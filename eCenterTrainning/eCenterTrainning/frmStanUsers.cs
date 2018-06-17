using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using IMIC.SyncModule;
using IMIC.VALUEOBJECTS;
using IMIC.BUSINESSLOGICLAYERS;
namespace eCenterTrainning
{
    public partial class frmStanUsers : Base.frmIMICBase
    {
        AccountBill mAccountBiLL;
        Account UpdateAcc = null;
        public frmStanUsers(Account oAccount) : base(oAccount) //Insert
        {
            InitializeComponent();
            mAccountBiLL = new AccountBill(mAccount);

        }
        public frmStanUsers(Account oAccount, int UserId) : base(oAccount) //Update
        {
            InitializeComponent();
            mAccountBiLL = new AccountBill(mAccount);
            txtPassword.Enabled = false;
            txtPasswordAfter.Enabled = false;
            DisplayAccNow(UserId);

        }

        private void DisplayAccNow(int UserId)
        {
            UpdateAcc = mAccountBiLL.getElementById(UserId);
            if (UpdateAcc != null)
            {
                txtEmail.Text = UpdateAcc.Email;
                txtHoTen.Text = UpdateAcc.DisplayName;
                txtMobile.Text = UpdateAcc.Phone;
                txtUserName.Text = UpdateAcc.UserName;
                if (UpdateAcc.Sex == 0)
                    cboSex.Text = "Nam";
                else if (UpdateAcc.Sex == 1)
                    cboSex.Text = "Nữ";

                if (UpdateAcc.isAdmin == 0)
                    cboUserType.Text = "User";
                else if (UpdateAcc.isAdmin == 1)
                    cboUserType.Text = "Admin";

            }
        }

        public frmStanUsers(cConfigParams oConfigs)
        {
            InitializeComponent();            
        }
        private void frmStanUsers_Load(object sender, EventArgs e)
        {
            actionUpdateStanUser.PressUpdate += new EventHandler(actionUpdateStanUser_PressUpdate);
            actionUpdateStanUser.PressNew += new EventHandler(actionUpdateStanUser_PressNew);
            actionUpdateStanUser.PressClose += new EventHandler(actionUpdateStanUser_PressClose);
            actionUpdateStanUser.PressHelp += new EventHandler(actionUpdateStanUser_PressHelp);
            loadDepartment();
            loadEmployee();
            this.Text = "Thêm mới thông tin người dùng";
            
        }

        void actionUpdateStanUser_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cập nhật", "Thông Báo");
        }

