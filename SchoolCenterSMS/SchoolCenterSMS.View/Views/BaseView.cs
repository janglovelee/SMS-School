using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolCenterSMS.View.Views
{
    public partial class BaseView : UserControl
    {
        public BaseView()
        {
            InitializeComponent();
        }

        protected void ControlChangeValue(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            if (control is TextBox || control is ComboBox)
                control.BackColor = Color.White;
            else if (control is DateTimePicker)
                control.BackColor = Color.White;
        }
        protected bool IsBirthday(DateTimePicker control)
        {
            if (control.Value.Date >= DateTime.Today)
            {
                control.BackColor = Color.Red;
                control.Invalidate();
                return false;
            }

            return true;
        }
        protected bool IsEmpty(Control control)
        {
            bool valid = false;

            if (control is TextBox)
            {
                control.Text = control.Text.Trim();
                valid &= (control.Text.Length > 0);
            }
            else if (control is ComboBox)
            {
                valid &= (control.Text.Length > 0);
            }
            return !valid;
        }
    }
}
