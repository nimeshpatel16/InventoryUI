using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data;

namespace SOUMCO
{
    class ClsComm
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(String section, String key, String val, String filepath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(String section, String key, String def, StringBuilder retval, int size, String filepath);
        public static String m_Connectionstr=string.Empty;
        public static string strUserId = string.Empty;
        public static int CompanyId;
        public static int YearId;
        public static bool tUserRightToEdit = false;
        public bool IsAdminUser = false;
        OleDbConnection connstr = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter MyADP;        

        public void ConnectToAccess()
        {

            connstr.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + m_Connectionstr + ";Persist Security Info=True;Jet OLEDB:Database Password=dingbat";
            
            
            try
            {
                connstr.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long IniWriteValue(String Section, String Key, String Value, String Path)
        {
            long ret = WritePrivateProfileString(Section, Key, Value, Path);
            return ret;
        }
        public string IniReadValue(String Section, String Key, String Path)
        {
                StringBuilder temp = new StringBuilder(255);
                long i = GetPrivateProfileString(Section, Key, "", temp, 255, Path);
                if (Key == "Connecting")
                {
                    m_Connectionstr = temp.ToString();
                }
                return temp.ToString();
        }
        
        public int GetUniqueId(String FeildName, String TableName)
        {
            int GetValue;
            string Str = String.Format("Select Max({0}) as Id from {1}", FeildName, TableName);
            ConnectToAccess();
            cmd.CommandText = Str;
            cmd.Connection = connstr;
            if (cmd.ExecuteScalar() == DBNull.Value)
            {
                GetValue = 1;
            }
            else
            {
                GetValue = Convert.ToInt32(cmd.ExecuteScalar())+1;
            }
            connstr.Close();
            return GetValue;
        }
        public void AddData(String TableName, String Feild, String Values, bool AddDefaultColumns=false)
        {
            string Str = string.Empty;
            ConnectToAccess();
            if(AddDefaultColumns)
            {
                Values = Values + "," + ClsComm.strUserId + "," + ClsComm.CompanyId + "," + ClsComm.YearId + ",'" + DateTime.Now + "','" + DateTime.Now + "'";
            }
            
            if (Feild == null)
            {
                Str = "Insert Into " + TableName + " Values(" + Values + ")";
            }
            else
            {
                Str = "Insert Into " + TableName + " ("+ Feild +") Values(" + Values + ")";
            }
            
            cmd.CommandText = Str;
            cmd.Connection = connstr;
            cmd.ExecuteNonQuery();
            connstr.Close();
        }
        public void EditData(String TableName, String Values, String Condition, bool EditDefaultColumns = false)
        {
            string Str = string.Empty;
            ConnectToAccess();
            if (EditDefaultColumns)
            {
                Values = Values + ",UserId=" + ClsComm.strUserId + ",CompanyId=" + ClsComm.CompanyId + ",YearId=" + ClsComm.YearId + ",ModifiedDate='" + DateTime.Now + "'";
            }

            if (Condition == null)
            {
                Str = "Update " + TableName + " Set " + Values + "";
            }
            else
            {
                Str = "Update " + TableName + " Set " + Values + " Where " + Condition;
            }
            
            cmd.CommandText = Str;
            cmd.Connection = connstr;
            cmd.ExecuteNonQuery();
            connstr.Close();
        }
        public void DeleteData(String TableName, String Condition)
        {
            string Str = string.Empty;
            ConnectToAccess();
            if (Condition == null)
            {
                Str = "Delete from " + TableName;
            }
            else
            {
                Str = "Delete from " + TableName + " where " + Condition;
            }
            cmd.CommandText = Str;
            cmd.Connection = connstr;
            cmd.ExecuteNonQuery();
            connstr.Close();
        }
        public enum enmDataState
        {
            StateNone = 0,
            StateAdd = 1,
            StateEdit = 2,
            StateDelete = 3,
        }
        private DataTable FillDatatableForCombo(DataTable DT, string strValuemember, string strDisplayMember, string TableName, string OrderBy)
        {
            string strQuery = string.Empty;
            if (OrderBy == null)
                strQuery = String.Format("Select {0},{1} from {2}", strValuemember, strDisplayMember, TableName);
            else
                strQuery = String.Format("Select {0},{1} from {2} Order By {3}", strValuemember, strDisplayMember, TableName, OrderBy);
            ConnectToAccess();
            cmd.CommandText = strQuery;
            cmd.Connection = connstr;
            MyADP = new OleDbDataAdapter(cmd);
            MyADP.Fill(DT);
            connstr.Close();
            return DT;
        }
        private DataTable FillDatatableForCombo(DataTable DT, string strQuery)
        {
            ConnectToAccess();
            cmd.CommandText = strQuery;
            cmd.Connection = connstr;
            MyADP = new OleDbDataAdapter(cmd);
            MyADP.Fill(DT);
            connstr.Close();
            return DT;
        }
        public ComboBox BindCombo(ComboBox CmbCombo, Boolean AddNew, string strValueMember, string strDisplayMember, string strTableName, string OrderBy)
        {
            DataTable Xtable = new DataTable();
            FillDatatableForCombo(Xtable, strValueMember, strDisplayMember, strTableName, OrderBy);

            if (AddNew == true)
            {
                DataRow DR = Xtable.NewRow();
                DataRow DR1 = Xtable.NewRow();
                DR[strDisplayMember] = "--Select--";
                DR[strValueMember] = "-1";
                Xtable.Rows.InsertAt(DR, 0);
                DR1[strDisplayMember] = "------------------";
                DR1[strValueMember] = "-2";
                Xtable.Rows.InsertAt(DR1, 1);

            }

            CmbCombo.DataSource = null;
            CmbCombo.DisplayMember = null;
            CmbCombo.ValueMember = null;
            CmbCombo.DataBindings.Clear();

            CmbCombo.DataSource = Xtable;
            if (strDisplayMember.Trim() != "")
                CmbCombo.DisplayMember = strDisplayMember;
            if (strValueMember.Trim() != "")
                CmbCombo.ValueMember = strValueMember;

            CmbCombo.DataBindings.Add("Tag", Xtable, strDisplayMember);
            return CmbCombo;
        }
        
        public DataGridViewComboBoxColumn GridBindCombo(DataGridViewComboBoxColumn CmbCombo, Boolean AddNew, string strValueMember, string strDisplayMember, string strTableName, string OrderBy)
        {
            DataTable Xtable = new DataTable();
            FillDatatableForCombo(Xtable, strValueMember, strDisplayMember, strTableName, OrderBy);

            if (AddNew == true)
            {
                DataRow DR = Xtable.NewRow();
                DataRow DR1 = Xtable.NewRow();
                DR[strDisplayMember] = "Add New";
                DR[strValueMember] = "-1";
                Xtable.Rows.InsertAt(DR, 0);
                DR1[strDisplayMember] = "------------------";
                DR1[strValueMember] = "-2";
                Xtable.Rows.InsertAt(DR1, 1);

            }

            CmbCombo.DataSource = null;
            CmbCombo.DisplayMember = null;
            CmbCombo.ValueMember = null;
            //CmbCombo.DataBindings.Clear();

            CmbCombo.DataSource = Xtable;
            if (strDisplayMember.Trim() != "")
                CmbCombo.DisplayMember = strDisplayMember;
            if (strValueMember.Trim() != "")
                CmbCombo.ValueMember = strValueMember;

            //CmbCombo.DataBindings.Add("Tag", Xtable, strDisplayMember);
            return CmbCombo;
        }

        public DataGridViewComboBoxColumn GridBindCombo(DataGridViewComboBoxColumn CmbCombo, Boolean AddNew, string strValueMember, string strDisplayMember, string strQuery)
        {
            DataTable Xtable = new DataTable();
            FillDatatableForCombo(Xtable, strQuery);

            if (AddNew == true)
            {
                DataRow DR = Xtable.NewRow();
                DataRow DR1 = Xtable.NewRow();
                DR[strDisplayMember] = "Add New";
                DR[strValueMember] = "-1";
                Xtable.Rows.InsertAt(DR, 0);
                DR1[strDisplayMember] = "------------------";
                DR1[strValueMember] = "-2";
                Xtable.Rows.InsertAt(DR1, 1);

            }

            CmbCombo.DataSource = null;
            CmbCombo.DisplayMember = null;
            CmbCombo.ValueMember = null;
            //CmbCombo.DataBindings.Clear();

            CmbCombo.DataSource = Xtable;
            if (strDisplayMember.Trim() != "")
                CmbCombo.DisplayMember = strDisplayMember;
            if (strValueMember.Trim() != "")
                CmbCombo.ValueMember = strValueMember;

            //CmbCombo.DataBindings.Add("Tag", Xtable, strDisplayMember);
            return CmbCombo;
        }
        
        public ComboBox BindCombo(ComboBox CmbCombo, Boolean AddNew, string strquery)
        {
            try
            {
                DataTable Xtable = new DataTable();
                FillDatatableForCombo(Xtable, strquery);

                
                
                if (AddNew == true)
                {
                    DataRow DR = Xtable.NewRow();
                    DataRow DR1 = Xtable.NewRow();
                    DR[Xtable.Columns[1].ColumnName] = "--Select--";
                    DR[Xtable.Columns[0].ColumnName] = "-1";
                    Xtable.Rows.InsertAt(DR, 0);
                    DR1[Xtable.Columns[1].ColumnName] = "------------------";
                    DR1[Xtable.Columns[0].ColumnName] = "-2";
                    Xtable.Rows.InsertAt(DR1, 1);

                }

                CmbCombo.DataSource = null;
                CmbCombo.DisplayMember = null;
                CmbCombo.ValueMember = null;
                CmbCombo.DataBindings.Clear();


                CmbCombo.DataSource = Xtable;
                CmbCombo.DisplayMember = Xtable.Columns[1].ColumnName.ToString();
                CmbCombo.ValueMember = Xtable.Columns[0].ColumnName.ToString();


                CmbCombo.DataBindings.Add("Tag", Xtable, Xtable.Columns[1].ColumnName.ToString());
                return CmbCombo;


                //gDA = null;
                //gDA = new SqlDataAdapter(query, ConnectionString);
                //DataTable srcTable = new DataTable();
                //gDA.SelectCommand.CommandTimeout = 0;
                //srcTable = null;
                //srcTable = new DataTable();
                //gDA.Fill(srcTable);
                //cmbCombo.DataSource = srcTable;
                //cmbCombo.DisplayMember = srcTable.Columns[1].ColumnName.ToString();
                //cmbCombo.ValueMember = srcTable.Columns[0].ColumnName.ToString();
                //cmbCombo.SelectedIndex = 0;
                //return (cmbCombo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public ComboBox BindComboForAll(ComboBox CmbCombo, Boolean AddNew, string strquery)
        {
            try
            {
                DataTable Xtable = new DataTable();
                FillDatatableForCombo(Xtable, strquery);

                CmbCombo.DataSource = null;
                CmbCombo.DisplayMember = null;
                CmbCombo.ValueMember = null;
                CmbCombo.DataBindings.Clear();

                if (AddNew == true)
                {
                    DataRow DR = Xtable.NewRow();
                    DataRow DR1 = Xtable.NewRow();
                    DR[CmbCombo.DisplayMember] = "All";
                    DR[CmbCombo.ValueMember] = "-1";
                    Xtable.Rows.InsertAt(DR, 0);
                    DR1[CmbCombo.DisplayMember] = "------------------";
                    DR1[CmbCombo.ValueMember] = "-2";
                    Xtable.Rows.InsertAt(DR1, 1);

                }



                CmbCombo.DataSource = Xtable;
                CmbCombo.DisplayMember = Xtable.Columns[1].ColumnName.ToString();
                CmbCombo.ValueMember = Xtable.Columns[0].ColumnName.ToString();


                CmbCombo.DataBindings.Add("Tag", Xtable, Xtable.Columns[1].ColumnName.ToString());
                return CmbCombo;


                //gDA = null;
                //gDA = new SqlDataAdapter(query, ConnectionString);
                //DataTable srcTable = new DataTable();
                //gDA.SelectCommand.CommandTimeout = 0;
                //srcTable = null;
                //srcTable = new DataTable();
                //gDA.Fill(srcTable);
                //cmbCombo.DataSource = srcTable;
                //cmbCombo.DisplayMember = srcTable.Columns[1].ColumnName.ToString();
                //cmbCombo.ValueMember = srcTable.Columns[0].ColumnName.ToString();
                //cmbCombo.SelectedIndex = 0;
                //return (cmbCombo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public ComboBox BindComboForAll(ComboBox CmbCombo, Boolean AddNew, string strValueMember, string strDisplayMember, string strTableName, string OrderBy)
        {
            DataTable Xtable = new DataTable();
            FillDatatableForCombo(Xtable, strValueMember, strDisplayMember, strTableName, OrderBy);

            if (AddNew == true)
            {
                DataRow DR = Xtable.NewRow();
                DataRow DR1 = Xtable.NewRow();
                DR[strDisplayMember] = "All";
                DR[strValueMember] = "-1";
                Xtable.Rows.InsertAt(DR, 0);
                DR1[strDisplayMember] = "------------------";
                DR1[strValueMember] = "-2";
                Xtable.Rows.InsertAt(DR1, 1);

            }

            CmbCombo.DataSource = null;
            CmbCombo.DisplayMember = null;
            CmbCombo.ValueMember = null;
            CmbCombo.DataBindings.Clear();

            CmbCombo.DataSource = Xtable;
            if (strDisplayMember.Trim() != "")
                CmbCombo.DisplayMember = strDisplayMember;
            if (strValueMember.Trim() != "")
                CmbCombo.ValueMember = strValueMember;

            CmbCombo.DataBindings.Add("Tag", Xtable, strDisplayMember);
            return CmbCombo;
        }
        public DataTable FillTable(string FieldNames, string TableName, string WhereCaluse, string OrderBy)
        {
            DataTable DT = new DataTable();
            string strQuery = String.Format("Select {0} From {1} {2} {3}", FieldNames, TableName, WhereCaluse, OrderBy);
            ConnectToAccess();
            cmd.CommandText = strQuery;
            cmd.Connection = connstr;
            MyADP = new OleDbDataAdapter(cmd);
            MyADP.Fill(DT);
            connstr.Close();
            return DT;
        }

        public DataTable FillTable(string strQuery)
        {
            DataTable DT = new DataTable();
            if (!string.IsNullOrEmpty(strQuery))
            {
                ConnectToAccess();
                cmd.CommandText = strQuery;
                cmd.Connection = connstr;
                MyADP = new OleDbDataAdapter(cmd);
                MyADP.Fill(DT);
                connstr.Close();
            }
            return DT;
        }

        public String GetRowValuesOfColumns(DataGridView Dg,String StrColName)
        {
            string myValue=string.Empty;
            int i=0;
            for(i=0;i<Dg.Rows.Count-1;i++)
            {
                if (Dg[StrColName, i].Value != null)
                {
                    if (myValue == "")
                    {
                        myValue = Dg[StrColName, i].Value.ToString();
                    }
                    else
                    {

                        myValue = myValue + "," + Dg[StrColName, i].Value;
                    }
                }
                
            }
            return myValue;
        }

        public string GetValue(String FeildName, String TableName, String Condition, bool FilterByCompanyIdAndYearId = false)
        {
            string strCompanyAndYearIdFilter;
            if (FilterByCompanyIdAndYearId)
            {
                strCompanyAndYearIdFilter = " And CompanyId=" + ClsComm.CompanyId.ToString() + " And YearId=" + ClsComm.YearId.ToString();
                Condition = Condition + strCompanyAndYearIdFilter;
            }
            string GetValue;
            string Str = String.Format("Select {0} from {1} where {2}", FeildName, TableName,Condition);
            ConnectToAccess();
            cmd.CommandText = Str;
            cmd.Connection = connstr;
            if (cmd.ExecuteScalar() == DBNull.Value)
            {
                GetValue = "";
            }
            else
            {
                 if(cmd.ExecuteScalar()==null) 
                {
                    GetValue = null;
                }
                else
                {
                    GetValue = cmd.ExecuteScalar().ToString();
                }
            }
            connstr.Close();
            return GetValue;
        }
        public string GetValue(String SqlQuery, bool FilterByCompanyIdAndYearId=false)
        {
            string strCompanyAndYearIdFilter;
            if(FilterByCompanyIdAndYearId)
            {
                strCompanyAndYearIdFilter = " And CompanyId=" + ClsComm.CompanyId.ToString() + " And YearId=" + ClsComm.YearId.ToString();
                SqlQuery = SqlQuery + strCompanyAndYearIdFilter;
            }
            string GetValue;
            
            ConnectToAccess();
            cmd.CommandText = SqlQuery;
            cmd.Connection = connstr;
            if (cmd.ExecuteScalar() == DBNull.Value)
            {
                GetValue = "";
            }
            else
            {
                if (cmd.ExecuteScalar() == null)
                {
                    GetValue = null;
                }
                else
                {
                    GetValue = cmd.ExecuteScalar().ToString();
                }
            }
            connstr.Close();
            return GetValue;
        }
        public double GetValueint(String FeildName, String TableName, String Condition)
        {
            double GetValue;
            string Str = String.Format("Select {0} from {1} where {2}", FeildName, TableName, Condition);
            ConnectToAccess();
            cmd.CommandText = Str;
            cmd.Connection = connstr;
            if (cmd.ExecuteScalar() == DBNull.Value)
            {
                GetValue = 0;
            }
            else
            {
                if (cmd.ExecuteScalar() == null)
                {
                    GetValue =0;
                }
                else
                {
                    GetValue =Convert.ToDouble(cmd.ExecuteScalar());
                }
            }
            connstr.Close();
            return GetValue;
        }
        public double GetValueint(String SqlQuery)
        {
            double GetValue;

            ConnectToAccess();
            cmd.CommandText = SqlQuery;
            cmd.Connection = connstr;
            if (cmd.ExecuteScalar() == DBNull.Value)
            {
                GetValue = 0;
            }
            else
            {
                if (cmd.ExecuteScalar() == null)
                {
                    GetValue = 0;
                }
                else
                {
                    GetValue = Convert.ToDouble(cmd.ExecuteScalar());
                }
            }
            connstr.Close();
            return GetValue;
        }

        public OleDbDataReader ReadDataReader(string strQuery)
        {
            return GetDataReader(strQuery);
        }

        private OleDbDataReader GetDataReader(string strQuery)
        {
            OleDbDataReader Dr= default(OleDbDataReader);
            if (!String.IsNullOrEmpty(strQuery))
            {
                ConnectToAccess();
                cmd.CommandText = strQuery;
                cmd.Connection = connstr;
                Dr = cmd.ExecuteReader();
                connstr.Close();
                
            }
            return Dr;
        }

        public void StockLedger(string OperationType,int TxnId,int TxnDId, string TxnType, string InvoiceNo, DateTime InvoiceDate, int ItemId, int CategoryId, double Qty, double Kgs, double FormulatedKg, bool AddDefaultColumns=false)
        {
            int iLedgerId;
            //if(OperationType=="Edit")
            //{
            //    DeleteData("tbLedger", "TxnId=" + TxnId + " and TxnType='" + TxnType + "' and CompanyId=" + ClsComm.CompanyId + " and YearId=" + ClsComm.YearId);
            //}
            iLedgerId = GetUniqueId("LedgerId", "tbLedger");
            AddData("tbLedger", null, iLedgerId + "," + TxnId + "," + TxnDId + ",'" + TxnType + "','" + InvoiceNo + "','" + InvoiceDate + "'," + ItemId + "," + CategoryId + "," + Qty + "," + Kgs + "," + FormulatedKg + "", true);
            
        }

        public double CalculateKgs(string category, double qty = 0, double diameter = 0, double length = 0, double OD = 0, double ID = 0,
           double width = 0, double thickness = 0, double size = 0, double density = 0, double kgs = 0)
        {
            double dTotalKgs = 0;
            double dTotalPerUnit = 0, dOD = 0, dID = 0;
            diameter = diameter / 2;
            OD = OD / 2;
            ID = ID / 2;
            // category = cmbCategory.Text;
            if (category == null) { category = string.Empty; }

            if (category.Contains("ROD"))
                category = "ROD";
            if (category.Contains("BUSH"))
                category = "BUSH";
            if (category.Contains("SHEET"))
                category = "SHEET";

            switch (category)
            {
                case "ROD":
                    dTotalPerUnit = (3.14 * diameter * diameter * length * density) / 1000000;
                    dTotalKgs = Math.Round(Convert.ToDouble(qty * dTotalPerUnit), 3);
                    break;
                case "BUSH":
                case "PIPE":
                    dOD = Math.Round((3.14 * OD * OD * length * density) / 1000000, 3);
                    dID = Math.Round((3.14 * ID * ID * length * density) / 1000000, 3);
                    dTotalPerUnit = dOD - dID;
                    dTotalKgs = Convert.ToDouble(qty * dTotalPerUnit);
                    break;
                case "SHEET":
                    dTotalPerUnit = Math.Round((thickness * length * width * density) / 1000000, 3);
                    dTotalKgs = Math.Round(Convert.ToDouble(qty * dTotalPerUnit), 3);
                    break;
                default:
                    dTotalKgs = Math.Round(kgs, 3);
                    break;

            }

            return dTotalKgs;
        }

        public Boolean GetLicense(DateTime dtValue)
        {
            if (dtValue > Convert.ToDateTime("13/08/2020").Date)
            {
                MessageBox.Show("License expired -- for continue please contact on 9227140054", "License Info");
                return false;
            }
            return true;
        }
    }
}
