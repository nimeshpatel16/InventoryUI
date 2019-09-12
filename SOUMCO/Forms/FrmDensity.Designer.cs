namespace SOUMCO.Forms
{
    partial class FrmDensity
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
            this.txtDensityValue = new System.Windows.Forms.TextBox();
            this.txtDensity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 266);
            this.panel1.TabIndex = 4;
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Location = new System.Drawing.Point(234, 225);
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
            this.btnOk.Location = new System.Drawing.Point(142, 225);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(84, 28);
            this.btnOk.TabIndex = 1001;
            this.btnOk.Text = "&Save";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(357, 225);
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
            this.GBCustomerInformation.Controls.Add(this.txtDensityValue);
            this.GBCustomerInformation.Controls.Add(this.txtDensity);
            this.GBCustomerInformation.Controls.Add(this.label1);
            this.GBCustomerInformation.Controls.Add(this.label5);
            this.GBCustomerInformation.Controls.Add(this.txtRemarks);
            this.GBCustomerInformation.Controls.Add(this.label3);
            this.GBCustomerInformation.Controls.Add(this.lblId);
            this.GBCustomerInformation.Location = new System.Drawing.Point(4, 4);
            this.GBCustomerInformation.Margin = new System.Windows.Forms.Padding(4);
            this.GBCustomerInformation.Name = "GBCustomerInformation";
            this.GBCustomerInformation.Padding = new System.Windows.Forms.Padding(4);
            this.GBCustomerInformation.Size = new System.Drawing.Size(475, 213);
            this.GBCustomerInformation.TabIndex = 0;
            this.GBCustomerInformation.TabStop = false;
            // 
            // txtDensityValue
            // 
            this.txtDensityValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDensityValue.Location = new System.Drawing.Point(138, 62);
            this.txtDensityValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtDensityValue.Name = "txtDensityValue";
            this.txtDensityValue.Size = new System.Drawing.Size(318, 26);
            this.txtDensityValue.TabIndex = 1;
            // 
            // txtDensity
            // 
            this.txtDensity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDensity.Location = new System.Drawing.Point(138, 29);
            this.txtDensity.Margin = new System.Windows.Forms.Padding(4);
            this.txtDensity.Name = "txtDensity";
            this.txtDensity.Size = new System.Drawing.Size(318, 26);
            this.txtDensity.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Value (i.e. 1.45)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Density";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Location = new System.Drawing.Point(138, 96);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(318, 84);
            this.txtRemarks.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Remarks";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(437, 38);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 18);
            this.lblId.TabIndex = 27;
            this.lblId.Visible = false;
            // 
            // FrmDensity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 266);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDensity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Density Info";
            this.Load += new System.EventHandler(this.FrmVehicle_Load);
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
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDensity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDensityValue;
        private System.Windows.Forms.Label label1;
    }
}