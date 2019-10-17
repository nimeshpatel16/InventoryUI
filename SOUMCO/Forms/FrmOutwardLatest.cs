using Newtonsoft.Json;
using SOUMCO.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;


namespace SOUMCO.Forms
{
    public partial class FrmOutwardLatest : Form
    {
        DataTable productDataTable;
        DataTable InwardproductDataTable;

        public FrmOutwardLatest()
        {
            InitializeComponent();
            ProcOpen();
        }

        private void FrmOutwardLatest_Load(object sender, EventArgs e)
        {

        }

        #region API Call

        private async System.Threading.Tasks.Task GetProductType()
        {
            List<ProductTypeInfo> productTypeInfo = new List<ProductTypeInfo>();
            var client = new HttpClient();
            
            HttpResponseMessage response = await client.GetAsync(Common.Common.APIURL_PRODUCTTYPE_GETALL);
            var fileJsonString = await response.Content.ReadAsStringAsync();

            //cmbProductType.Items.Insert(0, "<--Please select-->");
            cmbProductType.DataSource = JsonConvert.DeserializeObject<ProductTypeInfo[]>(fileJsonString);
            cmbProductType.ValueMember = "productTypeId";
            cmbProductType.DisplayMember = "productTypeName";
            
        }

        private async System.Threading.Tasks.Task GetProductSizeBaseOnProductType(int ProductTypeId)
        {
            List<ProductSizeInfo> productInfo = new List<ProductSizeInfo>();
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(Common.Common.APIURL_PRODUCTSIZE_GETALLBY_PRODUCTTYPE_ID + "?ProductTypeId=" + ProductTypeId.ToString());
            var fileJsonString = await response.Content.ReadAsStringAsync();
            cmbProductSize.DataSource = JsonConvert.DeserializeObject<ProductSizeInfo[]>(fileJsonString);
            cmbProductSize.ValueMember = "productSizeId";
            cmbProductSize.DisplayMember = "productSizeName";

        }

        private async System.Threading.Tasks.Task GetProductBaseOnProductTypeAndSize(int ProductTypeId, int ProductSizeId)
        {
            List<ProductInfo> productInfo = new List<ProductInfo>();
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(Common.Common.APIURL_PRODUCT_GETBY_PRODUCT_TYPE_AND_SIZE + "?ProductTypeId=" + ProductTypeId.ToString() + "&ProductSizeId=" + ProductSizeId.ToString());
            var fileJsonString = await response.Content.ReadAsStringAsync();
            cmbProduct.DataSource = JsonConvert.DeserializeObject<ProductInfo[]>(fileJsonString);
            cmbProduct.ValueMember = "productId";
            cmbProduct.DisplayMember = "productName";
        }

        private async void GetAvailableQty()
        {
            try
            {
                OutwardGetAvailableQuantity outwardGetAvailableQuantity = new OutwardGetAvailableQuantity();
                outwardGetAvailableQuantity.productId = Convert.ToInt32(cmbProduct.SelectedValue);
                outwardGetAvailableQuantity.type = ((ProductTypeInfo)cmbProductType.SelectedItem).productTypeName.ToUpper();
                outwardGetAvailableQuantity.length = Convert.ToDecimal(txtLength.Text);
                outwardGetAvailableQuantity.width =Convert.ToDecimal(txtWidth.Text);
                outwardGetAvailableQuantity.quantity = Convert.ToInt32(txtQuantity.Text);

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Common.Common.APIURL_OUTWARD_GET_AVAILABLE_QTY);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.PostAsJsonAsync(Common.Common.APIURL_OUTWARD_GET_AVAILABLE_QTY, outwardGetAvailableQuantity);
                    var fileJsonString = await response.Content.ReadAsStringAsync();
                    dgInward.DataSource = JsonConvert.DeserializeObject<OutwardResultAvailableQuantity[]>(fileJsonString);
                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("An error has occurred");
                    }
                    dgInward.Columns[1].Visible = false;
                    dgInward.Columns[2].Visible = false;
                    dgInward.Columns[4].Visible = false;
                    dgInward.Columns[5].Visible = false;
                }



