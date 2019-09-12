using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SOUMCO;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SOUMCO.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
        }
        [STAThread]
        public static void ThreadProc()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDIMain());
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            GBAdmin.Enabled = true;
            ClsComm comm = new ClsComm();
            comm.IniWriteValue("Datasource", "Connecting", Application.StartupPath + "\\Database\\SOUMCO.mdb", Application.StartupPath + "\\Connection.ini");
            comm.IniReadValue("Datasource", "Connecting", Application.StartupPath + "\\Connection.ini");
            txtUserName.Text = comm.IniReadValue("LoginInfo", "Users", Application.StartupPath + "\\Connection.ini");
            ProcOpen();
            if (comm.IniReadValue("CompanyInfo", "SelectedCompany", Application.StartupPath + "\\Connection.ini")!=string.Empty)
            cmbCompany.SelectedValue = comm.IniReadValue("CompanyInfo", "SelectedCompany", Application.StartupPath + "\\Connection.ini");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        class ProductTypeInfo
        {

            public int productTypeId { get; set; }
            public string productTypeName { get; set; }
            public string description { get; set; }
        }

        public class RequestOutStandingSummary 
        {
            public int companyId { get; set; }
            public int partyId { get; set; }
            public int agentId { get; set; }
            public DateTime date1 { get; set; }
            public DateTime date2 { get; set; }
            public int? PageIndex { get; set; }
            public int? PageSize { get; set; }
            public string SortDirection { get; set; }
            public string SortbyColumn { get; set; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //RequestOutStandingSummary p = new RequestOutStandingSummary();
            //p.companyId = 1;
            //p.partyId = 1;
            //p.agentId = 2;
            //p.date1 = new DateTime(2019,1,1);
            //p.date2 = new DateTime(2019,2,1);
            //p.PageIndex = 1;
            //p.PageSize = 10;
            //p.SortDirection = "asc";
            //p.SortbyColumn = "pId";

            //ProductTypeInfo Product = new ProductTypeInfo();
            //Product.productTypeName = "Test";
            //Product.description = "Test desc";

            ////string apiUrl = "http://localhost:54211/api/v1/Oustanding/OutStandingList";
            ////SaveObj(apiUrl, p);
            //string apiUrl = "http://localhost:54211/api/v1/ProductType/SaveProductType";
            //SaveObj(apiUrl, Product);




            ClsComm comm = new ClsComm();
            DataTable Dt = new DataTable();
            if (cmbYear.Text == string.Empty)
            {
                MessageBox.Show("Select Financial Year");

            }
            else
            {
                Dt = comm.FillTable("Select UserId,UsersName,UserPassword,AllowEditOrDelete from UserInfo where UsersName='" + txtUserName.Text + "' and UserPassword='" + txtPassword.Text + "'");
                if (Dt.Rows.Count > 0)
                {
                    if (txtUserName.Text == Dt.Rows[0]["UsersName"].ToString() && txtPassword.Text == Dt.Rows[0]["UserPassword"].ToString())
                    {
                        if (comm.GetLicense(System.DateTime.Now.Date))
                        {
                            comm.IniWriteValue("LoginInfo", "Users", txtUserName.Text, Application.StartupPath + "\\Connection.ini");
                            comm.IniWriteValue("CompanyInfo", "SelectedCompany", cmbCompany.SelectedValue.ToString(), Application.StartupPath + "\\Connection.ini");
                            comm.IniWriteValue("FinancialDetail", "SelectedYear", cmbYear.SelectedValue.ToString(), Application.StartupPath + "\\Connection.ini");
                            //comm.IniWriteValue("LoginInfo", "Id", Dt.Rows[0]["UsersId"].ToString(), Application.StartupPath + "\\Connection.ini");
                            comm.IniWriteValue("TAllow", "Right", Dt.Rows[0]["AllowEditOrDelete"].ToString(), Application.StartupPath + "\\Connection.ini");
                            ClsComm.strUserId = Dt.Rows[0]["UserId"].ToString();
                            ClsComm.CompanyId = Convert.ToInt32(cmbCompany.SelectedValue);
                            ClsComm.YearId = Convert.ToInt32(cmbCompany.SelectedValue);
                            ClsComm.tUserRightToEdit = (bool)Dt.Rows[0]["AllowEditOrDelete"];
                            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                            t.SetApartmentState(System.Threading.ApartmentState.STA);
                            t.Start();
                            this.Dispose();
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong login credential! Try again", "SOUMCO", MessageBoxButtons.OK);
                        txtUserName.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong login credential! Try again", "SOUMCO", MessageBoxButtons.OK);
                    txtUserName.Focus();
                }
            }
        }

        private async void SaveObj(string url, ProductTypeInfo p)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PostAsJsonAsync(url, p);

                if (response.IsSuccessStatusCode)
                {
                    bool result = await response.Content.ReadAsAsync<bool>();
                    if (result)
                        Console.WriteLine("Report Submitted");
                    else
                        Console.WriteLine("An error has occurred");
                }
            }
        }
        //private async void GetFileInformation(string url, ProductTypeInfo inwardInfo)
        //{
        //    var SaveInward = JsonConvert.SerializeObject(inwardInfo);
        //    var content = new StringContent(SaveInward, Encoding.UTF8, "application/json");
        //    var content1 = new FormUrlEncodedContent(new[]
        //    {
        //        new KeyValuePair<string, string>("", "Hello")
        //    });

        //    // var result = await content.PostAsync("/api/Membership/exists", content);
        //    using (var client = new HttpClient())
        //    {

        //        //client.DefaultRequestHeaders.Accept.Clear();
        //        //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //        //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Encoding.UTF8"));
        //        //HttpContent content = new StringContent(SaveInward, Encoding.UTF8, "application/json");

        //        //var content = new StringContent(SaveInward.ToString(), Encoding.UTF8, "application/json");
        //        var result = client.PostAsync(url, content);

        //        using (var response = await client.PostAsJsonAsync(url, inwardInfo))
        //        {
        //            if (response.IsSuccessStatusCode)
        //            {
        //                var fileJsonString = await response.Content.ReadAsStringAsync();

        //                //dataGridView1.DataSource = JsonConvert.DeserializeObject<InwardInfo[]>(fileJsonString).ToList();
        //            }
        //        }
        //    }
        //}


        private Boolean GetLicense() 
        {
            if (System.DateTime.Now.Date > Convert.ToDateTime("29/08/2019").Date)
            {
                MessageBox.Show("License expired -- for continue please contact on 9227140054", "License Info");
                return false;
            }
            return true;
        }
        //else
        //{   
        //    comm.IniWriteValue("LoginInfo", "Users", "Others", Application.StartupPath + "\\Connection.ini");
        //    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
        //    t.SetApartmentState(System.Threading.ApartmentState.STA);
        //    t.Start();
        //    //MDIMain mdi = new MDIMain();
        //    this.Dispose();
        //    //mdi.Show();
        //}

        private void ProcOpen()
        {
            ClsComm Comm = new ClsComm();
            Comm.BindCombo(cmbCompany, true, "CompanyId", "CompanyName", "Company", "CompanyName");
           
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ClsComm Comm = new ClsComm();
            //if (cmbCompany.SelectedIndex!= -1)
            //{
            //    //  Comm.BindCombo(cmbYear, false, "YearId", "Description", "FinancialDetail", "Description");
            //    Comm.BindCombo(cmbYear, false, "Select YearId, Description from FinancialDetail where CompanyId=1");
                
            //}
            //else if(Convert.ToInt32(cmbCompany.SelectedValue)>0)
            //{
            //    Comm.BindCombo(cmbYear, false, "Select YearId, Description from FinancialDetail where CompanyId=" + cmbCompany.SelectedValue);
            //}
            //if (Comm.IniReadValue("FinancialDetail", "SelectedYear", Application.StartupPath + "\\Connection.ini") != string.Empty)
            //    cmbYear.SelectedValue = Comm.IniReadValue("FinancialDetail", "SelectedYear", Application.StartupPath + "\\Connection.ini");
        }

        private void cmbCompany_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void cmbCompany_SelectedValueChanged(object sender, EventArgs e)
        {
            ClsComm Comm = new ClsComm();
            if (cmbCompany.SelectedIndex > 0)
            {
                //  Comm.BindCombo(cmbYear, false, "YearId", "Description", "FinancialDetail", "Description");
                Comm.BindCombo(cmbYear, false, "Select YearId, Description from FinancialDetail where CompanyId=" + cmbCompany.SelectedValue);

                if (Comm.IniReadValue("FinancialDetail", "SelectedYear", Application.StartupPath + "\\Connection.ini") != string.Empty)
                    cmbYear.SelectedValue = Comm.IniReadValue("FinancialDetail", "SelectedYear", Application.StartupPath + "\\Connection.ini");
            }
           
        }
    }

}