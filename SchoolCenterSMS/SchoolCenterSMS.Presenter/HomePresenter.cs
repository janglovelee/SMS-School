using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolCenterSMS.View;
using SchoolCenterSMS.View.Forms;
using SchoolCenterSMS.View.Views.Home;

namespace SchoolCenterSMS.Presenter
{
    public class HomePresenter : BasePresenter
    {
        #region Constants
        public const int CAU_HINH = 0;
        public const int DANH_BA = 1;
        public const int THIET_BI = 2;
        public const int LICH_GUI_TIN = 3;
        #endregion

        #region Enums
        #endregion

        #region Fields
        private int subMenuIndex = -1;
        //private PatientCareService _service;
        //private Patient _patient;
        private CauHinhView _cauHinhView;
        private DanhBaView _danhBaView;
        private ThietBiView _thietBiView;
        private LichGuiTinView _lichGuiTinView;
        #endregion

        #region Properties
        public CauHinhView CauHinhView 
        {
            get
            {
                if (_cauHinhView == null)
                {
                    this._cauHinhView = new CauHinhView();
                    this._cauHinhView.ConnectDevice += ConnectDevice;
                    this._cauHinhView.DisconnectDevice += DisconnectDevice;
                }
                return this._cauHinhView;
            }          
        }
                
        public DanhBaView DanhBaView
        {
            get
            {
                if (_danhBaView == null)
                {
                    _danhBaView = new DanhBaView();
                }
                return _danhBaView;
            }
        }
        public ThietBiView ThietBiView
        {
            get
            {
                if (_thietBiView == null)
                {
                    this._thietBiView = new ThietBiView();
                }
                return this._thietBiView;
            }
        }

        public LichGuiTinView LichGuiTinView
        {
            get
            {
                if (_lichGuiTinView == null)
                {
                    this._lichGuiTinView = new LichGuiTinView();
                }
                return this._lichGuiTinView;
            }
        }
        #endregion

        #region Constructors
        public HomePresenter ( MainForm form )
            : base(form)
        {
        }
        #endregion

        #region Private Methods

        private void ConnectDevice(string portName, int baudRate, int dataBits, int readTimeout, int writeTimeout)
        {
            try
            {
                //Open communication port 
                this.mainForm.port = this.mainForm.objclsSMS.OpenPort(portName, baudRate, dataBits, readTimeout, writeTimeout);

                if (this.mainForm.port != null)
                {
                    //this.gboPortSettings.Enabled = false;

                    //MessageBox.Show("Modem is connected at PORT " + this.cboPortName.Text);
                    this.mainForm.sttBarStatusDevice.Text = "Modem đã kết nối với cổng " + portName;

                    //Add tab pages
                    //this.tabSMSapplication.TabPages.Add(tbSendSMS);
                    //this.tabSMSapplication.TabPages.Add(tbReadSMS);
                    //this.tabSMSapplication.TabPages.Add(tbDeleteSMS);

                    this.CauHinhView.SetStatusLabel("Đã kết nối tại " + portName);
                    this.CauHinhView.EnableButtonDisconnect(true);
                }

                else
                {
                    //MessageBox.Show("Invalid port settings");
                    this.mainForm.sttBarStatusDevice.Text = "Cài đặt thông số port không hợp lệ";
                }
            }
            catch (Exception ex)
            {
                this.mainForm.ErrorLog(ex.Message);
            }
        }

        private void DisconnectDevice()
        {
            try
            {
                //this.gboPortSettings.Enabled = true;
                this.mainForm.objclsSMS.ClosePort(this.mainForm.port);

                ////Remove tab pages
                //this.tabSMSapplication.TabPages.Remove(tbSendSMS);
                //this.tabSMSapplication.TabPages.Remove(tbReadSMS);
                //this.tabSMSapplication.TabPages.Remove(tbDeleteSMS);

                this.CauHinhView.SetStatusLabel("Không có kết nối!");
                this.CauHinhView.EnableButtonDisconnect(false);
                this.mainForm.sttBarStatusDevice.Text = "Không có kết nối!";
            }
            catch (Exception ex)
            {
                this.mainForm.ErrorLog(ex.Message);
            }
        }