                //GetFileInformation("http://localhost:54211/api/v1/Inward/SaveInward", inwardInfo);
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private async void SaveData()
        {
            try
            {
                OutwardInfo outwardInfo = new OutwardInfo();
                outwardInfo.invoiceDate = Convert.ToDateTime(dtpInvoiceDate.Value);
                outwardInfo.invoiceNo = txtBillNo.Text.ToUpper();
                outwardInfo.partyName = txtSupplierName.Text.ToUpper();
                outwardInfo.description = txtRemarks.Text.ToUpper();
                outwardInfo.outwardId = lblId.Text == "" ? 0 : Convert.ToInt32(lblId.Text);
                List<OutwardDetail> listOutwardDetail = new List<OutwardDetail>();
                foreach (DataGridViewRow item in dgInward.Rows)
                {
                    if (Convert.ToBoolean(item.Cells["dgcSelect"].Value))
                    {
                        OutwardDetail outwardDetail = new OutwardDetail();
                        outwardDetail.productId = Convert.ToInt32(item.Cells[2].Value.ToString());
                        outwardDetail.productLedgerId = Convert.ToInt32(item.Cells[1].Value.ToString());
                        outwardDetail.length = Convert.ToDecimal(txtLength.Text);  //Convert.ToDecimal(item.Cells[5].Value.ToString());
                        outwardDetail.width = Convert.ToDecimal(txtWidth.Text);  //Convert.ToDecimal(item.Cells[6].Value.ToString());
                        outwardDetail.quantity = Convert.ToInt32(item.Cells[8].Value.ToString());
                        outwardDetail.heigth = 0;

                        listOutwardDetail.Add(outwardDetail);
                    }
                }
                outwardInfo.lstOutwardDetail = listOutwardDetail;
                List<InwardOfOutwardSheet> lstInwardOfOutwardSheet = new List<InwardOfOutwardSheet>();
                foreach (DataGridViewRow item in dgInwardForSheet.Rows)
                {
                    if (item.Cells[0].Value != null)
                    {
                        InwardOfOutwardSheet inwardOfOutwardSheet = new InwardOfOutwardSheet();
                        inwardOfOutwardSheet.productId = Convert.ToInt32(cmbProduct.SelectedValue);
                        inwardOfOutwardSheet.length = Convert.ToDecimal(item.Cells[0].Value.ToString());
                        inwardOfOutwardSheet.width = Convert.ToDecimal(item.Cells[1].Value.ToString());
                        inwardOfOutwardSheet.quantity = Convert.ToInt32(item.Cells[2].Value.ToString());
                        lstInwardOfOutwardSheet.Add(inwardOfOutwardSheet);
                    }
                }

                outwardInfo.lstInwardOfOutwardSheet = lstInwardOfOutwardSheet;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Common.Common.APIURL_OUTWARD_SAVE);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.PostAsJsonAsync(Common.Common.APIURL_OUTWARD_SAVE, outwardInfo);

                    if (response.IsSuccessStatusCode)
                    {
                        // int result = await response.Content.ReadAsAsync<int>();
                        //if (result == -1)
                        MessageBox.Show("Record Save Successfully", "Inventory", MessageBoxButtons.OK);
                        //else
                        //   MessageBox.Show("An error has occurred");
                    }
                    else
                    {
                        MessageBox.Show("An error has occurred");
                    }
                }



                //GetFileInformation("http://localhost:54211/api/v1/Inward/SaveInward", inwardInfo);
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        #endregion

