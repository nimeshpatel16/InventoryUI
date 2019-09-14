namespace SOUMCO.Forms
{
    partial class frmProduct
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
            this.GBCustomerInformation = new System.Windows.Forms.GroupBox();
            this.cmbProductSize = new System.Windows.Forms.ComboBox();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveAndNew = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.GBCustomerInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBCustomerInformation
            // 
            this.GBCustomerInformation.Controls.Add(this.cmbProductSize);
            this.GBCustomerInformation.Controls.Add(this.cmbProductType);
            this.GBCustomerInformation.Controls.Add(this.label16);
            this.GBCustomerInformation.Controls.Add(this.label5);
            this.GBCustomerInformation.Controls.Add(this.lblId);
            this.GBCustomerInformation.Controls.Add(this.txtRemarks);
            this.GBCustomerInformation.Controls.Add(this.label3);
            this.GBCustomerInformation.Controls.Add(this.txtName);
            this.GBCustomerInformation.Controls.Add(this.label2);
            this.GBCustomerInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBCustomerInformation.Location = new System.Drawing.Point(13, 13);
            this.GBCustomerInformation.Margin = new System.Windows.Forms.Padding(4);
            this.GBCustomerInformation.Name = "GBCustomerInformation";
            this.GBCustomerInformation.Padding = new System.Windows.Forms.Padding(4);
            this.GBCustomerInformation.Size = new System.Drawing.Size(493, 172);
            this.GBCustomerInformation.TabIndex = 1;
            this.GBCustomerInformation.TabStop = false;
            // 
            // cmbProductSize
            // 
            this.cmbProductSize.FormattingEnabled = true;
            this.cmbProductSize.Location = new System.Drawing.Point(149, 52);
            this.cmbProductSize.Name = "cmbProductSize";
            this.cmbProductSize.Size = new System.Drawing.Size(324, 26);
            this.cmbProductSize.TabIndex = 4;
            // 
            // cmbProductType
            // 
            this.cmbProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(149, 22);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(324, 26);
            this.cmbProductType.TabIndex = 3;
            this.cmbProductType.SelectionChangeCommitted += new System.EventHandler(this.cmbProductType_SelectionChangeCommitted);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(39, 55);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 18);
            this.label16.TabIndex = 32;
            this.label16.Text = "Product Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Product Type";
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
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Location = new System.Drawing.Point(149, 119);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(324, 29);
            this.txtRemarks.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Remarks";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(149, 87);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(324, 24);
            this.txtName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Location = new System.Drawing.Point(264, 218);
            this.btnSaveAndNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(115, 28);
            this.btnSaveAndNew.TabIndex = 1005;
            this.btnSaveAndNew.Text = "Save && &New";
            this.btnSaveAndNew.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(156, 218);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 1004;
            this.btnOk.Text = "&Save";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(386, 218);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 1006;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 269);
            this.Controls.Add(this.btnSaveAndNew);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.GBCustomerInformation);
            this.Name = "frmProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.GBCustomerInformation.ResumeLayout(false);
            this.GBCustomerInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBCustomerInformation;
        private System.Windows.Forms.ComboBox cmbProductSize;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveAndNew;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}