        #endregion

        #region Protected Methods
        protected override void Initial ()
        {
            base.Initial();
        }
        protected override void CreateSubMenuItems ()
        {
            base.CreateSubMenuItems();
            this.mainForm.AddSubMenuItem(UIHelper.CreateMenuItem(Properties.Resources.CauHinh, "Cấu hình"));
            this.mainForm.AddSubMenuItem(UIHelper.CreateMenuItem(Properties.Resources.DanhBa, "Hiển thị danh bạ"));
            this.mainForm.AddSubMenuItem(UIHelper.CreateMenuItem(Properties.Resources.ThietBi, "Xem nhanh thiết bị kết nối"));
            this.mainForm.AddSubMenuItem(UIHelper.CreateMenuItem(Properties.Resources.LichGuiTin, "Xem lịch gửi tin"));
            this.mainForm.SubMenu_ItemClick = SubMenu_ItemClick;
            if (subMenuIndex == -1)//Lan dau tien load sub menu
                SubMenu_ItemClick(CAU_HINH);//view mac dinh
            else
                SubMenu_ItemClick(subMenuIndex);//Luu lai trang thai cu cua sub menu
        }
        #endregion

        #region Public Methods
        public override void Active ()
        {
            base.Active();
        }

        #endregion

        #region Events
        private void SubMenu_ItemClick (int index)
        {
            this.subMenuIndex = index;
            switch ( index )
            {
                case CAU_HINH:
                    this.mainForm.DisplayView(CauHinhView);
                    break;
                case DANH_BA:
                    this.mainForm.DisplayView(DanhBaView);
                    break;
                case THIET_BI:
                    this.mainForm.DisplayView(ThietBiView);
                    break;
                case LICH_GUI_TIN:
                    this.mainForm.DisplayView(LichGuiTinView);
                    break;
                default:
                    break;
            }
        }
        private void Logout ()
        {
        }
        private void EndPatientSession ()
        {
        }

        #region Registration
        private void RegistrationStepCompleted ( int currentStep )
        {
            //if ( currentStep < 9 )
            //{
            //    DisplayRegistrationStep(currentStep + 1);
            //}

            //if (currentStep == 9)
            //{
            //    if (System.Windows.Forms.MessageBox.Show("Save Patient Registration ...???", "Question", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            //    {
            //        _service.SavePatientRegistrationInfo(FrontPresenter.LoginUser.ProviderId, FrontPresenter.LoginUser.OfficeId, CurrentPatient);
            //        DisplayRegistrationStep(currentStep + 1);
            //    }
            //    else
            //    {                    
            //        SubMenu_ItemClick(PATIENT_CHECK_IN);
            //    }
            //    CurrentPatient = null;
            //}
        }
        private void BackToPreviousRegistrationStep ( int currentStep )
        {
            if ( currentStep > 1 )
            {
                //DisplayRegistrationStep(currentStep - 1);
            }
        }
        #endregion

        #region CheckInView
        //private void InsertPatient(string FirstName, string LastName, DateTime Birthday, string PhoneNumber)
        //{
        //    this._checkInView.PatientCurrentCheckIn= this._service.InsertPatient(FrontPresenter.LoginUser.ProviderId, FirstName, LastName, Birthday, PhoneNumber);
        //}
        //private void InsertPatientIntoQueue(int PatientId, bool IsExam, bool IsEyewear, bool IsContact, bool IsFitting, bool IsOther, int PhysicianId, string Reason, bool Appointment, bool NewPatient)
        //{
        //    this._service.InsertPatientIntoQueue(FrontPresenter.LoginUser.OfficeId , FrontPresenter.LoginUser.ProviderId, PatientId, IsExam, IsEyewear, IsContact, IsFitting, IsOther, PhysicianId, Reason, FrontPresenter.LoginUser.Id, Appointment, NewPatient);
        //    TodayPatientView.PatientWaiting = _service.GetTodayPatientWaitingList(FrontPresenter.LoginUser.OfficeId);

        //    this._checkInView.ResetUserControl();
        //    this._checkInView.IsNewPatientCheckIn(true);
        //    this._checkInView.PatientCurrentCheckIn = 0;
        //    SubMenu_ItemClick(TODAY_PATIENT);
        //}