        public async void ProcFillForm(object Id)
        {
            OutwardInfo ObjinwardInfo = new OutwardInfo();
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(Common.Common.APIURL_OUTWARD_GETBY_ID + "?Id=" + Id.ToString());
            var fileJsonString = await response.Content.ReadAsStringAsync();
            // DataTable dtList = (DataTable)JsonConvert.DeserializeObject(fileJsonString, (typeof(DataTable)));
            ObjinwardInfo = JsonConvert.DeserializeObject<OutwardInfo>(fileJsonString);
            if (ObjinwardInfo.outwardId > 0)
            {
                lblId.Text = ObjinwardInfo.outwardId.ToString();
                txtBillNo.Text = ObjinwardInfo.invoiceNo;
                dtpInvoiceDate.Value = ObjinwardInfo.invoiceDate;
                txtSupplierName.Text = ObjinwardInfo.partyName;
                txtRemarks.Text = ObjinwardInfo.description;

            }

            //foreach (var objDetail in ObjinwardInfo.lstOutwardDetail)
            //{
            //    productDataTable.Rows.Add(objDetail.productTypeId, objDetail.productTypeName, objDetail.productSizeId, objDetail.productSizeName, objDetail.productId, objDetail.productName, objDetail.width, objDetail.length, objDetail.quantity, objDetail.inwardDetailId, "Edit", "Delete");
            //    //dataGridView1.Columns.Clear();
            //    //dataGridView1.Columns.Add()

            //}
            dgInward.DataSource = ObjinwardInfo.lstOutwardDetail;
            dgInward.Columns[0].Visible = false;
            dgInward.Columns[1].Visible = false;
            dgInward.Columns[2].Visible = false;
            dgInward.Columns[3].Visible = false;
            dgInward.Columns[5].Visible = false;
            dgInward.Columns[7].Visible = false;
            dgInward.Columns[10].Visible = false;
            dgInward.Columns[13].Visible = false;


            //DataTable DTFill = new DataTable();
            //ClsComm comm = new ClsComm();
            //DTFill = comm.FillTable("Select * from InwardEntry where InwardId=" + Id);
            //if (DTFill.Rows.Count > 0)
            //{
            //    lblId.Text = Id.ToString();
            //    StrSupplierId = DTFill.Rows[0]["SupplierId"].ToString();
            //    txtBillNo.Text = DTFill.Rows[0]["BillNo"].ToString();
            // //   txtInvoiceNo.Text = DTFill.Rows[0]["InvoiceNo"].ToString();
            //   // cmbCompany.Text = DTFill.Rows[0]["CompanyName"].ToString();
            //  //  dtpEntryDate.Value = Convert.ToDateTime(DTFill.Rows[0]["EntryDate"]);
            //    dtpInvoiceDate.Value = Convert.ToDateTime(DTFill.Rows[0]["InvoiceDate"]);
            //    //cmbCompany.SelectedText=DTFill.Rows[0]["CompanyName"].ToString();
            //    //txtOtherAmt.Text = DTFill.Rows[0]["OtherAmount"].ToString();
            //    //txtTotalAmt.Text = DTFill.Rows[0]["TotalBillAmount"].ToString();
            //    txtRemarks.Text = DTFill.Rows[0]["Remarks"].ToString();
            //}

            //DataTable DT = new DataTable();
            //DT = comm.FillTable("Select * from InwardDetailEntry where InwardId=" + Id);
            //int i = 0;
            //for (i = 0; i <= DT.Rows.Count - 1; i++)
            //{

            //    dgInward.Rows.Add();
            //   // comm.GridBindCombo(dgItemName, false, "ItemId", "ItemName", "Select ItemId,ItemName from Item where CategoryId=" + DT.Rows[i]["CategoryId"] + " order by ItemName");
            //    dgInward["dgDetailId", i].Value = DT.Rows[i]["InwardDetailId"].ToString();
            //    dgInward["dgCategory", i].Value = DT.Rows[i]["CategoryId"];
            //    dgInward["dgItemName", i].Value = DT.Rows[i]["ItemId"];
            //    dgInward["dgDescription", i].Value = DT.Rows[i]["Description"].ToString();
            //    dgInward["dgDensity", i].Value = DT.Rows[i]["DensityValue"].ToString();
            //    dgInward["dgQty", i].Value = DT.Rows[i]["Qty"].ToString();
            //    dgInward["dgRate", i].Value = DT.Rows[i]["Rate"].ToString();
            //    dgInward["dgTotalAmount", i].Value =Convert.ToString(Convert.ToDouble(dgInward["dgQty", i].Value) * Convert.ToDouble(dgInward["dgRate", i].Value));
            //    dgInward["dgBottomRate", i].Value = DT.Rows[i]["BottomRate"].ToString();
            //    dgInward["dgKgs", i].Value = DT.Rows[i]["ActualKG"].ToString();
            //    dgInward["dgDiameter", i].Value = DT.Rows[i]["Diameter"].ToString();
            //    dgInward["dgThickness", i].Value = DT.Rows[i]["Thickness"].ToString();
            //    dgInward["dgWidth", i].Value = DT.Rows[i]["Width"].ToString();
            //    dgInward["dgLength", i].Value = DT.Rows[i]["Length"].ToString();
            //    dgInward["dgOD", i].Value = DT.Rows[i]["OD"].ToString();
            //    dgInward["dgID", i].Value = DT.Rows[i]["ID"].ToString();
            //    dgInward["dgSize", i].Value = DT.Rows[i]["Size"].ToString();
            //    dgInward["dgMeter", i].Value = DT.Rows[i]["Meter"].ToString();
            //    dgInward["dgFormulatedKgs", i].Value = DT.Rows[i]["FormulatedKG"].ToString();

            //}
            //if (ClsComm.tUserRightToEdit != true)
            //{
            //    btnOk.Enabled = false;
            //    btnSaveAndNew.Enabled = false;
            //    btnCancel.Enabled = false;
            //}
            //else
            //{
            //    btnOk.Enabled = true;
            //    btnSaveAndNew.Enabled = true;
            //    btnCancel.Enabled = true;
            //}

        }


