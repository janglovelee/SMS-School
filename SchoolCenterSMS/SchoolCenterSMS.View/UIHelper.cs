using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolCenterSMS.View
{
    public class UIHelper
    {
        public static string DateTimeFormatingStyle = "d";
        public static string TimeFormatingStyle = "hh:mm tt";

        #region Public Static Methods
        public static void FormatColumnDatetimeGrid(DataGridViewCellFormattingEventArgs e, string FormatDataTime)
        {
            DateTime ss;
            if (DateTime.TryParse(Convert.ToString(e.Value), out ss))
            {
                e.Value = ss;
                e.CellStyle.Format = FormatDataTime;
            }
        }
        public static ToolStripButton CreateMenuItem(Image image, string tooltipText)
        {
            ToolStripButton tlsButton = new ToolStripButton();
            tlsButton.AutoSize = false;
            tlsButton.Width = 90;
            tlsButton.Height = 79;
            tlsButton.BackgroundImage = image;
            tlsButton.BackgroundImageLayout = ImageLayout.Stretch;
            tlsButton.ToolTipText = tooltipText;
            return tlsButton;
        }
        public static ToolStripButton CreateMenuItemMini(Image image, string tooltipText)
        {
            ToolStripButton tlsButton = new ToolStripButton();
            tlsButton.AutoSize = false;
            tlsButton.Width = 102;
            tlsButton.Height = 65;
            tlsButton.BackgroundImage = image;
            tlsButton.BackgroundImageLayout = ImageLayout.Stretch;
            tlsButton.ToolTipText = tooltipText;
            return tlsButton;
        }
        public static void SelectMenuItem(ToolStrip menu, int index)
        {
            int cnt = 0;
            foreach (ToolStripItem tlsItem in menu.Items)
            {
                if (tlsItem is ToolStripButton)
                {
                    ToolStripButton tlsButton = (ToolStripButton)tlsItem;
                    tlsButton.Checked = (cnt == index);
                }
                cnt++;
            }
        }
        public static void DataGridViewCellFormatting(System.Windows.Forms.DataGridView grid, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if ((grid.Rows[e.RowIndex].DataBoundItem != null) && (grid.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(grid.Rows[e.RowIndex].DataBoundItem, grid.Columns[e.ColumnIndex].DataPropertyName);
            }
        }
        public static DateTime? IsDateTime(string value)
        {
            try
            {
                return DateTime.Parse(value);
            }
            catch (FormatException)
            {
                return null;
            }
        }
        public static void ValidateTextBoxReScription(System.Windows.Forms.TextBox txt, float min, float max, System.Windows.Forms.Label lb, string Error)
        {
            if (txt.Text.Trim().Length > 0)
            {
                txt.BackColor = System.Drawing.Color.White;
                float RSphere = 0;
                bool ValiRS = float.TryParse(txt.Text, out RSphere);
                if (ValiRS && RSphere >= min && RSphere <= max)
                {
                    lb.Text = ""; lb.Visible = false;
                    if (RSphere > 0)
                    {
                        txt.Text = "+" + RemoveSigns(txt.Text).ToString("0.00");
                    }
                    else
                    {
                        txt.Text = RemoveSigns(txt.Text).ToString("0.00");
                    }
                }
                else
                {
                    lb.Text = Error; lb.Visible = true;
                    txt.Text = "";
                    txt.BackColor = System.Drawing.Color.Yellow;
                    txt.Focus();
                }
            }
        }
        public static void ValidatePD_height(System.Windows.Forms.TextBox txt)
        {
            if (txt.Text.Length > 0)
            {
                try
                {
                    string PD = RemoveSigns(txt.Text).ToString();
                    if (PD.Substring(PD.Length - 3) == ".00")
                    {
                        PD = PD.Substring(0, PD.Length - 3);
                    }
                    int RPD = int.Parse(PD);
                    txt.Text = RPD.ToString("0");
                }
                catch
                {
                    txt.Text = "";

                }
            }
        }
        public static decimal RemoveSigns(string valInfo)
        {
            if (valInfo.Contains('+'))
            {
                valInfo = valInfo.Remove(0, 1);
            }
            return Convert.ToDecimal(valInfo);
        }
        public static void IsDigit(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '+' && e.KeyChar != '-')
                e.Handled = true;
        }
        #endregion

        #region Private Static Methods
        private static string BindProperty(object property, string propertyName)
        {
            string retValue = "";

            if (propertyName.Contains("."))
            {
                PropertyInfo[] properties;
                string leftPropertyName;

                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                properties = property.GetType().GetProperties();

                foreach (PropertyInfo propertyInfo in properties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = BindProperty(propertyInfo.GetValue(property, null), propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;

                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);

                if (propertyInfo != null)
                    retValue = propertyInfo.GetValue(property, null).ToString();
            }

            return retValue;
        }

        #endregion
    }
}
