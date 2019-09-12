using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SOUMCO;
using System.Data.OleDb;
using SOUMCO.Class;
using System.Net.Http;
using Newtonsoft.Json;
using System.Linq;


namespace SOUMCO.Forms
{
    public partial class FrmLists : Form
    {
        public String ClickName;
        DataTable dtList;
        DataTable dt;
        ClsComm comm;
        public FrmLists()
        {
            InitializeComponent();
        }
        //string SqlQuery = String.Format("Select {0} From {1} {2} {3}", FieldNames, TableName, WhereCaluse, OrderBy);
        private void FrmLists_Load(object sender, EventArgs e)
        {
            comm = new ClsComm();
           
            if (ClsComm.tUserRightToEdit != true)
            {
                //dgList.Columns[0].Visible = false;
                dgList.Columns[1].Visible = false;
                dgList.Columns[0].HeaderText = "View";
                dgEdit.Text = "View";
       
            }
            else
            {
                dgList.Columns[0].Visible = true;
                dgList.Columns[1].Visible = true;
            }
            switch (ClickName.ToUpper())
            {
                case "COMPANY":
                    CompanyInfo();
                    break;
                case "SUPPLIER":
                    SupplierInfo();
                    break;
                case "CUSTOMER":
                    CustomerInfo();
                    break;
                case "ITEM":
                    ItemInfo();
                    break;
                case "VEHICLE":
                    VechicleInfo();
                    break;
                case "INWARDENTRY":
                    InwardEntry();
                    break;
                case "OUTWARDENTRY" :
                    OutwardEntry();
                    break;
                case "DENSITY":
                    DensityInfo();
                    break;
                case "CATEGORY":
                    CategoryInfo();
                    break;
                case "SUBCATEGORY":
                    SUBCategoryInfo();
                    break;
                case "USER":
                    UserInfo();
                    break;
            }

        }

        private void FillFilterDropDown(DataTable dt, string NotIncludeColumn)
        {
            cmbFilterBy.DataBindings.Clear();
            
            foreach(DataColumn d in dt.Columns)
            {
                if (d.ColumnName != NotIncludeColumn)
                {
                    cmbFilterBy.Items.Add(d.ColumnName);
                }
            }
        }
        private void FilterData(string strClickName, string FilterBy, string FilterValue)
        {
            try
            {
                if (!string.IsNullOrEmpty(FilterValue))
                {
                    ((DataTable)dgList.DataSource).DefaultView.RowFilter = string.Format(FilterBy + " like '%{0}%'", FilterValue.Trim().Replace("'", "''"));
                }
                else
                {
                    ((DataTable)dgList.DataSource).DefaultView.RowFilter = "";
                }
                dgList.Refresh();
            }
            catch
            {

            }
        }
        private void CompanyInfo()
        {
            dtList = new DataTable();
            comm = new ClsComm();
            dtList = comm.FillTable("select CompanyId,CompanyName,GSTNo from Company order By CompanyName");
            if (dtList.Rows.Count > 0)
            {
                FillFilterDropDown(dtList, "CompanyId");
                dgList.DataSource = dtList;
                dgList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgList.ReadOnly = true;
                dgList.Columns[1].Visible = false;
                dgList.Columns[2].HeaderText = "Company Id";
                dgList.Columns[2].Visible = false;
                dgList.Columns[2].Width = 20;
                dgList.Columns[3].HeaderText = "Company Name";
                dgList.Columns[3].Width = 200;
                dgList.Columns[4].HeaderText = "GST No";
                dgList.Columns[4].Width = 200;
                dgList.AutoSize = true;
            }
            else
            {
                MessageBox.Show("No Record Found");
            }
        }
        private void SupplierInfo()
        {
            dtList = new DataTable();
            comm = new ClsComm();
            dtList =comm.FillTable("Select SupplierId,SupplierName,Address,City,ZipCode,PhoneNo,CellNo,FaxNo from Supplier where Type='Supplier' order By SupplierName");
            if (dtList.Rows.Count > 0)
            {
                dgList.DataSource = dtList;
                FillFilterDropDown(dtList, "SupplierId");
                dgList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgList.ReadOnly = true;
                dgList.Columns[2].HeaderText = "Supplier Id";
                dgList.Columns[2].Visible = false;
                dgList.Columns[2].Width = 20;
                dgList.Columns[3].HeaderText = "Supplier Name";
                dgList.Columns[3].Width = 210;
                dgList.Columns[4].HeaderText = "Address";
                dgList.Columns[4].Width = 150;
                dgList.Columns[5].HeaderText = "City";
                dgList.Columns[5].Width = 110;
                dgList.Columns[6].HeaderText = "Zip Code";
                dgList.Columns[6].Width = 80;
                dgList.Columns[7].HeaderText = "Phone No";
                dgList.Columns[7].Width = 80;
                dgList.Columns[8].HeaderText = "Cell No";
                dgList.Columns[8].Width = 85;
                dgList.Columns[9].HeaderText = "Fax No";
                dgList.Columns[9].Width = 85;
                dgList.AutoSize = true;
            }
            else
            {
                MessageBox.Show("No Record Found");
            }   
        }
        private void CustomerInfo()
        {
            dtList = new DataTable();
            comm = new ClsComm();
            dtList = comm.FillTable("Select SupplierId,SupplierName as CustomerName,Address,City,ZipCode,PhoneNo,CellNo,FaxNo from Supplier where Type='Customer' order By SupplierName");
            if (dtList.Rows.Count > 0)
            {
                dgList.DataSource = dtList;
                FillFilterDropDown(dtList, "SupplierId");
                dgList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgList.ReadOnly = true;
                dgList.Columns[2].HeaderText = "Customer Id";
                dgList.Columns[2].Visible = false;
                dgList.Columns[2].Width = 20;
                dgList.Columns[3].HeaderText = "Customer Name";
                dgList.Columns[3].Width = 210;
                dgList.Columns[4].HeaderText = "Address";
                dgList.Columns[4].Width = 150;
                dgList.Columns[5].HeaderText = "City";
                dgList.Columns[5].Width = 110;
                dgList.Columns[6].HeaderText = "Zip Code";
                dgList.Columns[6].Width = 80;
                dgList.Columns[7].HeaderText = "Phone No";
                dgList.Columns[7].Width = 80;
                dgList.Columns[8].HeaderText = "Cell No";
                dgList.Columns[8].Width = 85;
                dgList.Columns[9].HeaderText = "Fax No";
                dgList.Columns[9].Width = 85;
                dgList.AutoSize = true;
            }
            else
            {
                MessageBox.Show("No Record Found");
            }
        }
        private void VechicleInfo()
        {
            dtList = new DataTable();
            comm = new ClsComm();
            dtList = comm.FillTable("select VehicleId,VehicleNo,VehicleCode,OperatorName,AreaCode,Remarks from Vehicle order By VehicleNo");
            if (dtList.Rows.Count > 0)
            {
                dgList.DataSource = dtList;
                dgList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgList.ReadOnly = true;
                dgList.Columns[2].HeaderText = "Vehicle Id";
                dgList.Columns[2].Visible = false;
                dgList.Columns[2].Width = 20;
                dgList.Columns[3].HeaderText = "Vehicle No";
                dgList.Columns[3].Width = 120;
                dgList.Columns[4].HeaderText = "Vehicle Code";
                dgList.Columns[4].Width = 90;
                dgList.Columns[5].HeaderText = "Operator Name";
                dgList.Columns[5].Width = 250;
                dgList.Columns[6].HeaderText = "Area Code";
                dgList.Columns[6].Width = 250;
                dgList.Columns[7].HeaderText = "Remarks";
                dgList.Columns[7].Width = 140;
             
                dgList.AutoSize = true;
            }
            else
            {
                MessageBox.Show("No Record Found");
            }   
        }

