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
                outwardInfo.invoiceNo = txtBillNo.Text;
                outwardInfo.partyName = txtSupplierName.Text;
                outwardInfo.description = txtRemarks.Text;
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
                        outwardDetail.quantity = Convert.ToInt32(item.Cells[7].Value.ToString());
                        outwardDetail.heigth = 0;

                        listOutwardDetail.Add(outwardDetail);
                    }
                }
                outwardInfo.lstOutwardDetail = listOutwardDetail;

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
            productDataTable.Columns.Add("Edit");
            productDataTable.Columns.Add("Delete");
        }

        private bool IsValidate()
        {
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

        private async void cmbProductType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbProductType.SelectedValue) > 0)
            {
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
            GetAvailableQty();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                SaveData();
             
            }
        }
    }
}
