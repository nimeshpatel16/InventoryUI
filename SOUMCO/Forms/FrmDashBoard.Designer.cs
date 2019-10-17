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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgStock = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.lblRightPanelAvailableKgs = new System.Windows.Forms.Label();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.cmbProductSize = new System.Windows.Forms.ComboBox();
            this.cmbRightPanelCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlDashboard.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStock)).BeginInit();
            this.panel1.SuspendLayout();
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
            // panel2
            // 
            this.panel2.Controls.Add(this.dgStock);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1389, 369);
            this.panel2.TabIndex = 1;
            // 
            // dgStock
            // 
            this.dgStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStock.Location = new System.Drawing.Point(0, 0);
            this.dgStock.Margin = new System.Windows.Forms.Padding(4);
            this.dgStock.Name = "dgStock";
            this.dgStock.Size = new System.Drawing.Size(1389, 369);
            this.dgStock.TabIndex = 1018;
            this.dgStock.Tag = "10";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFilterValue);
            this.panel1.Controls.Add(this.lblRightPanelAvailableKgs);
            this.panel1.Controls.Add(this.cmbFilterBy);
            this.panel1.Controls.Add(this.cmbProduct);
            this.panel1.Controls.Add(this.cmbProductSize);
            this.panel1.Controls.Add(this.cmbRightPanelCategory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1389, 147);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.Location = new System.Drawing.Point(495, 94);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 33);
            this.btnAdd.TabIndex = 1023;
            this.btnAdd.Text = "Get Data";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 1020;
            this.label5.Text = "Product";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 1021;
            this.label4.Text = "Product Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 1022;
            this.label3.Text = "Product Type";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Location = new System.Drawing.Point(728, 61);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(313, 22);
            this.txtFilterValue.TabIndex = 2;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
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
            this.lblRightPanelAvailableKgs.Visible = false;
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
            this.cmbFilterBy.Location = new System.Drawing.Point(728, 17);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(313, 26);
            this.cmbFilterBy.TabIndex = 1;
            this.cmbFilterBy.Visible = false;
            this.cmbFilterBy.SelectedValueChanged += new System.EventHandler(this.cmbRightPanelItemName_SelectedValueChanged);
            // 
            // cmbProduct
            // 
            this.cmbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProduct.DropDownHeight = 120;
            this.cmbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.IntegralHeight = false;
            this.cmbProduct.ItemHeight = 22;
            this.cmbProduct.Location = new System.Drawing.Point(170, 95);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(313, 30);
            this.cmbProduct.TabIndex = 0;
            this.cmbProduct.Visible = false;
            this.cmbProduct.SelectionChangeCommitted += new System.EventHandler(this.cmbRightPanelCategory_SelectionChangeCommitted);
            this.cmbProduct.SelectedValueChanged += new System.EventHandler(this.cmbRightPanelCategory_SelectedValueChanged);
            // 
            // cmbProductSize
            // 
            this.cmbProductSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductSize.DropDownHeight = 120;
            this.cmbProductSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductSize.FormattingEnabled = true;
            this.cmbProductSize.IntegralHeight = false;
            this.cmbProductSize.ItemHeight = 22;
            this.cmbProductSize.Location = new System.Drawing.Point(170, 59);
            this.cmbProductSize.Name = "cmbProductSize";
            this.cmbProductSize.Size = new System.Drawing.Size(313, 30);
            this.cmbProductSize.TabIndex = 0;
            this.cmbProductSize.SelectionChangeCommitted += new System.EventHandler(this.cmbProductSize_SelectionChangeCommitted);
            this.cmbProductSize.SelectedValueChanged += new System.EventHandler(this.cmbProductSize_SelectedValueChanged);
            // 
            // cmbRightPanelCategory
            // 
            this.cmbRightPanelCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRightPanelCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRightPanelCategory.DropDownHeight = 120;
            this.cmbRightPanelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRightPanelCategory.FormattingEnabled = true;
            this.cmbRightPanelCategory.IntegralHeight = false;
            this.cmbRightPanelCategory.ItemHeight = 22;
            this.cmbRightPanelCategory.Location = new System.Drawing.Point(170, 20);
            this.cmbRightPanelCategory.Name = "cmbRightPanelCategory";
            this.cmbRightPanelCategory.Size = new System.Drawing.Size(313, 30);
            this.cmbRightPanelCategory.TabIndex = 0;
            this.cmbRightPanelCategory.SelectionChangeCommitted += new System.EventHandler(this.cmbRightPanelCategory_SelectionChangeCommitted);
            this.cmbRightPanelCategory.SelectedValueChanged += new System.EventHandler(this.cmbRightPanelCategory_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Filter Value";
            this.label1.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(642, 23);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 17);
            this.label26.TabIndex = 33;
            this.label26.Text = "Filter By";
            this.label26.Visible = false;
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
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.ComboBox cmbRightPanelCategory;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblRightPanelAvailableKgs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgStock;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.ComboBox cmbProductSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
    }
}