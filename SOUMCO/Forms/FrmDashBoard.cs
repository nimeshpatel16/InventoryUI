using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace SOUMCO.Forms
{
    public partial class FrmDashBoard : Form
    {
        public FrmDashBoard()
        {
            InitializeComponent();
            ProcOpen();
        }

        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
        //  TreeNode ParentNode = new TreeNode();
           // PopulateTreeView("test", ParentNode);
            
           // TreeNode treeNode = new TreeNode();
           // //treeViewtb1.Nodes.Add(treeNode);
           // ////
           // //// Another node following the first node.
           // ////
           // //treeNode = new TreeNode("Linux");
           // //treeViewtb1.Nodes.Add(treeNode);

           // //
           // // Create two child nodes and put them in an array.
           // // ... Add the third node, and specify these as its children.
           // //
           // TreeNode node2 = new TreeNode("C#");
           // TreeNode node3 = new TreeNode("VB.NET");
           // TreeNode[] array = new TreeNode[] { node2, node3 };
           // TreeNodeCollection tcollection;
           // List<string[]> l_tree = new List<string[]>();
           // string[] str1 = new string[] { "Example", "2", "1" };
           // string[] str2 = new string[] { "Example", "2", "2" };
           // string[] str3 = new string[] { "Example", "3", "0" };
           // l_tree.Add(str1);
           // l_tree.Add(str2);
           // TreeNode node4 = new TreeNode(str1.ToString());
           // TreeNode node5 = new TreeNode(str2.ToString());
           //// tcollection.AddRange()
           // //TreeNode[] array1 = new TreeNode[] {(TreeNode) l_tree };
           // //
           // // Final node.
           // //
           // treeNode = new TreeNode("Dot Net Perls", array);
           // treeViewtb1.Nodes.Add(treeNode);
           // treeNode = new TreeNode("Dot Net Adv", array1);
           // treeViewtb1.Nodes.Add(treeNode);
        }

        

        //private void PopulateTreeView(string parentId, TreeNode parentNode)
        //{
        //    TreeView trview = new TreeView();
        //    TreeNode childNode;
        //    TreeNode[] array = new TreeNode[5];
        //    DataTable dtList = new DataTable();
        //    DataTable dtCategory = new DataTable();
        //    DataView dv = null;
        //    ClsComm comm = new ClsComm();
        //    TreeNodeCollection nodes;
            
        //    dtCategory = comm.FillTable("SELECT Distinct CategoryName" +
        //                           " FROM QStockLedger WHERE TxnDate<='30-10-2018'");

        //    foreach (DataRow dr in dtCategory.Rows)
        //    {
        //         dtList = comm.FillTable("SELECT ItemName, CategoryName, Sum(Qty) AS AvailableQty, Sum(ActualKg) AS AvalableKG, ItemId, CategoryId" +
        //                            " FROM QStockLedger WHERE TxnDate<='30-10-2018' and CategoryName='" + dr["CategoryName"].ToString() + "'" +
        //                            " GROUP BY ItemName, CategoryName, ItemId, CategoryId Order by CategoryName, ItemName");

        //        if (parentNode.Text != dr["CategoryName"].ToString())
        //        {
        //            parentNode = new TreeNode(dr["CategoryName"].ToString());
        //        }
        //        foreach (DataRow dr1 in dtList.Rows)
        //        {
        //            TreeNode t = new TreeNode();

        //            t.Text = "Item Name: " + dr1["ItemName"].ToString() + ", Qty Available: " + dr1["AvailableQty"].ToString() + ", Remainag Kgs: " + dr1["AvalableKG"].ToString();
        //            t.Name = dr1["ItemName"].ToString();
        //            parentNode.Nodes.Add(t);
        //        }
        //        treeViewtb1.Nodes.Add(parentNode);
        //        parentNode = new TreeNode();
        //    }
            

        //}

        private void ProcOpen()
        {
            ClsComm Comm = new ClsComm();
            Comm.BindCombo(cmbRightPanelCategory, false, "CategoryId", "CategoryName", "Category", "CategoryName");
           

        }

        private void cmbRightPanelCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //ClsComm Comm = new ClsComm();
            //lblRightPanelAvailableKgs.Text = string.Empty;
            //if (Convert.ToInt32(cmbRightPanelCategory.SelectedValue) > 0)
            //{
            //    Comm.BindCombo(cmbRightPanelItemName, true, "Select ItemId,ItemName from Item where CategoryId=" + cmbRightPanelCategory.SelectedValue + " order by ItemName");
            //}
        }

        private void cmbRightPanelItemName_SelectedValueChanged(object sender, EventArgs e)
        {
            ClsComm comm = new ClsComm();
            DataTable dt = new DataTable();
            lblRightPanelAvailableKgs.Text = string.Empty;
            if (Convert.ToInt32(cmbFilterBy.SelectedIndex) > 0)
            {  
                lblRightPanelAvailableKgs.Text ="Available Kgs: " + comm.GetValue("SELECT iif(AvailableKgs>0,AvailableKgs, 0) from QAvailableActualKgs where AvailableKgs>0 And CategoryId=" + cmbRightPanelCategory.SelectedValue + " And ItemId=" + cmbFilterBy.SelectedValue, true); 
            }
        }

        private void cmbRightPanelCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ClsComm comm = new ClsComm();
                DataTable dt = new DataTable();
                lblRightPanelAvailableKgs.Text = string.Empty;
                if (Convert.ToInt32(cmbRightPanelCategory.SelectedValue) > 0)
                {
                    cmbFilterBy.Items.Clear();
                    //Comm.BindCombo(cmbRightPanelItemName, true, "Select ItemId,ItemName from Item where CategoryId=" + cmbRightPanelCategory.SelectedValue + " order by ItemName");
                    dt = comm.FillTable("Select ItemName, CategoryName as Category, Qty as AvailableQty, AvailableKgs from QAvailableActualKgs where CategoryId=" + Convert.ToInt32(cmbRightPanelCategory.SelectedValue) + " and CompanyId=" + ClsComm.CompanyId + " and YearId=" + ClsComm.YearId + " order by ItemName");
                     if (dt.Rows.Count > 0)
                     {
                         dgStock.DataSource = dt;
                         dgStock.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                         dgStock.ReadOnly = true;
                         dgStock.Columns[0].HeaderText = "Item Name";
                         dgStock.Columns[0].Width = 250;
                         dgStock.Columns[1].HeaderText = "Category";
                         dgStock.Columns[1].Width = 250;
                         dgStock.Columns[2].HeaderText = "Available Qty";
                         dgStock.Columns[2].Width = 110;
                         dgStock.Columns[3].HeaderText = "AvailableKgs";
                         dgStock.Columns[3].Width = 110;
                         //dgStock.AutoSize = true;
                         FillFilterDropDown(dt, string.Empty);
                     }
                }
            }
            catch
            {
                
                
            }
        }

        private void FillFilterDropDown(DataTable dt, string NotIncludeColumn)
        {
            foreach (DataColumn d in dt.Columns)
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
                ((DataTable)dgStock.DataSource).DefaultView.RowFilter = string.Format(FilterBy + " like '%{0}%'", FilterValue.Trim().Replace("'", "''"));
                dgStock.Refresh();
            }
            catch
            {

            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            FilterData(string.Empty, cmbFilterBy.Text, txtFilterValue.Text);
        }
        
    }
}