        private async System.Threading.Tasks.Task ItemInfo()
        {
            
            List<ProductInfo> productInfo = new List<ProductInfo>();
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(Common.Common.APIURL_PRODUCT_GETALL);
            var fileJsonString = await response.Content.ReadAsStringAsync();
            // DataTable dtList = (DataTable)JsonConvert.DeserializeObject(fileJsonString, (typeof(DataTable)));
            dgList.DataSource = JsonConvert.DeserializeObject<ProductInfo[]>(fileJsonString).ToList();
            dgList.Columns[2].Visible = false;
            dgList.Columns[3].Visible = false;
            dgList.Columns[4].Visible = false;
            foreach (DataGridViewColumn d in dgList.Columns)
            {

                if (d.DisplayIndex >= 5)
                {
                    cmbFilterBy.Items.Add(d.HeaderText);
                }
            }
            
                dgList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgList.ReadOnly = true;
                dgList.Columns[5].HeaderText = "Product Name";
                dgList.Columns[5].Width = 250;
                dgList.Columns[6].HeaderText = "Description";
                dgList.Columns[6].Width = 250;
                dgList.Columns[7].HeaderText = "Product Type";
                dgList.Columns[7].Width = 250;
                dgList.Columns[8].HeaderText = "Product Size";
                dgList.Columns[8].Width = 180;
                dgList.AutoSize = true;
            }
            //else
            //{
            //    MessageBox.Show("No Record Found");
            //}

        

