using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SOUMCO.Forms
{
    public partial class FrmCompany : Form
    {
        public FrmCompany()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           if (IsValidate())
            {
                SaveData();
                this.Dispose();
            }
        }

        private void SaveData()
        {
            ClsComm comm = new ClsComm();
            int iYearId;
         //   if (IsValidate())
            {
                if (string.IsNullOrEmpty(lblId.Text))
                {
                    lblId.Text = comm.GetUniqueId("CompanyId", "Company").ToString();
                    comm.AddData("Company", null, lblId.Text + ",'" + txtCompanyName.Text + "','" + txtAddress.Text + "','" + txtGSTNo.Text + "'," + ClsComm.strUserId + ",'" + DateTime.Now + "','" + DateTime.Now + "'");
                    for (int i = 0; i < dgvYear.RowCount - 1;i++ )
                    {
                        iYearId = comm.GetUniqueId("YearId", "FinancialDetail");
                        comm.AddData("FinancialDetail", null, iYearId + "," + lblId.Text + ",'" + dgvYear["dgPeriodFrom", i].Value + "','" + dgvYear["dgPeriodTo", i].Value + "','" +
                            dgvYear["dgDescription", i].Value + "'," + ClsComm.strUserId + ",'" + DateTime.Now + "','" + DateTime.Now + "'");
                    }
            
                    MessageBox.Show("Record Save Successfully", "SOUMCO", MessageBoxButtons.OK);
                }
                else
                {
                    comm.EditData("Company", "CompanyName='" + txtCompanyName.Text + "',CompanyAddress='" + txtAddress.Text + "',GSTNo='" + txtGSTNo.Text + 
                        "',ModifiedDate='" + DateTime.Now + "',UserId=" + ClsComm.strUserId + "", "CompanyId=" + lblId.Text);
                    for (int i = 0; i <=dgvYear.RowCount - 1; i++)
                    {

                        comm.EditData("FinancialDetail", "CompanyId=" + lblId.Text + ",FromPeriod='" + dgvYear["dgPeriodFrom", i].Value + "',ToPeriod='" + dgvYear["dgPeriodTo", i].Value + "',[Description]='" +
                            dgvYear["dgDescription", i].Value + "',ModifiedDate='" + DateTime.Now + "',UserId=" + ClsComm.strUserId, "YearId=" + dgvYear["dgId",i].Value);
                    }
                    MessageBox.Show("Record Update successfully", "SOUMCO", MessageBoxButtons.OK);
                }
            }
        }

        private bool IsValidate()
        {
            ClsComm comm = new ClsComm();
            string CompanyName = string.Empty;
            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                MessageBox.Show("Company cannot be null or empty", "SOUMCO");
                txtCompanyName.Focus();
                return false;
            }
            if (dgvYear["dgPeriodFrom", 0].Value==null)
            {
                MessageBox.Show("Enter Financial Year", "SOUMCO");
                dgvYear.Focus();
                return false;
            }
            if (lblId.Text != string.Empty)
            {
                CompanyName = comm.GetValue("CompanyName", "Company", "CompanyName='" + txtCompanyName.Text + "' and CompanyId not in (" + lblId.Text + ")");
                if (!string.IsNullOrEmpty(CompanyName))
                {
                    MessageBox.Show("Duplicate Company info found", "SOUMCO");
                    txtCompanyName.Focus();
                    return false;
                }
            }
            return true;
        }

        private void FrmCompany_Load(object sender, EventArgs e)
        {
            txtCompanyName.Focus();
        }

        public void ProcFillForm(object Id)
        {
            DataTable DTFill = new DataTable();
            ClsComm comm = new ClsComm();
            DTFill = comm.FillTable("Select CompanyId,CompanyName,CompanyAddress,GSTNo from Company where CompanyId=" + Id);
            if (DTFill.Rows.Count > 0)
            {
                lblId.Text = Id.ToString();
                txtCompanyName.Text = DTFill.Rows[0]["CompanyName"].ToString();
                txtAddress.Text = DTFill.Rows[0]["CompanyAddress"].ToString();
                txtGSTNo.Text = DTFill.Rows[0]["GSTNo"].ToString();

            }
            DTFill = new DataTable();
            DTFill = comm.FillTable("Select YearId,FromPeriod,ToPeriod, Description from FinancialDetail where CompanyId=" + Id);
            if (DTFill.Rows.Count > 0)
            {
                for (int i = 0; i <= DTFill.Rows.Count-1; i++)
                {
                    dgvYear["dgPeriodFrom", i].Value = DTFill.Rows[i]["FromPeriod"].ToString();
                    dgvYear["dgPeriodTo", i].Value = DTFill.Rows[i]["ToPeriod"].ToString();
                    dgvYear["dgDescription", i].Value = DTFill.Rows[i]["Description"].ToString();
                    dgvYear["dgId", i].Value = DTFill.Rows[i]["YearId"].ToString();

                }
            }
            if (ClsComm.tUserRightToEdit != true)
            {
                btnOk.Enabled = false;
                btnSaveAndNew.Enabled = false;
                btnCancel.Enabled = false;
            }
            else
            {
                btnOk.Enabled = true;
                btnSaveAndNew.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void ProcClear()
        {
            lblId.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtCompanyName.Focus();
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                SaveData();
                ProcClear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ProcClear();
        }

        private void txtGSTNo_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
