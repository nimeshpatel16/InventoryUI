using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace SOUMCO
{
    class clsExcelReport
    {
        Microsoft.Office.Interop.Excel.Application ExApp;
        Microsoft.Office.Interop.Excel.Workbook WB;
        Microsoft.Office.Interop.Excel.Worksheet WS;
        Microsoft.Office.Interop.Excel.Range range;
        System.Data.DataTable DtLocal;
        public string m_ClickReport = "";

        private void ExcelApp()
        {
            ExApp = new Application();
            ExApp.Visible = true;
            WB = ExApp.Workbooks.Add(Missing.Value);
            WS = (Worksheet)WB.Worksheets["Sheet1"];
            WS.Cells.Select();
            ExApp.ActiveWindow.DisplayGridlines = false;

        }

        public bool VehicleWiseTransaction(int Id, DateTime FromDate, DateTime ToDate)
        {
            int i = 0, j = 0;
            j = 5;
            ExcelApp();
            ClsComm comm = new ClsComm();
            DtLocal = new System.Data.DataTable();
            DtLocal = comm.FillTable("SELECT Vehicle.VehicleNo, OutwardEntry.DocNo, Format(OutwardEntry.DocDate,\"DD/MM/YYYY\") as DocDate, OutwardEntry.InchargeName, OutwardEntry.IssueTo, OutwardEntry.VehicleId " +
                                   " FROM Vehicle INNER JOIN OutwardEntry ON (Vehicle.VehicleId = OutwardEntry.VehicleId) AND (Vehicle.VehicleId = OutwardEntry.VehicleNo) " +
                                   " WHERE OutwardEntry.VehicleId=" + Id + " And  OutwardEntry.DocDate between #" + FromDate + "# and #" + ToDate + "#");
            WS.get_Range("B2", "F2").Merge(null);
            WS.get_Range("B2", Type.Missing).Value2 = "Vehicle wise transaction period From:" + String.Format("{0:dd/MM/yyyy}", FromDate) + " To:" + String.Format("{0:dd/MM/yyyy}", ToDate);
            WS.get_Range("B2", Type.Missing).Font.Bold = true;
            WS.get_Range("B2", Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;

            if (DtLocal.Rows.Count > 0)
            {
                WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).Value2 = "VehicleNo";
                WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).Value2 = "Doc No";
                WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).Value2 = "Date";
                WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                WS.get_Range("E" + Convert.ToString(j - 1), Type.Missing).Value2 = "InchargeName";  //"Instl Amt"
                WS.get_Range("E" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 13;
                WS.get_Range("F" + Convert.ToString(j - 1), Type.Missing).Value2 = "IssueTo";  //"Instl Amt"
                WS.get_Range("F" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 13;
                WS.get_Range("B4", "F4").Font.Bold = true;

                for (i = 0; i <= DtLocal.Rows.Count - 1; i++)
                {
                    WS.get_Range("B" + j, Type.Missing).Value2 = DtLocal.Rows[i]["VehicleNo"].ToString();
                    WS.get_Range("C" + j, Type.Missing).Value2 = DtLocal.Rows[i]["DocNo"].ToString();
                    WS.get_Range("C" + j, Type.Missing).HorizontalAlignment = XlVAlign.xlVAlignCenter;
                    WS.get_Range("D" + j, Type.Missing).Value2 = string.Format("{0:dd/MM/yyyy}", DtLocal.Rows[i]["DocDate"].ToString());
                    WS.get_Range("D" + j, Type.Missing).NumberFormat = "dd/MM/yyyy";
                    WS.get_Range("D" + j, Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignLeft;
                    WS.get_Range("E" + j, Type.Missing).Value2 = DtLocal.Rows[i]["InchargeName"].ToString();
                    WS.get_Range("F" + j, Type.Missing).Value2 = DtLocal.Rows[i]["IssueTo"].ToString();
                    j = j + 1;
                }
                WS.get_Range("B4", "F" + Convert.ToString(j)).BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, null);
                range = WS.get_Range("B4", "F" + Convert.ToString(j - 1));
                range.Borders.LineStyle = XlBordersIndex.xlEdgeLeft;
                //WS.get_Range("B" + j, Type.Missing).HorizontalAlignment = XlVAlign.xlVAlignCenter;
                //dt =Convert.ToDateTime(string.Format("{0:dd/MM/yyyy}", LoanDate.AddMonths(i)));
                //WS.get_Range("F" + j, Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                //WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).WrapText = true;
                return true;
            }

            return false;
        }

        public bool ItemwiseInwardOutward(int ItemId, DateTime FromDate, DateTime ToDate)
        {
            int i = 0, j = 0;
            j = 6;
            ExcelApp();
            ClsComm comm = new ClsComm();
            DtLocal = new System.Data.DataTable();
            System.Data.DataTable DtOutward = new System.Data.DataTable();
            DtLocal = comm.FillTable("Select I.ItemName, Format(Inw.InvoiceDate,\"DD/MM/YYYY\") as InvDate, Inw.InvoiceNo, IND.Qty, IND.Rate,IND.BottomRate,S.SupplierName FROM Supplier S INNER JOIN " +
                                   " (Item I INNER JOIN (InwardEntry Inw INNER JOIN InwardDetailEntry IND ON Inw.InwardID = IND.InwardId) ON I.ItemId = IND.ItemId) ON " +
                                   " S.SupplierId = Inw.SupplierId WHERE I.ItemId=" + ItemId + " And  Inw.InvoiceDate between #" + FromDate + "# and #" + ToDate + "#");

            DtOutward = comm.FillTable("Select I.ItemName,V.VehicleNo, V.OperatorName,V.AreaCode ,O.DocNo, Format(O.DocDate,\"DD/MM/YYYY\") as DocDate, O.InchargeName, O.IssueTo,OD.Qty FROM Item I INNER JOIN " +
                                   " ((Vehicle V INNER JOIN OutwardEntry O ON (V.VehicleId = O.VehicleId)) INNER JOIN OutwardDetailEntry OD ON O.OutwardId = OD.OutwardId) ON I.ItemId = OD.ItemId " +
                                   " WHERE OD.ItemId=" + ItemId + " And  O.DocDate between #" + FromDate + "# and #" + ToDate + "#");


            WS.get_Range("B2", "M2").Merge(null);
            WS.get_Range("B2", Type.Missing).Value2 = "Item wise inward/outward Detail period From:" + String.Format("{0:dd/MM/yyyy}", FromDate) + " To:" + String.Format("{0:dd/MM/yyyy}", ToDate);
            WS.get_Range("B2", Type.Missing).Font.Bold = true;
            WS.get_Range("B2", Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
            if (DtLocal.Rows.Count > 0)
            {
                WS.get_Range("B4", Type.Missing).Value2 = "INWARD ENTRY";
                WS.get_Range("B4", Type.Missing).Font.Bold = true;
                WS.get_Range("B4", "G4").Merge(null);
                WS.get_Range("B4", "G4").HorizontalAlignment = XlHAlign.xlHAlignCenter;
                WS.get_Range("B4", "G4").BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, null);
                WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).Value2 = "Item Name";
                WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 18;
                WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).Value2 = "Invoice Date";
                WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 11;
                WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).Value2 = "Invoice No";
                WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                WS.get_Range("E" + Convert.ToString(j - 1), Type.Missing).Value2 = "Qty";  //"Instl Amt"
                WS.get_Range("E" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 8;
                WS.get_Range("F" + Convert.ToString(j - 1), Type.Missing).Value2 = "Rate";  //"Instl Amt"
                WS.get_Range("F" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 8;
                WS.get_Range("G" + Convert.ToString(j - 1), Type.Missing).Value2 = "BottomRate";  //"Instl Amt"
                WS.get_Range("G" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                WS.get_Range("B5", "G5").Font.Bold = true;

                for (i = 0; i <= DtLocal.Rows.Count - 1; i++)
                {
                    WS.get_Range("B" + j, Type.Missing).Value2 = DtLocal.Rows[i]["ItemName"].ToString();
                    WS.get_Range("C" + j, Type.Missing).Value2 = string.Format("{0:dd/MM/yyyy}", DtLocal.Rows[i]["InvDate"].ToString());
                    WS.get_Range("C" + j, Type.Missing).NumberFormat = "dd/MM/yyyy";
                    WS.get_Range("C" + j, Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignLeft;
                    WS.get_Range("D" + j, Type.Missing).Value2 = DtLocal.Rows[i]["InvoiceNo"].ToString();
                    WS.get_Range("E" + j, Type.Missing).Value2 = DtLocal.Rows[i]["Qty"].ToString();
                    WS.get_Range("F" + j, Type.Missing).Value2 = DtLocal.Rows[i]["Rate"].ToString();
                    WS.get_Range("G" + j, Type.Missing).Value2 = DtLocal.Rows[i]["BottomRate"].ToString();
                    j = j + 1;
                }
            }
            int k;
            k = j;
            j = 6;
            if (DtOutward.Rows.Count > 0)
            {
                WS.get_Range("H4", Type.Missing).Value2 = "OUTWARD ENTRY";
                WS.get_Range("H4", Type.Missing).Font.Bold = true;
                WS.get_Range("H4", "M4").Merge(null);
                WS.get_Range("H4", "M4").HorizontalAlignment = XlHAlign.xlHAlignCenter;
                WS.get_Range("H4", "M4").BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, null);
                WS.get_Range("H" + Convert.ToString(j - 1), Type.Missing).Value2 = "Item Name";
                WS.get_Range("H" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 18;
                WS.get_Range("I" + Convert.ToString(j - 1), Type.Missing).Value2 = "DocDate";
                WS.get_Range("I" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                WS.get_Range("J" + Convert.ToString(j - 1), Type.Missing).Value2 = "DocNo";
                WS.get_Range("J" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 8;
                WS.get_Range("K" + Convert.ToString(j - 1), Type.Missing).Value2 = "InchargeName";  //"Instl Amt"
                WS.get_Range("K" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 15;
                WS.get_Range("L" + Convert.ToString(j - 1), Type.Missing).Value2 = "IssueTo";  //"Instl Amt"
                WS.get_Range("L" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 15;
                WS.get_Range("M" + Convert.ToString(j - 1), Type.Missing).Value2 = "Qty";  //"Instl Amt"
                WS.get_Range("M" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 8;
                WS.get_Range("H5", "M5").Font.Bold = true;
                for (i = 0; i <= DtOutward.Rows.Count - 1; i++)
                {
                    WS.get_Range("H" + j, Type.Missing).Value2 = DtOutward.Rows[i]["ItemName"].ToString();
                    WS.get_Range("I" + j, Type.Missing).Value2 = string.Format("{0:dd/MM/yyyy}", DtOutward.Rows[i]["DocDate"].ToString());
                    WS.get_Range("I" + j, Type.Missing).NumberFormat = "dd/MM/yyyy";
                    WS.get_Range("I" + j, Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignLeft;
                    WS.get_Range("J" + j, Type.Missing).Value2 = DtOutward.Rows[i]["DocNo"].ToString();
                    WS.get_Range("K" + j, Type.Missing).Value2 = DtOutward.Rows[i]["InchargeName"].ToString();
                    WS.get_Range("L" + j, Type.Missing).Value2 = DtOutward.Rows[i]["IssueTo"].ToString();
                    WS.get_Range("M" + j, Type.Missing).Value2 = DtOutward.Rows[i]["Qty"].ToString();
                    j = j + 1;
                }
            }
            int t;
            t = j > k ? j : k;
            WS.get_Range("B4", "M" + Convert.ToString(t)).BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, null);
            range = WS.get_Range("B4", "M" + Convert.ToString(t));
            range.Borders.LineStyle = XlBordersIndex.xlEdgeLeft;
            //WS.get_Range("B" + j, Type.Missing).HorizontalAlignment = XlVAlign.xlVAlignCenter;
            //dt =Convert.ToDateTime(string.Format("{0:dd/MM/yyyy}", LoanDate.AddMonths(i)));
            //WS.get_Range("F" + j, Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
            //WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).WrapText = true;
            return true;
        }

        public bool InwardRegister(int SupplierId, string StrCompany, DateTime FromDate, DateTime ToDate)
        {
            int i = 0, j = 0, x = 0, t = 0;
            j = 9;
            x = 6;
            ExcelApp();
            ClsComm comm = new ClsComm();
            DtLocal = new System.Data.DataTable();
            System.Data.DataTable DtSupplier = new System.Data.DataTable();
            System.Data.DataTable DtCompany = new System.Data.DataTable();

            #region Query

            if (SupplierId != -1 && StrCompany != "All")
                DtLocal = comm.FillTable("SELECT S.SupplierName as SupplierName,I.* FROM Supplier S INNER JOIN InwardEntry I ON S.SupplierId = I.SupplierId where I.SupplierId=" + SupplierId + " And I.CompanyName='" + StrCompany + "' And  I.InvoiceDate between #" + FromDate + "# and #" + ToDate + "#");
            else if (SupplierId == -1 && StrCompany != "All")
            {
                DtLocal = comm.FillTable("SELECT S.SupplierName as SupplierName,I.* FROM Supplier S INNER JOIN InwardEntry I ON S.SupplierId = I.SupplierId where I.CompanyName='" + StrCompany + "' And  I.InvoiceDate between #" + FromDate + "# and #" + ToDate + "#");
                DtSupplier = comm.FillTable("SELECT Distinct S.SupplierName as SupplierName FROM Supplier S INNER JOIN InwardEntry I ON S.SupplierId = I.SupplierId where I.CompanyName='" + StrCompany + "' And  I.InvoiceDate between #" + FromDate + "# and #" + ToDate + "# order by S.SupplierName");
            }
            else if (SupplierId != -1 && StrCompany == "All")
                DtLocal = comm.FillTable("SELECT S.SupplierName as SupplierName,I.* FROM Supplier S INNER JOIN InwardEntry I ON S.SupplierId = I.SupplierId where I.SupplierId=" + SupplierId + " And  I.InvoiceDate between #" + FromDate + "# and #" + ToDate + "#");
            else if (SupplierId == -1 && StrCompany == "All")
                DtLocal = comm.FillTable("SELECT S.SupplierName as SupplierName,I.* FROM Supplier S INNER JOIN InwardEntry I ON S.SupplierId = I.SupplierId where I.InvoiceDate between #" + FromDate + "# and #" + ToDate + "#");

            #endregion


            
            if (DtLocal.Rows.Count > 0)
            {
                WS.get_Range("B2", "F2").Merge(null);
                WS.get_Range("B2", Type.Missing).Value2 = "Inward Register period From:" + String.Format("{0:dd/MM/yyyy}", FromDate) + " To:" + String.Format("{0:dd/MM/yyyy}", ToDate);
                WS.get_Range("B2", Type.Missing).Font.Bold = true;
                WS.get_Range("B2", Type.Missing).Font.Size = 13;
                WS.get_Range("B2", Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;

                #region For Particular Supplier & Company

                if (SupplierId != -1 && StrCompany != "All")
                {
                    WS.get_Range("B4", Type.Missing).Value2 = "Company Name:" + StrCompany;
                    WS.get_Range("B4", Type.Missing).Font.Bold = true;
                    WS.get_Range("B4", Type.Missing).Font.Size = 12;

                    WS.get_Range("B6", Type.Missing).Value2 = "Supplier Name:" + DtLocal.Rows[0]["SupplierName"].ToString();
                    WS.get_Range("B6", Type.Missing).Font.Bold = true;
                    WS.get_Range("B6", Type.Missing).Font.Size = 11;

                    WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).Value2 = "Id";
                    WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 8;
                    WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).Value2 = "Bill No";
                    WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 11;
                    WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).Value2 = "Bill Date";
                    WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 12;
                    WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    WS.get_Range("E" + Convert.ToString(j - 1), Type.Missing).Value2 = "Description";
                    WS.get_Range("E" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 35;
                    WS.get_Range("F" + Convert.ToString(j - 1), Type.Missing).Value2 = "Amount";
                    WS.get_Range("F" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 13;
                    WS.get_Range("F" + Convert.ToString(j - 1), Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignRight;
                    WS.get_Range("B8", "F8").Font.Bold = true;

                    for (i = 0; i <= DtLocal.Rows.Count - 1; i++)
                    {
                        WS.get_Range("B" + j, Type.Missing).Value2 = DtLocal.Rows[i]["InvoiceNo"].ToString();
                        WS.get_Range("B" + j, Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        WS.get_Range("C" + j, Type.Missing).Value2 = DtLocal.Rows[i]["BillNo"].ToString();
                        WS.get_Range("C" + j, Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        WS.get_Range("D" + j, Type.Missing).Value2 = Convert.ToDateTime(string.Format("{0:dd/MM/yyyy}", DtLocal.Rows[i]["InvoiceDate"].ToString()));
                        WS.get_Range("D" + j, Type.Missing).NumberFormat = "dd/MM/yyyy";
                        WS.get_Range("D" + j, Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        WS.get_Range("E" + j, Type.Missing).Value2 = DtLocal.Rows[i]["Remarks"].ToString();
                        WS.get_Range("E" + Convert.ToString(j), Type.Missing).WrapText = true;
                        WS.get_Range("F" + j, Type.Missing).Value2 = DtLocal.Rows[i]["TotalBillAmount"].ToString();
                        WS.get_Range("B" + j, "F" + j).VerticalAlignment = XlVAlign.xlVAlignTop;
                        j = j + 1;
                    }
                    WS.get_Range("B" + j, Type.Missing).Value2 = "Total";
                    WS.get_Range("B" + j, "F" + j).Font.Bold = true;
                    WS.get_Range("F" + j, Type.Missing).FormulaR1C1 = string.Format("{0:N}", "=Sum(R[" + Convert.ToString(9 - j) + "]C:R[-1]C)");
                    WS.get_Range("B8", "F" + Convert.ToString(j)).BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, null);
                    range = WS.get_Range("B8", "F" + Convert.ToString(j));
                    range.Borders.LineStyle = XlBordersIndex.xlEdgeLeft;
                }
                #endregion

                #region For All Supplier and Selected Company

                if (SupplierId == -1 && StrCompany != "All")
                {
                    WS.get_Range("B4", Type.Missing).Value2 = "Company Name:- " + StrCompany;
                    WS.get_Range("B4", Type.Missing).Font.Bold = true;
                    WS.get_Range("B4", Type.Missing).Font.Size = 12;

                    for (i = 0; i <= DtSupplier.Rows.Count - 1; i++)
                    {

                        WS.get_Range("B" + x, Type.Missing).Value2 = "Supplier Name:- " + DtSupplier.Rows[i]["SupplierName"].ToString();
                        WS.get_Range("B" + x, Type.Missing).Font.Bold = true;
                        WS.get_Range("B" + x, Type.Missing).Font.Size = 11;

                        DtLocal.DefaultView.RowFilter = "SupplierName='" + DtSupplier.Rows[i]["SupplierName"].ToString() + "'";
                        WS.get_Range("B" + Convert.ToString(j - 1), "F" + Convert.ToString(j - 1)).Font.Bold = true;
                        WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).Value2 = "Id";
                        WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 8;
                        WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).Value2 = "Bill No";
                        WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 11;
                        WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).Value2 = "Bill Date";
                        WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 12;
                        WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        WS.get_Range("E" + Convert.ToString(j - 1), Type.Missing).Value2 = "Description";
                        WS.get_Range("E" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 35;
                        WS.get_Range("F" + Convert.ToString(j - 1), Type.Missing).Value2 = "Amount";
                        WS.get_Range("F" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 13;
                        WS.get_Range("F" + Convert.ToString(j - 1), Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignRight;
                        for (t = 0; t < DtLocal.DefaultView.Count; t++)
                        {
                            WS.get_Range("B" + j, Type.Missing).Value2 = DtLocal.DefaultView[t]["InvoiceNo"].ToString();
                            WS.get_Range("B" + j, Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                            WS.get_Range("C" + j, Type.Missing).Value2 = DtLocal.DefaultView[t]["BillNo"].ToString();
                            WS.get_Range("C" + j, Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                            WS.get_Range("D" + j, Type.Missing).Value2 = string.Format("{0:dd/MM/yyyy}", DtLocal.DefaultView[t]["InvoiceDate"]);
                            WS.get_Range("D" + j, Type.Missing).NumberFormat = "dd/MM/yyyy";
                            WS.get_Range("D" + j, Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                            WS.get_Range("E" + j, Type.Missing).Value2 = DtLocal.DefaultView[t]["Remarks"].ToString();
                            WS.get_Range("E" + Convert.ToString(j), Type.Missing).WrapText = true;
                            WS.get_Range("F" + j, Type.Missing).Value2 = DtLocal.DefaultView[t]["TotalBillAmount"].ToString();
                            WS.get_Range("B" + j, "F" + j).VerticalAlignment = XlVAlign.xlVAlignTop;
                            j = j + 1;

                        }
                        WS.get_Range("B" + j, Type.Missing).Value2 = "Total";
                        WS.get_Range("B" + j, "F" + j).Font.Bold = true;
                        WS.get_Range("F" + j, Type.Missing).FormulaR1C1 = string.Format("{0:N}", "=Sum(R[" + Convert.ToString(x + 3 - j) + "]C:R[-1]C)");
                        WS.get_Range("B" + Convert.ToString(x + 2), "F" + Convert.ToString(j)).BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, null);
                        range = WS.get_Range("B" + Convert.ToString(x + 2), "F" + Convert.ToString(j));
                        range.Borders.LineStyle = XlBordersIndex.xlEdgeLeft;
                        x = j + 2;
                        j = j + 5;
                        DtLocal.DefaultView.RowFilter = null;
                    }
                }
                #endregion
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No Record Found", "SOUMCO");
                return false;
            }
            return true;
        }

        public bool ClosingStockReport(int ItemId, DateTime ToDate)
        {
            int i = 0, j = 0, x = 0;
            j = 5;
            x = 6;
            ExcelApp();
            ClsComm comm = new ClsComm();
            DtLocal = new System.Data.DataTable();
            System.Data.DataTable Dt = new System.Data.DataTable();
            System.Data.DataTable DtItem = new System.Data.DataTable();

            DtItem = comm.FillTable("Select * from Item");
            Dt = comm.FillTable("Select Distinct ItemId,ItemName from QStockLedger");
            if (ItemId == -1)
            {
                if (Dt.Rows.Count > 0)
                {
                    WS.get_Range("B2", "E2").Merge(null);
                    WS.get_Range("B2", Type.Missing).Value2 = "Closing Stock Summary As of " + String.Format("{0:dd/MM/yyyy}", ToDate);
                    WS.get_Range("B2", Type.Missing).Font.Bold = true;
                    WS.get_Range("B2", Type.Missing).Font.Size = 10;
                    WS.get_Range("B2", Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).Value2 = "Item";
                    WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 25;
                    //WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).Value2 = "Cls Qty";
                    WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                    //WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).Value2 = "Rate";
                    WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                    WS.get_Range("E" + Convert.ToString(j - 1), Type.Missing).Value2 = "Amount";
                    WS.get_Range("E" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                    WS.get_Range("B" + Convert.ToString(j - 1), "E" + Convert.ToString(j - 1)).Font.Bold = true;
                    WS.get_Range("B" + Convert.ToString(j - 1), "E" + Convert.ToString(j - 1)).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    for (x = 0; x <= Dt.Rows.Count - 1; x++)
                    {

                        DtLocal = comm.FillTable("SELECT ItemName,Sum(Qty) as InwardQty,Sum(Rate) as InwRate  ,sum(Qty)-(Select Sum(Qty) from " +
                                              " QStockLedger where TxnType='Outward' and ItemId=" + Dt.Rows[x]["ItemId"] + " and TxnDate<='" + string.Format("{0:dd-MM-yyyy 23:59:59}", ToDate) + "') as SumQty from QStockLedger where TxnType='Inward' and ItemId=" + Dt.Rows[x]["ItemId"] + " and " +
                                              " TxnDate<='" + string.Format("{0:dd-MM-yyyy 23:59:59}", ToDate) + "' group by ItemName");
                        if (DtLocal.Rows.Count > 0)
                        {
                            DtItem.DefaultView.RowFilter = "ItemName='" + DtLocal.Rows[i]["ItemName"].ToString() + "'";

                            WS.get_Range("B" + j, Type.Missing).Value2 = DtLocal.Rows[i]["ItemName"].ToString();
                            if (DBNull.Value != DtLocal.Rows[i]["SumQty"] && DBNull.Value != DtItem.DefaultView[0]["OpStockQty"])
                            {
                                WS.get_Range("C" + j, Type.Missing).Value2 = Convert.ToDouble(DtLocal.Rows[i]["SumQty"]) + Convert.ToDouble(DtItem.DefaultView[0]["OpStockQty"]);
                            }
                            double dsumofRate = Convert.ToDouble(DtLocal.Rows[i]["InwRate"]) + Convert.ToDouble(DtItem.DefaultView[0]["OpStockValue"]);
                            WS.get_Range("D" + j, Type.Missing).Value2 = Math.Round(Convert.ToDouble(DtLocal.Rows[i]["InwardQty"]) / dsumofRate, 2);
                            WS.get_Range("E" + j, Type.Missing).Value2 = Convert.ToDouble(WS.get_Range("C" + j, Type.Missing).Value2) * Convert.ToDouble(WS.get_Range("D" + j, Type.Missing).Value2);

                            WS.get_Range("B" + j, "E" + j).VerticalAlignment = XlVAlign.xlVAlignTop;
                            j = j + 1;
                        }
                    }
                    WS.get_Range("B" + Convert.ToString(j), Type.Missing).Value2 = "Total";
                    WS.get_Range("B" + Convert.ToString(j), "E" + Convert.ToString(j)).Font.Bold = true;
                    WS.get_Range("E" + Convert.ToString(j), Type.Missing).FormulaR1C1 = string.Format("{0:N}", "=Sum(R[" + Convert.ToString(5 - j) + "]C:R[-1]C)");
                    WS.get_Range("B4", "E" + Convert.ToString(j)).BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, null);
                    range = WS.get_Range("B4", "E" + Convert.ToString(j));
                    range.Borders.LineStyle = XlBordersIndex.xlEdgeLeft;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No Record Found", "SOUMCO");
                    return false;
                }

            }
            else
            {
                DtLocal = comm.FillTable("SELECT ItemName,Sum(Qty) as InwardQty,Sum(Rate) as InwRate  ,sum(Qty)-(Select Sum(Qty) from " +
                                      " QStockLedger where TxnType='Outward' and ItemId=" + ItemId + "  and TxnDate<='" + string.Format("{0:dd-MM-yyyy 23:59:59}",ToDate) + "') as SumQty from QStockLedger where TxnType='Inward' and ItemId=" + ItemId + " and  " +
                                      " TxnDate<='" + string.Format("{0:dd-MM-yyyy 23:59:59}", ToDate) + "' group by ItemName");
                if (DtLocal.Rows.Count > 0)
                {
                    WS.get_Range("B2", "D2").Merge(null);
                    WS.get_Range("B2", Type.Missing).Value2 = "Closing Stock Summary As of " + String.Format("{0:dd/MM/yyyy}", ToDate);
                    WS.get_Range("B2", Type.Missing).Font.Bold = true;
                    WS.get_Range("B2", Type.Missing).Font.Size = 10;
                    WS.get_Range("B2", Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).Value2 = "Item";
                    WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 25;
                    WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).Value2 = "Cls Qty";
                    WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                    WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).Value2 = "Rate";
                    WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                    WS.get_Range("E" + Convert.ToString(j - 1), Type.Missing).Value2 = "Amount";
                    WS.get_Range("E" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                    WS.get_Range("B" + Convert.ToString(j - 1), "E" + Convert.ToString(j - 1)).Font.Bold = true;
                    WS.get_Range("B" + Convert.ToString(j - 1), "E" + Convert.ToString(j - 1)).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    for (i = 0; i <= DtLocal.Rows.Count - 1; i++)
                    {
                        DtItem.DefaultView.RowFilter = "ItemName='" + DtLocal.Rows[i]["ItemName"].ToString() + "'";
                        WS.get_Range("B" + j, Type.Missing).Value2 = DtLocal.Rows[i]["ItemName"].ToString();
                        WS.get_Range("C" + j, Type.Missing).Value2 = Convert.ToDouble(DtLocal.Rows[i]["SumQty"]) + Convert.ToDouble(DtItem.DefaultView[0]["OpStockQty"]);
                        double dsumofRate = Convert.ToDouble(DtLocal.Rows[i]["InwRate"]) + Convert.ToDouble(DtItem.DefaultView[0]["OpStockValue"]);
                        WS.get_Range("D" + j, Type.Missing).Value2 = Math.Round(Convert.ToDouble(DtLocal.Rows[i]["InwardQty"]) / dsumofRate, 2);
                        WS.get_Range("E" + j, Type.Missing).Value2 = Convert.ToDouble(WS.get_Range("C" + j, Type.Missing).Value2) * Convert.ToDouble(WS.get_Range("D" + j, Type.Missing).Value2);
                        WS.get_Range("B" + j, "E" + j).VerticalAlignment = XlVAlign.xlVAlignTop;
                        j = j + 1;
                    }
                    WS.get_Range("B" + Convert.ToString(j), Type.Missing).Value2 = "Total";
                    WS.get_Range("B" + Convert.ToString(j), "E" + Convert.ToString(j)).Font.Bold = true;
                    WS.get_Range("E" + Convert.ToString(j), Type.Missing).FormulaR1C1 = string.Format("{0:N}", "=Sum(R[" + Convert.ToString(5 - j) + "]C:R[-1]C)");
                    WS.get_Range("B4", "E" + Convert.ToString(j)).BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, null);
                    range = WS.get_Range("B4", "E" + Convert.ToString(j));
                    range.Borders.LineStyle = XlBordersIndex.xlEdgeLeft;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No Record Found", "SOUMCO");
                    return false;
                }


            }
            return true;
        }

        public bool VehiclewiseItemwiseTransaction(int VehicleCode, int ItemId, DateTime FromDate, DateTime ToDate)
        {
            int i = 0, j = 0, x = 0, t = 0;
            j = 9;
            x = 6;
            double dsumofRate = 0;
            double dStockValue = 0;
            ExcelApp();
            ClsComm comm = new ClsComm();
            DtLocal = new System.Data.DataTable();
            System.Data.DataTable DtSupplier = new System.Data.DataTable();

            #region Query
            if (VehicleCode != -1 && ItemId != -1)
            {
                DtLocal = comm.FillTable("Select * from QOutwardItemPopUp where VehicleId=" + VehicleCode + " And ItemId=" + ItemId + " And  DocDate between #" + FromDate + "# and #" + ToDate + "#");
               
                dsumofRate = comm.GetValueint("SELECT Sum(Rate) as InwRate from QStockLedger where TxnType='Inward' and ItemId=" + ItemId + "  and TxnDate<=#" + ToDate + "#");
                dStockValue = comm.GetValueint("SELECT OpStockValue from Item where ItemId=" + ItemId);

            }
            else if (VehicleCode != -1 && ItemId == -1)
            {
                DtLocal = comm.FillTable("Select * from QOutwardItemPopUp where VehicleId=" + VehicleCode + " And  DocDate between #" + FromDate + "# and #" + ToDate + "#");
                DtSupplier = comm.FillTable("SELECT Distinct I.ItemName as ItemName FROM Item I INNER JOIN  QOutwardItemPopUp Q ON I.ItemId = Q.ItemId where Q.VehicleId=" + VehicleCode + " And  DocDate between #" + FromDate + "# and #" + ToDate + "# order by I.ItemName");
            }
            #endregion

            
            if (DtLocal.Rows.Count > 0)
            {
                WS.get_Range("B2", "F2").Merge(null);
                WS.get_Range("B2", Type.Missing).Value2 = "Vehicle wise Item wise transaction period From:" + String.Format("{0:dd/MM/yyyy}", FromDate) + " To:" + String.Format("{0:dd/MM/yyyy}", ToDate);
                WS.get_Range("B2", Type.Missing).Font.Bold = true;
                WS.get_Range("B2", Type.Missing).Font.Size = 13;
                WS.get_Range("B2", Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;

                #region For Particular Vehicle & Item
                if (VehicleCode != -1 && ItemId != -1)
                {
                    WS.get_Range("B4", Type.Missing).Value2 = "Vehicle No:" + DtLocal.Rows[0]["VehicleNo"].ToString();
                    WS.get_Range("B4", Type.Missing).Font.Bold = true;
                    WS.get_Range("B4", Type.Missing).Font.Size = 12;

                    WS.get_Range("B6", Type.Missing).Value2 = "Item Name:" + DtLocal.Rows[0]["ItemName"].ToString();
                    WS.get_Range("B6", Type.Missing).Font.Bold = true;
                    WS.get_Range("B6", Type.Missing).Font.Size = 11;


                    WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).Value2 = "Doc No";  //"Instl Amt"
                    WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                    WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).Value2 = "Date";  //"Instl Amt"
                    WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 11;
                    WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).Value2 = "Incharge Name";  //"Instl Amt"
                    WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 25;
                    WS.get_Range("E" + Convert.ToString(j - 1), Type.Missing).Value2 = "Issue To";  //"Instl Amt"
                    WS.get_Range("E" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 25;
                    WS.get_Range("F" + Convert.ToString(j - 1), Type.Missing).Value2 = "Qty";  //"Instl Amt"
                    WS.get_Range("F" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                    WS.get_Range("G" + Convert.ToString(j - 1), Type.Missing).Value2 = "Amount";  //"Instl Amt"
                    WS.get_Range("G" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                    WS.get_Range("B" + Convert.ToString(j - 1), "G" + Convert.ToString(j - 1)).Font.Bold = true;
                    WS.get_Range("B" + Convert.ToString(j - 1), "G" + Convert.ToString(j - 1)).HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    for (i = 0; i <= DtLocal.Rows.Count - 1; i++)
                    {

                        WS.get_Range("B" + j, Type.Missing).Value2 = DtLocal.Rows[i]["DocNo"].ToString();
                        WS.get_Range("B" + j, Type.Missing).HorizontalAlignment = XlVAlign.xlVAlignCenter;
                        WS.get_Range("C" + j, Type.Missing).Value2 = string.Format("{0:dd/MM/yyyy}", DtLocal.Rows[i]["DocDate"].ToString());
                        WS.get_Range("C" + j, Type.Missing).NumberFormat = "dd/MM/yyyy";
                        WS.get_Range("C" + j, Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        WS.get_Range("D" + j, Type.Missing).Value2 = DtLocal.Rows[i]["InchargeName"].ToString();
                        WS.get_Range("E" + j, Type.Missing).Value2 = DtLocal.Rows[i]["IssueTo"].ToString();
                        WS.get_Range("F" + j, Type.Missing).Value2 = DtLocal.Rows[i]["Qty"].ToString();
                        j = j + 1;
                    }
                    WS.get_Range("B" + j, Type.Missing).Value2 = "Total";
                    WS.get_Range("B" + j, "G" + j).Font.Bold = true;
                    WS.get_Range("F" + j, Type.Missing).FormulaR1C1 = string.Format("{0:N}", "=Sum(R[" + Convert.ToString(9 - j) + "]C:R[-1]C)");
                    WS.get_Range("G" + j, Type.Missing).Value2 = Math.Round(Convert.ToDouble(WS.get_Range("F" + j, Type.Missing).Value2) / (dsumofRate + dStockValue), 2);
                    WS.get_Range("B8", "G" + Convert.ToString(j)).BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, null);
                    range = WS.get_Range("B8", "G" + Convert.ToString(j));
                    range.Borders.LineStyle = XlBordersIndex.xlEdgeLeft;
                }

                #endregion

                #region For Selected Vehicle & All Item

                if (VehicleCode != -1 && ItemId == -1)
                {
                    WS.get_Range("B4", Type.Missing).Value2 = "Vehicle No:- " + DtLocal.Rows[0]["VehicleNo"].ToString();
                    WS.get_Range("B4", Type.Missing).Font.Bold = true;
                    WS.get_Range("B4", Type.Missing).Font.Size = 12;
                    for (i = 0; i <= DtSupplier.Rows.Count - 1; i++)
                    {
                        WS.get_Range("B" + x, Type.Missing).Value2 = "Item Name:- " + DtSupplier.Rows[i]["ItemName"].ToString();
                        WS.get_Range("B" + x, Type.Missing).Font.Bold = true;
                        WS.get_Range("B" + x, Type.Missing).Font.Size = 11;

                        dsumofRate = comm.GetValueint("SELECT Sum(Rate) as InwRate from QStockLedger where TxnType='Inward' and ItemName='" + DtSupplier.Rows[i]["ItemName"] + "'  and TxnDate<=#" + ToDate + "#");
                        dStockValue = comm.GetValueint("SELECT OpStockValue from Item where ItemName='" + DtSupplier.Rows[i]["ItemName"] + "'");

                        DtLocal.DefaultView.RowFilter = "ItemName='" + DtSupplier.Rows[i]["ItemName"].ToString() + "'";

                        WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).Value2 = "Doc No";  //"Instl Amt"
                        WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                        WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).Value2 = "Date";  //"Instl Amt"
                        WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 11;
                        WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).Value2 = "Incharge Name";  //"Instl Amt"
                        WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 25;
                        WS.get_Range("E" + Convert.ToString(j - 1), Type.Missing).Value2 = "Issue To";  //"Instl Amt"
                        WS.get_Range("E" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 25;
                        WS.get_Range("F" + Convert.ToString(j - 1), Type.Missing).Value2 = "Qty";  //"Instl Amt"
                        WS.get_Range("F" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                        WS.get_Range("G" + Convert.ToString(j - 1), Type.Missing).Value2 = "Amount";  //"Instl Amt"
                        WS.get_Range("G" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                        WS.get_Range("B" + Convert.ToString(j - 1), "G" + Convert.ToString(j - 1)).Font.Bold = true;
                        WS.get_Range("B" + Convert.ToString(j - 1), "G" + Convert.ToString(j - 1)).HorizontalAlignment = XlHAlign.xlHAlignCenter;

                        for (t = 0; t < DtLocal.DefaultView.Count; t++)
                        {
                            WS.get_Range("B" + j, Type.Missing).Value2 = DtLocal.DefaultView[t]["DocNo"].ToString();
                            WS.get_Range("B" + j, Type.Missing).HorizontalAlignment = XlVAlign.xlVAlignCenter;
                            WS.get_Range("C" + j, Type.Missing).Value2 = string.Format("{0:dd/MM/yyyy}", DtLocal.DefaultView[t]["DocDate"].ToString());
                            WS.get_Range("C" + j, Type.Missing).NumberFormat = "dd/MM/yyyy";
                            WS.get_Range("C" + j, Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                            WS.get_Range("D" + j, Type.Missing).Value2 = DtLocal.DefaultView[t]["InchargeName"].ToString();
                            WS.get_Range("E" + j, Type.Missing).Value2 = DtLocal.DefaultView[t]["IssueTo"].ToString();
                            WS.get_Range("F" + j, Type.Missing).Value2 = DtLocal.DefaultView[t]["Qty"].ToString();
                            j = j + 1;

                        }
                        WS.get_Range("B" + j, Type.Missing).Value2 = "Total";
                        WS.get_Range("B" + j, "G" + j).Font.Bold = true;
                        WS.get_Range("F" + j, Type.Missing).FormulaR1C1 = string.Format("{0:N}", "=Sum(R[" + Convert.ToString(x + 3 - j) + "]C:R[-1]C)");
                        WS.get_Range("G" + j, Type.Missing).Value2 = Math.Round(Convert.ToDouble(WS.get_Range("F" + j, Type.Missing).Value2) / (dsumofRate + dStockValue), 2);
                        WS.get_Range("B" + Convert.ToString(x + 2), "G" + Convert.ToString(j)).BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, null);
                        range = WS.get_Range("B" + Convert.ToString(x + 2), "G" + Convert.ToString(j));
                        range.Borders.LineStyle = XlBordersIndex.xlEdgeLeft;
                        x = j + 2;
                        j = j + 5;
                        DtLocal.DefaultView.RowFilter = null;


                    }

                }
                #endregion

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No Record Found", "Soumco");
            }


            return true;

        }

        public bool InwardOutwardSummary(int ItemId, DateTime FromDate, DateTime ToDate)
        {
            int i = 0, j = 0,x=0,t=0,p=0;
            j = 7;
            x = 4;
            p = j;
            ExcelApp();
            ClsComm comm = new ClsComm();
            DtLocal = new System.Data.DataTable();
            System.Data.DataTable DtOutward = new System.Data.DataTable();
            System.Data.DataTable Dt = new System.Data.DataTable();
            double dBalance = 0;
            double dOpStock = 0;
            #region Query

            if (ItemId != -1)
            {
                DtLocal = comm.FillTable("Select * from QStockLedger where ItemId=" + ItemId + " And Txndate between #" + FromDate + "# and #" + ToDate + "#");

                dBalance = comm.GetValueint("SELECT sum(Qty)-(Select Sum(Qty) from " +
                                     " QStockLedger where TxnType='Outward' and ItemId=" + ItemId + "  and TxnDate<#" + FromDate + "#) as SumQty from QStockLedger where TxnType='Inward' and ItemId=" + ItemId + " and  " +
                                     " TxnDate<#" + FromDate + "# group by ItemName");
                dOpStock = comm.GetValueint("Select OpStockQty from Item where ItemId=" + ItemId);
            }
            else if (ItemId == -1)
            {
                DtLocal = comm.FillTable("Select * from QStockLedger where Txndate between #" + FromDate + "# and #" + ToDate + "#");
                Dt = comm.FillTable("Select Distinct ItemId,ItemName from QStockLedger where Txndate between #" + FromDate + "# and #" + ToDate + "# order by ItemName");
            }
            #endregion

            WS.get_Range("B2", "G2").Merge(null);
            WS.get_Range("B2", Type.Missing).Value2 = "Item wise inward/outward Summary period From:" + String.Format("{0:dd/MM/yyyy}", FromDate) + " To:" + String.Format("{0:dd/MM/yyyy}", ToDate);
            WS.get_Range("B2", Type.Missing).Font.Bold = true;
            WS.get_Range("B2", Type.Missing).HorizontalAlignment = XlHAlign.xlHAlignCenter;

             #region When Particular Item selected
            
                if (ItemId != -1)
                {
                    if (DtLocal.Rows.Count > 0)
                    {
                        WS.get_Range("B4", Type.Missing).Value2 = "Item Name:" + DtLocal.Rows[0]["ItemName"].ToString();
                        WS.get_Range("B4", Type.Missing).Font.Bold = true;
                        WS.get_Range("B4", Type.Missing).Font.Size = 12;


                        WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).Value2 = "Date";
                        WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                        WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).Value2 = "Doc No";
                        WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                        WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).Value2 = "Book";
                        WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 11;
                        WS.get_Range("E" + Convert.ToString(j - 1), Type.Missing).Value2 = "Inward Qty";
                        WS.get_Range("E" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 11;
                        WS.get_Range("F" + Convert.ToString(j - 1), Type.Missing).Value2 = "Outard Qty";
                        WS.get_Range("F" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 11;
                        WS.get_Range("G" + Convert.ToString(j - 1), Type.Missing).Value2 = "Balance Qty";
                        WS.get_Range("G" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 11;
                        WS.get_Range("B" + Convert.ToString(j - 1), "D" + Convert.ToString(j - 1)).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        WS.get_Range("E" + Convert.ToString(j - 1), "G" + Convert.ToString(j - 1)).HorizontalAlignment = XlHAlign.xlHAlignLeft;
                        WS.get_Range("B" + Convert.ToString(j - 1), "G" + Convert.ToString(j - 1)).Font.Bold = true;
                        WS.get_Range("D" + j, Type.Missing).Value2 = "Op Bal";

                        if (dBalance + dOpStock > 0)
                        {
                            WS.get_Range("E" + j, Type.Missing).Value2 = dBalance + dOpStock;
                        }
                        else
                        {
                            WS.get_Range("F" + j, Type.Missing).Value2 = dBalance + dOpStock;
                        }
                        WS.get_Range("B" + j, "G" + j).Font.Bold = true;

                        for (i = 0; i <= DtLocal.Rows.Count - 1; i++)
                        {
                            WS.get_Range("B" + Convert.ToString(j + 1), Type.Missing).Value2 = string.Format("{0:dd/MM/yyyy}", DtLocal.Rows[i]["TxnDate"].ToString());
                            WS.get_Range("B" + Convert.ToString(j + 1), Type.Missing).NumberFormat = "dd/MM/yyyy";
                            WS.get_Range("C" + Convert.ToString(j + 1), Type.Missing).Value2 = DtLocal.Rows[i]["TxnNo"].ToString();
                            WS.get_Range("D" + Convert.ToString(j + 1), Type.Missing).Value2 = DtLocal.Rows[i]["TxnType"].ToString();
                            WS.get_Range("B" + Convert.ToString(j + 1), "D" + Convert.ToString(j + 1)).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                            int iQty = 0;
                            if (DtLocal.Rows[i]["TxnType"].ToString() == "Inward")
                            {
                                WS.get_Range("E" + Convert.ToString(j + 1), Type.Missing).Value2 = DtLocal.Rows[i]["Qty"].ToString();
                                iQty = (int)DtLocal.Rows[i]["Qty"];

                                if (dBalance + dOpStock > 0 && j == 7)
                                {
                                    WS.get_Range("G" + Convert.ToString(j + 1), Type.Missing).FormulaR1C1 = string.Format("{0:N}", "=R[-1]C[-2]+RC[-2]-RC[-1]");
                                }
                                else if (j == 7)
                                {
                                    WS.get_Range("G" + Convert.ToString(j + 1), Type.Missing).FormulaR1C1 = string.Format("{0:N}", "=R[-1]C[-1]+RC[-2]-RC[-1]");
                                }
                                else
                                {
                                    WS.get_Range("G" + Convert.ToString(j + 1), Type.Missing).Value2 = Convert.ToInt32(WS.get_Range("G" + j, Type.Missing).Value2) + iQty;
                                }

                            }
                            if (DtLocal.Rows[i]["TxnType"].ToString() == "Outward")
                            {
                                WS.get_Range("F" + Convert.ToString(j + 1), Type.Missing).Value2 = DtLocal.Rows[i]["Qty"].ToString();
                                iQty = (int)DtLocal.Rows[i]["Qty"];
                                if (dBalance + dOpStock < 0 && j == 7)
                                {
                                    WS.get_Range("G" + Convert.ToString(j + 1), Type.Missing).FormulaR1C1 = string.Format("{0:N}", "=R[-1]C[-1]+RC[-2]-RC[-1]");
                                    iQty = 0;

                                }
                                else if (j == 7)
                                {
                                    WS.get_Range("G" + Convert.ToString(j + 1), Type.Missing).FormulaR1C1 = string.Format("{0:N}", "=R[-1]C[-2]+RC[-2]-RC[-1]");
                                }
                                else
                                {
                                    WS.get_Range("G" + Convert.ToString(j + 1), Type.Missing).Value2 = Convert.ToInt32(WS.get_Range("G" + j, Type.Missing).Value2) - iQty;
                                    iQty = 0;
                                }

                            }
                            j = j + 1;
                        }

                        WS.get_Range("B" + Convert.ToString(j + 1), Type.Missing).Value2 = "Total";
                        WS.get_Range("B" + Convert.ToString(j + 1), "G" + Convert.ToString(j + 1)).Font.Bold = true;
                        WS.get_Range("E" + Convert.ToString(j + 1), Type.Missing).FormulaR1C1 = string.Format("{0:N}", "=Sum(R[" + Convert.ToString(6 - j) + "]C:R[-1]C)");
                        WS.get_Range("F" + Convert.ToString(j + 1), Type.Missing).FormulaR1C1 = string.Format("{0:N}", "=Sum(R[" + Convert.ToString(6 - j) + "]C:R[-1]C)");
                        WS.get_Range("B6", "G" + Convert.ToString(j + 1)).BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, null);
                        range = WS.get_Range("B6", "G" + Convert.ToString(j + 1));
                        range.Borders.LineStyle = XlBordersIndex.xlEdgeLeft;
                    }
                    else
                    {
                       System.Windows.Forms.MessageBox.Show("No Record Found","SOUMCO");
                    }
                }
            #endregion

             #region When All Item
                if (ItemId == -1)
                {
                    for (i = 0;i<= Dt.Rows.Count - 1; i++)
                    {
                        dBalance = comm.GetValueint("SELECT sum(Qty)-(Select Sum(Qty) from " +
                                    " QStockLedger where TxnType='Outward' and ItemId=" + Dt.Rows[i]["ItemId"] + "  and TxnDate<=#" + FromDate + "#) as SumQty from QStockLedger where TxnType='Inward' and ItemId=" + ItemId + " and  " +
                                    " TxnDate<=#" + FromDate + "# group by ItemName");

                        dOpStock = comm.GetValueint("Select OpStockQty from Item where ItemId=" + Dt.Rows[i]["ItemId"]);

                        WS.get_Range("B" + Convert.ToString(x), Type.Missing).Value2 = "Item Name:" + Dt.Rows[i]["ItemName"].ToString();
                        WS.get_Range("B" + Convert.ToString(x), Type.Missing).Font.Bold = true;
                        WS.get_Range("B" + Convert.ToString(x), Type.Missing).Font.Size = 12;

                        DtLocal.DefaultView.RowFilter = "ItemName='" + Dt.Rows[i]["ItemName"].ToString() + "'";
                        
                        WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).Value2 = "Date";
                        WS.get_Range("B" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                        WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).Value2 = "Doc No";
                        WS.get_Range("C" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 10;
                        WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).Value2 = "Book";
                        WS.get_Range("D" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 11;
                        WS.get_Range("E" + Convert.ToString(j - 1), Type.Missing).Value2 = "Inward Qty";
                        WS.get_Range("E" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 11;
                        WS.get_Range("F" + Convert.ToString(j - 1), Type.Missing).Value2 = "Outard Qty";
                        WS.get_Range("F" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 11;
                        WS.get_Range("G" + Convert.ToString(j - 1), Type.Missing).Value2 = "Balance Qty";
                        WS.get_Range("G" + Convert.ToString(j - 1), Type.Missing).ColumnWidth = 11;
                        WS.get_Range("B" + Convert.ToString(j - 1), "D" + Convert.ToString(j - 1)).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        WS.get_Range("E" + Convert.ToString(j - 1), "G" + Convert.ToString(j - 1)).HorizontalAlignment = XlHAlign.xlHAlignLeft;
                        WS.get_Range("B" + Convert.ToString(j - 1), "G" + Convert.ToString(j - 1)).Font.Bold = true;
                        WS.get_Range("D" + j, Type.Missing).Value2 = "Op Bal";
                        if (dBalance + dOpStock > 0)
                        {
                            WS.get_Range("E" + j, Type.Missing).Value2 = dBalance + dOpStock;
                        }
                        else
                        {
                            WS.get_Range("F" + j, Type.Missing).Value2 = dBalance + dOpStock;
                        }
                        
                        WS.get_Range("B" + j, "G" + j).Font.Bold = true;

                        for (t = 0; t < DtLocal.DefaultView.Count; t++)
                        {
                          
                            WS.get_Range("B" + Convert.ToString(j + 1), Type.Missing).Value2 = string.Format("{0:dd/MM/yyyy}", DtLocal.DefaultView[t]["TxnDate"].ToString());
                            WS.get_Range("B" + Convert.ToString(j + 1), Type.Missing).NumberFormat = "dd/MM/yyyy";
                            WS.get_Range("C" + Convert.ToString(j + 1), Type.Missing).Value2 = DtLocal.DefaultView[t]["TxnNo"].ToString();
                            WS.get_Range("D" + Convert.ToString(j + 1), Type.Missing).Value2 = DtLocal.DefaultView[t]["TxnType"].ToString();
                            WS.get_Range("B" + Convert.ToString(j + 1), "D" + Convert.ToString(j + 1)).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                            int iQty = 0;
                            if (DtLocal.DefaultView[t]["TxnType"].ToString() == "Inward")
                            {
                                WS.get_Range("E" + Convert.ToString(j + 1), Type.Missing).Value2 = DtLocal.DefaultView[t]["Qty"].ToString();
                                iQty = (int)DtLocal.DefaultView[t]["Qty"];

                                if (dBalance + dOpStock > 0 && j == p)
                                {
                                    WS.get_Range("G" + Convert.ToString(j + 1), Type.Missing).FormulaR1C1 = string.Format("{0:N}", "=R[-1]C[-2]+RC[-2]-RC[-1]");
                                }
                                else if (j == p)
                                {
                                    WS.get_Range("G" + Convert.ToString(j + 1), Type.Missing).FormulaR1C1 = string.Format("{0:N}", "=R[-1]C[-1]+RC[-2]-RC[-1]");
                                }
                                else
                                {
                                    WS.get_Range("G" + Convert.ToString(j + 1), Type.Missing).Value2 = Convert.ToInt32(WS.get_Range("G" + j, Type.Missing).Value2) + iQty;
                                }

                            }
                            if (DtLocal.DefaultView[t]["TxnType"].ToString() == "Outward")
                            {
                                WS.get_Range("F" + Convert.ToString(j + 1), Type.Missing).Value2 = DtLocal.DefaultView[t]["Qty"].ToString();
                                iQty = (int)DtLocal.DefaultView[t]["Qty"];
                                if (dBalance + dOpStock < 0 && j == p)
                                {
                                    WS.get_Range("G" + Convert.ToString(j + 1), Type.Missing).FormulaR1C1 = string.Format("{0:N}", "=R[-1]C[-1]+RC[-2]-RC[-1]");
                                    iQty = 0;

                                }
                                else if (j == p)
                                {
                                    WS.get_Range("G" + Convert.ToString(j + 1), Type.Missing).FormulaR1C1 = string.Format("{0:N}", "=R[-1]C[-2]+RC[-2]-RC[-1]");
                                }
                                else
                                {
                                    WS.get_Range("G" + Convert.ToString(j + 1), Type.Missing).Value2 = Convert.ToInt32(WS.get_Range("G" + j, Type.Missing).Value2) - iQty;
                                    iQty = 0;
                                }

                            }
                            j = j + 1;
                        }

                        WS.get_Range("B" + Convert.ToString(j+1), Type.Missing).Value2 = "Total";
                        WS.get_Range("B" + Convert.ToString(j + 1), "G" + Convert.ToString(j + 1)).Font.Bold = true;
                        WS.get_Range("E" + Convert.ToString(j + 1), Type.Missing).FormulaR1C1 = string.Format("{0:N}", "=Sum(R[" + Convert.ToString(x+2 - j) + "]C:R[-1]C)");
                        WS.get_Range("F" + Convert.ToString(j + 1), Type.Missing).FormulaR1C1 = string.Format("{0:N}", "=Sum(R[" + Convert.ToString(x+2 - j) + "]C:R[-1]C)");
                        WS.get_Range("B" + Convert.ToString(x+2), "G" + Convert.ToString(j+1)).BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, null);
                        range = WS.get_Range("B" + Convert.ToString(x+2), "G" + Convert.ToString(j+1));
                        range.Borders.LineStyle = XlBordersIndex.xlEdgeLeft;
                        x = j + 3;
                        j = j + 6;
                        p = j;
                        DtLocal.DefaultView.RowFilter = null;
                    }
                }
            #endregion

                return true;
        }
    }
}
