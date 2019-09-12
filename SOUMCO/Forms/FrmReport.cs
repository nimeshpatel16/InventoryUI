using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SOUMCO.Forms
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }
        public string ClickName;
        private void FrmReport_Load(object sender, EventArgs e)
        {
            GBVehicleWiseItemWiseTran.Visible=false;
            GBVehiclewiseTran.Visible=false;
            if(ClickName=="VehicleWiseTransaction")
                GBVehiclewiseTran.Visible = true;
            else if (ClickName == "VehicleWiseItemwiseTransaction")
                GBVehicleWiseItemWiseTran.Visible = true;
            else if (ClickName == "ItemwiseInwardOrOutward" || ClickName=="ItemwiseInwardOrOutwardSummary")
            {
                GBVehicleWiseItemWiseTran.Visible = true;
                label7.Visible = false;
                cmbVehicleItemWise.Visible = false;
            }
            ProcOpen();
        }
        private void ProcOpen()
        {
            ClsComm Comm = new ClsComm();
            if(ClickName=="VehicleWiseTransaction")
            {
            Comm.BindCombo(cmbVehicle, false, "VehicleId", "VehicleNo", "Vehicle", "VehicleNo");
            }
            else if (ClickName == "VehicleWiseItemwiseTransaction")
            {
                Comm.BindCombo(cmbVehicleItemWise, false, "VehicleId", "VehicleNo", "Vehicle", "VehicleNo");
                Comm.BindCombo(cmbItem, false, "ItemId", "ItemName", "Item", "ItemName");
            }
            else if (ClickName == "ItemwiseInwardOrOutward" || ClickName == "ItemwiseInwardOrOutwardSummary")
            {
                Comm.BindCombo(cmbItem, false, "ItemId", "ItemName", "Item", "ItemName");
            }
         }

        private void btnOk_Click(object sender, EventArgs e)
        {
            clsExcelReport Ex = new clsExcelReport();
            if (ClickName == "VehicleWiseTransaction")
                Ex.VehicleWiseTransaction(Convert.ToInt32(cmbVehicle.SelectedValue), dtpFromDate.Value, dtpToDate.Value);
            else if (ClickName == "VehicleWiseItemwiseTransaction")
                Ex.VehiclewiseItemwiseTransaction(Convert.ToInt32(cmbVehicleItemWise.SelectedValue), Convert.ToInt32(cmbItem.SelectedValue), dtpFromDate1.Value, dtpToDate1.Value);
            else if (ClickName == "ItemwiseInwardOrOutward")
                Ex.ItemwiseInwardOutward(Convert.ToInt32(cmbItem.SelectedValue), dtpFromDate1.Value, dtpToDate1.Value);
            else if (ClickName == "ItemwiseInwardOrOutwardSummary")
                Ex.InwardOutwardSummary(Convert.ToInt32(cmbItem.SelectedValue), dtpFromDate1.Value, dtpToDate1.Value);
        }

       

       
    }
}