using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SOUMCO.Class;


namespace SOUMCO.Forms
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
            GetProductType();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            
            txtName.Focus();
        }

        #region API Call

        private async System.Threading.Tasks.Task GetProductType()
        {
            List<ProductTypeInfo> productTypeInfo = new List<ProductTypeInfo>();
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(Common.Common.APIURL_PRODUCTTYPE_GETALL);
            var fileJsonString = await response.Content.ReadAsStringAsync();
            cmbProductType.DataSource = JsonConvert.DeserializeObject<ProductTypeInfo[]>(fileJsonString);
            cmbProductType.ValueMember = "productTypeId";
            cmbProductType.DisplayMember = "productTypeName";
        }

        private async System.Threading.Tasks.Task GetProductSizeBaseOnProductType(int ProductTypeId)
        {
            List<ProductSizeInfo> productTypeInfo = new List<ProductSizeInfo>();
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(Common.Common.APIURL_PRODUCTSIZE_GETALLBY_PRODUCTTYPE_ID + "?ProductTypeId=" + ProductTypeId.ToString());
            var fileJsonString = await response.Content.ReadAsStringAsync();
            cmbProductSize.DataSource = JsonConvert.DeserializeObject<ProductSizeInfo[]>(fileJsonString);
            cmbProductSize.ValueMember = "productSizeId";
            cmbProductSize.DisplayMember = "productSizeName";
        }

        #endregion

        private void cmbProductType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbProductType.SelectedValue) > 0)
            {
                GetProductSizeBaseOnProductType(Convert.ToInt32(cmbProductType.SelectedValue));
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (IsValidate())
            {
                SaveDataAPIAsync();
                this.Dispose();
            }
        }

        #region API Calls

        private async System.Threading.Tasks.Task GetProductType1()
        {
            List<ProductTypeInfo> productTypeInfo = new List<ProductTypeInfo>();
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(Common.Common.APIURL_PRODUCTTYPE_GETALL);
            var fileJsonString = await response.Content.ReadAsStringAsync();
            cmbProductType.DataSource = JsonConvert.DeserializeObject<ProductTypeInfo[]>(fileJsonString);
            cmbProductType.ValueMember = "productTypeId";
            cmbProductType.DisplayMember = "productTypeName";
        }

        private async System.Threading.Tasks.Task SaveDataAPIAsync()
        {
            ProductInfo productInfo = new ProductInfo();
            productInfo.productName = txtName.Text;
            productInfo.description = txtRemarks.Text;
            productInfo.productTypeId =(int) cmbProductType.SelectedValue;
            productInfo.productSizeId = (int)cmbProductSize.SelectedValue;
            productInfo.productId = Convert.ToInt32(lblId.Text);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Common.Common.APIURL_PRODUCT_SAVE);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
              
                HttpResponseMessage response = null;
                if (productInfo.productId == 0)
                {
                    response = await client.PostAsJsonAsync(Common.Common.APIURL_PRODUCT_SAVE, productInfo);
                }
                else
                {
                    response = await client.PostAsJsonAsync(Common.Common.APIURL_PRODUCT_MODIFY, productInfo);
                }
                if (response.IsSuccessStatusCode)
                {
                    int result = await response.Content.ReadAsAsync<int>();
                    if (result == -1)
                        MessageBox.Show("Record Save Successfully", "Inventory", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("An error has occurred");
                }
            }

        }
        #endregion


        private bool IsValidate()
        {
            ClsComm comm = new ClsComm();
            string itemName = string.Empty;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Item Name cannot be null or empty", "SOUMCO");
                txtName.Focus();
                return false;
            }
            if (lblId.Text == string.Empty)
            {
                itemName = comm.GetValue("ItemName", "Item", "ItemName='" + txtName.Text + "'");
                if (!string.IsNullOrEmpty(itemName))
                {
                    MessageBox.Show("Duplicate item name found", "SOUMCO");
                    txtName.Focus();
                    return false;
                }
            }
            return true;
        }

        public async void ProcFillForm(object Id)
        {

            ProductInfo objProductInfo = new ProductInfo();
            var client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(Common.Common.APIURL_PRODUCT_GETBY_ID + "?Id=" + Id.ToString());
            var fileJsonString = await response.Content.ReadAsStringAsync();
            // DataTable dtList = (DataTable)JsonConvert.DeserializeObject(fileJsonString, (typeof(DataTable)));
            objProductInfo = JsonConvert.DeserializeObject<ProductInfo>(fileJsonString);
            if (objProductInfo.productId > 0)
            {
                cmbProductType.SelectedValue = objProductInfo.productTypeId;
                cmbProductType_SelectionChangeCommitted(null, null);
                cmbProductSize.SelectedValue = objProductInfo.productSizeId;
                txtName.Text = objProductInfo.productName;
                txtRemarks.Text = objProductInfo.description;
                lblId.Text = objProductInfo.productId.ToString();
            }

            //DataTable DTFill = new DataTable();
            //ClsComm comm = new ClsComm();
            //DTFill = comm.FillTable("Select * from Item where ItemId=" + Id);
            //if (DTFill.Rows.Count > 0)
            //{
            //    lblId.Text = Id.ToString();
            //    txtName.Text = DTFill.Rows[0]["ItemName"].ToString();
            //    cmbProductType.SelectedValue = DTFill.Rows[0]["CategoryId"].ToString();
            //    cmbProductSize.SelectedValue = DTFill.Rows[0]["SubCategoryId"];
            //    //   txtRelatedTo.Text = DTFill.Rows[0]["ItemRelatedTo"].ToString();
            //}
            if (ClsComm.tUserRightToEdit != true)
            {
                btnOk.Enabled = false;
                btnSaveAndNew.Enabled = false;
                btnCancel.Enabled = false;
            }
            else
            {
                btnOk.Enabled = true;
                btnSaveAndNew.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void ProcClear()
        {
            lblId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            // txtRelatedTo.Text = string.Empty;
            txtName.Focus();
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            SaveDataAPIAsync();
            ProcClear();
        }

    }
}
