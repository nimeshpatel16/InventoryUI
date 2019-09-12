using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using SOUMCO;
namespace SOUMCO.Forms
{
    public partial class FrmDensity : Form
    {
        //OleDbConnection conn = new OleDbConnection();
        //OleDbCommand cmd = new OleDbCommand();

        public FrmDensity()
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
                    lblId.Text = comm.GetUniqueId("DensityId", "Density").ToString();
                    comm.AddData("Density", null, lblId.Text + ",'" + txtDensity.Text + "','" + txtDensityValue.Text + "','" + txtRemarks.Text + "'",true);
                    MessageBox.Show("Record Save Successfully", "SOUMCO", MessageBoxButtons.OK);
                }
                else
                {
                    comm.EditData("Density", "DensityName='" + txtDensity.Text + "',DensityValue='" + txtDensityValue.Text + "',Description='" + txtRemarks.Text + "'", "DensityId=" + lblId.Text,true);
                    MessageBox.Show("Record update successfully", "SOUMCO", MessageBoxButtons.OK);
                }
            }
        }

        private bool IsValidate()
        {
            ClsComm comm = new ClsComm();
            string DensityName = string.Empty;
            if (string.IsNullOrEmpty(txtDensity.Text))
            {
                MessageBox.Show("Density cannot be null or empty", "SOUMCO");
                txtDensity.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDensityValue.Text))
            {
                MessageBox.Show("Value cannot be null or empty", "SOUMCO");
                txtDensityValue.Focus();
                return false;
            }
            if (lblId.Text != string.Empty)
            {
                DensityName = comm.GetValue("DensityName", "Density", "DensityName='" + txtDensity.Text + "' and DensityId not in (" + lblId.Text + ")");
            }
            if (!string.IsNullOrEmpty(DensityName))
            {
                MessageBox.Show("Duplicate value found", "SOUMCO");
                txtDensity.Focus();
                return false;
            }
            return true;
        }

        private void FrmVehicle_Load(object sender, EventArgs e)
        {
            txtDensity.Focus();
            
        }
        public void ProcFillForm(object Id)
        {
            DataTable DTFill = new DataTable();
            ClsComm comm = new ClsComm();
            DTFill = comm.FillTable("Select DensityId,DensityName,DensityValue, Description from Density where DensityId=" + Id);
            if (DTFill.Rows.Count > 0)
            {
                lblId.Text = Id.ToString();
                txtDensity.Text = DTFill.Rows[0]["DensityName"].ToString();
                txtRemarks.Text = DTFill.Rows[0]["Description"].ToString();
                txtDensityValue.Text = DTFill.Rows[0]["DensityValue"].ToString();
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
            txtDensity.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            txtDensityValue.Text = string.Empty;
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


  
    }
}