using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SOUMCO.Forms
{
    
    public partial class FrmUser : Form
    {
        bool tAllow = false;
        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            OptNo.Checked=true;
            if (txtUserName.Text == "Admin")
            {
                OptYes.Checked = true;
                GbPermission.Enabled = false;
              
            }
            if (lblId.Text == string.Empty)
            {
                gbChangePassword.Visible = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                SaveData();
                this.Dispose();
            }
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
        private void SaveData()
        {
            ClsComm comm = new ClsComm();
            //if (IsValidate())
            {
                if (string.IsNullOrEmpty(lblId.Text))
                {
                    lblId.Text = comm.GetUniqueId("UserId", "UserInfo").ToString();
                    tAllow= OptYes.Checked ? true :false ;
                    comm.AddData("UserInfo", null, lblId.Text + ",'" + txtUserName.Text + "','" + txtPassword.Text + "'," + tAllow + "");
                    MessageBox.Show("Record Save Successfully", "SOUMCO", MessageBoxButtons.OK);
                }
                else
                {
                    tAllow = OptYes.Checked ? true : false;
                    if (optYesChangePassword.Checked)
                    {
                        comm.EditData("UserInfo", "UsersName='" + txtUserName.Text + "',UserPassword='" + txtPassword.Text + "',AllowEditOrDelete=" + tAllow, "UserId=" + lblId.Text);
                    }
                    else
                    {
                        comm.EditData("UserInfo", "UsersName='" + txtUserName.Text + "',AllowEditOrDelete=" + tAllow, "UserId=" + lblId.Text);
                    }
                    MessageBox.Show("Record update successfully", "SOUMCO", MessageBoxButtons.OK);
                }
            }
        }

        public void ProcFillForm(object Id)
        {
            DataTable DTFill = new DataTable();
            ClsComm comm = new ClsComm();
            DTFill = comm.FillTable("Select * from UserInfo where UserId=" + Id);
            if (DTFill.Rows.Count > 0)
            {
                txtUserName.Enabled = false;
                lblId.Text = Id.ToString();
                txtUserName.Text = DTFill.Rows[0]["UsersName"].ToString();
            }
            if (lblId.Text != string.Empty)
            {
                txtPassword.Enabled = false;
                txtConfirmPassword.Enabled = false;
                gbChangePassword.Visible = true;
            }
        }

        private void ProcClear()
        {
            lblId.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
        }

        private bool IsValidate()
        {
           
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Username cannot be null or empty", "SOUMCO");
                txtUserName.Focus();
                return false;
            }
            if (lblId.Text == string.Empty)
            {
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Password cannot be null or empty", "SOUMCO");
                    txtPassword.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtConfirmPassword.Text))
                {
                    MessageBox.Show("Confirm Password cannot be null or empty", "SOUMCO");
                    txtConfirmPassword.Focus();
                    return false;
                }
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Password and Confirm Password are not same", "SOUMCO");
                    txtConfirmPassword.Focus();
                    return false;
                }
            }
            else if(lblId.Text!=string.Empty && optYesChangePassword.Checked)
            {
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Password cannot be null or empty", "SOUMCO");
                    txtPassword.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtConfirmPassword.Text))
                {
                    MessageBox.Show("Confirm Password cannot be null or empty", "SOUMCO");
                    txtConfirmPassword.Focus();
                    return false;
                }
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Password and Confirm Password are not same", "SOUMCO");
                    txtConfirmPassword.Focus();
                    return false;
                }
            }
            if (OptNo.Checked == true)
            {
                tAllow = false;
            }
            else if (OptYes.Checked == true)
            {
                tAllow = true;
            }

                return true;
        }

        private void OptionChangePassword()
        {
            if(optYesChangePassword.Checked)
            {
                txtPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
            }
            else
            {
                txtPassword.Enabled = false;
                txtConfirmPassword.Enabled = false;
            }
        }

        private void optYesChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            OptionChangePassword();
        }

        private void optNoChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            OptionChangePassword();
        }

    }
}