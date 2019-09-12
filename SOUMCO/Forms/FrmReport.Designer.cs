namespace SOUMCO.Forms
{
    partial class FrmReport
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.GBVehicleWiseItemWiseTran = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.dtpToDate1 = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate1 = new System.Windows.Forms.DateTimePicker();
            this.cmbVehicleItemWise = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GBVehiclewiseTran = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.cmbVehicle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveAndNew = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GBCustomerInformation = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.GBVehicleWiseItemWiseTran.SuspendLayout();
            this.GBVehiclewiseTran.SuspendLayout();
            this.panel2.SuspendLayout();
            this.GBCustomerInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.GBVehicleWiseItemWiseTran);
            this.panel1.Controls.Add(this.GBVehiclewiseTran);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 198);
            this.panel1.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(149, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(61, 23);
            this.btnCancel.TabIndex = 1033;
            this.btnCancel.Tag = "1001";
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(70, 167);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(61, 23);
            this.btnOk.TabIndex = 1032;
            this.btnOk.Tag = "1001";
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // GBVehicleWiseItemWiseTran
            // 
            this.GBVehicleWiseItemWiseTran.Controls.Add(this.label8);
            this.GBVehicleWiseItemWiseTran.Controls.Add(this.label7);
            this.GBVehicleWiseItemWiseTran.Controls.Add(this.cmbItem);
            this.GBVehicleWiseItemWiseTran.Controls.Add(this.dtpToDate1);
            this.GBVehicleWiseItemWiseTran.Controls.Add(this.dtpFromDate1);
            this.GBVehicleWiseItemWiseTran.Controls.Add(this.cmbVehicleItemWise);
            this.GBVehicleWiseItemWiseTran.Controls.Add(this.label4);
            this.GBVehicleWiseItemWiseTran.Controls.Add(this.label5);
            this.GBVehicleWiseItemWiseTran.Controls.Add(this.label6);
            this.GBVehicleWiseItemWiseTran.Location = new System.Drawing.Point(5, 5);
            this.GBVehicleWiseItemWiseTran.Name = "GBVehicleWiseItemWiseTran";
            this.GBVehicleWiseItemWiseTran.Size = new System.Drawing.Size(342, 155);
            this.GBVehicleWiseItemWiseTran.TabIndex = 3;
            this.GBVehicleWiseItemWiseTran.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 14);
            this.label8.TabIndex = 1034;
            this.label8.Text = "Item";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 14);
            this.label7.TabIndex = 1033;
            this.label7.Text = "Vehicle No";
            // 
            // cmbItem
            // 
            this.cmbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(80, 50);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(243, 22);
            this.cmbItem.TabIndex = 1030;
            this.cmbItem.Tag = "1";
            // 
            // dtpToDate1
            // 
            this.dtpToDate1.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate1.Location = new System.Drawing.Point(80, 120);
            this.dtpToDate1.Name = "dtpToDate1";
            this.dtpToDate1.Size = new System.Drawing.Size(91, 22);
            this.dtpToDate1.TabIndex = 1029;
            this.dtpToDate1.Tag = "2";
            // 
            // dtpFromDate1
            // 
            this.dtpFromDate1.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate1.Location = new System.Drawing.Point(80, 82);
            this.dtpFromDate1.Name = "dtpFromDate1";
            this.dtpFromDate1.Size = new System.Drawing.Size(91, 22);
            this.dtpFromDate1.TabIndex = 1028;
            this.dtpFromDate1.Tag = "2";
            // 
            // cmbVehicleItemWise
            // 
            this.cmbVehicleItemWise.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbVehicleItemWise.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVehicleItemWise.FormattingEnabled = true;
            this.cmbVehicleItemWise.Location = new System.Drawing.Point(80, 22);
            this.cmbVehicleItemWise.Name = "cmbVehicleItemWise";
            this.cmbVehicleItemWise.Size = new System.Drawing.Size(243, 22);
            this.cmbVehicleItemWise.TabIndex = 1026;
            this.cmbVehicleItemWise.Tag = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "To Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 14);
            this.label5.TabIndex = 28;
            this.label5.Text = "From Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 14);
            this.label6.TabIndex = 27;
            this.label6.Visible = false;
            // 
            // GBVehiclewiseTran
            // 
            this.GBVehiclewiseTran.Controls.Add(this.label2);
            this.GBVehiclewiseTran.Controls.Add(this.dtpToDate);
            this.GBVehiclewiseTran.Controls.Add(this.dtpFromDate);
            this.GBVehiclewiseTran.Controls.Add(this.cmbVehicle);
            this.GBVehiclewiseTran.Controls.Add(this.label3);
            this.GBVehiclewiseTran.Controls.Add(this.label1);
            this.GBVehiclewiseTran.Controls.Add(this.lblId);
            this.GBVehiclewiseTran.Location = new System.Drawing.Point(12, 12);
            this.GBVehiclewiseTran.Name = "GBVehiclewiseTran";
            this.GBVehiclewiseTran.Size = new System.Drawing.Size(328, 138);
            this.GBVehiclewiseTran.TabIndex = 0;
            this.GBVehiclewiseTran.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 1032;
            this.label2.Text = "Vehicle No";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(80, 99);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(91, 22);
            this.dtpToDate.TabIndex = 1029;
            this.dtpToDate.Tag = "2";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(80, 61);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(91, 22);
            this.dtpFromDate.TabIndex = 1028;
            this.dtpFromDate.Tag = "2";
            // 
            // cmbVehicle
            // 
            this.cmbVehicle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbVehicle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVehicle.FormattingEnabled = true;
            this.cmbVehicle.Location = new System.Drawing.Point(80, 22);
            this.cmbVehicle.Name = "cmbVehicle";
            this.cmbVehicle.Size = new System.Drawing.Size(243, 22);
            this.cmbVehicle.TabIndex = 1026;
            this.cmbVehicle.Tag = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "To Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 14);
            this.label1.TabIndex = 28;
            this.label1.Text = "From Date";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(328, 31);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 14);
            this.lblId.TabIndex = 27;
            this.lblId.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnSaveAndNew);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.GBCustomerInformation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 405);
            this.panel2.TabIndex = 5;
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Location = new System.Drawing.Point(131, 293);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(86, 23);
            this.btnSaveAndNew.TabIndex = 1002;
            this.btnSaveAndNew.Text = "Save && &New";
            this.btnSaveAndNew.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1001;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1003;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // GBCustomerInformation
            // 
            this.GBCustomerInformation.Controls.Add(this.label12);
            this.GBCustomerInformation.Location = new System.Drawing.Point(3, 3);
            this.GBCustomerInformation.Name = "GBCustomerInformation";
            this.GBCustomerInformation.Size = new System.Drawing.Size(388, 275);
            this.GBCustomerInformation.TabIndex = 0;
            this.GBCustomerInformation.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(328, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 14);
            this.label12.TabIndex = 27;
            this.label12.Visible = false;
            // 
            // FrmReport
            // 
            this.ClientSize = new System.Drawing.Size(396, 405);
            this.Controls.Add(this.panel2);
            this.Name = "FrmReport";
            this.panel1.ResumeLayout(false);
            this.GBVehicleWiseItemWiseTran.ResumeLayout(false);
            this.GBVehicleWiseItemWiseTran.PerformLayout();
            this.GBVehiclewiseTran.ResumeLayout(false);
            this.GBVehiclewiseTran.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.GBCustomerInformation.ResumeLayout(false);
            this.GBCustomerInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GBVehiclewiseTran;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.ComboBox cmbVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBVehicleWiseItemWiseTran;
        private System.Windows.Forms.DateTimePicker dtpToDate1;
        private System.Windows.Forms.DateTimePicker dtpFromDate1;
        private System.Windows.Forms.ComboBox cmbVehicleItemWise;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSaveAndNew;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox GBCustomerInformation;
        private System.Windows.Forms.Label label12;
    }
}