        private void ProcOpen()
        {
            ClsComm Comm = new ClsComm();
            GetProductType();
            dgInward.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblInwardEntry.Visible = false;
            pnlInward.Visible = false;
            productDataTable = new DataTable();
            productDataTable.Columns.Add("ProductTypeId");
            productDataTable.Columns.Add("Product Type");
            productDataTable.Columns.Add("ProductSizeId");
            productDataTable.Columns.Add("Product Size");
            productDataTable.Columns.Add("ProductId");
            productDataTable.Columns.Add("Product");
            productDataTable.Columns.Add("Width");
            productDataTable.Columns.Add("Length");
            productDataTable.Columns.Add("Quantity");
            productDataTable.Columns.Add("Edit");
            productDataTable.Columns.Add("Delete");

            InwardproductDataTable = new DataTable();
            InwardproductDataTable.Columns.Add("ProductId");
            InwardproductDataTable.Columns.Add("Width");
            InwardproductDataTable.Columns.Add("Length");
            InwardproductDataTable.Columns.Add("Quantity");

        }

        private bool IsValidate()
        {
            int iQuantityToUsed=0;
            bool isCheckedSelected = false;

            if (txtBillNo.Text == "")
            {
                MessageBox.Show("Enter Invoice No ", "Inventory");
                txtBillNo.Focus();
                return false;
            }

            if (dgInward.Rows.Count == 0)
            {
                MessageBox.Show("Cannot save data without transaction", "Inventory");
                return false;
            }
            foreach (DataGridViewRow item in dgInward.Rows)
            {
                if (Convert.ToBoolean(item.Cells["dgcSelect"].Value))
                {
                    iQuantityToUsed = Convert.ToInt32(item.Cells[8].Value.ToString()) + iQuantityToUsed;
                    isCheckedSelected = true;
                }
            }
            if(iQuantityToUsed>0 && iQuantityToUsed!=Convert.ToInt32(txtQuantity.Text))
            {
                MessageBox.Show("Used quantity and enter quantity should be same", "Inventory");
                return false;
            }
            if(!isCheckedSelected)
            {
                MessageBox.Show("Select atleast one product from list", "Inventory");
                return false;
            }

                    return true;
        }