        private async System.Threading.Tasks.Task InwardEntry()
        {
            List<InwardInfo> inwardInfo = new List<InwardInfo>();
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(Common.Common.APIURL_INWARD_GETALL);
            var fileJsonString = await response.Content.ReadAsStringAsync();
            // DataTable dtList = (DataTable)JsonConvert.DeserializeObject(fileJsonString, (typeof(DataTable)));
            dgList.DataSource = JsonConvert.DeserializeObject<InwardInfo[]>(fileJsonString).ToList();
           dgList.Columns[2].Visible = false;
            dgList.Columns[3].Visible = false;

            //dtList = new DataTable();
            //comm = new ClsComm();
            //int i = 0;
            ////ModGeneral.FillTable(ref dtList, "Select I.InwardId,C.CustomerName,I.ChallanNo,I.LRNO,Convert(Char(13),I.ChallanDate,103) as ChallanDate," +
            ////                                 "Convert(Char(13),I.Entrydate,103) as EntryDate from InwardEntry I inner join CustomerInfo C on C.CustomerId=I.CustomerId where I.CompanyId=" + ModGeneral.CompanyId + " Order By I.ChallanDate Desc");
            //dtList = comm.FillTable("Select Top 50 I.InwardId,S.SupplierName,I.BillNo,format(I.EntryDate,\"dd/mm/yyyy\") as ChallanDate from InwardEntry I,Supplier S where S.SupplierId=I.SupplierId and I.CompanyId=" + ClsComm.CompanyId + " and I.YearId=" + ClsComm.YearId + " order by I.EntryDate Desc");
            //if (dtList.Rows.Count > 0)
            //{
            //    dgList.DataSource = dtList;
            //    FillFilterDropDown(dtList, "InwardId");
            //    dgList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //    dgList.ReadOnly = true;
            //    i = 2;
            //    dgList.Columns[i].HeaderText = "Inward Id";
            //    dgList.Columns[i].Visible = false;
            //    dgList.Columns[i].Width = 20;
            //    i = i + 1;//3
            //    dgList.Columns[i].HeaderText = "Supplier Name";
            //    dgList.Columns[i].Width = 260;
            //    i = i + 1;//4
            //    //dgList.Columns[i].HeaderText = "Company Name";
            //    //dgList.Columns[i].Width = 250;
            //    //i = i + 1;//5
            //    dgList.Columns[i].HeaderText = "Bill No";
            //    dgList.Columns[i].Width = 100;
            //    i = i + 1;//6
            //    dgList.Columns[i].HeaderText = "Invoice Date";
            //    dgList.Columns[i].Width = 100;
            //    //i = i + 1;//7
            //    //dgList.Columns[i].HeaderText = "Bill Amt";
            //    //dgList.Columns[i].Width = 100;

            //    dgList.AutoSize = true;
            //}
            //else
            //{
            //    MessageBox.Show("No Record Found");
            //}   
        }
        private async System.Threading.Tasks.Task OutwardEntry()
        {
            List<OutwardInfo> outwardInfo = new List<OutwardInfo>();
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(Common.Common.APIURL_OUTWARD_GETALL);
            var fileJsonString = await response.Content.ReadAsStringAsync();
            // DataTable dtList = (DataTable)JsonConvert.DeserializeObject(fileJsonString, (typeof(DataTable)));
            dgList.DataSource = JsonConvert.DeserializeObject<OutwardInfo[]>(fileJsonString).ToList();
            dgList.Columns[2].Visible = false;
            dgList.Columns[3].Visible = false;

            //dtList = new DataTable();
            //comm = new ClsComm();
            //dtList = comm.FillTable("SELECT top 50 OutwardEntry.OutwardId, Supplier.SupplierName as CustomerName, OutwardEntry.InvoiceNo, format(OutwardEntry.InvoiceDate,\"dd/mm/yyyy\") as InvoiceDate " +
            //                        " From OutwardEntry INNER JOIN Supplier ON OutwardEntry.CustomerId = Supplier.SupplierId " +
            //                        " WHERE (((Supplier.Type)='Customer')) and OutwardEntry.CompanyId=" + ClsComm.CompanyId + " and OutwardEntry.YearId=" + ClsComm.YearId + " ORDER BY OutwardEntry.InvoiceDate Desc;");

            //if (dtList.Rows.Count > 0)
            //{
            //    dgList.DataSource = dtList;
            //    FillFilterDropDown(dtList, "OutwardId");
            //    dgList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //    dgList.ReadOnly = true;
            //    dgList.Columns[2].HeaderText = "Outward Id";
            //    dgList.Columns[2].Visible = false;
            //    dgList.Columns[2].Width = 10;
            //    dgList.Columns[3].HeaderText = "Customer Name";
            //    dgList.Columns[3].Width = 140;
            //    dgList.Columns[4].HeaderText = "Invoice No";
            //    dgList.Columns[4].Width = 100;
            //    dgList.Columns[5].HeaderText = "Invoice Date";
            //    dgList.Columns[5].Width = 100;
            //    //dgList.Columns[6].HeaderText = "Category Name";
            //    //dgList.Columns[6].Width = 100;
            //    //dgList.Columns[7].HeaderText = "Item Name";
            //    //dgList.Columns[7].Width = 220;
            //    dgList.AutoSize = true;
            //}
            //else
            //{
            //    MessageBox.Show("No Record Found");
            //}   
        }
        private void UserInfo()
        {
            dtList = new DataTable();
            comm = new ClsComm();
            dtList = comm.FillTable("select UserId,UsersName from UserInfo order By UsersName");
            if (dtList.Rows.Count > 0)
            {
                dgList.DataSource = dtList;
                FillFilterDropDown(dtList, "UserId");
                dgList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgList.ReadOnly = true;
                dgList.Columns[1].Visible = false;
                dgList.Columns[2].HeaderText = "User Id";
                dgList.Columns[2].Visible = false;
                dgList.Columns[2].Width = 20;
                dgList.Columns[3].HeaderText = "User Name";
                dgList.Columns[3].Width = 150;
                dgList.AutoSize = true;
            }
            else
            {
                MessageBox.Show("No Record Found");
            }   
        }

        private void DensityInfo()
        {
            dtList = new DataTable();
            comm = new ClsComm();
            dtList = comm.FillTable("select DensityId,DensityName,DensityValue,Description from Density order By DensityName");
            if (dtList.Rows.Count > 0)
            {
                dgList.DataSource = dtList;
                FillFilterDropDown(dtList, "DensityId");
                dgList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgList.ReadOnly = true;
                dgList.Columns[2].HeaderText = "Density Id";
                dgList.Columns[2].Visible = false;
                dgList.Columns[2].Width = 20;
                dgList.Columns[3].HeaderText = "Density Detail";
                dgList.Columns[3].Width = 150;
                dgList.Columns[4].HeaderText = "Value";
                dgList.Columns[4].Width = 150;
                dgList.Columns[5].HeaderText = "Description";
                dgList.Columns[5].Width = 200;
                dgList.AutoSize = true;
            }
            else
            {
                MessageBox.Show("No Record Found");
            }
        }

        private async System.Threading.Tasks.Task CategoryInfo()
        {
            List<ProductTypeInfo> productInfo = new List<ProductTypeInfo>();
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(Common.Common.APIURL_PRODUCTTYPE_GETALL);
            var fileJsonString = await response.Content.ReadAsStringAsync();
            // DataTable dtList = (DataTable)JsonConvert.DeserializeObject(fileJsonString, (typeof(DataTable)));
            dgList.DataSource = JsonConvert.DeserializeObject<ProductTypeInfo[]>(fileJsonString).ToList();
            dgList.Columns[2].Visible = false;
            // dgList.Columns[3].Visible = false;
            // dgList.Columns[4].Visible = false;
            foreach (DataGridViewColumn d in dgList.Columns)
            {

                if (d.DisplayIndex >= 3)
                {
                    cmbFilterBy.Items.Add(d.HeaderText);
                }
            }

            dgList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ////dgList.ReadOnly = true;
            dgList.Columns[3].HeaderText = "Product Type";
            dgList.Columns[3].Width = 250;
            dgList.Columns[4].HeaderText = "Description";
            dgList.Columns[4].Width = 250;
            //dgList.Columns[7].HeaderText = "Product Type";
            //dgList.Columns[7].Width = 250;
            //dgList.Columns[8].HeaderText = "Product Size";
            //dgList.Columns[8].Width = 180;
            //dgList.AutoSize = true;


            //dtList = new DataTable();
            //comm = new ClsComm();
            //dtList = comm.FillTable("select CategoryId,CategoryName,Description from Category order By CategoryName");
            //if (dtList.Rows.Count > 0)
            //{
            //    dgList.DataSource = dtList;
            //    FillFilterDropDown(dtList, "CategoryId");
            //    dgList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //    dgList.ReadOnly = true;
            //    dgList.Columns[2].HeaderText = "Category Id";
            //    dgList.Columns[2].Visible = false;
            //    dgList.Columns[2].Width = 20;
            //    dgList.Columns[3].HeaderText = "Category Detail";
            //    dgList.Columns[3].Width = 150;
            //    dgList.Columns[4].HeaderText = "Description";
            //    dgList.Columns[4].Width = 200;
            //    dgList.AutoSize = true;
            //}
            //else
            //{
            //    MessageBox.Show("No Record Found");
            //}
        }

