using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SOUMCO.Class;
using System.IO;

namespace SOUMCO.Forms
{
    public partial class FrmItem : Form
    {
        public string strMode = string.Empty;
        public FrmItem()
        {
            InitializeComponent();
            FillDropDown();
        }

        private void FillDropDown()
        {
            //ClsReadINI objclsReadINI = new ClsReadINI(Path.Combine(Application.StartupPath, "Setting.ini"));
            //string category = objclsReadINI.GetValue("Data", "Category", "NoCategory");
            //string density = objclsReadINI.GetValue("Data", "Density", "NoCountry");

            //var cat = category.Split(',');
            //var den = density.Split(',');
            //cmbCategory.DataSource = cat;
            //cmbDensity.DataSource = den;
            ClsComm Comm = new ClsComm();
            Comm.BindCombo(cmbCategory, false, "CategoryId", "CategoryName", "Category", "CategoryName");
            Comm.BindCombo(cmbSubCategory, false, "SubCategoryId", "SubCategoryName", "SubCategory", "SubCategoryName");
            Comm.BindCombo(cmbDensity, false, "DensityId", "DensityName", "Density", "DensityName");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                SaveData();
                this.Dispose();
            }
        }

        private void SaveData()
        {
            ClsComm comm = new ClsComm();
            if (IsValidate())
            {
                if (string.IsNullOrEmpty(txtRate.Text))
                    txtRate.Text = "0.00";
                if (string.IsNullOrEmpty(txtOpStockNos.Text))
                    txtOpStockNos.Text = "0.00";
                if (string.IsNullOrEmpty(txtOpStockValue.Text))
                    txtOpStockValue.Text = "0.00";

                if (string.IsNullOrEmpty(lblId.Text))
                {
                    lblId.Text = comm.GetUniqueId("ItemId", "Item").ToString();
                    comm.AddData("Item", null, lblId.Text + ",'" + txtName.Text + "'," +
                        cmbCategory.SelectedValue + "," + cmbSubCategory.SelectedValue + "," + cmbDensity.SelectedValue + "," +
                        Convert.ToDecimal(txtRate.Text) + ",'" + txtRemarks.Text + "'," +
                        txtOpStockNos.Text + "," + txtOpKgs.Text + "," + txtOpMeter.Text + "," + txtOpLength.Text + "," + txtOpWidth.Text + "," +
                        txtOpDiameter.Text + "," + txtOpOD.Text + "," + txtOpID.Text + "," + txtOpThickness.Text + "," + txtOpSize.Text + ","
                        + Convert.ToDecimal(txtOpStockValue.Text),true);
                   

                    comm.StockLedger("Add", Convert.ToInt32(lblId.Text), 0, "OP", lblId.Text, System.DateTime.Now.Date, Convert.ToInt32(lblId.Text), Convert.ToInt32(cmbCategory.SelectedValue),
                                         Convert.ToDouble(txtOpStockNos.Text), Convert.ToDouble(txtOpKgs.Text), Convert.ToDouble(txtOpKgs.Text), true);

                    MessageBox.Show("Record Save Successfully", "SOUMCO", MessageBoxButtons.OK);
                }
                else
                {
                    comm.EditData("Item", "ItemName='" + txtName.Text + "',ItemRate=" + txtRate.Text +
                        ",Description='" + txtRemarks.Text + "',CategoryId=" + cmbCategory.SelectedValue + ",SubCategoryId=" + cmbSubCategory.SelectedValue + ",DensityId=" + cmbDensity.SelectedValue + ",OpStockQty=" + txtOpStockNos.Text +
                        ",OpStockKgs=" + txtOpKgs.Text + ",OpStockMeter=" + txtOpMeter.Text +
                        ",OpStockLength=" + txtOpLength.Text + ",OpStockWidth=" + txtOpWidth.Text +
                         ",OpStockDia=" + txtOpDiameter.Text + ",OpStockOD=" + txtOpOD.Text +
                         ",OpStockID=" + txtOpID.Text + ",OpStockThick=" + txtOpID.Text +
                         ",OpStockSize=" + txtOpSize.Text + 
                        ",OpStockValue=" + txtOpStockValue.Text ,"ItemId=" + lblId.Text + "",true);

                    comm.DeleteData("tbLedger", "TxnId=" + lblId.Text + " and TxnType='OP' and CompanyId=" + ClsComm.CompanyId + " and YearId=" + ClsComm.YearId);
                   

                    comm.StockLedger("Edit", Convert.ToInt32(lblId.Text), 0, "OP", lblId.Text, System.DateTime.Now.Date, Convert.ToInt32(lblId.Text), Convert.ToInt32(cmbCategory.SelectedValue),
                                        Convert.ToDouble(txtOpStockNos.Text), Convert.ToDouble(txtOpKgs.Text), Convert.ToDouble(txtOpKgs.Text), true);

                    MessageBox.Show("Record update successfully", "SOUMCO", MessageBoxButtons.OK);
                }
            }
        }

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

