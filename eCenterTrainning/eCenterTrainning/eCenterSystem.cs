﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Localization;
using DevExpress.XtraBars.Helpers;
using System.Threading;

using IMIC.SyncModule;
using IMIC.VALUEOBJECTS;
using IMIC.BUSINESSLOGICLAYERS;


namespace eCenterTrainning
{
    public partial class eCenterSystem : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Account mAccount;
        public eCenterSystem()
        {
            InitializeComponent();
            mAccount = new Account();
            
        }        
        private void eCenterSystem_Load(object sender, EventArgs e)
        {
            //frmFlashScreen flash = new frmFlashScreen();
            //flash.ShowDialog();
            

            
            frmLogin oFrmLogin = new frmLogin(mAccount);
            oFrmLogin.ShowDialog(); 
            if (mAccount.isSuccess)
            {
                mAccount.ListTabPermissions = new TabPermissionBLL(mAccount).CheckElementById(mAccount.UserId);
                barButtonItemLogin.Caption = "Đăng xuất";
                this.Text = "Chào mừng " + mAccount.DisplayName;
                
            }
            
          
       


        }
        public class MyBarLocalizer : BarLocalizer
        {
            public override string GetLocalizedString(BarString id)
            {
                if (id == BarString.SkinCaptions)
                {
                    //Default value for BarString.SkinCaptions:
                    //"|DevExpress Style|Caramel|Money Twins|DevExpress Dark Style|iMaginary|Lilian|Black|Blue|Office 2010 Blue|Office 2010 Black|Office 2010 Silver|Office 2007 Blue|Office 2007 Black|Office 2007 Silver|Office 2007 Green|Office 2007 Pink|Seven|Seven Classic|Darkroom|McSkin|Sharp|Sharp Plus|Foggy|Dark Side|Xmas (Blue)|Springtime|Summer|Pumpkin|Valentine|Stardust|Coffee|Glass Oceans|High Contrast|Liquid Sky|London Liquid Sky|The Asphalt World|Blueprint|"
                    string defaultSkinCaptions = base.GetLocalizedString(id);
                    string newSkinCaptions = defaultSkinCaptions.Replace("|DevExpress Style|", "|My Favorite Skin|");
                    return newSkinCaptions;
                }
                return base.GetLocalizedString(id);
            }
        }        
        private void navBarItemCustomer_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.plMain.Controls.Clear();
            UseControls.uCustomers u = new UseControls.uCustomers();
            u.Dock = DockStyle.Fill;
            this.plMain.Controls.Add(u);
        }

        private void barButtonItemCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.plMain.Controls.Clear();
            UseControls.uCustomers u = new UseControls.uCustomers();
            u.Dock = DockStyle.Fill;
            this.plMain.Controls.Add(u);
        }

        private void barButtonItemLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(mAccount.isSuccess)
            {
                mAccount.isSuccess = false;
                barButtonItemLogin.Caption = "Đăng nhập";
                this.Text = "eTrainning";
                plMain.Controls.Clear();
            }
            //frmLogin oFrmLogin = new frmLogin(mAccount);
            //oFrmLogin.ShowDialog();
            //if (mAccount.isSuccess)
            //{
            //    barButtonItemLogin.Caption = "Đăng xuất";
            //    this.Text = "Chào mừng " + mAccount.DisplayName;
            //}
            eCenterSystem_Load(sender, e);

        }

        private void btnExitProgram_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bbIAdministrator_ItemClick(object sender, ItemClickEventArgs e)
        {
            plMain.Controls.Clear();
            plMain.Controls.Add(new UseControls.uListUsers(mAccount));
        }

        private void menuTinTucTuDong_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void navBarItemHocVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            UseControls.uStudent ouStudent = new UseControls.uStudent(mAccount);
            plMain.Controls.Add(ouStudent);
        }

        private void navBarItemNhanVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            UseControls.uEmployee ucEmployee = new UseControls.uEmployee(mAccount);
            plMain.Controls.Add(ucEmployee);
        }

        private void navBarGiangVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            UseControls.uExpertInfo oUExpert = new UseControls.uExpertInfo(mAccount);
            plMain.Controls.Add(oUExpert);
        }

        private void naveTrainning_Click(object sender, EventArgs e)
        {

        }

        private void navBarItemLopHoc_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            UseControls.uClass oUClass = new UseControls.uClass(mAccount);
            plMain.Controls.Add(oUClass);
        }

        private void navBarItemManageCandidate_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            UseControls.uCandidate ucCan = new UseControls.uCandidate(mAccount);
            plMain.Controls.Add(ucCan);
        }

        private void navBarItemAddRecuitment_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            UseControls.uRecruitmentInfo ucRec = new UseControls.uRecruitmentInfo(mAccount);
            plMain.Controls.Add(ucRec);
        }

        private void navBarItemUsers_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            UseControls.uQuanLyUser oUQuanLyUser = new UseControls.uQuanLyUser(mAccount);
            plMain.Controls.Add(oUQuanLyUser);
        }
    }
}