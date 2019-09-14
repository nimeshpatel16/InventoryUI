
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SOUMCO.Forms
{
    public partial class MDIMain : Form
    {
        FrmLists frmList1 = new FrmLists();
        private int childFormNumber = 0;

        public MDIMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            // Create a new instance of the child form.
            Form childForm = new Form();
            // Make it a child of this MDI form before showing it.
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                // TODO: Add code here to open the file.
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
                // TODO: Add code here to save the current contents of the form to a file.
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard.GetText() or System.Windows.Forms.GetData to retrieve information from the clipboard.
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vehicleInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVehicle frmvehicle = new FrmVehicle();
            frmvehicle.Show();
        }

        private void supplierInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupplier frmsupplier = new FrmSupplier();
            frmsupplier.MdiParent = this;
            frmsupplier.Show();
        }

        private void itemInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct frmItem = new frmProduct();
            frmItem.MdiParent = this;
            frmItem.Show();
        }

        private void inwardEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmInward frmInward = new FrmInward();
            OLDFrmInward frmInward = new OLDFrmInward();
            frmInward.MdiParent = this;
            frmInward.BringToFront();
            frmInward.WindowState = FormWindowState.Maximized;
            frmInward.Dock = DockStyle.Fill;
            
            frmInward.Show();
        }

        private void outwardEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOutwardLatest frmOutward = new FrmOutwardLatest();
            frmOutward.MdiParent = this;
            frmOutward.BringToFront();
            frmOutward.WindowState = FormWindowState.Maximized;
            frmOutward.Dock = DockStyle.Fill;
            frmOutward.Show();
            
        }

        private void MDIMain_Load(object sender, EventArgs e)
        {
            ClsComm comm = new ClsComm();
            string user = string.Empty, companyName=string.Empty, financialDetail=string.Empty;
            int companyInfoId;
            int yearId ;
            user = comm.IniReadValue("LoginInfo", "Users", Application.StartupPath + "\\Connection.ini");
            companyInfoId =Convert.ToInt32(comm.IniReadValue("CompanyInfo", "SelectedCompany", Application.StartupPath + "\\Connection.ini"));
            yearId = Convert.ToInt32(comm.IniReadValue("FinancialDetail", "SelectedYear", Application.StartupPath + "\\Connection.ini"));
            companyName = comm.GetValue("Select CompanyName from Company where CompanyId=" + companyInfoId);
            financialDetail = comm.GetValue("Select Description from FinancialDetail where YearId=" + yearId);
            this.Text = "Inventory-[" + companyName + "] - [" + financialDetail + "]";
            this.toolStripStatusLabel.Text = "Financial Period: [" + financialDetail + "]";
            if (user == "Admin")
            {
                userToolStripMenuItem.Visible = true;
            }
            else
            {
                userToolStripMenuItem.Visible = false;
            }
            
            
            //FrmLogin frmlogin = new FrmLogin();
            //frmlogin.Close();
        }

        private void supplierListToolStripMenuItem_Click(object sender, EventArgs e)
        {
                FrmLists frmList = new FrmLists();
                frmList.ClickName = "Supplier";
                frmList.Text = "Supplier List";
                ToolStripProperty(frmList);
            
        }

        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLists frmList = new FrmLists();
            frmList.ClickName = "Item";
            frmList.Text = "Item List";
            ToolStripProperty(frmList);
        }

        private void vehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLists frmList = new FrmLists();
            frmList.ClickName = "Vehicle";
            frmList.Text = "Vehicle List";
            frmList.MdiParent = this;
            frmList.Show();
        }

        private void inwardEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLists frmList = new FrmLists();
            frmList.ClickName = "InwardEntry";
            frmList.Text = "Inward List";
            ToolStripProperty(frmList);
        }

        private void outwardEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLists frmList = new FrmLists();
            frmList.ClickName = "OutwardEntry";
            frmList.Text = "Outward List";
            ToolStripProperty(frmList);
        }
        public void ShowForm(System.Windows.Forms.Form myForm, Boolean IsMDIChild, System.Windows.Forms.FormWindowState FormState)
        {
            if (myForm.Visible == true)
            {
                myForm.BringToFront();
            }
            else
            {
                if (IsMdiContainer == true)
                {
                    this.IsMdiContainer = true;
                    myForm.MdiParent = this;
                }
                //myForm.WindowState = FormState 

                myForm.Show();
                myForm.BringToFront();
            }
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUser user = new FrmUser();
            user.MdiParent = this;
            user.Show();
        }

        private void listOfUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLists frmList = new FrmLists();
            frmList.ClickName = "UserList";
            frmList.Text = "User List";
            frmList.MdiParent = this;
            frmList.Show();
        }

        private void vehicleWiseTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReport rpt = new FrmReport();
            rpt.ClickName = "VehicleWiseTransaction";
            rpt.Text="Vehicle wise transaction";
            rpt.MdiParent=this;
            rpt.Show();
        }

        private void vehicleItemWiseTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegister rpt = new FrmRegister();
            //rpt.ClickName = "VehicleWiseItemwiseTransaction";
            rpt.Text = "Vehicle wise item wise transaction";
            rpt.MdiParent = this;
            rpt.Show();
        }

        private void itemWiseInwardOutwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReport rpt = new FrmReport();
            rpt.ClickName = "ItemwiseInwardOrOutward";
            rpt.Text = "Item wise Inward/Outward";
            rpt.MdiParent = this;
            rpt.Show();
        }

        private void itemWiseStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReport rpt = new FrmReport();
            rpt.ClickName = "ItemwiseInwardOrOutwardSummary";
            rpt.Text = "Item wise Inward/Outward Summary";
            rpt.MdiParent = this;
            rpt.Show();
        }

        private void inwardRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegister reg = new FrmRegister();
            reg.Text = "Inward Register";
            reg.MdiParent = this;
            reg.Show();
        }

        private void stockSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClosingRegister clsreg = new ClosingRegister();
            clsreg.Text = "Stock Summary";
            clsreg.MdiParent = this;
            clsreg.Show();
        }

        private void Inward_Outward_Summary_Click(object sender, EventArgs e)
        {
            ClosingRegister clsreg = new ClosingRegister();
            clsreg.Text = "Inward/Outward Summary";
            clsreg.MdiParent = this;
            clsreg.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmDensity density = new FrmDensity();
            density.Text = "Density Info";
            density.MdiParent = this;
            density.Show();
        }
        
        private void Category_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategory category = new FrmCategory();
            category.Text = "Product Type Info";
            category.MdiParent = this;
            category.Show();
        }

        private void DensityList_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLists frmList = new FrmLists();
            frmList.ClickName = "Density";
            frmList.Text = "Density List";
            ToolStripProperty(frmList);
        }

        private void CategoryList_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLists frmList = new FrmLists();
            frmList.ClickName = "Category";
            frmList.Text = "Category List";
            ToolStripProperty(frmList);
        }

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDashBoard frmdashboad = new FrmDashBoard();
            frmdashboad.Text = "Dash Board";
            frmdashboad.MdiParent = this;
            frmdashboad.BringToFront();
            frmdashboad.WindowState = FormWindowState.Maximized;
            frmdashboad.Dock = DockStyle.Fill;
            frmdashboad.Show();

        }

        private void companyInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompany frmcompany = new FrmCompany();
            frmcompany.Text = "Company Info";
            frmcompany.MdiParent = this;
            frmcompany.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLists frmList = new FrmLists();
            frmList.ClickName = "Customer";
            frmList.Text = "Customer List";
            ToolStripProperty(frmList);
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            FrmLists frmList = new FrmLists();
            frmList.ClickName = "Company";
            frmList.Text = "Company List";
            ToolStripProperty(frmList);
        }

        void ToolStripProperty(Form frmForm)
        {
            frmForm.MdiParent = this;
            frmForm.BringToFront();
            frmForm.WindowState = FormWindowState.Maximized;
            frmForm.MaximumSize = this.MaximumSize;
            frmForm.MinimumSize = this.MinimumSize;
            frmForm.Dock = DockStyle.Fill;
            frmForm.Show();

        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLists frmList = new FrmLists();
            frmList.ClickName = "User";
            frmList.Text = "User List";
            ToolStripProperty(frmList);
        }

        private void subCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSubCategory category = new FrmSubCategory();
            category.Text = "Product Size Info";
            category.MdiParent = this;
            category.Show();
        }

        private void subCategoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLists frmList = new FrmLists();
            frmList.ClickName = "SUBCategory";
            frmList.Text = "Sub Category List";
            ToolStripProperty(frmList);

        }

        
    }
}
