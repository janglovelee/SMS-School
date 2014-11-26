using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolCenterSMS.View.Forms;
using SchoolCenterSMS.View.Views.Welcome;

namespace SchoolCenterSMS.Presenter
{
    class FrontPresenter
    {
        #region Constants
        public const int WELCOME_INDEX = 0;
        public const int HOME_INDEX = 1;
        public const int CONGCU_INDEX = 2;
        public const int TINNHAN_INDEX = 3;
        public const int HOTRO_INDEX = 4;
        public const int CLAIM_INFO_INDEX = 5;
        public const int FRAME_STYLING_INDEX = 6;
        public const int VIRTUAL_TRYON_INDEX = 7;
        public const int VISION_TEST_INDEX = 8;
        public const int CONTACT_LENS_INDEX = 9;
        public const int CONFIGURATION_INDEX = 10;
        #endregion

        #region Enums
        #endregion

        #region Fields
        private MainForm _mainForm;

        public static int _currentPresenterIndex = -1;
        private int _loginCount = 0;
        private Welcome _welcomeView;

        private HomePresenter _homePresenter;
        private CongCuPresenter _congCuPresenter;
        private TinNhanPresenter _tinNhanPresenter;
        private HoTroPresenter _hoTroPresenter;
        //private ClaimInfoPresenter _claimInfoPresenter;
        //private FrameStylingPresenter _frameStylingPresenter;
        //private VirtualTryOnPresenter _virtualTryOnPresenter;
        //private VisionTestPresenter _visionTestPresenter;
        //private ContactLensPresenter _contactLensPresenter;
        //private ConfigurationPresenter _configurationPresenter;

        #endregion

        #region Properties
        public MainForm MainForm
        {
            get
            {
                if (this._mainForm == null)
                {
                    this._mainForm = new MainForm();
                    this._mainForm.MainMenu_ItemClick += MainMenu_ItemClick;
                    //this._mainForm.LoadLoginForm += LoadLoginForm;
                    //this._mainForm.MenuLogin_Click += MenuLogin_Click;
                    //this._mainForm.MenuLogout_Click += MenuLogout_Click;
                    this._mainForm.ChangeCurrentPatient += ChangeCurrentPatient;
                    MainMenu_ItemClick(WELCOME_INDEX);
                }
                return this._mainForm;
            }
        }

        public Welcome WelcomeView
        {
            get
            {
                if (_welcomeView == null)
                {
                    _welcomeView = new Welcome();
                }
                //_welcomeView.Width = this._mainForm.Width;
                //_welcomeView.Height =  this._mainForm.tlsSubMenu.Height;
                return _welcomeView;
            }
        }

        public HomePresenter HomePresenter
        {
            get
            {
                if (_homePresenter == null)
                {
                    this._homePresenter = new HomePresenter(MainForm);
                }
                return this._homePresenter;
            }
        }

        public CongCuPresenter CongCuPresenter
        {
            get
            {
                if (_congCuPresenter == null)
                {
                    this._congCuPresenter = new CongCuPresenter(MainForm);
                }
                return this._congCuPresenter;
            }
        }
        public TinNhanPresenter TinNhanPresenter
        {
            get
            {
                if (_tinNhanPresenter == null)
                {
                    _tinNhanPresenter = new TinNhanPresenter(MainForm);
                }
                return _tinNhanPresenter;
            }
        }
        public HoTroPresenter HoTroPresenter
        {
            get
            {
                if (_hoTroPresenter == null)
                {
                    _hoTroPresenter = new HoTroPresenter(MainForm);
                }
                return _hoTroPresenter;
            }
        }
        //public VirtualTryOnPresenter VirtualTryOnPresenter
        //{
        //    get
        //    {
        //        if (_virtualTryOnPresenter == null)
        //        {
        //            _virtualTryOnPresenter = new VirtualTryOnPresenter(MainForm);
        //            _virtualTryOnPresenter.frontPresenter = this;
        //        }
        //        return _virtualTryOnPresenter;
        //    }
        //}

