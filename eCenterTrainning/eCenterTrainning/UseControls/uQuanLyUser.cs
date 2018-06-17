using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using IMIC.VALUEOBJECTS;
using IMIC.BUSINESSLOGICLAYERS;
namespace eCenterTrainning.UseControls
{
    public partial class uQuanLyUser : ucRightForm
    {
        int mNewId = 0;
        List<stanfTabPermission> lst;
        public uQuanLyUser(Account oAccount, int newId) : base(oAccount)
        {
            InitializeComponent();
            mNewId = newId;
            lst = new List<stanfTabPermission>();



        }
        public uQuanLyUser(Account oAccount) : base(oAccount)
        {
            InitializeComponent();
            lst = new List<stanfTabPermission>();


        }
        private void DisplayOfNewAccount()
        {

            lst = new TabPermissionBLL(mAccount).CheckElementById(mNewId);
            gridControl1.DataSource = lst;
            gridControl1.RefreshDataSource();
        }
        private void uQuanLyUser_Load(object sender, EventArgs e)
        {
            actionUpdate1.PressUpdate += new EventHandler(ActionUpdate1_PressUpdate);
            actionUpdate1.PressNew += new EventHandler(ActionUpdate1_PressNew);
            actionUpdate1.PressHelp += new EventHandler(ActionUpdate1_PressHelp);
            actionUpdate1.PressClose += new EventHandler(ActionUpdate1_PressClose);

            List<Account> lstAcc = new List<Account>();
            lstAcc = new AccountBill(mAccount).getElements();
            //TreeNode user = new TreeNode();
            //treeView1.Nodes.Add(user);
            //user.Text = "User";
            //List<TreeNode> lstTreeUser = new List<TreeNode>();
            TreeNode adminNode = new TreeNode("Admin");
            TreeNode userNode = new TreeNode("User");

            if (mAccount.IsSuperUser == true)
            {
                treeView1.Nodes.Add(adminNode);
                treeView1.Nodes.Add(userNode);
            }
            else
            {
                if (mAccount.isAdmin == 1)
                    treeView1.Nodes.Add(userNode);
            }
            foreach (Account item in lstAcc)
            {
                //if(item.IsSuperUser == false)
                //{
                //    TreeNode node = new TreeNode();
                //    node.Tag = item;
                //    node.Text = item.DisplayName;
                //    user.Nodes.Add(node);
                //}
                if (item.isAdmin == 1) // Admin
                {
                    TreeNode node = new TreeNode(item.DisplayName);
                    node.Tag = item;
                    adminNode.Nodes.Add(node);
                }
                else
                    if (item.isAdmin == 0) // User
                {
                    TreeNode node = new TreeNode(item.DisplayName);
                    node.Tag = item;
                    userNode.Nodes.Add(node);
                }
            }
            if (mNewId != 0)
            {
                DisplayOfNewAccount();
            }
            this.Dock = DockStyle.Fill;
            if(mAccount.isAdmin == 0)
            {
                this.Controls.Clear();
            }





        }

        private void ActionUpdate1_PressClose(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ActionUpdate1_PressHelp(object sender, EventArgs e)
        {

        }

        private void ActionUpdate1_PressNew(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ActionUpdate1_PressUpdate(object sender, EventArgs e)
        {
            //throw new NotImplementedException();


            TabPermissionBLL mTabPermissionBLL = new TabPermissionBLL(mAccount);
            int t = 0;
            foreach (stanfTabPermission obj in lst)
            {
                mTabPermissionBLL.UpdateElement(obj);
                t++;
            }
            if (t == lst.Count)
            {
                MessageBox.Show("Cập nhật quyền thành công!");
            }

        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                if (treeView1.SelectedNode.Tag != null)
                {
                    Account objAcc = new Account();
                    objAcc = (Account)treeView1.SelectedNode.Tag;

                    lst = new TabPermissionBLL(mAccount).CheckElementById(objAcc.UserId);
                    gridControl1.DataSource = lst;
                    gridControl1.RefreshDataSource();
                }
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int rowIndex = gridView1.GetFocusedDataSourceRowIndex();
            if (e.Column == IsAdd)
            {
                bool isAdd = (bool)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "IsAdd");
                lst[rowIndex].IsAdd = isAdd;
            }
            if (e.Column == IsList)
            {
                bool isList = (bool)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "IsList");
                lst[rowIndex].IsList = isList;
            }
            if (e.Column == IsEdit)
            {
                bool isEdit = (bool)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "IsEdit");
                lst[rowIndex].IsEdit = isEdit;
            }
            if (e.Column == IsDelete)
            {
                bool isDelete = (bool)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "IsDelete");
                lst[rowIndex].IsDelete = isDelete;
            }
            if (e.Column == IsReport)
            {
                bool isReport = (bool)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "IsReport");
                lst[rowIndex].IsReport = isReport;
            }


        }

    }
}
