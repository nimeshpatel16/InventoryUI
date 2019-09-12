namespace SOUMCO.Forms
{
    partial class FrmDashBoard
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
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRightPanelAvailableKgs = new System.Windows.Forms.Label();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.cmbRightPanelCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgStock = new System.Windows.Forms.DataGridView();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.pnlDashboard.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStock)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.panel2);
            this.pnlDashboard.Controls.Add(this.panel1);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1389, 516);
            this.pnlDashboard.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFilterValue);
            this.panel1.Controls.Add(this.lblRightPanelAvailableKgs);
            this.panel1.Controls.Add(this.cmbFilterBy);
            this.panel1.Controls.Add(this.cmbRightPanelCategory);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1389, 107);
            this.panel1.TabIndex = 0;
            // 
            // lblRightPanelAvailableKgs
            // 
            this.lblRightPanelAvailableKgs.AutoSize = true;
            this.lblRightPanelAvailableKgs.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightPanelAvailableKgs.Location = new System.Drawing.Point(1049, 67);
            this.lblRightPanelAvailableKgs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRightPanelAvailableKgs.Name = "lblRightPanelAvailableKgs";
            this.lblRightPanelAvailableKgs.Size = new System.Drawing.Size(52, 23);
            this.lblRightPanelAvailableKgs.TabIndex = 37;
            this.lblRightPanelAvailableKgs.Text = "0.00";
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFilterBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFilterBy.DropDownHeight = 120;
            this.cmbFilterBy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterBy.FormattingEnabled = true;
            this.cmbFilterBy.IntegralHeight = false;
            this.cmbFilterBy.ItemHeight = 18;
            this.cmbFilterBy.Location = new System.Drawing.Point(569, 23);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(313, 26);
            this.cmbFilterBy.TabIndex = 1;
            this.cmbFilterBy.SelectedValueChanged += new System.EventHandler(this.cmbRightPanelItemName_SelectedValueChanged);
            // 
            // cmbRightPanelCategory
            // 
            this.cmbRightPanelCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRightPanelCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRightPanelCategory.DropDownHeight = 120;
            this.cmbRightPanelCategory.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRightPanelCategory.FormattingEnabled = true;
            this.cmbRightPanelCategory.IntegralHeight = false;
            this.cmbRightPanelCategory.ItemHeight = 18;
            this.cmbRightPanelCategory.Location = new System.Drawing.Point(113, 23);
            this.cmbRightPanelCategory.Name = "cmbRightPanelCategory";
            this.cmbRightPanelCategory.Size = new System.Drawing.Size(313, 26);
            this.cmbRightPanelCategory.TabIndex = 0;
            this.cmbRightPanelCategory.SelectionChangeCommitted += new System.EventHandler(this.cmbRightPanelCategory_SelectionChangeCommitted);
            this.cmbRightPanelCategory.SelectedValueChanged += new System.EventHandler(this.cmbRightPanelCategory_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Category";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(483, 29);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 17);
            this.label26.TabIndex = 33;
            this.label26.Text = "Filter By";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Filter Value";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgStock);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1389, 409);
            this.panel2.TabIndex = 1;
            // 
            // dgStock
            // 
            this.dgStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStock.Location = new System.Drawing.Point(0, 0);
            this.dgStock.Margin = new System.Windows.Forms.Padding(4);
            this.dgStock.Name = "dgStock";
            this.dgStock.Size = new System.Drawing.Size(1389, 409);
            this.dgStock.TabIndex = 1018;
            this.dgStock.Tag = "10";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Location = new System.Drawing.Point(569, 67);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(313, 22);
            this.txtFilterValue.TabIndex = 2;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // FrmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 516);
            this.Controls.Add(this.pnlDashboard);
            this.Name = "FrmDashBoard";
            this.Text = "FrmDashBoard";
            this.Load += new System.EventHandler(this.FrmDashBoard_Load);
            this.pnlDashboard.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.ComboBox cmbRightPanelCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblRightPanelAvailableKgs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgStock;
        private System.Windows.Forms.TextBox txtFilterValue;
    }
}