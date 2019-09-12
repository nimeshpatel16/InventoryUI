namespace SOUMCO.Forms
{
    partial class FrmRegister
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
            this.GBInwardReg = new System.Windows.Forms.GroupBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.CmbSupplier = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.GBVehicleWiseTxn = new System.Windows.Forms.GroupBox();
            this.dtpToDateVehicleWise = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDateVehicleWise = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbVehicle = new System.Windows.Forms.ComboBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblVehicleNo = new System.Windows.Forms.Label();
            this.GBInwardReg.SuspendLayout();
            this.GBVehicleWiseTxn.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBInwardReg
            // 
            this.GBInwardReg.Controls.Add(this.dtpToDate);
            this.GBInwardReg.Controls.Add(this.dtpFromDate);
            this.GBInwardReg.Controls.Add(this.label3);
            this.GBInwardReg.Controls.Add(this.label2);
            this.GBInwardReg.Controls.Add(this.cmbCompany);
            this.GBInwardReg.Controls.Add(this.CmbSupplier);
            this.GBInwardReg.Controls.Add(this.label4);
            this.GBInwardReg.Controls.Add(this.label1);
            this.GBInwardReg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBInwardReg.Location = new System.Drawing.Point(6, 5);
            this.GBInwardReg.Name = "GBInwardReg";
            this.GBInwardReg.Size = new System.Drawing.Size(375, 137);
            this.GBInwardReg.TabIndex = 0;
            this.GBInwardReg.TabStop = false;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(109, 107);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(91, 22);
            this.dtpToDate.TabIndex = 1009;
            this.dtpToDate.Tag = "3";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(109, 77);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(91, 22);
            this.dtpFromDate.TabIndex = 1009;
            this.dtpFromDate.Tag = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 14);
            this.label3.TabIndex = 1010;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 14);
            this.label2.TabIndex = 1010;
            this.label2.Text = "From";
            // 
            // cmbCompany
            // 
            this.cmbCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Items.AddRange(new object[] {
            "All",
            "Suresh Oil Feild Units & Maintance Co.",
            "Jaytech Engineer Pvt Ltd.",
            "K P Parikh & Co.",
            "Shreeji Engineers."});
            this.cmbCompany.Location = new System.Drawing.Point(109, 21);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(243, 22);
            this.cmbCompany.TabIndex = 2;
            this.cmbCompany.Tag = "1";
            // 
            // CmbSupplier
            // 
            this.CmbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbSupplier.FormattingEnabled = true;
            this.CmbSupplier.Location = new System.Drawing.Point(109, 49);
            this.CmbSupplier.Name = "CmbSupplier";
            this.CmbSupplier.Size = new System.Drawing.Size(243, 22);
            this.CmbSupplier.TabIndex = 2;
            this.CmbSupplier.Tag = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(202, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 23);
            this.btnCancel.TabIndex = 1004;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(111, 162);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(63, 23);
            this.btnOk.TabIndex = 1003;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // GBVehicleWiseTxn
            // 
            this.GBVehicleWiseTxn.Controls.Add(this.lblVehicleNo);
            this.GBVehicleWiseTxn.Controls.Add(this.dtpToDateVehicleWise);
            this.GBVehicleWiseTxn.Controls.Add(this.dtpFromDateVehicleWise);
            this.GBVehicleWiseTxn.Controls.Add(this.label5);
            this.GBVehicleWiseTxn.Controls.Add(this.label6);
            this.GBVehicleWiseTxn.Controls.Add(this.cmbVehicle);
            this.GBVehicleWiseTxn.Controls.Add(this.cmbItem);
            this.GBVehicleWiseTxn.Controls.Add(this.label7);
            this.GBVehicleWiseTxn.Controls.Add(this.label8);
            this.GBVehicleWiseTxn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBVehicleWiseTxn.Location = new System.Drawing.Point(7, 5);
            this.GBVehicleWiseTxn.Name = "GBVehicleWiseTxn";
            this.GBVehicleWiseTxn.Size = new System.Drawing.Size(375, 137);
            this.GBVehicleWiseTxn.TabIndex = 1005;
            this.GBVehicleWiseTxn.TabStop = false;
            // 
            // dtpToDateVehicleWise
            // 
            this.dtpToDateVehicleWise.CustomFormat = "dd/MM/yyyy";
            this.dtpToDateVehicleWise.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDateVehicleWise.Location = new System.Drawing.Point(80, 107);
            this.dtpToDateVehicleWise.Name = "dtpToDateVehicleWise";
            this.dtpToDateVehicleWise.Size = new System.Drawing.Size(91, 22);
            this.dtpToDateVehicleWise.TabIndex = 1009;
            this.dtpToDateVehicleWise.Tag = "3";
            // 
            // dtpFromDateVehicleWise
            // 
            this.dtpFromDateVehicleWise.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDateVehicleWise.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDateVehicleWise.Location = new System.Drawing.Point(80, 77);
            this.dtpFromDateVehicleWise.Name = "dtpFromDateVehicleWise";
            this.dtpFromDateVehicleWise.Size = new System.Drawing.Size(91, 22);
            this.dtpFromDateVehicleWise.TabIndex = 1009;
            this.dtpFromDateVehicleWise.Tag = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 14);
            this.label5.TabIndex = 1010;
            this.label5.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 14);
            this.label6.TabIndex = 1010;
            this.label6.Text = "From";
            // 
            // cmbVehicle
            // 
            this.cmbVehicle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbVehicle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVehicle.FormattingEnabled = true;
            this.cmbVehicle.Items.AddRange(new object[] {
            "All",
            "Suresh Oil Feild Units & Maintance Co.",
            "Jaytech Engineer Pvt Ltd.",
            "K P Parikh & Co.",
            "Shreeji Engineers."});
            this.cmbVehicle.Location = new System.Drawing.Point(80, 21);
            this.cmbVehicle.Name = "cmbVehicle";
            this.cmbVehicle.Size = new System.Drawing.Size(91, 22);
            this.cmbVehicle.TabIndex = 2;
            this.cmbVehicle.Tag = "1";
            this.cmbVehicle.SelectionChangeCommitted += new System.EventHandler(this.cmbVehicle_SelectionChangeCommitted);
            // 
            // cmbItem
            // 
            this.cmbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(80, 49);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(243, 22);
            this.cmbItem.TabIndex = 2;
            this.cmbItem.Tag = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "Vehicle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "Item Name";
            // 
            // lblVehicleNo
            // 
            this.lblVehicleNo.AutoSize = true;
            this.lblVehicleNo.Location = new System.Drawing.Point(185, 24);
            this.lblVehicleNo.Name = "lblVehicleNo";
            this.lblVehicleNo.Size = new System.Drawing.Size(0, 14);
            this.lblVehicleNo.TabIndex = 1011;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 193);
            this.Controls.Add(this.GBVehicleWiseTxn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.GBInwardReg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.GBInwardReg.ResumeLayout(false);
            this.GBInwardReg.PerformLayout();
            this.GBVehicleWiseTxn.ResumeLayout(false);
            this.GBVehicleWiseTxn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBInwardReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSupplier;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox GBVehicleWiseTxn;
        private System.Windows.Forms.DateTimePicker dtpToDateVehicleWise;
        private System.Windows.Forms.DateTimePicker dtpFromDateVehicleWise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbVehicle;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblVehicleNo;
    }
}