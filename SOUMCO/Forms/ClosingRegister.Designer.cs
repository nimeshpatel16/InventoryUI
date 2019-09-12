namespace SOUMCO.Forms
{
    partial class ClosingRegister
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.GBClosingStockSummary = new System.Windows.Forms.GroupBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GBInwOutSumm = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpToInwOutSumm = new System.Windows.Forms.DateTimePicker();
            this.dtpFromInwOutSumm = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbItemInwOutSumm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GBClosingStockSummary.SuspendLayout();
            this.GBInwOutSumm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(196, 114);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 23);
            this.btnCancel.TabIndex = 1007;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(104, 114);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(63, 23);
            this.btnOk.TabIndex = 1006;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // GBClosingStockSummary
            // 
            this.GBClosingStockSummary.Controls.Add(this.dtpToDate);
            this.GBClosingStockSummary.Controls.Add(this.label2);
            this.GBClosingStockSummary.Controls.Add(this.cmbItem);
            this.GBClosingStockSummary.Controls.Add(this.label1);
            this.GBClosingStockSummary.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBClosingStockSummary.Location = new System.Drawing.Point(12, 2);
            this.GBClosingStockSummary.Name = "GBClosingStockSummary";
            this.GBClosingStockSummary.Size = new System.Drawing.Size(375, 75);
            this.GBClosingStockSummary.TabIndex = 1005;
            this.GBClosingStockSummary.TabStop = false;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(109, 43);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(91, 22);
            this.dtpToDate.TabIndex = 1009;
            this.dtpToDate.Tag = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 1010;
            this.label2.Text = "As of";
            // 
            // cmbItem
            // 
            this.cmbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(109, 15);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(243, 22);
            this.cmbItem.TabIndex = 2;
            this.cmbItem.Tag = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // GBInwOutSumm
            // 
            this.GBInwOutSumm.Controls.Add(this.label5);
            this.GBInwOutSumm.Controls.Add(this.dtpToInwOutSumm);
            this.GBInwOutSumm.Controls.Add(this.dtpFromInwOutSumm);
            this.GBInwOutSumm.Controls.Add(this.label3);
            this.GBInwOutSumm.Controls.Add(this.cmbItemInwOutSumm);
            this.GBInwOutSumm.Controls.Add(this.label4);
            this.GBInwOutSumm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBInwOutSumm.Location = new System.Drawing.Point(9, 2);
            this.GBInwOutSumm.Name = "GBInwOutSumm";
            this.GBInwOutSumm.Size = new System.Drawing.Size(375, 99);
            this.GBInwOutSumm.TabIndex = 1008;
            this.GBInwOutSumm.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 14);
            this.label5.TabIndex = 1012;
            this.label5.Text = "To";
            // 
            // dtpToInwOutSumm
            // 
            this.dtpToInwOutSumm.CustomFormat = "dd/MM/yyyy";
            this.dtpToInwOutSumm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToInwOutSumm.Location = new System.Drawing.Point(109, 71);
            this.dtpToInwOutSumm.Name = "dtpToInwOutSumm";
            this.dtpToInwOutSumm.Size = new System.Drawing.Size(91, 22);
            this.dtpToInwOutSumm.TabIndex = 1011;
            this.dtpToInwOutSumm.Tag = "3";
            // 
            // dtpFromInwOutSumm
            // 
            this.dtpFromInwOutSumm.CustomFormat = "dd/MM/yyyy";
            this.dtpFromInwOutSumm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromInwOutSumm.Location = new System.Drawing.Point(109, 43);
            this.dtpFromInwOutSumm.Name = "dtpFromInwOutSumm";
            this.dtpFromInwOutSumm.Size = new System.Drawing.Size(91, 22);
            this.dtpFromInwOutSumm.TabIndex = 1009;
            this.dtpFromInwOutSumm.Tag = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 14);
            this.label3.TabIndex = 1010;
            this.label3.Text = "From";
            // 
            // cmbItemInwOutSumm
            // 
            this.cmbItemInwOutSumm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbItemInwOutSumm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItemInwOutSumm.FormattingEnabled = true;
            this.cmbItemInwOutSumm.Location = new System.Drawing.Point(109, 15);
            this.cmbItemInwOutSumm.Name = "cmbItemInwOutSumm";
            this.cmbItemInwOutSumm.Size = new System.Drawing.Size(243, 22);
            this.cmbItemInwOutSumm.TabIndex = 2;
            this.cmbItemInwOutSumm.Tag = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Item Name";
            // 
            // ClosingRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 146);
            this.Controls.Add(this.GBInwOutSumm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.GBClosingStockSummary);
            this.Name = "ClosingRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClosingRegister";
            this.Load += new System.EventHandler(this.ClosingRegister_Load);
            this.GBClosingStockSummary.ResumeLayout(false);
            this.GBClosingStockSummary.PerformLayout();
            this.GBInwOutSumm.ResumeLayout(false);
            this.GBInwOutSumm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox GBClosingStockSummary;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBInwOutSumm;
        private System.Windows.Forms.DateTimePicker dtpFromInwOutSumm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbItemInwOutSumm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpToInwOutSumm;
    }
}