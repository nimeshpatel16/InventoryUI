using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SOUMCO.Forms
{
    public partial class FrmSupplier : Form
    {
        private int iRowIndexOfGrid;
        public FrmSupplier()
        {
            InitializeComponent();
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
                if (string.IsNullOrEmpty(lblId.Text))
                {
                    lblId.Text = comm.GetUniqueId("SupplierId", "Supplier").ToString();
                    comm.AddData("Supplier", null, lblId.Text + ",'" + txtName.Text + "','" + txtAddress.Text + "','" + txtCity.Text + "','" + txtZipCode.Text + "','" + txtPhNo.Text + "','" + txtCellNo.Text + "','" + txtFaxNo.Text + "','" + txtTanNo.Text + "','" + txtServiceNo.Text + "','" + txtExciseNo.Text + "','" + txtPanNo.Text + "','" + cmbType.Text + "'",true);
                    MessageBox.Show("Record Save Successfully", "SOUMCO", MessageBoxButtons.OK);
                }
                else
                {
                    comm.EditData("Supplier", "SupplierName='" + txtName.Text + "',Address='" + txtAddress.Text + "',City='" + txtCity.Text + "',ZipCode='" + txtZipCode.Text + "',PhoneNo='" + txtPhNo.Text + "',CellNo='" + txtCellNo.Text + "',FaxNo='" + txtFaxNo.Text + "',TanNo='" + txtTanNo.Text + "',ServiceTaxNo='" + txtServiceNo.Text + "',ExciseNo='" + txtExciseNo.Text + "',PanNo='" + txtPanNo.Text + "',Type='" + cmbType.Text + "'", "SupplierId=" + lblId.Text,true);

                    MessageBox.Show("Record update successfully", "SOUMCO", MessageBoxButtons.OK);
                }
            }
        }
     
        private bool IsValidate()
        {
            ClsComm comm = new ClsComm();
            string SupplierName = String.Empty;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Supplier Name cannot be null or empty", "SOUMCO");
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCity.Text))
            {
                MessageBox.Show("City cannot be null or empty", "SOUMCO");
                txtCity.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(lblId.Text))
            {
                SupplierName = comm.GetValue("SupplierName", "Supplier", "SupplierName='" + txtName.Text + "'");
                if (!string.IsNullOrEmpty(SupplierName))
                {
                    MessageBox.Show("Duplicate name found", "SOUMCO");
                    txtName.Focus();
                    return false;
                }
            }



            return true;
        }

        public void ProcFillForm(object Id, int iRowIndex)
        {
            DataTable DTFill = new DataTable();
            ClsComm comm=new ClsComm();
            DTFill = comm.FillTable("Select * from Supplier where SupplierId=" + Id);
            if (DTFill.Rows.Count > 0)
            {
                lblId.Text = Id.ToString();
                cmbType.Text = DTFill.Rows[0]["Type"].ToString();
                txtName.Text = DTFill.Rows[0]["SupplierName"].ToString();
                txtAddress.Text = DTFill.Rows[0]["Address"].ToString();
                txtCity.Text = DTFill.Rows[0]["City"].ToString();
                txtZipCode.Text = DTFill.Rows[0]["ZipCode"].ToString();
                txtPhNo.Text = DTFill.Rows[0]["PhoneNo"].ToString();
                txtCellNo.Text = DTFill.Rows[0]["CellNo"].ToString();
                txtFaxNo.Text = DTFill.Rows[0]["FaxNo"].ToString();
                txtTanNo.Text = DTFill.Rows[0]["TanNo"].ToString();
                txtServiceNo.Text = DTFill.Rows[0]["ServiceTaxNo"].ToString();
                txtExciseNo.Text = DTFill.Rows[0]["ExciseNo"].ToString();
                txtPanNo.Text = DTFill.Rows[0]["PanNo"].ToString();
                iRowIndexOfGrid = iRowIndex;
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

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            SaveData();
            ProcClear();
            txtName.Focus();
        }
        private void ProcClear()
        {
            lblId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtZipCode.Text = string.Empty;
            txtPhNo.Text = string.Empty;
            txtCellNo.Text = string.Empty;
            txtFaxNo.Text = string.Empty;
            txtTanNo.Text = string.Empty;
            txtServiceNo.Text = string.Empty;
            txtExciseNo.Text = string.Empty;
            txtPanNo.Text = string.Empty;
            txtName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ProcClear();
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            
        }
    }
}