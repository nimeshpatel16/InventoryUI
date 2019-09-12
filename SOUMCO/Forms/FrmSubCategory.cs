using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using SOUMCO.Class;

namespace SOUMCO.Forms
{
    public partial class FrmSubCategory : Form
    {
        public FrmSubCategory()
        {
            InitializeComponent();
            GetProductType();
        }

        private void FrmSubCategory_Load(object sender, EventArgs e)
        {
            
            txtSubCategoryName.Focus();


        }



        #region UserEvent

        private void SaveData()
        {
            ClsComm comm = new ClsComm();
           // if (IsValidate())
            {
                if (string.IsNullOrEmpty(lblId.Text))
                {
                    lblId.Text = comm.GetUniqueId("SubCategoryId", "SubCategory").ToString();
                    comm.AddData("SubCategory", null, lblId.Text + ",'" + txtSubCategoryName.Text + "','" + txtRemarks.Text + "'", true);
                    MessageBox.Show("Record Save Successfully", "SOUMCO", MessageBoxButtons.OK);
                }
                else
                {
                    comm.EditData("SubCategory", "SubCategoryName='" + txtSubCategoryName.Text + "',Description='" + txtRemarks.Text + "'", "SubCategoryId=" + lblId.Text, true);
                    MessageBox.Show("Record Update successfully", "SOUMCO", MessageBoxButtons.OK);
                }
            }
        }

        private bool IsValidate()
        {
            ClsComm comm = new ClsComm();
            string CategoryName = string.Empty;
            if (string.IsNullOrEmpty(txtSubCategoryName.Text))
            {
                MessageBox.Show("SubCategory cannot be null or empty", "SOUMCO");
                txtSubCategoryName.Focus();
                return false;
            }
            if (lblId.Text != string.Empty)
            {
                CategoryName = comm.GetValue("SubCategoryName", "SubCategory", "SubCategoryName='" + txtSubCategoryName.Text + "' and SubCategoryId not in (" + lblId.Text + ")");
                if (!string.IsNullOrEmpty(CategoryName))
                {
                    MessageBox.Show("Duplicate Sub Category found", "SOUMCO");
                    txtSubCategoryName.Focus();
                    return false;
                }
            }
            else
            {
                CategoryName = comm.GetValue("SubCategoryName", "SubCategory", "SubCategoryName='" + txtSubCategoryName.Text + "'");
                if (!string.IsNullOrEmpty(CategoryName))
                {
                    MessageBox.Show("Duplicate Sub Category found", "SOUMCO");
                    txtSubCategoryName.Focus();
                    return false;
                }
            }
            return true;
        }

        public async void ProcFillForm(object Id)
        {

            ProductSizeInfo objProductInfo = new ProductSizeInfo();
            var client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(Common.Common.APIURL_PRODUCTSIZE_GETBY_ID + "?Id=" + Id.ToString());
            var fileJsonString = await response.Content.ReadAsStringAsync();
            // DataTable dtList = (DataTable)JsonConvert.DeserializeObject(fileJsonString, (typeof(DataTable)));
            objProductInfo = JsonConvert.DeserializeObject<ProductSizeInfo>(fileJsonString);
            if (objProductInfo.productSizeId > 0)
            {
                txtSubCategoryName.Text = objProductInfo.productSizeName;
                txtRemarks.Text = objProductInfo.productSizedescription;
                cmbProductType.SelectedValue = objProductInfo.productTypeId;
                lblId.Text = objProductInfo.productSizeId.ToString();
            }
            //DataTable DTFill = new DataTable();
            //ClsComm comm = new ClsComm();
            //DTFill = comm.FillTable("Select SubCategoryId,SubCategoryName,Description from SubCategory where SubCategoryId=" + Id);
            //if (DTFill.Rows.Count > 0)
            //{
            //    lblId.Text = Id.ToString();
            //    txtSubCategoryName.Text = DTFill.Rows[0]["SubCategoryName"].ToString();
            //    txtRemarks.Text = DTFill.Rows[0]["Description"].ToString();

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
            lblId.Text = string.Empty;
            txtSubCategoryName.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            txtSubCategoryName.Focus();
        }


        #endregion

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                SaveDataAPIAsync();
                ProcClear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ProcClear();
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

        private async System.Threading.Tasks.Task SaveDataAPIAsync()
        {
            ProductSizeInfo productSizeInfo = new ProductSizeInfo();
            productSizeInfo.productSizeName = txtSubCategoryName.Text;
            productSizeInfo.productSizedescription = txtRemarks.Text;
            productSizeInfo.productTypeId = (int) cmbProductType.SelectedValue;
            productSizeInfo.productSizeId = lblId.Text == "" ? 0 : Convert.ToInt32(lblId.Text);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Common.Common.APIURL_PRODUCTSIZE_SAVE);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = null;
                if (productSizeInfo.productSizeId == 0)
                {
                    response = await client.PostAsJsonAsync(Common.Common.APIURL_PRODUCTSIZE_SAVE, productSizeInfo);
                }
                else
                {
                    response = await client.PostAsJsonAsync(Common.Common.APIURL_PRODUCTSIZE_MODIFY, productSizeInfo);
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
    }
}
