using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using System.Data.SqlClient;
using System.Configuration;
using DevExpress.XtraPrinting.Export.Pdf;
using IMIC.SyncModule.DAO;
using IMIC.SyncModule.EntityObject;
using IMIC.SyncModule;
using IMIC.VALUEOBJECTS;
using IMIC.BUSINESSLOGICLAYERS;

namespace eCenterTrainning.UseControls
{
   
    public partial class uStudent : ucRightForm
    {
        private StudentLists mStudentLists;
        private CommentSupport mCommentSupport;
        private List<CommentSupport> mLisCommentSupport;
        private List<StudentLists> mLisStudentLists;
        StudentListsBll mStudentListsBll;

        /* isAction = false: Cập nhật & isAction = true: Thêm */
        private bool isAction = false;

        public uStudent(Account oAccount) : base(oAccount)
        {            
            InitializeComponent();
            mStudentLists = new StudentLists();
            mCommentSupport = new CommentSupport();
            mLisCommentSupport = new List<CommentSupport>();
            mStudentListsBll = new StudentListsBll(mAccount);
            dateEditFromDateCheckIn.EditValue = DateTime.Now.AddMonths(-3);
          
            dateEditToDateCheckIn.EditValue = DateTime.Now;
            //dateEditFromDateCheckIn.Text = ;
            //dateEditToDateCheckIn.Text = dateEditToDateCheckIn.EditValue.ToString();



        }
        public uStudent()
        {
            InitializeComponent();

            
            
        }        
        private void uStudent_Load(object sender, EventArgs e)
        {
            tabHocVienTiemNang.SelectedTabPage = xtraTabPageStudent;
            actionMenu1.PressNew += new EventHandler(actionMenu1_PressNew);
            actionMenu1.PressEdit += new EventHandler(actionMenu1_PressEdit);
            actionMenu1.PressRefresh += new EventHandler(actionMenu1_PressRefresh);
            actionMenu1.PressDelete += new EventHandler(actionMenu1_PressDelete);
            actionMenu1.PressClose += new EventHandler(actionMenu1_PressClose);
            actionMenu1.PressHelp += new EventHandler(actionMenu1_PressHelp);
            actionMenu1.SetHVTiemNangVisible();
            actionMenu1.SetVisibleReport();
            actionMenu1.PressReports += new EventHandler(actionMenu1_PressTimKiemKoMaHoa);
            actionMenu1.PressHVTiemNang += new EventHandler(actionMenu1_PressHVTiemNang);            
            BindStudentList();
            
            IFormatProvider mFomatter = new System.Globalization.CultureInfo("vi-VN");
            //Student_Register_Online oRegister = new StudentRegisterOnlineBll(mAccount).getElementById(0);
            //if (oRegister != null)
            //    lblGetRegisterOnline.Text = string.Format(">> Dữ liệu đk trực tuyến: {0} và lần gần nhất lấy dữ liệu: {1} bởi {2}. Bấm vào khi muốn lấy thông tin đk mới!!!",
            //                    Convert.ToDateTime(oRegister.CreatedTime, mFomatter).ToString("dd-MM-yyyy"),
            //                    Convert.ToDateTime(oRegister.UpdateDateTime, mFomatter).ToString("dd-MM-yyyy"),
            //                    oRegister.UserName);
            LoadCourse();
            //if (mAccount.IsSuperUser == false)
            //{
            dateEditFromDateCheckIn.Enabled = true;
            dateEditToDateCheckIn.Enabled = true;
            //    btnConfirms.Visible = true;
            //}else if(mAccount.IsSuperUser == true)
            //    btnConfirms.Visible = false;

            //LoadClassesForComboBox();
        }