        private async void cmbProductType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string ProductCategory;
            if (Convert.ToInt32(cmbProductType.SelectedValue) > 0)
            {
                txtWidth.Enabled = true;
                txtLength.Enabled = true;
                txtWidth.Text = "0.00";
                txtLength.Text = "0.00";
                lblInwardEntry.Visible = false;
                pnlInward.Visible = false;
                if (Convert.ToInt32(cmbProductType.SelectedValue) > 0)
                {
                    ProductCategory = ((ProductTypeInfo)cmbProductType.SelectedItem).productTypeName.ToUpper();
                    if (ProductCategory.Contains("ROD") || ProductCategory.Contains("BUSH"))
                    {
                        txtWidth.Text = "0.00";
                        txtWidth.Enabled = false;
                    }
                    else if (ProductCategory.Contains("ARTICLE"))
                    {
                        txtWidth.Text = "0.00";
                        txtLength.Text = "0.00";
                        txtWidth.Enabled = false;
                        txtLength.Enabled = false;
                    }
                    else if(ProductCategory.Contains("SHEET"))
                    {
                        lblInwardEntry.Visible = true;
                        pnlInward.Visible = true;
                    }
                }

                    await GetProductSizeBaseOnProductType(Convert.ToInt32(cmbProductType.SelectedValue));
            }
        }

        private async void cmbProductSize_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbProductSize.SelectedValue) > 0)
            {
                await GetProductBaseOnProductTypeAndSize(Convert.ToInt32(cmbProductType.SelectedValue), Convert.ToInt32(cmbProductSize.SelectedValue));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuantity.Text))
            {
                GetAvailableQty();
            }
            else
            {
                MessageBox.Show("Enter Quantity");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                SaveData();
             
            }
        }

        private void lblInwardEntry_Click(object sender, EventArgs e)
        {

        }

        private async void cmbProductSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cmbProductSize.SelectedValue) > 0)
                {
                    await GetProductBaseOnProductTypeAndSize(Convert.ToInt32(cmbProductType.SelectedValue), Convert.ToInt32(cmbProductSize.SelectedValue));
                }
            }
            catch (Exception)
            {

                
            }
        }

        private async void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string ProductCategory;
                if (Convert.ToInt32(cmbProductType.SelectedValue) > 0)
                {
                    txtWidth.Enabled = true;
                    txtLength.Enabled = true;
                    txtWidth.Text = "0.00";
                    txtLength.Text = "0.00";
                    lblInwardEntry.Visible = false;
                    pnlInward.Visible = false;
                    if (Convert.ToInt32(cmbProductType.SelectedValue) > 0)
                    {
                        ProductCategory = ((ProductTypeInfo)cmbProductType.SelectedItem).productTypeName.ToUpper();
                        if (ProductCategory.Contains("ROD") || ProductCategory.Contains("BUSH"))
                        {
                            txtWidth.Text = "0.00";
                            txtWidth.Enabled = false;
                        }
                        else if (ProductCategory.Contains("ARTICLE"))
                        {
                            txtWidth.Text = "0.00";
                            txtLength.Text = "0.00";
                            txtWidth.Enabled = false;
                            txtLength.Enabled = false;
                        }
                        else if (ProductCategory.Contains("SHEET"))
                        {
                            lblInwardEntry.Visible = true;
                            pnlInward.Visible = true;
                        }
                    }

                    await GetProductSizeBaseOnProductType(Convert.ToInt32(cmbProductType.SelectedValue));
                }
            }
            catch (Exception)
            {

               
            }

        }
    }
}