        void actionUpdateStanUser_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }

        void actionUpdateStanUser_PressNew(object sender, EventArgs e)
        {
            resetAllField();
        }

        void actionUpdateStanUser_PressUpdate(object sender, EventArgs e)
        {
            msgMessage.Clear();

            if (string.IsNullOrEmpty("" + txtHoTen.Text))
            {
                msgMessage.SetError(txtHoTen, "Bạn cần nhập họ tên trước khi thực hiện");
                txtHoTen.Focus();
                return;
            }
            if (string.IsNullOrEmpty("" + txtEmail.Text))
            {
                msgMessage.SetError(txtEmail, "Bạn cần nhập email trước khi thực hiện");
                txtEmail.Focus();
                return;
            }
            if (!string.IsNullOrEmpty("" + txtEmail.Text))
            {
                if (Common.validateEmail(txtEmail.Text) < 1)
                {
                    msgMessage.SetError(txtEmail, "Bạn cần nhập email đúng định dạng");
                    txtEmail.Focus();
                    return;
                }
            }

            if (string.IsNullOrEmpty("" + txtUserName.Text))
            {
                msgMessage.SetError(txtUserName, "Bạn cần nhập tên tài khoản trước khi thực hiện");
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Enabled == true)
            {
                if (string.IsNullOrEmpty("" + txtPassword.Text))
                {
                    msgMessage.SetError(txtPassword, "Bạn cần nhập mật khẩu trước khi thực hiện");
                    txtPassword.Focus();
                    return;
                }
            }
            if (txtPasswordAfter.Enabled == true)
            {
                if (string.IsNullOrEmpty("" + txtPasswordAfter.Text))
                {
                    msgMessage.SetError(txtPasswordAfter, "Bạn cần nhập mật khẩu nhập lại trước khi thực hiện");
                    txtPasswordAfter.Focus();
                    return;
                }
            }
            if (!string.IsNullOrEmpty("" + txtPassword.Text) && !string.IsNullOrEmpty("" + txtPasswordAfter.Text) && !txtPassword.Text.Equals(txtPasswordAfter.Text))
            {
                msgMessage.SetError(txtPasswordAfter, "Mật khẩu nhập lại không chính xác");
                txtPasswordAfter.Focus();
                return;
            }
            int temp = 1;
            int mIsAdmin = 1;
            if (cboUserType.Text == "User")
                mIsAdmin = 0;
            if (cboSex.Text == "Nam")
                temp = 0;
             Account objAcc = new Account()
            {
                
                DisplayName = txtHoTen.Text,
                Email = txtEmail.Text,
                isOnline = false,
                isSuccess = false,
                IsSuperUser = false,
                isAdmin = mIsAdmin,
                Password = Common.EncodePassword(txtPassword.Text),
                Phone = txtMobile.Text,       
                Sex = temp,
                UserName = txtUserName.Text
            };
            if(UpdateAcc == null) //Insert
            {
                
                if (mAccountBiLL.InsertElement(objAcc))
                {
                    MessageBox.Show("Thêm mới tài khoản thành công!");
                    List<stanfRole> lstRoles = new List<stanfRole>();
                    lstRoles = new RolesBLL(mAccount).getElements();
                    TabPermissionBLL mTabPermissionBLL = new TabPermissionBLL(mAccount);
                    List<Account> lstAcc = new List<Account>();
                    lstAcc = mAccountBiLL.getElements();
                    Account tempAcc = new Account();
                    tempAcc = lstAcc.LastOrDefault();
                    
                    foreach (stanfRole o in lstRoles)
                    {
                        stanfTabPermission mStanfTabPermission = new stanfTabPermission
                        {
                            RoleId = o.RoleId,
                            UserId = tempAcc.UserId
                        };
                        mTabPermissionBLL.InsertElement(mStanfTabPermission);
                           
                    }
                    
                    
                    
                    
                }
                else
                {
                    MessageBox.Show("Thêm mới tài khoản thất bại!");
                }
            }
            else //Update
            {
                objAcc.UserId = UpdateAcc.UserId;
                if (mAccountBiLL.UpdateElement(objAcc))
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật tài khoản thất bại!");
                }
            }
            this.Close();
        }
        // load employee
        private void loadEmployee()
        {
            ConnectionEntities obj = new ConnectionEntities();
            
            //lookUpEditEmployee.Properties.DataSource = lstEmp;
            lookUpEditEmployee.Properties.DisplayMember = "EmployeeName";
            lookUpEditEmployee.Properties.ValueMember = "Id";

        }
        private void lookUpEditEmployee_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void loadEmployeeData()
        {
            String value = "" + lookUpEditEmployee.EditValue;
            int idEmp = 0;
            int.TryParse(value, out idEmp);
            if (idEmp > 0)
            {
                ConnectionEntities obj = new ConnectionEntities();
                
            }
            btnAddMoreDepartment.Enabled = false;
            lookUpEditDepartment.Enabled = false;
            enableField();
        }
        // load department
        private void loadDepartment()
        {
            ConnectionEntities obj = new ConnectionEntities();
            
            //lookUpEditDepartment.Properties.DataSource = lstOu;
            lookUpEditDepartment.Properties.DisplayMember = "OuName";
            lookUpEditDepartment.Properties.ValueMember = "Id";            
        }

        private void btnAddMoreDepartment_Click(object sender, EventArgs e)
        {
            frmPhongBan frm = new frmPhongBan();
            frm.ShowDialog();          
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      xoa thong tin user tren field
        /// </summary>
        private void resetAllField()
        {
            foreach (Control c in groupControlStanUser.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    c.Text = "";
                }
                txtAddress.Text = "";
                btnAddMoreDepartment.Enabled = true;
                enableField();              
            }
        }
        private void enableField()
        {
            //lookUpEditDepartment.Enabled = true;
            txtHoTen.Enabled = true;
            cboSex.Enabled = true;
            txtMobile.Enabled = true;
            txtEmail.Enabled = true;
            txtAddress.Enabled = true;
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them thong tin user
        /// </summary>
        private int insertUser()
        {
            try
            {                
                ConnectionEntities obj = new ConnectionEntities();
                
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
                return 0;
            }
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      sua thong tin user
        /// </summary>
        private int updateUser()
        {
            try
            {
                ConnectionEntities obj = new ConnectionEntities();
                
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
                return 0;
            }
        }
        
        public string LocalIPAddress()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }

        private void linkLabelChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(UpdateAcc != null)
            {
                frmChangePassword oFrmChangePassword = new frmChangePassword(mAccount, UpdateAcc);
                oFrmChangePassword.ShowDialog();
            }
        }
    }
}