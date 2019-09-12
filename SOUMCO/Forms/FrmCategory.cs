using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using SOUMCO;
using System.Net.Http;
using System.Net.Http.Headers;
using SOUMCO.Class;
using SOUMCO.Common;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SOUMCO.Forms
{
    public partial class FrmCategory : Form
    {
        //OleDbConnection conn = new OleDbConnection();
        //OleDbCommand cmd = new OleDbCommand();
        
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //if (IsValidate())
            {
                SaveDataAPIAsync();
                this.Dispose();
            }
        }

        private async System.Threading.Tasks.Task SaveDataAPIAsync()
        {
            ProductTypeInfo productTypeInfo = new ProductTypeInfo();
            productTypeInfo.productTypeName = txtCategoryName.Text;
            productTypeInfo.description = txtRemarks.Text;
            productTypeInfo.productTypeId = lblId.Text == "" ? 0 : Convert.ToInt32(lblId.Text);
           
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Common.Common.APIURL_PRODUCTTYPE_SAVE);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = null;
                if (productTypeInfo.productTypeId==0)
                {
                     response = await client.PostAsJsonAsync(Common.Common.APIURL_PRODUCTTYPE_SAVE, productTypeInfo);
                }
               else
                {
                     response = await client.PostAsJsonAsync(Common.Common.APIURL_PRODUCTTYPE_MODIFY, productTypeInfo);
                }

                if (response.IsSuccessStatusCode)
                {
                    int result = await response.Content.ReadAsAsync<int>();
                    if (result == -1)
                        MessageBox.Show("Record Save Successfully", "Inventory", MessageBoxButtons.OK);
                    else
                        Console.WriteLine("An error has occurred");
                }
            }

        }

        private void SaveData()
        {
            ClsComm comm = new ClsComm();
            if (IsValidate())
            {
                if (string.IsNullOrEmpty(lblId.Text))
                {
                    lblId.Text = comm.GetUniqueId("CategoryId", "Category").ToString();
                    comm.AddData("Category", null, lblId.Text + ",'" + txtCategoryName.Text + "','" + txtRemarks.Text + "'",true);
                    MessageBox.Show("Record Save Successfully", "SOUMCO", MessageBoxButtons.OK);
                }
                else
                {
                    comm.EditData("Category", "CategoryName='" + txtCategoryName.Text + "',Description='" + txtRemarks.Text + "'", "CategoryId=" + lblId.Text,true);
                    MessageBox.Show("Record Update successfully", "SOUMCO", MessageBoxButtons.OK);
                }
            }
        }

        private bool IsValidate()
        {
            ClsComm comm = new ClsComm();
            string CategoryName = string.Empty;
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("Category cannot be null or empty", "SOUMCO");
                txtCategoryName.Focus();
                return false;
            }

            CategoryName = comm.GetValue("CategoryName", "Category", "CategoryName='" + txtCategoryName.Text + "' and CategoryId not in (" + lblId.Text + ")");
            if (!string.IsNullOrEmpty(CategoryName))
            {
                MessageBox.Show("Duplicate Category found", "SOUMCO");
                txtCategoryName.Focus();
                return false;
            }
            return true;
        }

        private void FrmVehicle_Load(object sender, EventArgs e)
        {
            txtCategoryName.Focus();
            
        }
        public async void ProcFillForm(object Id)
        {
            ProductTypeInfo objProductInfo = new ProductTypeInfo();
            var client = new HttpClient();
            
            HttpResponseMessage response = await client.GetAsync(Common.Common.APIURL_PRODUCTTYPE_GETBY_ID + "?Id=" + Id.ToString());
            var fileJsonString = await response.Content.ReadAsStringAsync();
            // DataTable dtList = (DataTable)JsonConvert.DeserializeObject(fileJsonString, (typeof(DataTable)));
            objProductInfo = JsonConvert.DeserializeObject<ProductTypeInfo>(fileJsonString);
            if(objProductInfo.productTypeId>0)
            {
                txtCategoryName.Text = objProductInfo.productTypeName;
                txtRemarks.Text = objProductInfo.description;
                lblId.Text = objProductInfo.productTypeId.ToString();
            }

            //DataTable DTFill = new DataTable();
            //ClsComm comm = new ClsComm();
            //DTFill = comm.FillTable("Select CategoryId,CategoryName,Description from Category where CategoryId=" + Id);
            //if (DTFill.Rows.Count > 0)
            //{
            //    lblId.Text = Id.ToString();
            //    txtCategoryName.Text = DTFill.Rows[0]["CategoryName"].ToString();
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
            txtCategoryName.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            txtCategoryName.Focus();
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                SaveData();
                ProcClear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ProcClear();
        }

        private void GBCustomerInformation_Enter(object sender, EventArgs e)
        {

        }
    }
}