        //public OrderInfoPresenter OrderInfoPresenter
        //{
        //    get
        //    {
        //        if (_orderInfoPresenter == null)
        //        {
        //            _orderInfoPresenter = new OrderInfoPresenter(MainForm);
        //        }
        //        return _orderInfoPresenter;
        //    }
        //}

        #endregion

        #region Constructors
        public FrontPresenter()
        {
            //this._userService = new UserService();
        }
        #endregion

        #region Private Methods
        #endregion

        #region Protected Methods
        #endregion

        #region Public Methods



        #endregion

        #region Events
        //private void Login(string username, string password)
        //{
        //    if (this._loginForm.IsNullTextBox()) return;

        //    User loginUser = this._userService.Authenticate(username, password);

        //    if (loginUser != null) // login successful
        //    {
        //        FrontPresenter.LoginUser = loginUser;
        //        this.LoginForm.Close();
        //        this._mainForm.IsEnableMainMenu(true);
        //        this._loginCount++;
        //    }
        //    else // login fail
        //    {
        //        this._loginForm.DisplayMessage("Login fail", 0);
        //        this._loginForm.Username = "";
        //        this._loginForm.Password = "";

        //        FrontPresenter.LoginUser = null;
        //    }
        //}
        //private void CancelLogin()
        //{
        //    if (this._loginCount > 0)
        //    {
        //        Logout();
        //    }
        //    else
        //    {
        //        Application.Exit();
        //    }
        //}
        //private void Logout()
        //{
        //    FrontPresenter.LoginUser = null;
        //    this._mainForm.ResetSubMenu();
        //    MainMenu_ItemClick(WELCOME_INDEX);
        //    this._mainForm.IsEnableMainMenu(false);
        //}
        //private void MenuLogin_Click()
        //{
        //    this.LoginForm.ShowDialog();
        //}
        //private void MenuLogout_Click()
        //{
        //    if (MessageBox.Show("User Log out ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //        Logout();
        //}

        
        public void MainMenu_ItemClick(int index)
        {
            if (FrontPresenter._currentPresenterIndex == index)
                return;
            FrontPresenter._currentPresenterIndex = index;

            switch (index)
            {
                case HOME_INDEX:
                    if (this._homePresenter == null)
                    {
                        this._homePresenter = new HomePresenter(MainForm);
                    }
                    this._homePresenter.Active();
                    break;
                case CONGCU_INDEX:
                    this._congCuPresenter = CongCuPresenter;
                    this._congCuPresenter.Active();
                    break;
                case TINNHAN_INDEX:
                    this._tinNhanPresenter = TinNhanPresenter;
                    this._tinNhanPresenter.Active();
                    break;
                case HOTRO_INDEX:
                    this._hoTroPresenter = HoTroPresenter;
                    this._hoTroPresenter.Active();
                    break;
                //case CLAIM_INFO_INDEX:
                //    if (this._claimInfoPresenter == null)
                //    {
                //        this._claimInfoPresenter = new ClaimInfoPresenter(MainForm);
                //    }
                //    TurnOffAllCamera();
                //    this._claimInfoPresenter.Active();
                //    break;
                //case FRAME_STYLING_INDEX:
                //    this._frameStylingPresenter = FrameStylingPresenter;
                //    TurnOffAllCamera();
                //    if (_frameStylingPresenter != null && _frameStylingPresenter._frameCompareView != null)
                //    {
                //        if (_frameStylingPresenter._frameCompareView.CameraIsRunning == false)
                //        {
                //            _frameStylingPresenter._frameCompareView.InitCamera();
                //        }
                //    }
                //    this._frameStylingPresenter.flag = true;
                //    this._frameStylingPresenter.Active();
                //    break;
                //case VIRTUAL_TRYON_INDEX:
                //    this._virtualTryOnPresenter = VirtualTryOnPresenter;
                //    TurnOffAllCamera();
                //    if (_virtualTryOnPresenter != null && _virtualTryOnPresenter._takePictureView != null)
                //    {
                //        if (_virtualTryOnPresenter._takePictureView.CameraIsRunning == false)
                //        {
                //            _virtualTryOnPresenter._takePictureView.InitCamera();
                //        }
                //    }
                //    this._virtualTryOnPresenter.flag = true;
                //    this._virtualTryOnPresenter.Active();
                //    break;
                //case VISION_TEST_INDEX:
                //    if (this._visionTestPresenter == null)
                //    {
                //        this._visionTestPresenter = new VisionTestPresenter(MainForm);
                //    }
                //    TurnOffAllCamera();
                //    this._visionTestPresenter.Active();
                //    break;
                //case CONTACT_LENS_INDEX:
                //    if (this._contactLensPresenter == null)
                //    {
                //        this._contactLensPresenter = new ContactLensPresenter(MainForm);
                //    }
                //    TurnOffAllCamera();
                //    this._contactLensPresenter.Active();
                //    break;
                case CONFIGURATION_INDEX:
                    //if ( this._configurationPresenter == null )
                    //{
                    //    this._configurationPresenter = new ConfigurationPresenter(MainForm);
                    //}
                    //TurnOffAllCamera();
                    //this._configurationPresenter.Active();
                    OpenWebsite("http://97.74.205.163:8008/");
                    break;
                case WELCOME_INDEX:
                    this._mainForm.DisplayView(WelcomeView);
                    break;
                default:
                    this._mainForm.DisplayView(WelcomeView);
                    break;
            }
        }
        private void ChangeCurrentPatient()
        {
            //if (this._selectPatientdialog == null)
            //{
            //    _selectPatientdialog = new SelectPatientDialog();
            //    _selectPatientdialog.SelectionPatient += SelectPatient;
            //    _selectPatientdialog.SearchPatient += SearchPatient;
            //}
            //_selectPatientdialog.ShowDialog();
        }