        void LoadClassesForComboBox()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                List<Classes> oLisClasses = new List<Classes>();
                int iClassId = 0;
                int.TryParse(""+uluClasses.EditValue, out iClassId);
                if (iClassId > 0)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void BindStudentList()
        {
            mLisStudentLists = mStudentListsBll.getElementByTime(DateTime.Parse(dateEditFromDateCheckIn.EditValue.ToString()), DateTime.Parse(dateEditToDateCheckIn.EditValue.ToString()));
            gridControlStudent.DataSource = mLisStudentLists;
        }
        private void LoadCourse()
        {
            List<Cours> lisCourse = new CourseBll(mAccount).getElements();
            lookUpEditCourse.Properties.DisplayMember = "CourseName";
            lookUpEditCourse.Properties.ValueMember = "Id";
            lookUpEditCourse.Properties.DataSource = lisCourse;
        }
        //private void dateEditFromDateCheckIn_EditValueChanged(object sender, EventArgs e)
        //{
        //    msgMessage.Clear();
        //    if (string.IsNullOrEmpty(dateEditFromDateCheckIn.Text))
        //    {
        //        msgMessage.SetError(dateEditFromDateCheckIn, "Bạn hãy nhập ngày bắt đầu trước khi thực hiện");
        //        dateEditFromDateCheckIn.Focus();
        //        return;
        //    }
        //    else
        //    {
        //        dateEditToDateCheckIn.Enabled = true;
        //        if (string.IsNullOrEmpty(dateEditToDateCheckIn.Text))
        //        {
        //            msgMessage.SetError(dateEditToDateCheckIn, "Bạn hãy nhập ngày kết thúc trước khi thực hiện");
        //            dateEditToDateCheckIn.Focus();
        //            return;
        //        }
        //    }
        //}

        //private void dateEditToDateCheckIn_EditValueChanged(object sender, EventArgs e)
        //{
        //    msgMessage.Clear();
        //    int resultEnd = DateTime.Compare(DateTime.Parse("" + dateEditFromDateCheckIn.Text, Common.ci), DateTime.Parse("" + dateEditToDateCheckIn.Text, Common.ci));
        //    if (resultEnd >= 0)
        //    {
        //        msgMessage.SetError(dateEditToDateCheckIn, " Bạn cần chọn ngày kết thúc sau ngày bắt đầu");
        //        return;
        //    }
        //    else
        //    {
        //        TimKiemHocVienTheoThoiGian();
        //    }
        //}

