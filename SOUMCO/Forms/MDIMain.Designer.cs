namespace SOUMCO.Forms
{
    partial class MDIMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Density_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Category_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inwardEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outwardEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DensityList_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryList_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomertoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inwardEntryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.outwardEntryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleWiseTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleItemWiseTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemWiseInwardOutwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Inward_Outward_Summary = new System.Windows.Forms.ToolStripMenuItem();
            this.inwardRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mastersToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.listToolStripMenuItem,
            this.userToolStripMenuItem,
            this.dashBoardToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(1229, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mastersToolStripMenuItem
            // 
            this.mastersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyInfoToolStripMenuItem,
            this.Density_toolStripMenuItem,
            this.Category_toolStripMenuItem,
            this.subCategoryToolStripMenuItem,
            this.supplierInfoToolStripMenuItem,
            this.itemInfoToolStripMenuItem,
            this.vehicleInfoToolStripMenuItem});
            this.mastersToolStripMenuItem.Name = "mastersToolStripMenuItem";
            this.mastersToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.mastersToolStripMenuItem.Text = "Masters";
            // 
            // companyInfoToolStripMenuItem
            // 
            this.companyInfoToolStripMenuItem.Name = "companyInfoToolStripMenuItem";
            this.companyInfoToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.companyInfoToolStripMenuItem.Text = "Company Info";
            this.companyInfoToolStripMenuItem.Click += new System.EventHandler(this.companyInfoToolStripMenuItem_Click);
            // 
            // Density_toolStripMenuItem
            // 
            this.Density_toolStripMenuItem.Name = "Density_toolStripMenuItem";
            this.Density_toolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.Density_toolStripMenuItem.Text = "Density Info";
            this.Density_toolStripMenuItem.Visible = false;
            this.Density_toolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Category_toolStripMenuItem
            // 
            this.Category_toolStripMenuItem.Name = "Category_toolStripMenuItem";
            this.Category_toolStripMenuItem.ShowShortcutKeys = false;
            this.Category_toolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.Category_toolStripMenuItem.Text = "Product Type Info";
            this.Category_toolStripMenuItem.Click += new System.EventHandler(this.Category_toolStripMenuItem_Click);
            // 
            // subCategoryToolStripMenuItem
            // 
            this.subCategoryToolStripMenuItem.Name = "subCategoryToolStripMenuItem";
            this.subCategoryToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.subCategoryToolStripMenuItem.Text = "Product Size info";
            this.subCategoryToolStripMenuItem.Click += new System.EventHandler(this.subCategoryToolStripMenuItem_Click);
            // 
            // supplierInfoToolStripMenuItem
            // 
            this.supplierInfoToolStripMenuItem.Name = "supplierInfoToolStripMenuItem";
            this.supplierInfoToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.supplierInfoToolStripMenuItem.Text = "Supplier Info";
            this.supplierInfoToolStripMenuItem.Visible = false;
            this.supplierInfoToolStripMenuItem.Click += new System.EventHandler(this.supplierInfoToolStripMenuItem_Click);
            // 
            // itemInfoToolStripMenuItem
            // 
            this.itemInfoToolStripMenuItem.Name = "itemInfoToolStripMenuItem";
            this.itemInfoToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.itemInfoToolStripMenuItem.Text = "Product Info";
            this.itemInfoToolStripMenuItem.Click += new System.EventHandler(this.itemInfoToolStripMenuItem_Click);
            // 
            // vehicleInfoToolStripMenuItem
            // 
            this.vehicleInfoToolStripMenuItem.Name = "vehicleInfoToolStripMenuItem";
            this.vehicleInfoToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.vehicleInfoToolStripMenuItem.Text = "Vehicle Info";
            this.vehicleInfoToolStripMenuItem.Visible = false;
            this.vehicleInfoToolStripMenuItem.Click += new System.EventHandler(this.vehicleInfoToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inwardEntryToolStripMenuItem,
            this.outwardEntryToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // inwardEntryToolStripMenuItem
            // 
            this.inwardEntryToolStripMenuItem.Name = "inwardEntryToolStripMenuItem";
            this.inwardEntryToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.inwardEntryToolStripMenuItem.Text = "Inward Entry";
            this.inwardEntryToolStripMenuItem.Click += new System.EventHandler(this.inwardEntryToolStripMenuItem_Click);
            // 
            // outwardEntryToolStripMenuItem
            // 
            this.outwardEntryToolStripMenuItem.Name = "outwardEntryToolStripMenuItem";
            this.outwardEntryToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.outwardEntryToolStripMenuItem.Text = "Outward Entry";
            this.outwardEntryToolStripMenuItem.Click += new System.EventHandler(this.outwardEntryToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.userToolStripMenuItem1,
            this.DensityList_toolStripMenuItem,
            this.CategoryList_toolStripMenuItem,
            this.subCategoryToolStripMenuItem1,
            this.CustomertoolStripMenuItem1,
            this.supplierListToolStripMenuItem,
            this.itemListToolStripMenuItem,
            this.vehicleToolStripMenuItem,
            this.inwardEntryToolStripMenuItem1,
            this.outwardEntryToolStripMenuItem1});
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(43, 24);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(178, 26);
            this.toolStripMenuItem2.Text = "Company";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click_1);
            // 
            // userToolStripMenuItem1
            // 
            this.userToolStripMenuItem1.Name = "userToolStripMenuItem1";
            this.userToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.userToolStripMenuItem1.Text = "User";
            this.userToolStripMenuItem1.Visible = false;
            this.userToolStripMenuItem1.Click += new System.EventHandler(this.userToolStripMenuItem1_Click);
            // 
            // DensityList_toolStripMenuItem
            // 
            this.DensityList_toolStripMenuItem.Name = "DensityList_toolStripMenuItem";
            this.DensityList_toolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.DensityList_toolStripMenuItem.Text = "Density";
            this.DensityList_toolStripMenuItem.Visible = false;
            this.DensityList_toolStripMenuItem.Click += new System.EventHandler(this.DensityList_toolStripMenuItem_Click);
            // 
            // CategoryList_toolStripMenuItem
            // 
            this.CategoryList_toolStripMenuItem.Name = "CategoryList_toolStripMenuItem";
            this.CategoryList_toolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.CategoryList_toolStripMenuItem.Text = "Product Type";
            this.CategoryList_toolStripMenuItem.Click += new System.EventHandler(this.CategoryList_toolStripMenuItem_Click);
            // 
            // subCategoryToolStripMenuItem1
            // 
            this.subCategoryToolStripMenuItem1.Name = "subCategoryToolStripMenuItem1";
            this.subCategoryToolStripMenuItem1.Size = new System.Drawing.Size(178, 26);
            this.subCategoryToolStripMenuItem1.Text = "Product Size";
            this.subCategoryToolStripMenuItem1.Click += new System.EventHandler(this.subCategoryToolStripMenuItem1_Click);
            // 
            // CustomertoolStripMenuItem1
            // 
            this.CustomertoolStripMenuItem1.Name = "CustomertoolStripMenuItem1";
            this.CustomertoolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.CustomertoolStripMenuItem1.Text = "Customer";
            this.CustomertoolStripMenuItem1.Visible = false;
            this.CustomertoolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // supplierListToolStripMenuItem
            // 
            this.supplierListToolStripMenuItem.Name = "supplierListToolStripMenuItem";
            this.supplierListToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.supplierListToolStripMenuItem.Text = "Supplier";
            this.supplierListToolStripMenuItem.Visible = false;
            this.supplierListToolStripMenuItem.Click += new System.EventHandler(this.supplierListToolStripMenuItem_Click);
            // 
            // itemListToolStripMenuItem
            // 
            this.itemListToolStripMenuItem.Name = "itemListToolStripMenuItem";
            this.itemListToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.itemListToolStripMenuItem.Text = "Product";
            this.itemListToolStripMenuItem.Click += new System.EventHandler(this.itemListToolStripMenuItem_Click);
            // 
            // vehicleToolStripMenuItem
            // 
            this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
            this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.vehicleToolStripMenuItem.Text = "Vehicle";
            this.vehicleToolStripMenuItem.Visible = false;
            this.vehicleToolStripMenuItem.Click += new System.EventHandler(this.vehicleToolStripMenuItem_Click);
            // 
            // inwardEntryToolStripMenuItem1
            // 
            this.inwardEntryToolStripMenuItem1.Name = "inwardEntryToolStripMenuItem1";
            this.inwardEntryToolStripMenuItem1.Size = new System.Drawing.Size(178, 26);
            this.inwardEntryToolStripMenuItem1.Text = "Inward Entry";
            this.inwardEntryToolStripMenuItem1.Click += new System.EventHandler(this.inwardEntryToolStripMenuItem1_Click);
            // 
            // outwardEntryToolStripMenuItem1
            // 
            this.outwardEntryToolStripMenuItem1.Name = "outwardEntryToolStripMenuItem1";
            this.outwardEntryToolStripMenuItem1.Size = new System.Drawing.Size(178, 26);
            this.outwardEntryToolStripMenuItem1.Text = "Outward Entry";
            this.outwardEntryToolStripMenuItem1.Click += new System.EventHandler(this.outwardEntryToolStripMenuItem1_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.listOfUserToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.userToolStripMenuItem.Text = "User";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // listOfUserToolStripMenuItem
            // 
            this.listOfUserToolStripMenuItem.Name = "listOfUserToolStripMenuItem";
            this.listOfUserToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.listOfUserToolStripMenuItem.Text = "List / Change User Credential ";
            this.listOfUserToolStripMenuItem.Visible = false;
            this.listOfUserToolStripMenuItem.Click += new System.EventHandler(this.listOfUserToolStripMenuItem_Click);
            // 
            // dashBoardToolStripMenuItem
            // 
            this.dashBoardToolStripMenuItem.Name = "dashBoardToolStripMenuItem";
            this.dashBoardToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.dashBoardToolStripMenuItem.Text = "DashBoard";
            this.dashBoardToolStripMenuItem.Click += new System.EventHandler(this.dashBoardToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleWiseTransactionToolStripMenuItem,
            this.vehicleItemWiseTransactionToolStripMenuItem,
            this.itemWiseInwardOutwardToolStripMenuItem,
            this.Inward_Outward_Summary,
            this.inwardRegisterToolStripMenuItem,
            this.stockSummaryToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Visible = false;
            // 
            // vehicleWiseTransactionToolStripMenuItem
            // 
            this.vehicleWiseTransactionToolStripMenuItem.Name = "vehicleWiseTransactionToolStripMenuItem";
            this.vehicleWiseTransactionToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.vehicleWiseTransactionToolStripMenuItem.Text = "Vehicle wise transaction";
            this.vehicleWiseTransactionToolStripMenuItem.Visible = false;
            this.vehicleWiseTransactionToolStripMenuItem.Click += new System.EventHandler(this.vehicleWiseTransactionToolStripMenuItem_Click);
            // 
            // vehicleItemWiseTransactionToolStripMenuItem
            // 
            this.vehicleItemWiseTransactionToolStripMenuItem.Name = "vehicleItemWiseTransactionToolStripMenuItem";
            this.vehicleItemWiseTransactionToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.vehicleItemWiseTransactionToolStripMenuItem.Text = "Vehicle/Item wise transaction";
            this.vehicleItemWiseTransactionToolStripMenuItem.Click += new System.EventHandler(this.vehicleItemWiseTransactionToolStripMenuItem_Click);
            // 
            // itemWiseInwardOutwardToolStripMenuItem
            // 
            this.itemWiseInwardOutwardToolStripMenuItem.Name = "itemWiseInwardOutwardToolStripMenuItem";
            this.itemWiseInwardOutwardToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.itemWiseInwardOutwardToolStripMenuItem.Text = "Item wise Inward && Outward Detail";
            this.itemWiseInwardOutwardToolStripMenuItem.Visible = false;
            this.itemWiseInwardOutwardToolStripMenuItem.Click += new System.EventHandler(this.itemWiseInwardOutwardToolStripMenuItem_Click);
            // 
            // Inward_Outward_Summary
            // 
            this.Inward_Outward_Summary.Name = "Inward_Outward_Summary";
            this.Inward_Outward_Summary.Size = new System.Drawing.Size(317, 26);
            this.Inward_Outward_Summary.Text = "Inward && Outward Summary";
            this.Inward_Outward_Summary.Click += new System.EventHandler(this.Inward_Outward_Summary_Click);
            // 
            // inwardRegisterToolStripMenuItem
            // 
            this.inwardRegisterToolStripMenuItem.Name = "inwardRegisterToolStripMenuItem";
            this.inwardRegisterToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.inwardRegisterToolStripMenuItem.Text = "Inward Register";
            this.inwardRegisterToolStripMenuItem.Click += new System.EventHandler(this.inwardRegisterToolStripMenuItem_Click);
            // 
            // stockSummaryToolStripMenuItem
            // 
            this.stockSummaryToolStripMenuItem.Name = "stockSummaryToolStripMenuItem";
            this.stockSummaryToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.stockSummaryToolStripMenuItem.Text = "Stock Summary";
            this.stockSummaryToolStripMenuItem.Click += new System.EventHandler(this.stockSummaryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 560);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1229, 25);
            this.statusStrip.TabIndex = 2;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MDIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1229, 585);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDIMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventory Control";
            this.TransparencyKey = System.Drawing.Color.Azure;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inwardEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outwardEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inwardEntryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem outwardEntryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleWiseTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleItemWiseTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemWiseInwardOutwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Inward_Outward_Summary;
        private System.Windows.Forms.ToolStripMenuItem inwardRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Density_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Category_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DensityList_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoryList_toolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem dashBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomertoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem subCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subCategoryToolStripMenuItem1;
    }
}