        public void ProcFillForm(object Id)
        {
            DataTable DTFill = new DataTable();
            ClsComm comm = new ClsComm();
            DTFill = comm.FillTable("Select * from Item where ItemId=" + Id);
            if (DTFill.Rows.Count > 0)
            {
                lblId.Text = Id.ToString();
                txtName.Text = DTFill.Rows[0]["ItemName"].ToString();
                txtRate.Text = DTFill.Rows[0]["ItemRate"].ToString();
                cmbCategory.SelectedValue = DTFill.Rows[0]["CategoryId"].ToString();
                cmbSubCategory.SelectedValue = DTFill.Rows[0]["SubCategoryId"];
                cmbDensity.SelectedValue = DTFill.Rows[0]["DensityId"].ToString();
                txtRemarks.Text = DTFill.Rows[0]["Description"].ToString();
                txtOpStockNos.Text = DTFill.Rows[0]["OpStockQty"].ToString() == "" ? "0.00" : DTFill.Rows[0]["OpStockQty"].ToString();
                txtOpKgs.Text = DTFill.Rows[0]["OpStockKgs"].ToString() == "" ? "0.00" : DTFill.Rows[0]["OpStockKgs"].ToString();
                txtOpMeter.Text = DTFill.Rows[0]["OpStockMeter"].ToString() == "" ? "0.00" : DTFill.Rows[0]["OpStockMeter"].ToString();
                txtOpLength.Text = DTFill.Rows[0]["OpStockLength"].ToString() == "" ? "0.00" : DTFill.Rows[0]["OpStockLength"].ToString();
                txtOpWidth.Text = DTFill.Rows[0]["OpStockWidth"].ToString() == "" ? "0.00" : DTFill.Rows[0]["OpStockWidth"].ToString();
                txtOpDiameter.Text = DTFill.Rows[0]["OpStockDia"].ToString() == "" ? "0.00" : DTFill.Rows[0]["OpStockDia"].ToString();
                txtOpOD.Text = DTFill.Rows[0]["OpStockOD"].ToString() == "" ? "0.00" : DTFill.Rows[0]["OpStockOD"].ToString();
                txtOpID.Text = DTFill.Rows[0]["OpStockID"].ToString() == "" ? "0.00" : DTFill.Rows[0]["OpStockID"].ToString();
                txtOpThickness.Text = DTFill.Rows[0]["OpStockThick"].ToString() == "" ? "0.00" : DTFill.Rows[0]["OpStockThick"].ToString();
                txtOpSize.Text = DTFill.Rows[0]["OpStockSize"].ToString() == "" ? "0.00" : DTFill.Rows[0]["OpStockSize"].ToString();
                txtOpStockValue.Text = DTFill.Rows[0]["OpStockValue"].ToString() == "" ? "0.00" : DTFill.Rows[0]["OpStockValue"].ToString();
             //   txtRelatedTo.Text = DTFill.Rows[0]["ItemRelatedTo"].ToString();
            }
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
            txtRate.Text = string.Empty;
            txtRemarks.Text = string.Empty;
           // txtRelatedTo.Text = string.Empty;
            txtName.Focus();
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            SaveData();
            ProcClear();
        }

        private void FrmItem_Load(object sender, EventArgs e)
        {
            
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ProcClear();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}