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
    public partial class FrmVehicle : Form
    {
        //OleDbConnection conn = new OleDbConnection();
        //OleDbCommand cmd = new OleDbCommand();
        
        public FrmVehicle()
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
                    lblId.Text = comm.GetUniqueId("VehicleId", "Vehicle").ToString();
                    comm.AddData("Vehicle", null, lblId.Text + ",'" + txtVehicleNo.Text + "','" + txtRemarks.Text + "','" + txtOperatorName.Text + "','" + txtAreaCode.Text + "','" + txtVehicleCode.Text + "'");
                    MessageBox.Show("Record Save Successfully", "SOUMCO", MessageBoxButtons.OK);
                }
                else
                {
                    comm.EditData("Vehicle", "VehicleNo='" + txtVehicleNo.Text + "',Remarks='" + txtRemarks.Text + "',OperatorName='" + txtOperatorName.Text + "',AreaCode='" + txtAreaCode.Text + "',VehicleCode='" + txtVehicleCode.Text + "'", "VehicleId=" + lblId.Text);
                    MessageBox.Show("Record update successfully", "SOUMCO", MessageBoxButtons.OK);
                }
            }
        }

        private bool IsValidate()
        {
            ClsComm comm = new ClsComm();
            string VehicleName = string.Empty;
            if (string.IsNullOrEmpty(txtVehicleNo.Text))
            {
                MessageBox.Show("Vehicle No cannot be null or empty", "SOUMCO");
                txtVehicleNo.Focus();
                return false;
            }

            VehicleName = comm.GetValue("VehicleNo", "Vehicle", "VehicleNo='" + txtVehicleNo.Text + "'");
            if (!string.IsNullOrEmpty(VehicleName))
            {
                MessageBox.Show("Duplicate vehicle no found", "SOUMCO");
                txtVehicleNo.Focus();
                return false;
            }
            return true;
        }

        private void FrmVehicle_Load(object sender, EventArgs e)
        {
            txtVehicleNo.Focus();
            
        }
        public void ProcFillForm(object Id)
        {
            DataTable DTFill = new DataTable();
            ClsComm comm = new ClsComm();
            DTFill = comm.FillTable("Select * from Vehicle where VehicleId=" + Id);
            if (DTFill.Rows.Count > 0)
            {
                lblId.Text = Id.ToString();
                txtVehicleNo.Text = DTFill.Rows[0]["VehicleNo"].ToString();
                txtRemarks.Text = DTFill.Rows[0]["Remarks"].ToString();
                txtOperatorName.Text= DTFill.Rows[0]["OperatorName"].ToString();
                txtAreaCode.Text = DTFill.Rows[0]["AreaCode"].ToString();
                txtVehicleCode.Text = DTFill.Rows[0]["VehicleCode"].ToString();
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
            txtVehicleCode.Text = string.Empty;
            txtVehicleNo.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            txtOperatorName.Text = string.Empty;
            txtAreaCode.Text = string.Empty;
            txtVehicleCode.Focus();
            
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