        void TimKiemHocVienTheoThoiGian()
        {
            if (mAccount.IsSuperUser == true || mAccount.UserId == 60)
            {
                if (!string.IsNullOrEmpty("" + dateEditFromDateCheckIn.Text) && !string.IsNullOrEmpty("" + dateEditToDateCheckIn.Text))
                {
                    DateTime dtStartTime = DateTime.Parse("" + dateEditFromDateCheckIn.EditValue);
                    DateTime dtEndTime = DateTime.Parse("" + dateEditToDateCheckIn.EditValue);
                    List<StudentLists> lisStudent = new StudentListsBll(mAccount).
                                getElementByTime(dtStartTime, dtEndTime);
                    gridControlStudent.DataSource = lisStudent;
                }
            }
            else
            {                
                MessageBox.Show("Bạn không có quyền sử dụng tính năng này.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        void actionMenu1_PressHVTiemNang(object sender, EventArgs e){}
        void actionMenu1_PressTimKiemKoMaHoa(object sender, EventArgs e)
        {
            if (mAccount.IsSuperUser == true)
            {
                frmHocVienSearch ofrm = new frmHocVienSearch(mAccount);
                ofrm.ShowDialog();
            }else
            {
                MessageBox.Show("Bạn không có quyền sử dụng tính năng này.","Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }
        void actionMenu1_PressHelp(object sender, EventArgs e){}        
        void actionMenu1_PressClose(object sender, EventArgs e)
        {
            this.Dispose();
        }
        void actionMenu1_PressDelete(object sender, EventArgs e)
        {
            if (mAccount.IsSuperUser == true)
            {
                int intStudentId = 0;
                int.TryParse("" + gridViewStudent.GetFocusedRowCellValue("Id"), out intStudentId);
                if (intStudentId > 0)
                {

                    DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dlg == DialogResult.Yes)
                    {
                        Student oStudent = new Student
                        {
                            Id = intStudentId
                        };
                        bool isResult = new StudentBll(mAccount).DeleteElement(oStudent);
                        BindStudentList();
                    }
                }
                else
                {
                     DialogResult opt =  MessageBox.Show("Hãy xác nhận Yes để làm mới lại dữ liệu trước khi thực hiện xóa.", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (opt == DialogResult.Yes)
                        BindStudentList();
                    MessageBox.Show("Vui lòng chọn lại dữ liệu cần xóa khỏi hệ thống. Dữ liệu này sẽ được sao chép lại để phục hồi khi cần.", 
                                            "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                    
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sử dụng tính năng này.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }           
        }
        void actionMenu1_PressRefresh(object sender, EventArgs e){
            BindStudentList();
        }
        void actionMenu1_PressEdit(object sender, EventArgs e)
        {
            int intStudentId = 0;
            int.TryParse("" + gridViewStudent.GetFocusedRowCellValue("Id"), out intStudentId);

            if (intStudentId > 0)
            {
                StudentLists oStudentLists = new StudentListsBll(mAccount).getElementById(intStudentId);
                //frmAddHocVien ofrm = new frmAddHocVien(mAccount, oStudentLists);
                //ofrm.ShowDialog();
                if(mAccount.isClose == false)
                   BindStudentList();               
            }
            else
            {
                MessageBox.Show("Bạn cần chọn thông tin trước khi thực hiện", "Thông báo");
            }
        }
        void actionMenu1_PressNew(object sender, EventArgs e)
        {
            //frmAddHocVien ofrm = new frmAddHocVien(mAccount, null);
            //ofrm.ShowDialog();
            if (mAccount.isClose == false)
                BindStudentList();
        }        
        
        private void gridControlSupport_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //int id = 0;
            //frmSupportDetails obj = new frmSupportDetails();
            //int.TryParse("" + gridViewSupport.GetFocusedRowCellValue("Id"), out id);
            //obj.Id = id;
            //obj.ShowDialog();
        }
        /// <summary>
        /// Hàm binding dữ liệu sinh viên được chọn lên tabpageHistory
        /// Author          Date        Comment
        /// hungld       05/02/2013     Tạo mới
        /// </summary>

        private void xtraTabControlStudent_Click_1(object sender, EventArgs e)
        {

            //if (tabHocVienTiemNang.SelectedTabPageIndex == 1)
            //{
            //    int.TryParse("" + gridViewStudent.GetFocusedRowCellValue("Id"), out _IdStudent);
            //    //IdStudent = Convert.ToInt32(gridViewStudent.GetFocusedRowCellValue("Id"));
            //    if (IdStudent > 0)
            //    {
            //        loadLastHistorySupportComment();
            //        displaySupportComment();
            //        //if (txtUserName.Text == eCenterSystem.UserName)
            //        //{
            //        //    btnSua.Enabled = true;
            //        //}
            //    }
            //}
            /*else*/ if (tabHocVienTiemNang.SelectedTabPageIndex == 2)
            {
                //txtName.Text = "" + gridViewStudent.GetFocusedRowCellValue("FullName");
                txt_Email.Text = "" + gridViewStudent.GetFocusedRowCellValue("Email");
                txt_Mobile.Text = "" + gridViewStudent.GetFocusedRowCellValue("Mobile");
                //if (gridViewStudent.GetFocusedRowCellValue("Email") != null)
                //{
                //    txt_Email.Text = new Common().DecryptInfo("" + gridViewStudent.GetFocusedRowCellValue("Email"));
                //}
                //else
                //{
                //    txt_Email.Text = "";
                //}
                //if (gridViewStudent.GetFocusedRowCellValue("Mobile") != null)
                //{
                //    txt_Mobile.Text = new Common().DecryptInfo("" + gridViewStudent.GetFocusedRowCellValue("Mobile"));
                //}
                //else
                //{
                //    txt_Mobile.Text = "";
                //}
                //LoadHocPhi();
                List<StudentClasses> lstStudentClasses = new StudentClassesBll(mAccount).CheckElementById(mStudentLists.Id);
                gridControlHP.DataSource = lstStudentClasses;

                uluClasses.Properties.DisplayMember = "ClassName";
                uluClasses.Properties.ValueMember = "ClassId";
                uluClasses.Properties.DataSource = lstStudentClasses;

                
            }
        }

        private void gridViewSupport_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column == ColAction)
            {
                if(mAccount.IsSuperUser == true)
                {
                    DialogResult opt = MessageBox.Show("Bạn chắc chắn muốn xóa nội dung này?",
                                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opt == DialogResult.Yes)
                    {
                        int idcomment = 0;
                        int.TryParse("" + gridViewSupport.GetFocusedRowCellValue("Id"), out idcomment);

                        if (idcomment > 0)
                        {
                            CommentSupport oComment = new CommentSupport
                            {
                                Id = idcomment
                            };
                            bool isResult = new CommentSupportBll(mAccount).DeleteElement(oComment);
                            if (isResult)
                            {
                                foreach (CommentSupport o in mLisCommentSupport)
                                {
                                    if (oComment.Id == o.Id)
                                    {                                        
                                        mLisCommentSupport.Remove(o);
                                        break;
                                    }
                                }
                            }
                            RefeshListCommentSupport(sender, e);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn không có quền xóa dữ liệu này. Vui lòng liên hệ người Quản lý của bạn",
                              "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }                      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            msgMessage.Clear();
            string Id = ""+mStudentLists.Id;           
            if (btnAdd.Text.Equals("Thêm"))
            {
                btnSua.Text = "Hủy Bỏ";
                btnSua.Enabled = true;
                btnSua.Image = eCenterTrainning.Properties.Resources.deleted;
                btnAdd.Text = "Lưu Lại";
                btnAdd.Image = eCenterTrainning.Properties.Resources.save;
                isAction = true;  //TH Thêm

                dateEditSupport.Enabled = true;
                richTextBoxContent.ReadOnly = false;
                richTextBoxContent.Text = "";                
                dateEditSupport.EditValue = DateTime.Now;
                gridControlSupport.Enabled = false;
                lookUpEditCourse.Enabled = true;
            }
            else
            {                
                if (isAction)
                {
                    //Flag > 0 : Insert & Flag <= 0 : Update
                    CommentSupport oCommentSupport = new CommentSupport
                    {
                        CommentName = lookUpEditCourse.Text,
                        UserId = mAccount.UserId,
                        UserName = mAccount.UserName,
                        Desription = richTextBoxContent.Text,
                        StudentId = mStudentLists.Id,
                        DateCreate = DateTime.Now
                    };
                    oCommentSupport.DateLastUpdate = DateTime.Now.ToLocalTime();
                    oCommentSupport.Flag = 1; //Thêm                    
                    bool isResult = new CommentSupportBll(mAccount).InsertAndUpdateElement(oCommentSupport);
                    if (isResult)
                    {
                        if (mLisCommentSupport == null)
                            mLisCommentSupport = new List<CommentSupport>();
                        mLisCommentSupport.Insert(0, oCommentSupport);
                    }                        
                }
                else
                {
                    CommentSupport oCommentSupport = null;
                    foreach (CommentSupport oComment in mLisCommentSupport)
                    {
                        if (mCommentSupport.Id == oComment.Id)
                        {
                            oCommentSupport = oComment;
                            mLisCommentSupport.Remove(oComment);
                            break;
                        }                            
                    }
                    oCommentSupport.Flag = 0; //Cập nhật  
                    oCommentSupport.Desription = richTextBoxContent.Text;
                    oCommentSupport.UserId = mAccount.UserId;
                    oCommentSupport.UserName = mAccount.UserName;
                    oCommentSupport.CommentName = lookUpEditCourse.Text;
                    oCommentSupport.Id = mCommentSupport.Id;
                    oCommentSupport.StudentId = mStudentLists.Id;
                    bool isResult = new CommentSupportBll(mAccount).InsertAndUpdateElement(oCommentSupport);
                    if (isResult)                                          
                        mLisCommentSupport.Insert(0, oCommentSupport);                                  
                }
                RefeshListCommentSupport(sender, e);
                
                btnAdd.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnSua.Enabled = false;
                gridControlSupport.Enabled = true;
                btnSua.Image = eCenterTrainning.Properties.Resources.book_edit;                
                btnAdd.Image = eCenterTrainning.Properties.Resources._new;
                lookUpEditCourse.Enabled = false;
                dateEditSupport.Enabled = false;
                richTextBoxContent.ReadOnly = true;
            }
        }
        void RefeshListCommentSupport(object sender, EventArgs e)
        {
            //if (mLisCommentSupport.Count > 0)
            //{
            //    richTextBoxContent.Text = mLisCommentSupport[0].Desription;
            //    gridControlSupport.DataSource = mLisCommentSupport;
            //    gridControlSupport.RefreshDataSource();
            //    gridControlSupport.Update();
            //}
            //else
            //{
            //    richTextBoxContent.Text = "";
            //    richTextBoxContent.ReadOnly = true;
            //}            
            gridControlStudent_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {            
            int idcomment = 0;
            int.TryParse("" + gridViewSupport.GetFocusedRowCellValue("Id"), out idcomment);
            
            if (idcomment > 0)
            {
                string sTemp = "" + gridViewSupport.GetFocusedRowCellValue("Desription");
                if (btnSua.Text.Equals("Sửa"))
                {
                    isAction = false;  //TH Cập nhật
                    gridControlSupport.Enabled = false;                   
                    btnSua.Text = "Hủy bỏ";
                    btnSua.Image = eCenterTrainning.Properties.Resources.deleted;
                    btnAdd.Text = "Lưu lại";
                    btnAdd.Image = eCenterTrainning.Properties.Resources.save;
                    lookUpEditCourse.Enabled = true;
                    dateEditSupport.Enabled = true;
                    richTextBoxContent.ReadOnly = false;
                }
                else
                {
                    btnSua.Text = "Sửa";
                    gridControlSupport.Enabled = true;
                    btnSua.Image = eCenterTrainning.Properties.Resources.book_edit;
                    btnAdd.Text = "Thêm";
                    btnAdd.Image = eCenterTrainning.Properties.Resources._new;
                    richTextBoxContent.Text = sTemp;
                    lookUpEditCourse.Enabled = false;
                    dateEditSupport.Enabled = false;
                    richTextBoxContent.ReadOnly = true;
                }
            }                                  
        }        
        private void resetAllfieldAndEnable()
        {
            lookUpEditCourse.Enabled = true;
            dateEditSupport.Enabled = true;
            richTextBoxContent.ReadOnly = false;
            lookUpEditCourse.EditValue = 1;
            dateEditSupport.Text = "";
            richTextBoxContent.Text = "";

        }
        private void resetAllfieldAndDisable()
        {
            lookUpEditCourse.Enabled = false;
            dateEditSupport.Enabled = false;
            richTextBoxContent.ReadOnly = true;
        }

        private void lookUpEditUser_EditValueChanged_1(object sender, EventArgs e)
        {
            
        }       
        private void gridControlStudent_DoubleClick(object sender, EventArgs e)
        {
            tabHocVienTiemNang.SelectedTabPage = xtraTabPageHistory;            
        }        
        private void gridControlHP_Click(object sender, EventArgs e)
        {
            listBoxHP.Items.Clear();
            int id = 0;
            int.TryParse("" + gridViewHP.GetFocusedRowCellValue("Id"), out id);          
            
        }
        private void btnGhiHP_Click(object sender, EventArgs e)
        {
            //frmHocPhi objHP = new frmHocPhi();
            //int idClass = 0;
            //int.TryParse("" + gridViewHP.GetFocusedRowCellValue("ClassId"), out idClass);
            //if (idClass > 0)
            //{
            //    if (checkExistStudentClass(idClass) > 0)
            //    {
            //        objHP.IdClass = 0;
            //    }
            //    else
            //    {
            //        objHP.IdClass = idClass;
            //    }
            //}
            //objHP.IdStudent = IdStudent;
            
            //LoadHocPhi();
        }
        private void gridControlStudent_Click(object sender, EventArgs e)
        {
            int idStu = 0;
            string value = "" + gridViewStudent.GetFocusedRowCellValue("Id");          
            if (int.TryParse(value, out idStu))
            {
                mStudentLists.Id = idStu;
                mStudentLists.FullName = "" + gridViewStudent.GetFocusedRowCellValue("FullName");
                mStudentLists.Mobile = "" + gridViewStudent.GetFocusedRowCellValue("Mobile");
                mStudentLists.Email = "" + gridViewStudent.GetFocusedRowCellValue("Email");
                mStudentLists.CourseId = int.Parse("" + gridViewStudent.GetFocusedRowCellValue("CourseId"));
                
                //if (mStudentLists.Mobile != null)
                //{
                //    mStudentLists.Mobile = new Common().DecryptInfo(mStudentLists.Mobile);
                //}
                //if (mStudentLists.Email != null)
                //{
                //    mStudentLists.Email = new Common().DecryptInfo(mStudentLists.Email);
                //}
                txtHoTen.Text = mStudentLists.FullName;
                txtEmail.Text = mStudentLists.Email;
                txtMobileStudent.Text = mStudentLists.Mobile;
                txtUserName.Text = mAccount.UserName;
                //lookUpEditCourse.Enabled = true;
                lookUpEditCourse.EditValue = mStudentLists.CourseId;
                dateEditSupport.EditValue = DateTime.Now.ToString("dd-MM-yyyy hh:mi:ss");

                //Hien thi nhat ky cham soc hoc vien
                LoadData_Comment_Support_By_StudentId(idStu);
            }
        }

        void LoadData_Comment_Support_By_StudentId(object id)
        {
            mLisCommentSupport = new CommentSupportBll(mAccount).CheckElementById(id);
            if (mLisCommentSupport != null)
            {
                string CommentDescription = mLisCommentSupport[0].Desription;
                richTextBoxContent.Text = CommentDescription;
                gridControlSupport.DataSource = mLisCommentSupport;                
            }
            btnSua.Enabled = false;
        }

        private void gridControlSupport_Click(object sender, EventArgs e)
        {
            int idComment = 0;            
            string value = "" + gridViewSupport.GetFocusedRowCellValue("Id");            
            int.TryParse(value, out idComment);
            if(idComment > 0)
            {
                mCommentSupport.Id = idComment;
                mCommentSupport.Desription = ""+gridViewSupport.GetFocusedRowCellValue("Desription");                
                richTextBoxContent.Text = mCommentSupport.Desription;
                btnSua.Enabled = true;
            }
            else
            {
                DialogResult opt = MessageBox.Show("Bạn chắc chắn muốn sửa lại dữ liệu vừa thêm?",
                                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opt == DialogResult.Yes)
                {
                    if (mStudentLists.Id > 0)
                    {                        
                        LoadData_Comment_Support_By_StudentId(mStudentLists.Id);
                    }
                    else
                        MessageBox.Show("Bạn cần chọn lại 1 học viên nào đó để tiếp tục");
                }
                btnSua.Enabled = false;
            }            
        }
        private int checkExistStudentClass(int idClass)
        {
            
            return 0;
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            //frmHocPhi objHP = new frmHocPhi();
            //int id = 0;
            //int.TryParse("" + gridViewHP.GetFocusedRowCellValue("Id"), out id);
            //int idClass = 0;
            //int.TryParse("" + gridViewHP.GetFocusedRowCellValue("ClassId"), out idClass);
            //if (id > 0)
            //{
            //    objHP.IdStudent_Class = id;
            //}
            //objHP.IdStudent = IdStudent;
            //objHP.IdClass = idClass;           
            //LoadHocPhi();
        }            
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            msgMessage.Clear();
            int iKhoaHoc = 0;
            if (String.IsNullOrEmpty(dtpTuNgay_TiemNang.Text))
            {
                msgMessage.SetError(dtpTuNgay_TiemNang, "Chọn Ngày bắt đầu!");
            }
            else if (String.IsNullOrEmpty(dtpDenNgay_TiemNang.Text))
            {
                msgMessage.SetError(dtpDenNgay_TiemNang, "Chọn Ngày kết thúc!");
            }
            else
            {
                int.TryParse("" + uluKhoaHoc_TiemNang.Properties.
                                GetKeyValueByDisplayText(uluKhoaHoc_TiemNang.Text), out iKhoaHoc);
                //Get date
                int ngay = dtpTuNgay_TiemNang.DateTime.Day;
                int thang = dtpTuNgay_TiemNang.DateTime.Month;
                int nam = dtpTuNgay_TiemNang.DateTime.Year;
                string tungay = String.Format("{0}-{1}-{2}", nam, thang, ngay);

                ngay = dtpDenNgay_TiemNang.DateTime.Day;
                thang = dtpDenNgay_TiemNang.DateTime.Month;
                nam = dtpDenNgay_TiemNang.DateTime.Year;
                string denngay = String.Format("{0}-{1}-{2}", nam, thang, ngay);

                //Excecuted SQL                
                try
                {
                    MessageBox.Show("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnCapNhatThongTin_Click(object sender, EventArgs e)
        {
            ThongTin_HocVien_TiemNang();
        }
        void ThongTin_HocVien_TiemNang()
        {
            int id = int.Parse("" + grdHocVienTiemNang.GetFocusedRowCellValue("ID"));
            int iStudentId = int.Parse("" + grdHocVienTiemNang.
                            GetFocusedRowCellValue("StudentID"));
            string fullName = "" + grdHocVienTiemNang.GetFocusedRowCellValue("FullName");
            string contents = "" + grdHocVienTiemNang.GetFocusedRowCellValue("Contents");
            int iStatus = int.Parse("" + grdHocVienTiemNang.GetFocusedRowCellValue("Status"));
                        
        }
        private void grdHocVienTiemNang_DoubleClick(object sender, EventArgs e)
        {
            ThongTin_HocVien_TiemNang();
        }       
        private void btnSync_Click(object sender, EventArgs e){ }       
        private void btnDecrypt_Click(object sender, EventArgs e){ }              

        private void lblGetRegisterOnline_Click(object sender, EventArgs e)
        {
            Actions oActions = new Actions();
            oActions.isHasData = false;
            frmStudentRegisterOnline ofrm = new frmStudentRegisterOnline(mAccount, mLisStudentLists, oActions);
            ofrm.ShowDialog();
            if (oActions.isHasData)
            {
                gridControlStudent.DataSource = mLisStudentLists;
                gridControlStudent.RefreshDataSource();
                gridControlStudent.Update();
            }            
        }

        private void dateEditToDateCheckIn_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            //BindStudentList();
        }

        private void dateEditToDateCheckIn_EditValueChanged(object sender, EventArgs e)
        {
            BindStudentList();
        }

        private void dateEditFromDateCheckIn_EditValueChanged(object sender, EventArgs e)
        {
            if(dateEditToDateCheckIn.EditValue == null)
                dateEditToDateCheckIn.EditValue = DateTime.Now;
            BindStudentList();
        }

        private void uluClasses_EditValueChanged(object sender, EventArgs e)
        {
           
            List<StudentClasses> lstStudentClasses = new StudentClassesBll(mAccount).CheckElementById(mStudentLists.Id);
            foreach (StudentClasses item in lstStudentClasses)
            {
                if (uluClasses.Text == item.ClassName)
                {
                    List<StudentClasses> lst = new List<StudentClasses>();
                    lst.Add(item);
                    gridControlHP.DataSource = lst;

                    //gridControlHP.RefreshDataSource();
                    //gridControlHP.Update();


                    break;
                }
            }
        }
    }
}
