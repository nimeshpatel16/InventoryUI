namespace SOUMCO.Forms
{
    partial class FrmUser
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GBCustomerInformation = new System.Windows.Forms.GroupBox();
            this.GbPermission = new System.Windows.Forms.GroupBox();
            this.OptYes = new System.Windows.Forms.RadioButton();
            this.OptNo = new System.Windows.Forms.RadioButton();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.gbChangePassword = new System.Windows.Forms.GroupBox();
            this.optYesChangePassword = new System.Windows.Forms.RadioButton();
            this.optNoChangePassword = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.GBCustomerInformation.SuspendLayout();
            this.GbPermission.SuspendLayout();
            this.gbChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveAndNew);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.GBCustomerInformation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 318);
            this.panel1.TabIndex = 5;
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Location = new System.Drawing.Point(216, 254);
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
            this.btnOk.Location = new System.Drawing.Point(124, 254);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(84, 28);
            this.btnOk.TabIndex = 1001;
            this.btnOk.Text = "&Save";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Location = new System.Drawing.Point(160, 32);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(297, 26);
            this.txtUserName.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(339, 254);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 1003;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // GBCustomerInformation
            // 
            this.GBCustomerInformation.Controls.Add(this.gbChangePassword);
            this.GBCustomerInformation.Controls.Add(this.GbPermission);
            this.GBCustomerInformation.Controls.Add(this.txtConfirmPassword);
            this.GBCustomerInformation.Controls.Add(this.label4);
            this.GBCustomerInformation.Controls.Add(this.txtPassword);
            this.GBCustomerInformation.Controls.Add(this.label1);
            this.GBCustomerInformation.Controls.Add(this.lblId);
            this.GBCustomerInformation.Location = new System.Drawing.Point(4, 4);
            this.GBCustomerInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBCustomerInformation.Name = "GBCustomerInformation";
            this.GBCustomerInformation.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBCustomerInformation.Size = new System.Drawing.Size(567, 218);
            this.GBCustomerInformation.TabIndex = 0;
            this.GBCustomerInformation.TabStop = false;
            // 
            // GbPermission
            // 
            this.GbPermission.Controls.Add(this.OptYes);
            this.GbPermission.Controls.Add(this.OptNo);
            this.GbPermission.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbPermission.Location = new System.Drawing.Point(156, 130);
            this.GbPermission.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GbPermission.Name = "GbPermission";
            this.GbPermission.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GbPermission.Size = new System.Drawing.Size(171, 68);
            this.GbPermission.TabIndex = 3;
            this.GbPermission.TabStop = false;
            this.GbPermission.Text = "Allow Edit && Delete";
            // 
            // OptYes
            // 
            this.OptYes.AutoSize = true;
            this.OptYes.Checked = true;
            this.OptYes.Location = new System.Drawing.Point(20, 36);
            this.OptYes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OptYes.Name = "OptYes";
            this.OptYes.Size = new System.Drawing.Size(57, 22);
            this.OptYes.TabIndex = 4;
            this.OptYes.TabStop = true;
            this.OptYes.Text = "Yes";
            this.OptYes.UseVisualStyleBackColor = true;
            // 
            // OptNo
            // 
            this.OptNo.AutoSize = true;
            this.OptNo.Location = new System.Drawing.Point(99, 36);
            this.OptNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OptNo.Name = "OptNo";
            this.OptNo.Size = new System.Drawing.Size(50, 22);
            this.OptNo.TabIndex = 5;
            this.OptNo.Text = "No";
            this.OptNo.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Location = new System.Drawing.Point(155, 96);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(297, 26);
            this.txtConfirmPassword.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(155, 62);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(298, 26);
            this.txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Password";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(136, 22);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 18);
            this.lblId.TabIndex = 27;
            this.lblId.Visible = false;
            // 
            // gbChangePassword
            // 
            this.gbChangePassword.Controls.Add(this.optYesChangePassword);
            this.gbChangePassword.Controls.Add(this.optNoChangePassword);
            this.gbChangePassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChangePassword.Location = new System.Drawing.Point(335, 130);
            this.gbChangePassword.Margin = new System.Windows.Forms.Padding(4);
            this.gbChangePassword.Name = "gbChangePassword";
            this.gbChangePassword.Padding = new System.Windows.Forms.Padding(4);
            this.gbChangePassword.Size = new System.Drawing.Size(184, 68);
            this.gbChangePassword.TabIndex = 3;
            this.gbChangePassword.TabStop = false;
            this.gbChangePassword.Text = "Change Password";
            // 
            // optYesChangePassword
            // 
            this.optYesChangePassword.AutoSize = true;
            this.optYesChangePassword.Location = new System.Drawing.Point(20, 27);
            this.optYesChangePassword.Margin = new System.Windows.Forms.Padding(4);
            this.optYesChangePassword.Name = "optYesChangePassword";
            this.optYesChangePassword.Size = new System.Drawing.Size(57, 22);
            this.optYesChangePassword.TabIndex = 4;
            this.optYesChangePassword.Text = "Yes";
            this.optYesChangePassword.UseVisualStyleBackColor = true;
            this.optYesChangePassword.CheckedChanged += new System.EventHandler(this.optYesChangePassword_CheckedChanged);
            // 
            // optNoChangePassword
            // 
            this.optNoChangePassword.AutoSize = true;
            this.optNoChangePassword.Checked = true;
            this.optNoChangePassword.Location = new System.Drawing.Point(99, 27);
            this.optNoChangePassword.Margin = new System.Windows.Forms.Padding(4);
            this.optNoChangePassword.Name = "optNoChangePassword";
            this.optNoChangePassword.Size = new System.Drawing.Size(50, 22);
            this.optNoChangePassword.TabIndex = 5;
            this.optNoChangePassword.TabStop = true;
            this.optNoChangePassword.Text = "No";
            this.optNoChangePassword.UseVisualStyleBackColor = true;
            this.optNoChangePassword.CheckedChanged += new System.EventHandler(this.optNoChangePassword_CheckedChanged);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 318);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Info";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GBCustomerInformation.ResumeLayout(false);
            this.GBCustomerInformation.PerformLayout();
            this.GbPermission.ResumeLayout(false);
            this.GbPermission.PerformLayout();
            this.gbChangePassword.ResumeLayout(false);
            this.gbChangePassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveAndNew;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GBCustomerInformation;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox GbPermission;
        private System.Windows.Forms.RadioButton OptYes;
        private System.Windows.Forms.RadioButton OptNo;
        private System.Windows.Forms.GroupBox gbChangePassword;
        private System.Windows.Forms.RadioButton optYesChangePassword;
        private System.Windows.Forms.RadioButton optNoChangePassword;

    }
}