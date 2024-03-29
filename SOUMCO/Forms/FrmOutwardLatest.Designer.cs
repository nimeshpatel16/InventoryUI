﻿namespace SOUMCO.Forms
{
    partial class FrmOutwardLatest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.cmbProductSize = new System.Windows.Forms.ComboBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgInward = new System.Windows.Forms.DataGridView();
            this.dgcSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSaveAndNew = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblInwardEntry = new System.Windows.Forms.Label();
            this.pnlInward = new System.Windows.Forms.Panel();
            this.dgInwardForSheet = new System.Windows.Forms.DataGridView();
            this.dgcLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInward)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlInward.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInwardForSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.Location = new System.Drawing.Point(487, 160);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 33);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Get Data";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(412, 124);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 25);
            this.label10.TabIndex = 1019;
            this.label10.Text = "Length";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuantity.Location = new System.Drawing.Point(204, 160);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(118, 30);
            this.txtQuantity.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(109, 163);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 25);
            this.label9.TabIndex = 1019;
            this.label9.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(131, 124);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 25);
            this.label8.TabIndex = 1019;
            this.label8.Text = "Width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 1019;
            this.label5.Text = "Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 1019;
            this.label4.Text = "Product Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 1019;
            this.label3.Text = "Product Type";
            // 
            // cmbProduct
            // 
            this.cmbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(204, 81);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(401, 30);
            this.cmbProduct.TabIndex = 8;
            this.cmbProduct.Tag = "1";
            // 
            // cmbProductSize
            // 
            this.cmbProductSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductSize.FormattingEnabled = true;
            this.cmbProductSize.Location = new System.Drawing.Point(204, 44);
            this.cmbProductSize.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProductSize.Name = "cmbProductSize";
            this.cmbProductSize.Size = new System.Drawing.Size(401, 30);
            this.cmbProductSize.TabIndex = 7;
            this.cmbProductSize.Tag = "1";
            this.cmbProductSize.SelectedIndexChanged += new System.EventHandler(this.cmbProductSize_SelectedIndexChanged);
            this.cmbProductSize.SelectionChangeCommitted += new System.EventHandler(this.cmbProductSize_SelectionChangeCommitted);
            // 
            // txtWidth
            // 
            this.txtWidth.BackColor = System.Drawing.SystemColors.Window;
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtWidth.Location = new System.Drawing.Point(204, 121);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(4);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(118, 30);
            this.txtWidth.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgInward);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1407, 188);
            this.panel1.TabIndex = 1018;
            // 
            // dgInward
            // 
            this.dgInward.AllowUserToAddRows = false;
            this.dgInward.AllowUserToDeleteRows = false;
            this.dgInward.AllowUserToResizeColumns = false;
            this.dgInward.AllowUserToResizeRows = false;
            this.dgInward.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInward.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcSelect});
            this.dgInward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgInward.Location = new System.Drawing.Point(0, 0);
            this.dgInward.Margin = new System.Windows.Forms.Padding(4);
            this.dgInward.Name = "dgInward";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgInward.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgInward.Size = new System.Drawing.Size(1405, 186);
            this.dgInward.TabIndex = 12;
            // 
            // dgcSelect
            // 
            this.dgcSelect.HeaderText = "Select";
            this.dgcSelect.Name = "dgcSelect";
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndNew.Location = new System.Drawing.Point(1140, 7);
            this.btnSaveAndNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(133, 38);
            this.btnSaveAndNew.TabIndex = 1005;
            this.btnSaveAndNew.Tag = "1002";
            this.btnSaveAndNew.Text = "&Save && &New";
            this.btnSaveAndNew.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(1018, 7);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(101, 37);
            this.btnOk.TabIndex = 1004;
            this.btnOk.Tag = "1001";
            this.btnOk.Text = "&Save";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtLength
            // 
            this.txtLength.BackColor = System.Drawing.SystemColors.Window;
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLength.Location = new System.Drawing.Point(489, 121);
            this.txtLength.Margin = new System.Windows.Forms.Padding(4);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(112, 30);
            this.txtLength.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1292, 7);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 37);
            this.btnCancel.TabIndex = 1006;
            this.btnCancel.Tag = "1003";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbProductType
            // 
            this.cmbProductType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductType.Location = new System.Drawing.Point(204, 8);
            this.cmbProductType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(401, 30);
            this.cmbProductType.TabIndex = 6;
            this.cmbProductType.Tag = "1";
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            this.cmbProductType.SelectionChangeCommitted += new System.EventHandler(this.cmbProductType_SelectionChangeCommitted);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BottomPanel.Controls.Add(this.btnSaveAndNew);
            this.BottomPanel.Controls.Add(this.btnOk);
            this.BottomPanel.Controls.Add(this.btnCancel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 691);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1407, 65);
            this.BottomPanel.TabIndex = 1017;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(567, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 1021;
            this.label7.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(664, 11);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(484, 100);
            this.txtRemarks.TabIndex = 4;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(204, 11);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(348, 30);
            this.txtSupplierName.TabIndex = 1;
            // 
            // txtBillNo
            // 
            this.txtBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillNo.Location = new System.Drawing.Point(204, 47);
            this.txtBillNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(348, 30);
            this.txtBillNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 1019;
            this.label2.Text = "Customer Name";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CustomFormat = "dd/MM/yyyy";
            this.dtpInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(204, 82);
            this.dtpInvoiceDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(138, 30);
            this.dtpInvoiceDate.TabIndex = 3;
            this.dtpInvoiceDate.Tag = "3";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(908, 70);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 17);
            this.lblId.TabIndex = 1006;
            this.lblId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 1008;
            this.label1.Text = "Invoice No";
            // 
            // TopPanel
            // 
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.label7);
            this.TopPanel.Controls.Add(this.txtRemarks);
            this.TopPanel.Controls.Add(this.txtSupplierName);
            this.TopPanel.Controls.Add(this.txtBillNo);
            this.TopPanel.Controls.Add(this.label2);
            this.TopPanel.Controls.Add(this.dtpInvoiceDate);
            this.TopPanel.Controls.Add(this.lblId);
            this.TopPanel.Controls.Add(this.label6);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1407, 121);
            this.TopPanel.TabIndex = 1016;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtLength);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbProduct);
            this.panel2.Controls.Add(this.cmbProductSize);
            this.panel2.Controls.Add(this.cmbProductType);
            this.panel2.Controls.Add(this.txtWidth);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1407, 210);
            this.panel2.TabIndex = 5;
            // 
            // lblInwardEntry
            // 
            this.lblInwardEntry.AutoSize = true;
            this.lblInwardEntry.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblInwardEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInwardEntry.Location = new System.Drawing.Point(0, 516);
            this.lblInwardEntry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInwardEntry.Name = "lblInwardEntry";
            this.lblInwardEntry.Size = new System.Drawing.Size(120, 25);
            this.lblInwardEntry.TabIndex = 1019;
            this.lblInwardEntry.Text = "Inward Entry";
            this.lblInwardEntry.Click += new System.EventHandler(this.lblInwardEntry_Click);
            // 
            // pnlInward
            // 
            this.pnlInward.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInward.Controls.Add(this.dgInwardForSheet);
            this.pnlInward.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInward.Location = new System.Drawing.Point(0, 541);
            this.pnlInward.Name = "pnlInward";
            this.pnlInward.Size = new System.Drawing.Size(1407, 150);
            this.pnlInward.TabIndex = 1019;
            // 
            // dgInwardForSheet
            // 
            this.dgInwardForSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInwardForSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcLength,
            this.dgcWidth,
            this.dgcQuantity});
            this.dgInwardForSheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgInwardForSheet.Location = new System.Drawing.Point(0, 0);
            this.dgInwardForSheet.Name = "dgInwardForSheet";
            this.dgInwardForSheet.RowTemplate.Height = 24;
            this.dgInwardForSheet.Size = new System.Drawing.Size(1405, 148);
            this.dgInwardForSheet.TabIndex = 14;
            // 
            // dgcLength
            // 
            this.dgcLength.FillWeight = 200F;
            this.dgcLength.HeaderText = "Length";
            this.dgcLength.Name = "dgcLength";
            this.dgcLength.Width = 200;
            // 
            // dgcWidth
            // 
            this.dgcWidth.FillWeight = 200F;
            this.dgcWidth.HeaderText = "Width";
            this.dgcWidth.Name = "dgcWidth";
            this.dgcWidth.Width = 200;
            // 
            // dgcQuantity
            // 
            this.dgcQuantity.HeaderText = "Quantity";
            this.dgcQuantity.Name = "dgcQuantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 1008;
            this.label6.Text = "Invoice Date";
            // 
            // FrmOutwardLatest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 756);
            this.Controls.Add(this.lblInwardEntry);
            this.Controls.Add(this.pnlInward);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TopPanel);
            this.Name = "FrmOutwardLatest";
            this.Text = "Outward";
            this.Load += new System.EventHandler(this.FrmOutwardLatest_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInward)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlInward.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInwardForSheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.ComboBox cmbProductSize;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgInward;
        private System.Windows.Forms.Button btnSaveAndNew;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgcSelect;
        private System.Windows.Forms.Label lblInwardEntry;
        private System.Windows.Forms.Panel pnlInward;
        private System.Windows.Forms.DataGridView dgInwardForSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcQuantity;
        private System.Windows.Forms.Label label6;
    }
}