        private async System.Threading.Tasks.Task SUBCategoryInfo()
        {
            List<ProductSizeInfo> productInfo = new List<ProductSizeInfo>();
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(Common.Common.APIURL_PRODUCTSIZE_GETALL);
            var fileJsonString = await response.Content.ReadAsStringAsync();
            // DataTable dtList = (DataTable)JsonConvert.DeserializeObject(fileJsonString, (typeof(DataTable)));
            dgList.DataSource = JsonConvert.DeserializeObject<ProductSizeInfo[]>(fileJsonString).ToList();
            dgList.Columns[2].Visible = false;
             dgList.Columns[5].Visible = false;
            // dgList.Columns[4].Visible = false;
            foreach (DataGridViewColumn d in dgList.Columns)
            {

                if (d.DisplayIndex >= 3)
                {
                    cmbFilterBy.Items.Add(d.HeaderText);
                }
            }

            dgList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ////dgList.ReadOnly = true;
            dgList.Columns[3].HeaderText = "Product Size";
            dgList.Columns[3].Width = 250;
            dgList.Columns[4].HeaderText = "Description";
            dgList.Columns[4].Width = 250;
            dgList.Columns[6].HeaderText = "Product Type";
            dgList.Columns[6].Width = 250;
            //dgList.Columns[7].HeaderText = "Product Type";
            //dgList.Columns[7].Width = 250;
            //dgList.Columns[8].HeaderText = "Product Size";
            //dgList.Columns[8].Width = 180;
            //dgList.AutoSize = true;


            //dtList = new DataTable();
            //comm = new ClsComm();
            //dtList = comm.FillTable("select SubCategoryId,SubCategoryName,Description from SubCategory order By SubCategoryName");
            //if (dtList.Rows.Count > 0)
            //{
            //    dgList.DataSource = dtList;
            //    FillFilterDropDown(dtList, "SubCategoryId");
            //    dgList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //    dgList.ReadOnly = true;
            //    dgList.Columns[2].HeaderText = "SubCategory Id";
            //    dgList.Columns[2].Visible = false;
            //    dgList.Columns[2].Width = 20;
            //    dgList.Columns[3].HeaderText = "Sub Category Detail";
            //    dgList.Columns[3].Width = 150;
            //    dgList.Columns[4].HeaderText = "Description";
            //    dgList.Columns[4].Width = 200;
            //    dgList.AutoSize = true;
            //}
            //else
            //{
            //    MessageBox.Show("No Record Found");
            //}
        }
        private async void dgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                #region Supplier Info

