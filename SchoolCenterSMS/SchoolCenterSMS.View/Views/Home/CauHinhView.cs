using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using SchoolCenterSMS.View.Forms;

namespace SchoolCenterSMS.View.Views.Home
{
    public partial class CauHinhView : BaseView
    {
        public CauHinhView()
        {
            InitializeComponent();
        }

        public delegate void ConnectDeviceHandle(string portName, int baudRate, int dataBits,int readTimeout,int writeTimeout);
        public ConnectDeviceHandle ConnectDevice;

        public delegate void DisconnectDeviceHandle();
        public DisconnectDeviceHandle DisconnectDevice;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectDevice(this.cboPortName.Text, Convert.ToInt32(this.cboBaudRate.Text), Convert.ToInt32(this.cboDataBits.Text), Convert.ToInt32(this.txtReadTimeout.Text), Convert.ToInt32(this.txtWriteTimeout.Text));
        }

        public void SetStatusLabel(string status)
        {
            lblStatus.Text = status;
        }

        public void EnableButtonDisconnect(bool value)
        {
            btnDisconnect.Enabled = value;
            btnConnect.Enabled = !value;
        }

        private void CauHinhView_Load(object sender, EventArgs e)
        {
            try
            {
                #region Display all available COM Ports
                string[] ports = SerialPort.GetPortNames();

                // Add all port names to the combo box:
                foreach (string port in ports)
                {
                    this.cboPortName.Items.Add(port);
                }
                if (this.cboPortName.Items.Count > 0)
                    this.cboPortName.SelectedIndex = 0;
                #endregion

                //Remove tab pages

                this.btnDisconnect.Enabled = false;
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DisconnectDevice();
        }
    }
}