        //private void _loginForm_FormClosing(object sender, FormClosingEventArgs e)
        //{
            //if (FrontPresenter.LoginUser == null)
            //{
            //    Logout();
            //}
        //}
        //private void LoadLoginForm()
        //{
        //    LoginForm.ShowDialog();
        //}
        //private void SelectPatient(int patientId)
        //{
        //    Patient patient = (new PatientInfoService()).FindPatientById(patientId);
        //    this._currentPatient = patient;
        //    if (_measurementPresenter == null)
        //    {
        //        _measurementPresenter = MeasurementPresenter;
        //    }
        //    if (_frameStylingPresenter == null)
        //    {
        //        _frameStylingPresenter = FrameStylingPresenter;
        //    }
        //    if (_virtualTryOnPresenter == null)
        //    {
        //        _virtualTryOnPresenter = VirtualTryOnPresenter;
        //    }
        //    _measurementPresenter.Patient = patient;
        //    _frameStylingPresenter.Patient = patient;
        //    _virtualTryOnPresenter.Patient = patient;
        //    this._mainForm.DisplayCurrentPatientInfo(patient);
        //    this._selectPatientdialog.Close();
        //}
        //private void SearchPatient(string patientId, string PatientName)
        //{
        //    IList<Patient> patients = (new PatientInfoService()).SearchPatient(FrontPresenter.LoginUser.ProviderId, patientId, PatientName);
        //    _selectPatientdialog.DisplayPatients(patients);
        //}
        private void OpenWebsite(string url)
        {
            System.Diagnostics.Process.Start(GetDefaultBrowserPath(), url);
        }

        private string GetDefaultBrowserPath()
        {
            string key = @"http\shell\open\command";
            Microsoft.Win32.RegistryKey registryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(key, false);
            return ((string)registryKey.GetValue(null, null)).Split('"')[1];
        }
        #endregion
    }
}