                if (ClickName.ToUpper() == "Supplier".ToString().ToUpper())
                {
                    ClsComm comm = new ClsComm();
                    dt = new DataTable();
                    if (e.ColumnIndex == 0)
                    {
                        FrmSupplier frmSupplier = new FrmSupplier();
                        frmSupplier.ProcFillForm(dgList.Rows[e.RowIndex].Cells[2].Value,e.RowIndex);
                        frmSupplier.ShowDialog();
                        dt = comm.FillTable("Select SupplierId,SupplierName,Address,City,ZipCode,PhoneNo,CellNo,FaxNo from Supplier where SupplierId=" + dgList.Rows[e.RowIndex].Cells[2].Value);
                        if(dt.Rows.Count>0)
                        {
                            dgList[3, e.RowIndex].Value = dt.Rows[0]["SupplierName"].ToString();
                            dgList[4, e.RowIndex].Value = dt.Rows[0]["Address"].ToString();
                            dgList[5, e.RowIndex].Value = dt.Rows[0]["City"].ToString();
                            dgList[6, e.RowIndex].Value = dt.Rows[0]["ZipCode"].ToString();
                            dgList[7, e.RowIndex].Value = dt.Rows[0]["PhoneNo"].ToString();
                            dgList[8, e.RowIndex].Value = dt.Rows[0]["CellNo"].ToString();
                            dgList[9, e.RowIndex].Value = dt.Rows[0]["FaxNo"].ToString();
                        }
                        

                        frmSupplier.MdiParent = this.MdiParent.FindForm();
                    }
                    else if (e.ColumnIndex == 1)
                    {
                        DialogResult MsgDialog;
                        int CountId =Convert.ToInt32(comm.GetValue("Count(SupplierId)", "InwardEntry", "SupplierId=" + dgList.Rows[e.RowIndex].Cells[2].Value));
                        if (CountId == 0)
                        {
                            MsgDialog = MessageBox.Show("Are You sure you want to delete?", "SOUMCO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (MsgDialog == DialogResult.Yes)
                            {
                                comm.DeleteData("Supplier", "SupplierId=" + dgList.Rows[e.RowIndex].Cells[2].Value);
                                dgList.Rows.Remove(dgList.Rows[e.RowIndex]);
                                dgList.Refresh();
                            }
                        }
                        else
                        {
                            MessageBox.Show("First delete all transaction related to " + dgList.Rows[e.RowIndex].Cells[3].Value, "SOUMCO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }

                }
                #endregion

                #region Customer Info

                if (ClickName.ToUpper() == "Customer".ToString().ToUpper())
                {
                    ClsComm comm = new ClsComm();
                    dt = new DataTable();
                    if (e.ColumnIndex == 0)
                    {
                        FrmSupplier frmSupplier = new FrmSupplier();
                        frmSupplier.ProcFillForm(dgList.Rows[e.RowIndex].Cells[2].Value, e.RowIndex);
                        frmSupplier.ShowDialog();
                        dt = comm.FillTable("Select SupplierId,SupplierName,Address,City,ZipCode,PhoneNo,CellNo,FaxNo from Supplier where SupplierId=" + dgList.Rows[e.RowIndex].Cells[2].Value);
                        if (dt.Rows.Count > 0)
                        {
                            dgList[3, e.RowIndex].Value = dt.Rows[0]["SupplierName"].ToString();
                            dgList[4, e.RowIndex].Value = dt.Rows[0]["Address"].ToString();
                            dgList[5, e.RowIndex].Value = dt.Rows[0]["City"].ToString();
                            dgList[6, e.RowIndex].Value = dt.Rows[0]["ZipCode"].ToString();
                            dgList[7, e.RowIndex].Value = dt.Rows[0]["PhoneNo"].ToString();
                            dgList[8, e.RowIndex].Value = dt.Rows[0]["CellNo"].ToString();
                            dgList[9, e.RowIndex].Value = dt.Rows[0]["FaxNo"].ToString();
                        }


                        frmSupplier.MdiParent = this.MdiParent.FindForm();
                    }
                    else if (e.ColumnIndex == 1)
                    {
                        DialogResult MsgDialog;
                        int CountId = Convert.ToInt32(comm.GetValue("Count(SupplierId)", "InwardEntry", "SupplierId=" + dgList.Rows[e.RowIndex].Cells[2].Value));
                        if (CountId == 0)
                        {
                            MsgDialog = MessageBox.Show("Are You sure you want to delete?", "SOUMCO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (MsgDialog == DialogResult.Yes)
                            {
                                comm.DeleteData("Supplier", "SupplierId=" + dgList.Rows[e.RowIndex].Cells[2].Value);
                                dgList.Rows.Remove(dgList.Rows[e.RowIndex]);
                                dgList.Refresh();
                            }
                        }
                        else
                        {
                            MessageBox.Show("First delete all transaction related to " + dgList.Rows[e.RowIndex].Cells[3].Value, "SOUMCO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }

                }
                #endregion

                #region Item Info

                else if (ClickName.ToUpper() == "Item".ToString().ToUpper())
                {


                    ClsComm comm = new ClsComm();
                    dt = new DataTable();
                    if (e.ColumnIndex == 0)
                    {
                        frmProduct frmItem = new frmProduct();
                        frmItem.ProcFillForm(dgList.Rows[e.RowIndex].Cells[2].Value);
                        //frmItem.MdiParent = this.MdiParent.FindForm();
                        frmItem.ShowDialog();
                        ProductInfo objProductInfo = new ProductInfo();
                        var client = new HttpClient();

                        HttpResponseMessage response = await client.GetAsync(Common.Common.APIURL_PRODUCT_GETBY_ID + "?Id=" + dgList.Rows[e.RowIndex].Cells[2].Value.ToString());
                        var fileJsonString = await response.Content.ReadAsStringAsync();
                        // DataTable dtList = (DataTable)JsonConvert.DeserializeObject(fileJsonString, (typeof(DataTable)));
                        objProductInfo = JsonConvert.DeserializeObject<ProductInfo>(fileJsonString);


                        ////dt = comm.FillTable("Select ItemId,ItemName,Description,OpStockQty, OpStockKgs,ItemRate from item where ItemId=" + dgList.Rows[e.RowIndex].Cells[2].Value);
                        //dt = comm.FillTable("SELECT Item.ItemId,Item.ItemName, Item.Description, Category.CategoryName, SubCategory.SubCategoryName, Item.OpStockQty, Item.OpStockKgs, Item.ItemRate " +
                        //                  " FROM (Item LEFT JOIN Category ON Item.CategoryId = Category.CategoryId) LEFT JOIN SubCategory ON Item.SubCategoryId = SubCategory.SubCategoryId Where Item.ItemId=" + dgList.Rows[e.RowIndex].Cells[2].Value);

                        if (objProductInfo.productId > 0)
                        {
                            dgList[5, e.RowIndex].Value = objProductInfo.productName.ToString();
                            dgList[6, e.RowIndex].Value = objProductInfo.description.ToString();
                            dgList[7, e.RowIndex].Value = objProductInfo.productTypeName.ToString();
                            dgList[8, e.RowIndex].Value = objProductInfo.productSizeName.ToString();
                        }
                    }
                    //else if (e.ColumnIndex == 1)
                    //{

                    //    DialogResult MsgDialog;
                    //    int CountId =Convert.ToInt32(comm.GetValue("SELECT Count(ItemId) + (SELECT Count(ItemId) FROM OutwardDetailEntry WHERE ItemId=" + dgList.Rows[e.RowIndex].Cells[2].Value +") as ID FROM InwardDetailEntry WHERE ItemId=" + dgList.Rows[e.RowIndex].Cells[2].Value));
                    //    if (CountId == 0)
                    //    {
                    //        MsgDialog = MessageBox.Show("Are You sure you want to delete?", "SOUMCO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    //        comm.DeleteData("Item", "ItemId=" + dgList.Rows[e.RowIndex].Cells[2].Value);
                    //        comm.DeleteData("tbLedger", "TxnId=" + dgList.Rows[e.RowIndex].Cells[2].Value + " and TxnType='OP' and CompanyId=" + ClsComm.CompanyId + " and YearId=" + ClsComm.YearId);
                    //        dgList.Rows.Remove(dgList.Rows[e.RowIndex]);
                    //        dgList.Refresh();
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("First delete all transaction related to " + dgList.Rows[e.RowIndex].Cells[3].Value, "SOUMCO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    }

                    //}
                }
                #endregion

                #region Vehicle Info

                else if (ClickName.ToUpper() == "Vehicle".ToString().ToUpper())
                {
                    ClsComm comm = new ClsComm();
                    dt = new DataTable();
                    if (e.ColumnIndex == 0)
                    {
                        FrmVehicle frmvehicle = new FrmVehicle();
                        frmvehicle.ProcFillForm(dgList.Rows[e.RowIndex].Cells[2].Value);
                        frmvehicle.ShowDialog();
                        dt = comm.FillTable("select VehicleId,VehicleNo,VehicleCode,OperatorName,AreaCode,Remarks from Vehicle where VehicleId=" + dgList.Rows[e.RowIndex].Cells[2].Value);
                        if (dt.Rows.Count > 0)
                        {
                            dgList[3, e.RowIndex].Value = dt.Rows[0]["VehicleNo"].ToString();
                            dgList[4, e.RowIndex].Value = dt.Rows[0]["VehicleCode"].ToString();
                            dgList[5, e.RowIndex].Value = dt.Rows[0]["OperatorName"].ToString();
                            dgList[6, e.RowIndex].Value = dt.Rows[0]["AreaCode"].ToString();
                            dgList[7, e.RowIndex].Value = dt.Rows[0]["Remarks"].ToString();
                        }
                    }
                    else if (e.ColumnIndex == 1)
                    {
                        DialogResult MsgDialog;
                        int CountId = Convert.ToInt32(comm.GetValue("Count(VehicleId)", "OutwardEntry", "VehicleId=" + dgList.Rows[e.RowIndex].Cells[2].Value));
                        if (CountId == 0)
                        {
                            MsgDialog = MessageBox.Show("Are You sure you want to delete?", "SOUMCO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (MsgDialog == DialogResult.Yes)
                            {
                                comm.DeleteData("Vehicle", "VehicleId=" + dgList.Rows[e.RowIndex].Cells[2].Value);
                                dgList.Rows.Remove(dgList.Rows[e.RowIndex]);
                                dgList.Refresh();
                            }
                        }
                        else
                        {
                            MessageBox.Show("First delete all transaction related to " + dgList.Rows[e.RowIndex].Cells[3].Value, "SOUMCO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                #endregion

                #region Inward Entry

                else if (ClickName.ToUpper() == "InwardEntry".ToString().ToUpper())
                {
                    ClsComm comm = new ClsComm();
                    dt = new DataTable();
                    if (e.ColumnIndex == 0)
                    {
                        OLDFrmInward objCategory = new OLDFrmInward();
                        objCategory.ProcFillForm(dgList.Rows[e.RowIndex].Cells[2].Value);
                        //objCategory.ShowDialog();
                        objCategory.MdiParent = this.MdiParent;
                        objCategory.BringToFront();
                        objCategory.WindowState = FormWindowState.Maximized;
                        objCategory.Dock = DockStyle.Fill;
                        objCategory.Show();
                        InwardInfo objProductInfo = new InwardInfo();
                        var client = new HttpClient();

                        HttpResponseMessage response = await client.GetAsync(Common.Common.APIURL_INWARD_GETBY_ID + "?Id=" + dgList.Rows[e.RowIndex].Cells[2].Value.ToString());
                        var fileJsonString = await response.Content.ReadAsStringAsync();
                        // DataTable dtList = (DataTable)JsonConvert.DeserializeObject(fileJsonString, (typeof(DataTable)));
                        objProductInfo = JsonConvert.DeserializeObject<InwardInfo>(fileJsonString);
                        if (objProductInfo.inwardId > 0)
                        {
                            dgList[4, e.RowIndex].Value = objProductInfo.billNo;
                            dgList[5, e.RowIndex].Value = objProductInfo.billDate;
                            dgList[6, e.RowIndex].Value = objProductInfo.supplierName;
                            dgList[7, e.RowIndex].Value = objProductInfo.description;
                        }

                        dgList.Refresh();


                        //ClsComm comm = new ClsComm();
                        //dt = new DataTable();
                        //if (e.ColumnIndex == 0)
                        //{
                        //    FrmNewInward frminward = new FrmNewInward();
                        //    MDIMain mdi = new MDIMain();
                        //    frminward.ProcFillForm(dgList.Rows[e.RowIndex].Cells[2].Value);
                        //    frminward.MdiParent = this.MdiParent;
                        //    frminward.BringToFront();
                        //    frminward.WindowState = FormWindowState.Maximized;
                        //    frminward.Dock = DockStyle.Fill;
                        //    frminward.Show();
                        //    //frminward.ShowDialog(mdi);
                        //    dt = comm.FillTable("Select I.InwardId,S.SupplierName,I.BillNo,format(I.EntryDate,\"dd/mm/yyyy\") as ChallanDate from InwardEntry I,Supplier S where S.SupplierId=I.SupplierId and I.InwardId=" + dgList.Rows[e.RowIndex].Cells[2].Value);
                        //    if (dt.Rows.Count > 0)
                        //    {
                        //        dgList[3, e.RowIndex].Value = dt.Rows[0]["SupplierName"].ToString();
                        //        dgList[4, e.RowIndex].Value = dt.Rows[0]["BillNo"].ToString();
                        //        dgList[5, e.RowIndex].Value = dt.Rows[0]["ChallanDate"].ToString();

                        //    }

                        //}
                        //else if (e.ColumnIndex == 1)
                        //{
                        //    DialogResult MsgDialog;

                        //    MsgDialog = MessageBox.Show("Are You sure you want to delete?", "SOUMCO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        //    if (MsgDialog == DialogResult.Yes)
                        //    {
                        //        comm.DeleteData("InwardEntry", "InwardId=" + dgList.Rows[e.RowIndex].Cells[2].Value + " and CompanyId=" + ClsComm.CompanyId + " and YearId=" + ClsComm.YearId);
                        //        comm.DeleteData("tbLedger", "TxnId=" + dgList.Rows[e.RowIndex].Cells[2].Value + " and TxnType='I' and CompanyId=" + ClsComm.CompanyId + " and YearId=" + ClsComm.YearId);
                        //        dgList.Rows.Remove(dgList.Rows[e.RowIndex]);
                        //        dgList.Refresh();
                        //    }
                        //}
                    }
                }
                #endregion

                #region Outward Entry

                else if (ClickName.ToUpper() == "OutwardEntry".ToString().ToUpper())
                {
                    ClsComm comm = new ClsComm();
                    dt = new DataTable();
                    if (e.ColumnIndex == 0)
                    {
                        FrmOutwardLatest frmOutward = new FrmOutwardLatest();
                      //  frmOutward.ProcFillForm(dgList.Rows[e.RowIndex].Cells[2].Value);
                        //frmOutward.ShowDialog();
                        frmOutward.MdiParent = this.MdiParent;
                        frmOutward.BringToFront();
                        frmOutward.WindowState = FormWindowState.Maximized;
                        frmOutward.Dock = DockStyle.Fill;
                        frmOutward.Show();


                        dt = comm.FillTable("SELECT OutwardEntry.OutwardId, Supplier.SupplierName as CustomerName, OutwardEntry.InvoiceNo, format(OutwardEntry.InvoiceDate,\"dd/mm/yyyy\") as InvoiceDate " +
                                    " FROM OutwardEntry INNER JOIN Supplier ON OutwardEntry.CustomerId = Supplier.SupplierId " +
                                    " WHERE (((Supplier.Type)='Customer')) AND OutwardEntry.OutwardId=" + dgList.Rows[e.RowIndex].Cells[2].Value + "" +
                                    " ORDER BY OutwardEntry.InvoiceDate Desc;");

                        //dt = comm.FillTable("Select O.OutwardId,V.VehicleNo,O.DocNo,format(O.DocDate,\"dd/mm/yyyy\") as DocDate,O.InchargeName,O.IssueTo from OutwardEntry O inner join Vehicle V on V.VehicleId=O.VehicleId where O.OutwardId=" + dgList.Rows[e.RowIndex].Cells[2].Value);
                        if (dt.Rows.Count > 0)
                        {
                            dgList[3, e.RowIndex].Value = dt.Rows[0]["CustomerName"].ToString();
                            dgList[4, e.RowIndex].Value = dt.Rows[0]["InvoiceNo"].ToString();
                            dgList[5, e.RowIndex].Value = dt.Rows[0]["InvoiceDate"].ToString();
                            //dgList[6, e.RowIndex].Value = dt.Rows[0]["CategoryName"].ToString();
                            //dgList[7, e.RowIndex].Value = dt.Rows[0]["ItemName"].ToString();
                        }


                    }
                    else if (e.ColumnIndex == 1)
                    {
                        DialogResult MsgDialog;

                        MsgDialog = MessageBox.Show("Are You sure you want to delete?", "SOUMCO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (MsgDialog == DialogResult.Yes)
                        {
                            comm.DeleteData("OutwardEntry", "OutwardId=" + dgList.Rows[e.RowIndex].Cells[2].Value + " and CompanyId=" + ClsComm.CompanyId + " and YearId=" + ClsComm.YearId);
                            comm.DeleteData("tbLedger", "TxnId=" + dgList.Rows[e.RowIndex].Cells[2].Value + " and TxnType='O' and CompanyId=" + ClsComm.CompanyId + " and YearId=" + ClsComm.YearId);
                            dgList.Rows.Remove(dgList.Rows[e.RowIndex]);
                            dgList.Refresh();
                        }
                    }
                }
                #endregion

                #region user Info
                else if (ClickName.ToUpper() == "User".ToString().ToUpper())
                {
                    ClsComm comm = new ClsComm();
                    dt = new DataTable();
                    if (e.ColumnIndex == 0)
                    {
                        FrmUser user = new FrmUser();
                        user.ProcFillForm(dgList.Rows[e.RowIndex].Cells[2].Value);
                        user.ShowDialog();
                    }
                    else if (e.ColumnIndex == 1)
                    {
                        DialogResult MsgDialog;
                        if (dgList.Rows[e.RowIndex].Cells[3].Value.ToString() != "Admin")
                        {
                            MsgDialog = MessageBox.Show("Are you sure you want to delete " + dgList.Rows[e.RowIndex].Cells[3].Value, "SOUMCO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (MsgDialog == DialogResult.Yes)
                            {
                                comm.DeleteData("UserInfo", "UserId=" + dgList.Rows[e.RowIndex].Cells[2].Value);
                                dgList.Rows.Remove(dgList.Rows[e.RowIndex]);
                                dgList.Refresh();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cannot delete! " + dgList.Rows[e.RowIndex].Cells[3].Value, "SOUMCO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                #endregion

                #region Density Info

                else if (ClickName.ToUpper() == "DENSITY".ToString().ToUpper())
                {
                    ClsComm comm = new ClsComm();
                    dt = new DataTable();
                    if (e.ColumnIndex == 0)
                    {
                        FrmDensity objDensity = new FrmDensity();
                        objDensity.ProcFillForm(dgList.Rows[e.RowIndex].Cells[2].Value);
                        objDensity.ShowDialog();
                        dt = comm.FillTable("Select DensityId,DensityName,DensityValue,[Description] as Description From Density where DensityId=" + dgList.Rows[e.RowIndex].Cells[2].Value);
                        if (dt.Rows.Count > 0)
                        {
                            dgList[3, e.RowIndex].Value = dt.Rows[0]["DensityName"].ToString();
                            dgList[4, e.RowIndex].Value = dt.Rows[0]["DensityValue"].ToString();
                            dgList[5, e.RowIndex].Value = dt.Rows[0]["Description"].ToString();

                        }

                    }
                    else if (e.ColumnIndex == 1)
                    {
                        DialogResult MsgDialog;
                        if (dgList.Rows[e.RowIndex].Cells[3].Value.ToString() != "Admin")
                        {
                            MsgDialog = MessageBox.Show("Are you sure you want to delete " + dgList.Rows[e.RowIndex].Cells[3].Value, "SOUMCO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (MsgDialog == DialogResult.Yes)
                            {
                                comm.DeleteData("Density", "DensityId=" + dgList.Rows[e.RowIndex].Cells[2].Value);
                                dgList.Rows.Remove(dgList.Rows[e.RowIndex]);
                                dgList.Refresh();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cannot delete! " + dgList.Rows[e.RowIndex].Cells[3].Value, "SOUMCO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                #endregion

                #region Category Info

                else if (ClickName.ToUpper() == "Category".ToString().ToUpper())
                {
                    ClsComm comm = new ClsComm();
                    dt = new DataTable();
                    if (e.ColumnIndex == 0)
                    {
                        FrmCategory objCategory = new FrmCategory();
                        objCategory.ProcFillForm(dgList.Rows[e.RowIndex].Cells[2].Value);
                        objCategory.ShowDialog();
                        ProductTypeInfo objProductInfo = new ProductTypeInfo();
                        var client = new HttpClient();

                        HttpResponseMessage response = await client.GetAsync(Common.Common.APIURL_PRODUCTTYPE_GETBY_ID + "?Id=" + dgList.Rows[e.RowIndex].Cells[2].Value.ToString());
                        var fileJsonString = await response.Content.ReadAsStringAsync();
                        // DataTable dtList = (DataTable)JsonConvert.DeserializeObject(fileJsonString, (typeof(DataTable)));
                        objProductInfo = JsonConvert.DeserializeObject<ProductTypeInfo>(fileJsonString);
                        if (objProductInfo.productTypeId > 0)
                        {
                            dgList[3, e.RowIndex].Value = objProductInfo.productTypeName;
                            dgList[4, e.RowIndex].Value = objProductInfo.description;
                        }

                        dgList.Refresh();

                        //dt = comm.FillTable("Select CategoryId,CategoryName,Description from Category where CategoryId=" + dgList.Rows[e.RowIndex].Cells[2].Value);
                        //if (dt.Rows.Count > 0)
                        //{
                        //    dgList[3, e.RowIndex].Value = dt.Rows[0]["CategoryName"].ToString();
                        //    dgList[4, e.RowIndex].Value = dt.Rows[0]["Description"].ToString();

                        //}
                    }
                    else if (e.ColumnIndex == 1)
                    {
                        DialogResult MsgDialog;
                        if (dgList.Rows[e.RowIndex].Cells[3].Value.ToString() != "Admin")
                        {
                            MsgDialog = MessageBox.Show("Are you sure you want to delete " + dgList.Rows[e.RowIndex].Cells[3].Value, "SOUMCO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (MsgDialog == DialogResult.Yes)
                            {
                                comm.DeleteData("Category", "CategoryId=" + dgList.Rows[e.RowIndex].Cells[2].Value);
                                dgList.Rows.Remove(dgList.Rows[e.RowIndex]);
                                dgList.Refresh();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cannot delete! " + dgList.Rows[e.RowIndex].Cells[3].Value, "SOUMCO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                #endregion


                #region Sub Category Info

                else if (ClickName.ToUpper() == "SUBCategory".ToString().ToUpper())
                {
                    ClsComm comm = new ClsComm();
                    dt = new DataTable();
                    if (e.ColumnIndex == 0)
                    {
                        FrmSubCategory objCategory = new FrmSubCategory();
                        objCategory.ProcFillForm(dgList.Rows[e.RowIndex].Cells[2].Value);
                        objCategory.ShowDialog();

                        ProductSizeInfo objProductInfo = new ProductSizeInfo();
                        var client = new HttpClient();

                        HttpResponseMessage response = await client.GetAsync(Common.Common.APIURL_PRODUCTSIZE_GETBY_ID + "?Id=" + dgList.Rows[e.RowIndex].Cells[2].Value.ToString());
                        var fileJsonString = await response.Content.ReadAsStringAsync();
                        // DataTable dtList = (DataTable)JsonConvert.DeserializeObject(fileJsonString, (typeof(DataTable)));
                        objProductInfo = JsonConvert.DeserializeObject<ProductSizeInfo>(fileJsonString);
                        if (objProductInfo.productSizeId > 0)
                        {
                            dgList[3, e.RowIndex].Value = objProductInfo.productSizeName;
                            dgList[4, e.RowIndex].Value = objProductInfo.productSizedescription;
                            dgList[5, e.RowIndex].Value = objProductInfo.productTypeId;
                            dgList[6, e.RowIndex].Value = objProductInfo.productTypeName;
                        }

                        dgList.Refresh();


                        //dt = comm.FillTable("Select SubCategoryId,SubCategoryName,Description from SubCategory where SubCategoryId=" + dgList.Rows[e.RowIndex].Cells[2].Value);
                        //if (dt.Rows.Count > 0)
                        //{
                        //    dgList[3, e.RowIndex].Value = dt.Rows[0]["SubCategoryName"].ToString();
                        //    dgList[4, e.RowIndex].Value = dt.Rows[0]["Description"].ToString();

                        //}
                    }
                    else if (e.ColumnIndex == 1)
                    {
                        DialogResult MsgDialog;
                        if (dgList.Rows[e.RowIndex].Cells[3].Value.ToString() != "Admin")
                        {
                            MsgDialog = MessageBox.Show("Are you sure you want to delete " + dgList.Rows[e.RowIndex].Cells[3].Value, "SOUMCO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (MsgDialog == DialogResult.Yes)
                            {
                                comm.DeleteData("SubCategory", "SubCategoryId=" + dgList.Rows[e.RowIndex].Cells[2].Value);
                                dgList.Rows.Remove(dgList.Rows[e.RowIndex]);
                                dgList.Refresh();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cannot delete! " + dgList.Rows[e.RowIndex].Cells[3].Value, "SOUMCO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                #endregion

                #region Company Info

                else if (ClickName.ToUpper() == "Company".ToString().ToUpper())
                {
                    ClsComm comm = new ClsComm();
                    dt = new DataTable();
                    if (e.ColumnIndex == 0)
                    {
                        FrmCompany objCategory = new FrmCompany();
                        objCategory.ProcFillForm(dgList.Rows[e.RowIndex].Cells[2].Value);
                        objCategory.ShowDialog();
                        dt = comm.FillTable("Select CompanyId,CompanyName,GSTNo from Company where CompanyId=" + dgList.Rows[e.RowIndex].Cells[2].Value);
                        if (dt.Rows.Count > 0)
                        {
                            dgList[3, e.RowIndex].Value = dt.Rows[0]["CompanyName"].ToString();
                            dgList[4, e.RowIndex].Value = dt.Rows[0]["GSTNo"].ToString();

                        }
                    }
                    else if (e.ColumnIndex == 1)
                    {
                        DialogResult MsgDialog;
                        if (dgList.Rows[e.RowIndex].Cells[3].Value.ToString() != "Admin")
                        {
                            MsgDialog = MessageBox.Show("Are you sure you want to delete " + dgList.Rows[e.RowIndex].Cells[3].Value, "SOUMCO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (MsgDialog == DialogResult.Yes)
                            {
                                comm.DeleteData("Company", "CompanyId=" + dgList.Rows[e.RowIndex].Cells[2].Value);
                                dgList.Rows.Remove(dgList.Rows[e.RowIndex]);
                                dgList.Refresh();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cannot delete! " + dgList.Rows[e.RowIndex].Cells[3].Value, "SOUMCO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                    #endregion
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            FilterData("Company", cmbFilterBy.Text, txtFilterValue.Text);
        }
        
    }
   
}