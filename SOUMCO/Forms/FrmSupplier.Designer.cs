namespace SOUMCO.Forms
{
    partial class FrmSupplier
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
            this.txtServiceNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtExciseNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPanNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTanNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtFaxNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCellNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.GBCustomerInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveAndNew);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.GBCustomerInformation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 569);
            this.panel1.TabIndex = 3;
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Location = new System.Drawing.Point(207, 529);
            this.btnSaveAndNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(115, 28);
            this.btnSaveAndNew.TabIndex = 1002;
            this.btnSaveAndNew.Text = "Save && &New";
            this.btnSaveAndNew.UseVisualStyleBackColor = true;
            this.btnSaveAndNew.Click += new System.EventHandler(this.btnSaveAndNew_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(116, 529);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 28);
            this.btnOk.TabIndex = 1001;
            this.btnOk.Text = "&Save";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(329, 529);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 1003;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GBCustomerInformation
            // 
            this.GBCustomerInformation.Controls.Add(this.cmbType);
            this.GBCustomerInformation.Controls.Add(this.txtServiceNo);
            this.GBCustomerInformation.Controls.Add(this.label11);
            this.GBCustomerInformation.Controls.Add(this.txtExciseNo);
            this.GBCustomerInformation.Controls.Add(this.label9);
            this.GBCustomerInformation.Controls.Add(this.txtPanNo);
            this.GBCustomerInformation.Controls.Add(this.label8);
            this.GBCustomerInformation.Controls.Add(this.txtTanNo);
            this.GBCustomerInformation.Controls.Add(this.label7);
            this.GBCustomerInformation.Controls.Add(this.label6);
            this.GBCustomerInformation.Controls.Add(this.txtZipCode);
            this.GBCustomerInformation.Controls.Add(this.txtFaxNo);
            this.GBCustomerInformation.Controls.Add(this.label1);
            this.GBCustomerInformation.Controls.Add(this.lblId);
            this.GBCustomerInformation.Controls.Add(this.label10);
            this.GBCustomerInformation.Controls.Add(this.txtCity);
            this.GBCustomerInformation.Controls.Add(this.txtCellNo);
            this.GBCustomerInformation.Controls.Add(this.label5);
            this.GBCustomerInformation.Controls.Add(this.txtPhNo);
            this.GBCustomerInformation.Controls.Add(this.label4);
            this.GBCustomerInformation.Controls.Add(this.txtAddress);
            this.GBCustomerInformation.Controls.Add(this.label3);
            this.GBCustomerInformation.Controls.Add(this.txtName);
            this.GBCustomerInformation.Controls.Add(this.label12);
            this.GBCustomerInformation.Controls.Add(this.label2);
            this.GBCustomerInformation.Location = new System.Drawing.Point(4, 4);
            this.GBCustomerInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBCustomerInformation.Name = "GBCustomerInformation";
            this.GBCustomerInformation.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBCustomerInformation.Size = new System.Drawing.Size(461, 512);
            this.GBCustomerInformation.TabIndex = 0;
            this.GBCustomerInformation.TabStop = false;
            // 
            // txtServiceNo
            // 
            this.txtServiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServiceNo.Location = new System.Drawing.Point(116, 393);
            this.txtServiceNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServiceNo.Name = "txtServiceNo";
            this.txtServiceNo.Size = new System.Drawing.Size(313, 26);
            this.txtServiceNo.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 395);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 18);
            this.label11.TabIndex = 38;
            this.label11.Text = "Service No";
            // 
            // txtExciseNo
            // 
            this.txtExciseNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExciseNo.Location = new System.Drawing.Point(116, 427);
            this.txtExciseNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExciseNo.Name = "txtExciseNo";
            this.txtExciseNo.Size = new System.Drawing.Size(313, 26);
            this.txtExciseNo.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 430);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 18);
            this.label9.TabIndex = 36;
            this.label9.Text = "Excise No";
            // 
            // txtPanNo
            // 
            this.txtPanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPanNo.Location = new System.Drawing.Point(116, 462);
            this.txtPanNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPanNo.Name = "txtPanNo";
            this.txtPanNo.Size = new System.Drawing.Size(313, 26);
            this.txtPanNo.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 464);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Pan No";
            // 
            // txtTanNo
            // 
            this.txtTanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTanNo.Location = new System.Drawing.Point(116, 358);
            this.txtTanNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTanNo.Name = "txtTanNo";
            this.txtTanNo.Size = new System.Drawing.Size(313, 26);
            this.txtTanNo.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 361);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 32;
            this.label7.Text = "Tan No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 222);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Zip Code";
            // 
            // txtZipCode
            // 
            this.txtZipCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZipCode.Location = new System.Drawing.Point(116, 219);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(313, 26);
            this.txtZipCode.TabIndex = 5;
            // 
            // txtFaxNo
            // 
            this.txtFaxNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFaxNo.Location = new System.Drawing.Point(116, 324);
            this.txtFaxNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFaxNo.Name = "txtFaxNo";
            this.txtFaxNo.Size = new System.Drawing.Size(313, 26);
            this.txtFaxNo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Fax. No";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(496, 33);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 18);
            this.lblId.TabIndex = 27;
            this.lblId.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 187);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Location = new System.Drawing.Point(116, 185);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(313, 26);
            this.txtCity.TabIndex = 4;
            // 
            // txtCellNo
            // 
            this.txtCellNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCellNo.Location = new System.Drawing.Point(116, 289);
            this.txtCellNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCellNo.Name = "txtCellNo";
            this.txtCellNo.Size = new System.Drawing.Size(313, 26);
            this.txtCellNo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cell. No";
            // 
            // txtPhNo
            // 
            this.txtPhNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhNo.Location = new System.Drawing.Point(116, 255);
            this.txtPhNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhNo.Name = "txtPhNo";
            this.txtPhNo.Size = new System.Drawing.Size(313, 26);
            this.txtPhNo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "PH. No";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(116, 89);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(313, 88);
            this.txtAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(116, 55);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(313, 26);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 23);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Customer",
            "Supplier"});
            this.cmbType.Location = new System.Drawing.Point(116, 22);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(313, 26);
            this.cmbType.TabIndex = 1;
            // 
            // FrmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 569);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Info";
            this.Load += new System.EventHandler(this.FrmSupplier_Load);
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
        private System.Windows.Forms.TextBox txtFaxNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCellNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtServiceNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtExciseNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPanNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTanNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbType;
    }
}