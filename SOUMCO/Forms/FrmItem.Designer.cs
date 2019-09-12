namespace SOUMCO.Forms
{
    partial class FrmItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveAndNew = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.GBCustomerInformation = new System.Windows.Forms.GroupBox();
            this.txtOpSize = new System.Windows.Forms.TextBox();
            this.txtOpThickness = new System.Windows.Forms.TextBox();
            this.txtOpID = new System.Windows.Forms.TextBox();
            this.txtOpOD = new System.Windows.Forms.TextBox();
            this.txtOpDiameter = new System.Windows.Forms.TextBox();
            this.txtOpWidth = new System.Windows.Forms.TextBox();
            this.txtOpLength = new System.Windows.Forms.TextBox();
            this.txtOpMeter = new System.Windows.Forms.TextBox();
            this.txtOpKgs = new System.Windows.Forms.TextBox();
            this.txtOpStockNos = new System.Windows.Forms.TextBox();
            this.cmbDensity = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOpStockValue = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSubCategory = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.GBCustomerInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnSaveAndNew);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.GBCustomerInformation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 741);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Location = new System.Drawing.Point(181, 689);
            this.btnSaveAndNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(115, 28);
            this.btnSaveAndNew.TabIndex = 1002;
            this.btnSaveAndNew.Text = "Save && &New";
            this.btnSaveAndNew.UseVisualStyleBackColor = true;
            this.btnSaveAndNew.Click += new System.EventHandler(this.btnSaveAndNew_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(73, 689);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 1001;
            this.btnOk.Text = "&Save";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(303, 689);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 1003;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GBCustomerInformation
            // 
            this.GBCustomerInformation.Controls.Add(this.txtOpSize);
            this.GBCustomerInformation.Controls.Add(this.txtOpThickness);
            this.GBCustomerInformation.Controls.Add(this.txtOpID);
            this.GBCustomerInformation.Controls.Add(this.txtOpOD);
            this.GBCustomerInformation.Controls.Add(this.txtOpDiameter);
            this.GBCustomerInformation.Controls.Add(this.txtOpWidth);
            this.GBCustomerInformation.Controls.Add(this.txtOpLength);
            this.GBCustomerInformation.Controls.Add(this.txtOpMeter);
            this.GBCustomerInformation.Controls.Add(this.txtOpKgs);
            this.GBCustomerInformation.Controls.Add(this.txtOpStockNos);
            this.GBCustomerInformation.Controls.Add(this.cmbDensity);
            this.GBCustomerInformation.Controls.Add(this.cmbSubCategory);
            this.GBCustomerInformation.Controls.Add(this.cmbCategory);
            this.GBCustomerInformation.Controls.Add(this.label13);
            this.GBCustomerInformation.Controls.Add(this.label16);
            this.GBCustomerInformation.Controls.Add(this.label5);
            this.GBCustomerInformation.Controls.Add(this.label4);
            this.GBCustomerInformation.Controls.Add(this.txtOpStockValue);
            this.GBCustomerInformation.Controls.Add(this.label18);
            this.GBCustomerInformation.Controls.Add(this.label17);
            this.GBCustomerInformation.Controls.Add(this.label15);
            this.GBCustomerInformation.Controls.Add(this.label14);
            this.GBCustomerInformation.Controls.Add(this.label12);
            this.GBCustomerInformation.Controls.Add(this.label11);
            this.GBCustomerInformation.Controls.Add(this.label9);
            this.GBCustomerInformation.Controls.Add(this.label8);
            this.GBCustomerInformation.Controls.Add(this.label7);
            this.GBCustomerInformation.Controls.Add(this.label6);
            this.GBCustomerInformation.Controls.Add(this.label1);
            this.GBCustomerInformation.Controls.Add(this.lblId);
            this.GBCustomerInformation.Controls.Add(this.label10);
            this.GBCustomerInformation.Controls.Add(this.txtRate);
            this.GBCustomerInformation.Controls.Add(this.txtRemarks);
            this.GBCustomerInformation.Controls.Add(this.label3);
            this.GBCustomerInformation.Controls.Add(this.txtName);
            this.GBCustomerInformation.Controls.Add(this.label2);
            this.GBCustomerInformation.Location = new System.Drawing.Point(4, 4);
            this.GBCustomerInformation.Margin = new System.Windows.Forms.Padding(4);
            this.GBCustomerInformation.Name = "GBCustomerInformation";
            this.GBCustomerInformation.Padding = new System.Windows.Forms.Padding(4);
            this.GBCustomerInformation.Size = new System.Drawing.Size(517, 664);
            this.GBCustomerInformation.TabIndex = 0;
            this.GBCustomerInformation.TabStop = false;
            // 
            // txtOpSize
            // 
            this.txtOpSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpSize.Location = new System.Drawing.Point(149, 587);
            this.txtOpSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpSize.Name = "txtOpSize";
            this.txtOpSize.Size = new System.Drawing.Size(169, 26);
            this.txtOpSize.TabIndex = 17;
            this.txtOpSize.Text = "0.00";
            this.txtOpSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOpThickness
            // 
            this.txtOpThickness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpThickness.Location = new System.Drawing.Point(149, 553);
            this.txtOpThickness.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpThickness.Name = "txtOpThickness";
            this.txtOpThickness.Size = new System.Drawing.Size(169, 26);
            this.txtOpThickness.TabIndex = 16;
            this.txtOpThickness.Text = "0.00";
            this.txtOpThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOpID
            // 
            this.txtOpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpID.Location = new System.Drawing.Point(149, 519);
            this.txtOpID.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpID.Name = "txtOpID";
            this.txtOpID.Size = new System.Drawing.Size(169, 26);
            this.txtOpID.TabIndex = 15;
            this.txtOpID.Text = "0.00";
            this.txtOpID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOpOD
            // 
            this.txtOpOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpOD.Location = new System.Drawing.Point(149, 485);
            this.txtOpOD.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpOD.Name = "txtOpOD";
            this.txtOpOD.Size = new System.Drawing.Size(169, 26);
            this.txtOpOD.TabIndex = 14;
            this.txtOpOD.Text = "0.00";
            this.txtOpOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOpDiameter
            // 
            this.txtOpDiameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpDiameter.Location = new System.Drawing.Point(149, 451);
            this.txtOpDiameter.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpDiameter.Name = "txtOpDiameter";
            this.txtOpDiameter.Size = new System.Drawing.Size(169, 26);
            this.txtOpDiameter.TabIndex = 13;
            this.txtOpDiameter.Text = "0.00";
            this.txtOpDiameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOpWidth
            // 
            this.txtOpWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpWidth.Location = new System.Drawing.Point(149, 417);
            this.txtOpWidth.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpWidth.Name = "txtOpWidth";
            this.txtOpWidth.Size = new System.Drawing.Size(169, 26);
            this.txtOpWidth.TabIndex = 12;
            this.txtOpWidth.Text = "0.00";
            this.txtOpWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOpLength
            // 
            this.txtOpLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpLength.Location = new System.Drawing.Point(149, 383);
            this.txtOpLength.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpLength.Name = "txtOpLength";
            this.txtOpLength.Size = new System.Drawing.Size(169, 26);
            this.txtOpLength.TabIndex = 11;
            this.txtOpLength.Text = "0.00";
            this.txtOpLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOpMeter
            // 
            this.txtOpMeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpMeter.Location = new System.Drawing.Point(149, 349);
            this.txtOpMeter.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpMeter.Name = "txtOpMeter";
            this.txtOpMeter.Size = new System.Drawing.Size(169, 26);
            this.txtOpMeter.TabIndex = 10;
            this.txtOpMeter.Text = "0.00";
            this.txtOpMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOpMeter.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtOpKgs
            // 
            this.txtOpKgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpKgs.Location = new System.Drawing.Point(149, 315);
            this.txtOpKgs.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpKgs.Name = "txtOpKgs";
            this.txtOpKgs.Size = new System.Drawing.Size(169, 26);
            this.txtOpKgs.TabIndex = 9;
            this.txtOpKgs.Text = "0.00";
            this.txtOpKgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOpStockNos
            // 
            this.txtOpStockNos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpStockNos.Location = new System.Drawing.Point(149, 281);
            this.txtOpStockNos.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpStockNos.Name = "txtOpStockNos";
            this.txtOpStockNos.Size = new System.Drawing.Size(169, 26);
            this.txtOpStockNos.TabIndex = 8;
            this.txtOpStockNos.Text = "0.00";
            this.txtOpStockNos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbDensity
            // 
            this.cmbDensity.FormattingEnabled = true;
            this.cmbDensity.Location = new System.Drawing.Point(149, 135);
            this.cmbDensity.Name = "cmbDensity";
            this.cmbDensity.Size = new System.Drawing.Size(313, 26);
            this.cmbDensity.TabIndex = 5;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(149, 65);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(313, 26);
            this.cmbCategory.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 135);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 18);
            this.label13.TabIndex = 32;
            this.label13.Text = "Density";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 623);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Op Stock Value";
            // 
            // txtOpStockValue
            // 
            this.txtOpStockValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpStockValue.Location = new System.Drawing.Point(149, 621);
            this.txtOpStockValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpStockValue.Name = "txtOpStockValue";
            this.txtOpStockValue.Size = new System.Drawing.Size(169, 26);
            this.txtOpStockValue.TabIndex = 18;
            this.txtOpStockValue.Text = "0.00";
            this.txtOpStockValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(108, 589);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 18);
            this.label18.TabIndex = 29;
            this.label18.Text = "Size";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(108, 561);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 18);
            this.label17.TabIndex = 29;
            this.label17.Text = "Thick";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(108, 527);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 18);
            this.label15.TabIndex = 29;
            this.label15.Text = "ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(107, 487);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 18);
            this.label14.TabIndex = 29;
            this.label14.Text = "OD";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(108, 453);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 18);
            this.label12.TabIndex = 29;
            this.label12.Text = "Dia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(108, 419);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 18);
            this.label11.TabIndex = 29;
            this.label11.Text = "W";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 385);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "L";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 351);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "Mtr";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 317);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "Kgs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 283);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 281);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Op Stock";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(437, 31);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 18);
            this.lblId.TabIndex = 27;
            this.lblId.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 168);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Rate";
            // 
            // txtRate
            // 
            this.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRate.Location = new System.Drawing.Point(149, 168);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(169, 26);
            this.txtRate.TabIndex = 6;
            this.txtRate.Text = "0.00";
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Location = new System.Drawing.Point(149, 202);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(313, 71);
            this.txtRemarks.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Remarks";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(149, 31);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(313, 26);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name";
            // 
            // cmbSubCategory
            // 
            this.cmbSubCategory.FormattingEnabled = true;
            this.cmbSubCategory.Location = new System.Drawing.Point(149, 100);
            this.cmbSubCategory.Name = "cmbSubCategory";
            this.cmbSubCategory.Size = new System.Drawing.Size(313, 26);
            this.cmbSubCategory.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 103);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 18);
            this.label16.TabIndex = 32;
            this.label16.Text = "Sub Category";
            // 
            // FrmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 741);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Info";
            this.Load += new System.EventHandler(this.FrmItem_Load);
            this.panel1.ResumeLayout(false);
            this.GBCustomerInformation.ResumeLayout(false);
            this.GBCustomerInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveAndNew;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox GBCustomerInformation;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOpStockValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOpStockNos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtOpThickness;
        private System.Windows.Forms.TextBox txtOpID;
        private System.Windows.Forms.TextBox txtOpOD;
        private System.Windows.Forms.TextBox txtOpDiameter;
        private System.Windows.Forms.TextBox txtOpWidth;
        private System.Windows.Forms.TextBox txtOpLength;
        private System.Windows.Forms.TextBox txtOpMeter;
        private System.Windows.Forms.TextBox txtOpKgs;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOpSize;
        private System.Windows.Forms.ComboBox cmbDensity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbSubCategory;
        private System.Windows.Forms.Label label16;
    }
}