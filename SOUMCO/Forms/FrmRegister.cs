using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SOUMCO.Forms
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            ProcOpen();
            GBInwardReg.Visible = false;
            GBVehicleWiseTxn.Visible = false;
            if (this.Text == "Inward Register")
            {
                GBInwardReg.Visible = true;
                CmbSupplier.Focus();
            }
            else if (this.Text == "Vehicle wise item wise transaction")
            {
                GBVehicleWiseTxn.Visible = true;
                cmbVehicle.Focus();

            }
            
            dtpFromDate.Value =Convert.ToDateTime("01/" + DateTime.Now.Month + "/"  + DateTime.Now.Year);
            dtpToDate.Value = Convert.ToDateTime("30/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
            dtpFromDateVehicleWise.Value = Convert.ToDateTime("01/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
            dtpToDateVehicleWise.Value = Convert.ToDateTime("30/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
            
        }
        private void ProcOpen()
        {
            ClsComm Comm = new ClsComm();
            if (this.Text == "Inward Register")
            {
                Comm.BindComboForAll(CmbSupplier, true, "SupplierId", "SupplierName", "Supplier", "SupplierName");
            }
            else if (this.Text == "Vehicle wise item wise transaction")
            {
                Comm.BindComboForAll(cmbVehicle, false, "VehicleId", "VehicleCode", "Vehicle", "VehicleCode");
                Comm.BindComboForAll(cmbItem, true, "ItemId", "ItemName", "Item", "ItemName");
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            clsExcelReport strEx = new clsExcelReport();
            if (this.Text == "Inward Register")
            {
                if (CmbSupplier.SelectedValue != null || cmbCompany.Text != "")
                {
                    strEx.InwardRegister(Convert.ToInt32(CmbSupplier.SelectedValue), cmbCompany.Text, dtpFromDate.Value, dtpToDate.Value);
                }
                else
                {
                    MessageBox.Show("Select Proper Value", "SOUMCO");
                }
            }
            else if (this.Text == "Vehicle wise item wise transaction")
            {
                if (cmbVehicle.SelectedValue != null || cmbItem.SelectedValue != null)
                {
                    strEx.VehiclewiseItemwiseTransaction(Convert.ToInt32(cmbVehicle.SelectedValue), Convert.ToInt32(cmbItem.SelectedValue), dtpFromDateVehicleWise.Value, dtpToDateVehicleWise.Value);
                }
                else
                {
                    MessageBox.Show("Select Proper Value", "SOUMCO");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmbVehicle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ClsComm comm = new ClsComm();
            lblVehicleNo.Text = comm.GetValue("VehicleNo", "Vehicle", "Vehicleid=" + cmbVehicle.SelectedValue);
        }

    }
}