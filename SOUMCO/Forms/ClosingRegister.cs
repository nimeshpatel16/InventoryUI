using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SOUMCO.Forms
{
    public partial class ClosingRegister : Form
    {
        public ClosingRegister()
        {
            InitializeComponent();
        }

        private void ClosingRegister_Load(object sender, EventArgs e)
        {
            ProcOpen();
            GBClosingStockSummary.Visible = false;
            GBInwOutSumm.Visible = false;
            if (this.Text == "Inward/Outward Summary")
            {
                dtpFromInwOutSumm.Value = Convert.ToDateTime("01/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
                dtpToInwOutSumm.Value = Convert.ToDateTime("30/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
                GBInwOutSumm.Visible = true;
            }
            else if (this.Text == "Stock Summary")
            {
                GBClosingStockSummary.Visible = true;
            }

        }
        private void ProcOpen()
        {
            ClsComm Comm = new ClsComm();
            if(this.Text=="Stock Summary")
                Comm.BindComboForAll(cmbItem, true, "ItemId", "ItemName", "Item", "ItemName");
            else if (this.Text == "Inward/Outward Summary")
                Comm.BindComboForAll(cmbItemInwOutSumm, true, "ItemId", "ItemName", "Item", "ItemName");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            clsExcelReport strEx = new clsExcelReport();
            if (this.Text == "Stock Summary")
                if (cmbItem.SelectedValue != null)
                {
                    strEx.ClosingStockReport(Convert.ToInt32(cmbItem.SelectedValue), dtpToDate.Value);
                }
                else
                {
                    MessageBox.Show("Select Proper Value", "SOUMCO");
                }
            else if (this.Text == "Inward/Outward Summary")
            {
                if (cmbItemInwOutSumm.SelectedValue != null)
                {
                    strEx.InwardOutwardSummary(Convert.ToInt32(cmbItemInwOutSumm.SelectedValue), dtpFromInwOutSumm.Value, dtpToInwOutSumm.Value);
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

    }
}