        //private void NewPatient()
        //{
        //    this._checkInView.PatientCurrentCheckIn=0;
        //    this._checkInView.ResetUserControl();
        //    this._checkInView.IsNewPatientCheckIn(true);
        //}
        //private void SearchPatient()
        //{
        //    this._checkInView.PatientCurrentCheckIn = 0;
        //    this._checkInView.ResetUserControl();
        //    this._checkInView.IsNewPatientCheckIn(true);
        //    if (this._checkInView.PatientCurrentCheckIn != 0)
        //        this._checkInView.IsNewPatientCheckIn(false);
        //    SubMenu_ItemClick(SEARCH_PATIENT);
        //}
        //private void IsExitsPatientInPatientQueueCurrentDate(int patientId)
        //{
        //    this._checkInView.isExitsPatientInPatientQueue = _service.IsExitsPatientInPatientQueueCurrentDate(patientId);
        //}

        #region Search For Exits patient
        //private void SearchExistedPatient(string firstname, string lastname,DateTime dob)
        //{
        //    this._selectPatient.LoadListPatient(_service.GetListPatientSearch(FrontPresenter.LoginUser.ProviderId, firstname, lastname, dob));
        //}
        //private void SelectPatient(Patient patient)
        //{
        //    if (patient != null)
        //    {
        //        this._checkInView.PatientCurrentCheckIn = patient.Id;
        //        this._checkInView.FirstName = patient.FirstName;
        //        this._checkInView.LastName = patient.LastName;
        //        this._checkInView.PhoneNumber = patient.Phone;
        //        this._checkInView.Birthday = patient.Birthday;
        //    }

        //    this._selectPatient.Close();
        //}
        #endregion
        #endregion

        #region Today's Patient
        //private void UpdatePatientStatusToInProgress(int Patient, bool isInProgress)
        //{
        //    this._service.UpdatePatientStatusToInProgress(FrontPresenter.LoginUser.OfficeId, Patient, isInProgress);
        //    TodayPatientView.PatientWaiting = _service.GetTodayPatientWaitingList(FrontPresenter.LoginUser.OfficeId);
        //    TodayPatientView.PatientProgress = _service.GetTodayPatientProgressList(FrontPresenter.LoginUser.OfficeId);            
        //}
        //private void RedirectPatientRegistration(Patient patient)
        //{
        //    CurrentPatient = patient;
        //    SubMenu_ItemClick(PATIENT_REGISTRATION);
        //}
        //private void UpdatePatientStatusToComplete(int Patient, bool isReInProgress)
        //{
        //    this._service.UpdatePatientStatusToComplete(FrontPresenter.LoginUser.OfficeId, Patient,isReInProgress);
        //    TodayPatientView.PatientProgress = _service.GetTodayPatientProgressList(FrontPresenter.LoginUser.OfficeId);
        //    TodayPatientView.PatientCompleted = _service.GetTodayPatientCompletedList(FrontPresenter.LoginUser.OfficeId);
        //}

        #endregion
        

        #region SelectPatientView
        //private void GetListPatientSearchView(string firstname, string lastname, DateTime? DateRegisterFrom, DateTime? DateRegisterTo)
        //{
        //    this._searchPatientView.LoadListPatient(_service.GetListPatientSearch(FrontPresenter.LoginUser.ProviderId, firstname, lastname, DateRegisterFrom, DateRegisterTo));
        //}

        //private void GetPatientSearchView(Patient patient)
        //{
        //    if (patient != null)
        //    {
        //        if (this._checkInView != null)
        //        {
        //            this._checkInView.PatientCurrentCheckIn = patient.Id;
        //            this._checkInView.FirstName = patient.FirstName;
        //            this._checkInView.LastName = patient.LastName;
        //            this._checkInView.PhoneNumber = patient.Phone;
        //            this._checkInView.Birthday = patient.Birthday;
        //            this._checkInView.IsNewPatientCheckIn(false);
        //            SubMenu_ItemClick(PATIENT_CHECK_IN);
        //        }
        //    }
        //}
        #endregion

        #endregion
    }
}
