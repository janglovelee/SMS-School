using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolCenterSMS.View.Classes;
using SchoolCenterSMS.View.Views;
using System.IO;

namespace SchoolCenterSMS.View.Forms
{
    public partial class MainForm : Form
    {
        #region Delegate Events
        public delegate void MainMenuItemClickHandler(int index);
        public MainMenuItemClickHandler MainMenu_ItemClick;

        public delegate void SubMenuItemClickHandler(int index);
        public SubMenuItemClickHandler SubMenu_ItemClick;

        public delegate void LoadLoginFormHandler();
        public LoadLoginFormHandler LoadLoginForm;

        public delegate void MenuLoginClickHandler();
        public MenuLoginClickHandler MenuLogin_Click;

        public delegate void MenuLogoutClickHandler();
        public MenuLogoutClickHandler MenuLogout_Click;

        public delegate void ChangeCurrentPatientHandler();
        public ChangeCurrentPatientHandler ChangeCurrentPatient;

        public delegate void ChangeConnectDeviveHandle();
        public ChangeConnectDeviveHandle ChangeConnectDevice;
        #endregion

        #region Constants
        #endregion

        #region Enums
        #endregion

        #region Fields
        private Image _background;
        #endregion

        #region Properties
        public BaseView BaseViewCurrent { get; set; }
        #endregion

        #region Constructors
        public MainForm()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
            Initial();
        }
        public MainForm(Image background)
            : this()
        {
            this._background = background;
            this.BackgroundImageLayout = ImageLayout.None;
        }
        #endregion

        #region Private Methods
        private void Initial()
        {
            this.tlsSubMenu.Visible = false;
            pnlColor.Visible = false;
            foreach (ToolStripItem tsi in this.tlsMainMenu.Items)
            {
                tsi.Click += new EventHandler(tlsMainMenu_ItemClicked);
            }
        }

        #region Write StatusBar
        private void WriteStatusBar(string status)
        {
            try
            {
                sttBarStatusDevice.Text = "Message: " + status;
            }
            catch (Exception ex)
            {

            }
        }
        #endregion
        #endregion

        #region Private Variables
        public SerialPort port = new SerialPort();
        public clsSMS objclsSMS = new clsSMS();
        public ShortMessageCollection objShortMessageCollection = new ShortMessageCollection();
        #endregion

        #region Protected Methods
        #endregion

        #region Public Methods
        public void ResetSubMenu()
        {
            if (this.tlsSubMenu.Items.Count > 0)
            {
                this.tlsSubMenu.Items.Clear();
            }
        }

        public void AddSubMenuItem(ToolStripItem item)
        {
            this.tlsSubMenu.AutoSize = false;
            this.tlsSubMenu.Width = 106;
            this.tlsSubMenu.Items.Add(item);
            item.Click += new EventHandler(tlsSubMenu_ItemClicked);
        }

        public void DisplayView(BaseView view)
        {
            if (view != null && BaseViewCurrent != view)
            {
                //Turn off camera for Frame Styling
                this.pnlContent.Controls.Remove(BaseViewCurrent);
                this.pnlContent.Controls.Add(view);
                view.Dock = DockStyle.Fill;
                BaseViewCurrent = view;
            }
        }

        public void IsEnableMainMenu(bool isEnable)
        {
            foreach (ToolStripItem item in tlsMainMenu.Items)
            {
                if (item is ToolStripButton)
                    item.Enabled = isEnable;
            }
        }

        public void IsEnableSubMenu(bool isEnable)
        {
            foreach (ToolStripItem item in tlsSubMenu.Items)
            {
                if (item is ToolStripButton)
                    item.Enabled = isEnable;
            }
        }
        #endregion

        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (LoadLoginForm != null)
                LoadLoginForm();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void tlsExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tlsMainMenu_ItemClicked(object sender, EventArgs e)
        {
            tlsSubMenu.Visible = true;
            pnlColor.Visible = true;
            if (MainMenu_ItemClick != null)
            {
                ToolStripItem item = (ToolStripItem)sender;

                if (item is ToolStripButton)
                {
                    int index = tlsMainMenu.Items.IndexOf(item);
                    MainMenu_ItemClick(index);
                    UIHelper.SelectMenuItem(tlsMainMenu, index);
                }
            }
        }
        private void tlsSubMenu_ItemClicked(object sender, EventArgs e)
        {
            if (SubMenu_ItemClick != null)
            {
                ToolStripItem item = (ToolStripItem)sender;

                int index = tlsSubMenu.Items.IndexOf(item);
                SubMenu_ItemClick(index);
                UIHelper.SelectMenuItem(tlsSubMenu, index);
            }
        }
        private void tlsLoginMenuItem_Click(object sender, EventArgs e)
        {
            if (MenuLogin_Click != null)
            {
                MenuLogin_Click();
            }
        }
        private void tlsLogOutMenuItem_Click(object sender, EventArgs e)
        {
            if (MenuLogout_Click != null)
            {
                MenuLogout_Click();
            }
        }
        private void tsbChangePatient_Click(object sender, EventArgs e)
        {
            if (ChangeCurrentPatient != null)
            {
                ChangeCurrentPatient();
            }
        }
        #endregion

        #region Error Log
        public void ErrorLog(string Message)
        {
            StreamWriter sw = null;

            try
            {
                WriteStatusBar(Message);

                string sLogFormat = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + " ==> ";
                //string sPathName = @"E:\";
                string sPathName = @"SMSapplicationErrorLog_";

                string sYear = DateTime.Now.Year.ToString();
                string sMonth = DateTime.Now.Month.ToString();
                string sDay = DateTime.Now.Day.ToString();

                string sErrorTime = sDay + "-" + sMonth + "-" + sYear;

                sw = new StreamWriter(sPathName + sErrorTime + ".txt", true);

                sw.WriteLine(sLogFormat + Message);
                sw.Flush();

            }
            catch (Exception ex)
            {
                //ErrorLog(ex.ToString());
            }
            finally
            {
                if (sw != null)
                {
                    sw.Dispose();
                    sw.Close();
                }
            }

        }
        #endregion 
    }
}
