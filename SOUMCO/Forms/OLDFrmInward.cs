using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SOUMCO;
using SOUMCO.Class;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace SOUMCO.Forms
{
    public partial class OLDFrmInward : Form
    {
        string ProductCategory;
        double dTotalAmt = 0;
        private DataTable productDataTable;

        public OLDFrmInward()
        {
            InitializeComponent();
            ProcOpen();
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (GetLicense())
            {
                if (IsValidate())
                {
                    SaveData();
                    //{
                    //   // SaveDataGrid();
                    //    MessageBox.Show("Record save successfully", "SOUMCO", MessageBoxButtons.OK);
                    //    this.Dispose();
                    //}
                }
            }
            else
            {
                Application.Exit();
            }
            
        }

        private async void SaveData()
        {
            try
            {
                InwardInfo inwardInfo = new InwardInfo();
                inwardInfo.billDate = Convert.ToDateTime(dtpInvoiceDate.Value);
                inwardInfo.billNo = txtBillNo.Text.ToUpper();
                inwardInfo.supplierName = txtSupplierName.Text.ToUpper();
                inwardInfo.description = txtRemarks.Text.ToUpper();
                inwardInfo.inwardId= lblId.Text==""? 0: Convert.ToInt32(lblId.Text);
                List<InwardDetailForSP> listInwardDetail = new List<InwardDetailForSP>();
                foreach (DataGridViewRow item in dgInward.Rows)
                {
                    InwardDetailForSP inwardDetail = new InwardDetailForSP();
                    inwardDetail.ProductId = Convert.ToInt32(item.Cells[4].Value.ToString());
                    inwardDetail.InwardWidth = Convert.ToDecimal(item.Cells[6].Value.ToString());
                    inwardDetail.InwardLength = Convert.ToDecimal(item.Cells[7].Value.ToString());
                    inwardDetail.Quantity = Convert.ToInt32(item.Cells[8].Value.ToString());
                    inwardDetail.InwardDetailId= Convert.ToInt32(item.Cells[9].Value.ToString());
                    inwardDetail.InwardHeight = 0;
                    listInwardDetail.Add(inwardDetail);
                }
                inwardInfo.lstInwardDetailForSP = listInwardDetail;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Common.Common.APIURL_INWARD_SAVE);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.PostAsJsonAsync(Common.Common.APIURL_INWARD_SAVE, inwardInfo);

                    if (response.IsSuccessStatusCode)
                    {
                       // int result = await response.Content.ReadAsAsync<int>();
                        //if (result == -1)
                            MessageBox.Show("Record Save Successfully", "Inventory", MessageBoxButtons.OK);
                        //else
                         //   MessageBox.Show("An error has occurred");
                    }
                    else { MessageBox.Show("An error has occurred");
                    }
                }



                    //GetFileInformation("http://localhost:54211/api/v1/Inward/SaveInward", inwardInfo);
                }
            catch (Exception ex)
            {

                throw;
            }

            #region old SaveMethod
            //if (IsValidate())
            //{
            //    ClsComm comm = new ClsComm();
            //    //if (txtOtherAmt.Text == "") { txtOtherAmt.Text = "0.00"; }
            //    if (string.IsNullOrEmpty(lblId.Text))
            //    {
            //        //lblId.Text = txtInvoiceNo.Text;

            //        //comm.AddData("InwardEntry", null, lblId.Text + "," + CmbSupplier.SelectedValue + ",'" + txtBillNo.Text + "','" + dtpEntryDate.Value + "','" + txtInvoiceNo.Text + "','" + dtpInvoiceDate.Value + "'," + CmbSupplier.SelectedValue + "," + txtOtherAmt.Text + "," + txtTotalAmt.Text + ",'" + txtRemarks.Text + "'",true);
            //    }
            //    else
            //    {
            //        string strDID = comm.GetRowValuesOfColumns(dgInward, "dgDetailId");
            //        comm.DeleteData("InwardDetailEntry", "InwardId=" + lblId.Text + " and InwardDetailId not in (" + strDID + ")");
            //        //comm.EditData("InwardEntry", "SupplierId=" + CmbSupplier.SelectedValue + ",BillNo='" + txtBillNo.Text + "',EntryDate='" + dtpEntryDate.Value + "',InvoiceNo='" + txtInvoiceNo.Text + "',InvoiceDate='" + dtpInvoiceDate.Text + "',SupplierName=" + CmbSupplier.SelectedValue + ",OtherAmount=" + txtOtherAmt.Text + ", TotalBillAmount=" + txtTotalAmt.Text + ",Remarks='" + txtRemarks.Text + "'", "InwardId=" + lblId.Text,true);

            //    }

            //}

            #endregion

            
        }

        private Boolean GetLicense()
        {
            if (dtpInvoiceDate.Value > Convert.ToDateTime("13/08/2020").Date)
            {
                MessageBox.Show("License expired -- for continue please contact on 9227140054", "License Info");
                return false;
            }
            return true;
        }

        private bool SaveDataGrid()
        {
            int DID;
            int i = 0;
            ClsComm comm = new ClsComm();
            for (i = 0; i <= dgInward.Rows.Count - 2; i++)
            {
                if (dgInward["dgDetailId", i].Value == null)
                {
                    DID = comm.GetUniqueId("InwardDetailId", "InwardDetailEntry");
                    comm.AddData("InwardDetailEntry", null, DID + "," + lblId.Text + "," + dgInward["dgCategory", i].Value + "," + dgInward["dgItemName", i].Value +
                        ",'" + dgInward["dgDescription", i].Value + "','" + dgInward["dgDensity", i].Tag + "'," + dgInward["dgQty", i].Value + "," + dgInward["dgRate", i].Value + 
                        "," + dgInward["dgBottomRate", i].Value + ",'" + dgInward["dgItemName", i].FormattedValue + 
                        "'," + Convert.ToDouble(dgInward["dgKgs", i].Value) +
                        "," + Convert.ToDouble(dgInward["dgDiameter", i].Value) + "," + Convert.ToDouble(dgInward["dgThickness", i].Value) + 
                        "," + Convert.ToDouble(dgInward["dgWidth", i].Value) + "," + Convert.ToDouble(dgInward["dgLength", i].Value) + 
                        "," + Convert.ToDouble(dgInward["dgOD", i].Value) + "," + Convert.ToDouble(dgInward["dgID", i].Value) + 
                        "," + Convert.ToDouble(dgInward["dgSize", i].Value) + "," + Convert.ToDouble(dgInward["dgMeter", i].Value) + 
                        "," + Convert.ToDouble(dgInward["dgFormulatedKgs", i].Value) + "");
                    Double InwardQty = Convert.ToDouble(comm.GetValue("Sum(Qty)", "InwardDetailEntry", "ItemId=" + dgInward["dgItemName", i].Value));
                    //comm.EditData("Item", "InwardQty=" + InwardQty, "ItemId=" + dgInward["dgItemName", i].Value);
                }
                else
                {
                    comm.EditData("InwardDetailEntry", "InwardId=" + lblId.Text + ", CategoryId=" + dgInward["dgCategory", i].Value + ",ItemId=" + dgInward["dgItemName", i].Value +
                        ", Description='" + dgInward["dgDescription", i].Value + "', DensityValue='" + dgInward["dgDensity", i].Value + "', Qty=" + dgInward["dgQty", i].Value +
                        ", Rate=" + dgInward["dgRate", i].Value + ", BottomRate=" + dgInward["dgBottomRate", i].Value +
                        ", ItemName='" + dgInward["dgItemName", i].FormattedValue + "', ActualKG=" + Convert.ToDouble(dgInward["dgKgs", i].Value) +
                        ", Diameter=" + Convert.ToDouble(dgInward["dgDiameter", i].Value) + ", Thickness=" + Convert.ToDouble(dgInward["dgThickness", i].Value) +
                        ", Width=" + Convert.ToDouble(dgInward["dgWidth", i].Value) + ", Length=" + Convert.ToDouble(dgInward["dgLength", i].Value) +
                        ", OD=" + Convert.ToDouble(dgInward["dgOD", i].Value) + ", ID=" + Convert.ToDouble(dgInward["dgID", i].Value) +
                        ", [Size]=" + Convert.ToDouble(dgInward["dgSize", i].Value) + 
                        ", Meter=" + Convert.ToDouble(dgInward["dgMeter", i].Value) + 
                       ", FormulatedKG=" + Convert.ToDouble(dgInward["dgFormulatedKgs", i].Value)
                       , "InwardDetailId=" + dgInward["dgDetailId", i].Value);

                    Double InwardQty = Convert.ToDouble(comm.GetValue("Sum(Qty)", "InwardDetailEntry", "ItemId=" + dgInward["dgItemName", i].Value));
                    //comm.EditData("Item", "InwardQty=" + InwardQty, "ItemId=" + dgInward["dgItemName", i].Value);
 
                }
            }

            return true;
        }

        private bool IsValidate()
        {
            //if (Convert.ToInt32(CmbSupplier.SelectedValue)<0)
            //{
            //    MessageBox.Show("Select Supplier name", "SOUMCO");
            //    CmbSupplier.Focus();
            //    return false;
            //}

            if (txtBillNo.Text == "")
            {
                MessageBox.Show("Enter Invoice No ", "SOUMCO");
                txtBillNo.Focus();
                return false;
            }

            if (dgInward.Rows.Count == 0)
            {
                MessageBox.Show("Cannot save data without transaction", "SOUMCO");
                return false;
            }

           

            
                
                
          
            return true;
        }

        private void FrmInward_Load(object sender, EventArgs e)
        {
            ClsComm comm = new ClsComm();
            //if(string.IsNullOrEmpty(txtInvoiceNo.Text))
            //txtInvoiceNo.Text = comm.GetUniqueId("InwardID", "InwardEntry").ToString();
            
           
        }

        #region API Call

        private async System.Threading.Tasks.Task GetProductType()
        {
            List<ProductTypeInfo> productTypeInfo = new List<ProductTypeInfo>();
            var client = new HttpClient();
            DataTable Xtable = new DataTable();
            HttpResponseMessage response = await client.GetAsync(Common.Common.APIURL_PRODUCTTYPE_GETALL);
            var fileJsonString = await response.Content.ReadAsStringAsync();
           
            cmbProductType.Items.Insert(0, "<--Please select-->");
            cmbProductType.DataSource = JsonConvert.DeserializeObject<ProductTypeInfo[]>(fileJsonString);
            cmbProductType.ValueMember = "productTypeId";
            cmbProductType.DisplayMember = "productTypeName";
            
            
            ////if (AddNew == true)
            //{
                
            //    Xtable =(DataTable) cmbProductType.DataSource;
            //    DataRow DR = Xtable.NewRow();
            //    DataRow DR1 = Xtable.NewRow();
            //    DR[Xtable.Columns[1].ColumnName] = "--Select--";
            //    DR[Xtable.Columns[0].ColumnName] = "-1";
            //    Xtable.Rows.InsertAt(DR, 0);
            //    DR1[Xtable.Columns[1].ColumnName] = "------------------";
            //    DR1[Xtable.Columns[0].ColumnName] = "-2";
            //    Xtable.Rows.InsertAt(DR1, 1);

            //}

            //cmbProductType.DataSource = null;
            //cmbProductType.DisplayMember = null;
            //cmbProductType.ValueMember = null;
            //cmbProductType.DataBindings.Clear();


            //cmbProductType.DataSource = Xtable;
            //cmbProductType.DisplayMember = Xtable.Columns[1].ColumnName.ToString();
            //cmbProductType.ValueMember = Xtable.Columns[0].ColumnName.ToString();



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

        #endregion

        private void ProcOpen()
        {
            ClsComm Comm = new ClsComm();
            GetProductType();
            dgInward.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
            productDataTable.Columns.Add("InwardDetailId");
            productDataTable.Columns.Add("Edit");
            productDataTable.Columns.Add("Delete");
            lblDetailId.Text = string.Empty;
            lblRowIndex.Text = string.Empty;
        }

        public async void ProcFillForm(object Id)
        {
            InwardInfo ObjinwardInfo = new InwardInfo();
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(Common.Common.APIURL_INWARD_GETBY_ID + "?Id=" + Id.ToString());
            var fileJsonString = await response.Content.ReadAsStringAsync();
            // DataTable dtList = (DataTable)JsonConvert.DeserializeObject(fileJsonString, (typeof(DataTable)));
            ObjinwardInfo = JsonConvert.DeserializeObject<InwardInfo>(fileJsonString);
            if (ObjinwardInfo.inwardId > 0)
            {
                lblId.Text = ObjinwardInfo.inwardId.ToString();
                txtBillNo.Text = ObjinwardInfo.billNo;
                dtpInvoiceDate.Value = ObjinwardInfo.billDate;
                txtSupplierName.Text = ObjinwardInfo.supplierName;
                txtRemarks.Text = ObjinwardInfo.description;

            }

            foreach(var objDetail in ObjinwardInfo.lstInwardDetail)
            {
                productDataTable.Rows.Add(objDetail.productTypeId, objDetail.productTypeName, objDetail.productSizeId, objDetail.productSizeName, objDetail.productId, objDetail.productName, objDetail.width, objDetail.length, objDetail.quantity, objDetail.inwardDetailId, "Edit", "Delete");
                //dataGridView1.Columns.Clear();
                //dataGridView1.Columns.Add()
              
            }
            dgInward.DataSource = productDataTable;
            
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

        private void ProcClear()
        {
            ClsComm comm = new ClsComm();
            lblId.Text = string.Empty;
            //txtInvoiceNo.Text = string.Empty;
            dgInward.DataSource = null;
            txtBillNo.Text = string.Empty;
            txtRemarks.Text = string.Empty;
           // txtOtherAmt.Text = "0.00";
           // txtTotalAmt.Text = "0.00";
            dgInward.Rows.Clear();
            if (string.IsNullOrEmpty(txtBillNo.Text))
                //txtInvoiceNo.Text = comm.GetUniqueId("InwardID", "InwardEntry").ToString();
            txtSupplierName.Focus();
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            //if (SaveData())
            //{
            //    SaveDataGrid();
            //    ProcClear();
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ProcClear();
        }

        private void dgInward_Leave(object sender, EventArgs e)
        {
           // txtOtherAmt.Focus();
        }

        private void dgInward_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            ClsComm comm = new ClsComm();
            if (e.RowIndex <= dgInward.Rows.Count - 2)
            {
                if (e.ColumnIndex == 0)
                {
                    //dgInward.Columns["dgWidth"].Visible = false;
                    //dgInward.Columns["dgSize"].Visible = false;
                    //dgInward.Columns["dgOD"].Visible = false;
                    //dgInward.Columns["dgID"].Visible = false;
                    //dgInward.Columns["dgThickness"].Visible = false;
                    //dgInward.Columns["dgLength"].Visible = false;
                    //dgInward.Columns["dgMeter"].Visible = false;
                    //dgInward.Columns["dgDiameter"].Visible = false;

                    if (dgInward["dgCategory", e.RowIndex].Value != null)
                    {
                        //comm.GridBindCombo(dgItemName, false, "ItemId", "ItemName", "Item", "ItemName");
                     //   comm.GridBindCombo(dgItemName, false, "ItemId", "ItemName", "Select ItemId,ItemName from Item where CategoryId=" + dgInward["dgCategory", e.RowIndex].Value + " order by ItemName" );
                        
                    }
                    //if(dgInward["dgCategory", e.RowIndex].FormattedValue.ToString().ToUpper().Contains("ROD"))
                    //{

                    //    dgInward.Columns["dgDiameter"].Visible = true;
                    //    dgInward.Columns["dgLength"].Visible = true;

                    //}
                    //else if (dgInward["dgCategory", e.RowIndex].FormattedValue.ToString().ToUpper().Contains("BUSH"))
                    //{
                    //    dgInward.Columns["dgOD"].Visible = true;
                    //    dgInward.Columns["dgID"].Visible = true;
                    //    dgInward.Columns["dgLength"].Visible = true;

                    //}
                   
                }
                if(e.ColumnIndex==1)
                {
                    if (dgInward["dgItemName", e.RowIndex].Value != null)
                    {
                        dgInward["dgRate", e.RowIndex].Value = comm.GetValue("ItemRate", "Item", "ItemId=" + dgInward["dgItemName", e.RowIndex].Value.ToString());
                        dgInward["dgDensity", e.RowIndex].Value = comm.GetValue("DensityName", "Density", "DensityId in (Select DensityId from Item where ItemId=" + dgInward["dgItemName", e.RowIndex].Value.ToString() + ")");
                        dgInward["dgDensity", e.RowIndex].Tag = comm.GetValue("DensityValue", "Density", "DensityId in (Select DensityId from Item where ItemId=" + dgInward["dgItemName", e.RowIndex].Value.ToString() + ")");
                        dgInward["dgBottomRate", e.RowIndex].Value = dgInward["dgRate", e.RowIndex].Value;
                    }
                }
                if (e.ColumnIndex == 4)
                {
                    if (dgInward["dgQty", e.RowIndex].Value == null || Convert.ToDouble(dgInward["dgQty", e.RowIndex].Value) <= 0)
                    {
                        MessageBox.Show("Qty cannot be null or zero", "SOUMCO");
                    }
                    else
                    {
                        dgInward["dgTotalAmount", e.RowIndex].Value = Convert.ToDouble(dgInward["dgQty", e.RowIndex].Value) * Convert.ToDouble(dgInward["dgRate", e.RowIndex].Value);
                    }
                }
                if (e.ColumnIndex == 5)
                {
                    dgInward["dgTotalAmount", e.RowIndex].Value = Convert.ToDouble(dgInward["dgQty", e.RowIndex].Value) * Convert.ToDouble(dgInward["dgRate", e.RowIndex].Value);
                }

            }
            
        }
       
        private void dgInward_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {

            if (e.RowIndex <= dgInward.Rows.Count - 2)
            {
                if (dgInward["dgQty", e.RowIndex].Value == null || Convert.ToDouble(dgInward["dgQty", e.RowIndex].Value) <= 0)
                {
                    MessageBox.Show("Qty cannot be null or zero", "SOUMCO");
                    e.Cancel = true;
                }
                else
                {
                    dgSumOfTotalAmount();
                }
            }
        }
        
        private void dgSumOfTotalAmount()
        {
            dTotalAmt = 0;
            int i;
            for (i = 0; i < dgInward.Rows.Count - 1; i++)
            {
                dTotalAmt = dTotalAmt + Convert.ToDouble(dgInward["dgTotalAmount", i].Value);
            }
           
        }
        
        private void txtRemarks_Leave(object sender, EventArgs e)
        {
            dgInward.Select();
        }

        private void txtOtherAmt_Leave(object sender, EventArgs e)
        {
           
        }

        private void FrmInward_Activated(object sender, EventArgs e)
        {
          
        }

        private void dgInward_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            double dDebsity = 0, dOD = 0, dID = 0, dSize = 0, dwidth = 0, dthickness = 0, dkgs=0;
            int iQty =Convert.ToInt32(dgInward.Rows[e.RowIndex].Cells["dgQty"].Value);
            double ddia = Convert.ToDouble(dgInward.Rows[e.RowIndex].Cells["dgDiameter"].Value) / 2;
            double dlength = Convert.ToDouble(dgInward.Rows[e.RowIndex].Cells["dgLength"].Value);
            dOD = Convert.ToDouble(dgInward.Rows[e.RowIndex].Cells["dgOD"].Value)/2;
            dID = Convert.ToDouble(dgInward.Rows[e.RowIndex].Cells["dgID"].Value)/2;
            dthickness = Convert.ToDouble(dgInward.Rows[e.RowIndex].Cells["dgThickness"].Value);
            dwidth = Convert.ToDouble(dgInward.Rows[e.RowIndex].Cells["dgWidth"].Value);
            dkgs = Convert.ToDouble(dgInward.Rows[e.RowIndex].Cells["dgKgs"].Value); 
            //if (dgInward["dgDensity", e.RowIndex].Value != null)
            //{
            //    var strDensity = dgInward["dgDensity", e.RowIndex].Value.ToString().Split('-');
                
            //    if (Convert.ToDouble(strDensity[1]) > 0)
            //    {
            //        dDebsity = Convert.ToDouble(strDensity[1]);
            //    }
            //}

            dgInward.Rows[e.RowIndex].Cells["dgFormulatedKgs"].Value = CalculateKgs(Convert.ToString(dgInward.Rows[e.RowIndex].Cells["dgCategory"].FormattedValue).ToUpper(), qty: iQty, diameter: ddia,
                length: dlength, OD: dOD,ID: dID,width: dwidth, size:dSize, thickness: dthickness,
                density: Convert.ToDouble(dgInward.Rows[e.RowIndex].Cells["dgDensity"].Tag), kgs: dkgs).ToString(); //"F2"
       
        }

        private double CalculateKgs(string category, double qty=0, double diameter=0, double length=0, double OD=0, double ID=0,
            double width = 0, double thickness = 0, double size = 0,double density=0,double kgs=0)
        {
            double dTotalKgs = 0;
            double dTotalPerUnit = 0, dOD=0,dID=0;
            if (category == null) { category = string.Empty; }

            if (category.Contains("ROD"))
                category = "ROD";
            if (category.Contains("BUSH"))
                category = "BUSH";
            if (category.Contains("SHEET"))
                category = "SHEET";

            switch(category)
            {
                case "ROD":
                    dTotalPerUnit = (3.14 * diameter * diameter * length * density) / 1000000;
                    dTotalKgs = Math.Round(Convert.ToDouble(qty * dTotalPerUnit),3);
                    break;
                case "BUSH": case "PIPE":
                    dOD = Math.Round((3.14 * OD * OD * length * density) / 1000000,3);
                    dID = Math.Round((3.14 * ID * ID * length * density) / 1000000,3);
                    dTotalPerUnit =  dOD - dID;
                    dTotalKgs =Convert.ToDouble(qty * dTotalPerUnit);
                    break;
                case "SHEET":
                    dTotalPerUnit = Math.Round((thickness * length * width * density) / 1000000, 3);
                    dTotalKgs = Math.Round(Convert.ToDouble(qty * dTotalPerUnit),3);
                    break;
                default:
                    dTotalKgs = Math.Round(kgs,3);
                    break;

            }

            return dTotalKgs;
        }

        private async void cmbProductType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtWidth.Enabled = true;
            txtLength.Enabled = true;
            txtWidth.Text = "0.00";
            txtLength.Text = "0.00";
            if (Convert.ToInt32(cmbProductType.SelectedValue) > 0)
            {
                ProductCategory = ((ProductTypeInfo)cmbProductType.SelectedItem).productTypeName.ToUpper();
                if(ProductCategory.Contains("ROD") || ProductCategory.Contains("BUSH"))
                {
                    txtWidth.Text = "0.00";
                    txtWidth.Enabled = false;
                }
                else if(ProductCategory.Contains("ARTICLE"))
                {
                    txtWidth.Text = "0.00";
                    txtLength.Text = "0.00";
                    txtWidth.Enabled = false;
                    txtLength.Enabled = false;
                }
                await GetProductSizeBaseOnProductType(Convert.ToInt32(cmbProductType.SelectedValue));
            }
        }

        private async  void cmbProductSize_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbProductType.SelectedValue) > 0)
            {
               await GetProductBaseOnProductTypeAndSize(Convert.ToInt32(cmbProductType.SelectedValue), Convert.ToInt32(cmbProductSize.SelectedValue));
            }
        }

        private async void cmbProductSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cmbProductType.SelectedValue) > 0 && cmbProductSize.SelectedValue!=null)
                {
                    await GetProductBaseOnProductTypeAndSize(Convert.ToInt32(cmbProductType.SelectedValue), Convert.ToInt32(cmbProductSize.SelectedValue));
                }
            }
            catch (Exception)
            {

                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (lblRowIndex.Text != string.Empty && btnAdd.Text=="Edit")
            {
                dgInward[0, Convert.ToInt32(lblRowIndex.Text)].Value = cmbProductType.SelectedValue;
                dgInward[1, Convert.ToInt32(lblRowIndex.Text)].Value = cmbProductType.GetItemText(this.cmbProductType.SelectedItem);
                dgInward[2, Convert.ToInt32(lblRowIndex.Text)].Value = cmbProductSize.SelectedValue;
                dgInward[3, Convert.ToInt32(lblRowIndex.Text)].Value = cmbProductSize.GetItemText(this.cmbProductSize.SelectedItem);
                dgInward[4, Convert.ToInt32(lblRowIndex.Text)].Value = cmbProduct.SelectedValue;
                dgInward[5, Convert.ToInt32(lblRowIndex.Text)].Value = cmbProduct.GetItemText(this.cmbProduct.SelectedItem);
                dgInward[6, Convert.ToInt32(lblRowIndex.Text)].Value = txtWidth.Text;
                dgInward[7, Convert.ToInt32(lblRowIndex.Text)].Value = txtLength.Text;
                dgInward[8, Convert.ToInt32(lblRowIndex.Text)].Value = txtQuantity.Text;
                dgInward[9, Convert.ToInt32(lblRowIndex.Text)].Value = lblDetailId.Text;
                btnAdd.Text = "Add";
                dgInward.RefreshEdit();
            }
            else
            {
                productDataTable.Rows.Add(cmbProductType.SelectedValue, cmbProductType.GetItemText(this.cmbProductType.SelectedItem), cmbProductSize.SelectedValue, cmbProductSize.GetItemText(this.cmbProductSize.SelectedItem), cmbProduct.SelectedValue, cmbProduct.GetItemText(this.cmbProduct.SelectedItem), txtWidth.Text, txtLength.Text, txtQuantity.Text, 0, "Edit", "Delete");
                //dataGridView1.Columns.Clear();
                //dataGridView1.Columns.Add()
                dgInward.DataSource = productDataTable;
            }
            clearControl();
        }

        private void dgInward_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private DataGridViewCellStyle GetHyperLinkStyleForGridCell()
        {
            // Set the Font and Uderline into the Content of the grid cell .  
            {
                DataGridViewCellStyle l_objDGVCS = new DataGridViewCellStyle();
                System.Drawing.Font l_objFont = new System.Drawing.Font(FontFamily.GenericSansSerif, 8, FontStyle.Underline);
                l_objDGVCS.Font = l_objFont;
                l_objDGVCS.ForeColor = Color.Blue;

                return l_objDGVCS;
            }
        }

        private void clearControl()
        {
            cmbProduct.SelectedIndex = 0;
            txtWidth.Text = string.Empty;
            txtLength.Text = string.Empty;
            txtQuantity.Text = string.Empty;
        }

        private void dgInward_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgInward.Columns["ProductTypeId"].Visible = false;
            dgInward.Columns["ProductSizeId"].Visible = false;
            dgInward.Columns["ProductId"].Visible = false;
            dgInward.Columns["InwardDetailId"].Visible = false;
            foreach (DataGridViewRow r in dgInward.Rows)
            {

                if (dgInward.Columns.Contains("Edit"))
                {
                    dgInward.Columns["Edit"].DefaultCellStyle = GetHyperLinkStyleForGridCell();
                }
                if (dgInward.Columns.Contains("Delete"))
                {
                    dgInward.Columns["Delete"].DefaultCellStyle = GetHyperLinkStyleForGridCell();
                }

            }
        }

        private void dgInward_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgInward[e.ColumnIndex, e.RowIndex].Value.ToString() == "Edit")
                {
                    cmbProductType.SelectedValue = Convert.ToInt32(dgInward[0, e.RowIndex].Value);
                   // cmbProductType_SelectionChangeCommitted(null, null);
                    cmbProductSize.SelectedIndex = -1;
                    cmbProductSize.SelectedValue = Convert.ToInt32(dgInward[2, e.RowIndex].Value);
                   // cmbProductSize_SelectionChangeCommitted(null, null);

                    cmbProduct.SelectedValue = Convert.ToInt32(dgInward[4, e.RowIndex].Value);
                    if (cmbProduct.SelectedValue == null)
                    {
                       // cmbProductSize_SelectionChangeCommitted(null, null);
                        cmbProduct.SelectedValue = Convert.ToInt32(dgInward[4, e.RowIndex].Value);
                    }
                    txtWidth.Text = dgInward[6, e.RowIndex].Value.ToString();
                    txtLength.Text = dgInward[7, e.RowIndex].Value.ToString();
                    txtQuantity.Text = dgInward[8, e.RowIndex].Value.ToString();
                    lblDetailId.Text = dgInward[9, e.RowIndex].Value.ToString();
                    lblRowIndex.Text = e.RowIndex.ToString();
                    btnAdd.Text = "Edit";
                }

            }
            catch (Exception)
            {

                throw;
            } 
            //inwardDetail.ProductId = Convert.ToInt32(item.Cells[4].Value.ToString());
            //inwardDetail.InwardWidth = Convert.ToDecimal(item.Cells[6].Value.ToString());
            //inwardDetail.InwardLength = Convert.ToDecimal(item.Cells[7].Value.ToString());
            //inwardDetail.Quantity = Convert.ToInt32(item.Cells[8].Value.ToString());
            //inwardDetail.InwardHeight = 0;

            //MessageBox.Show(this.dgInward[e.ColumnIndex, e.RowIndex].Value.ToString());
        }

        private async void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtWidth.Enabled = true;
                txtLength.Enabled = true;
                txtWidth.Text = "0.00";
                txtLength.Text = "0.00";
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
                    await GetProductSizeBaseOnProductType(Convert.ToInt32(cmbProductType.SelectedValue));
                }
            }
            catch (Exception)
            {

                
            }
        }
    }
}