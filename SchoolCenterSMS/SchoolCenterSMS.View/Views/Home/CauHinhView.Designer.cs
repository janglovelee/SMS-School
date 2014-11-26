namespace SchoolCenterSMS.View.Views.Home
{
    partial class CauHinhView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtWriteTimeout = new System.Windows.Forms.TextBox();
            this.txtReadTimeout = new System.Windows.Forms.TextBox();
            this.cboParityBits = new System.Windows.Forms.ComboBox();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.cboDataBits = new System.Windows.Forms.ComboBox();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.cboPortName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(314, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cấu Hình";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtWriteTimeout);
            this.groupBox1.Controls.Add(this.txtReadTimeout);
            this.groupBox1.Controls.Add(this.cboParityBits);
            this.groupBox1.Controls.Add(this.cboStopBits);
            this.groupBox1.Controls.Add(this.cboDataBits);
            this.groupBox1.Controls.Add(this.cboBaudRate);
            this.groupBox1.Controls.Add(this.cboPortName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 255);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port Settings";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(375, 216);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(90, 30);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtWriteTimeout
            // 
            this.txtWriteTimeout.Location = new System.Drawing.Point(357, 181);
            this.txtWriteTimeout.Name = "txtWriteTimeout";
            this.txtWriteTimeout.Size = new System.Drawing.Size(147, 20);
            this.txtWriteTimeout.TabIndex = 2;
            this.txtWriteTimeout.Text = "300";
            // 
            // txtReadTimeout
            // 
            this.txtReadTimeout.Location = new System.Drawing.Point(357, 155);
            this.txtReadTimeout.Name = "txtReadTimeout";
            this.txtReadTimeout.Size = new System.Drawing.Size(147, 20);
            this.txtReadTimeout.TabIndex = 2;
            this.txtReadTimeout.Text = "300";
            // 
            // cboParityBits
            // 
            this.cboParityBits.FormattingEnabled = true;
            this.cboParityBits.Items.AddRange(new object[] {
            "Even",
            "Odd",
            "None"});
            this.cboParityBits.Location = new System.Drawing.Point(357, 129);
            this.cboParityBits.Name = "cboParityBits";
            this.cboParityBits.Size = new System.Drawing.Size(147, 21);
            this.cboParityBits.TabIndex = 1;
            this.cboParityBits.Text = "None";
            // 
            // cboStopBits
            // 
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cboStopBits.Location = new System.Drawing.Point(357, 103);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(147, 21);
            this.cboStopBits.TabIndex = 1;
            this.cboStopBits.Text = "1";
            // 
            // cboDataBits
            // 
            this.cboDataBits.FormattingEnabled = true;
            this.cboDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cboDataBits.Location = new System.Drawing.Point(357, 77);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Size = new System.Drawing.Size(147, 21);
            this.cboDataBits.TabIndex = 1;
            this.cboDataBits.Text = "8";
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Items.AddRange(new object[] {
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.cboBaudRate.Location = new System.Drawing.Point(357, 51);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(147, 21);
            this.cboBaudRate.TabIndex = 1;
            this.cboBaudRate.Text = "9600";
            // 
            // cboPortName
            // 
            this.cboPortName.FormattingEnabled = true;
            this.cboPortName.Location = new System.Drawing.Point(357, 25);
            this.cboPortName.Name = "cboPortName";
            this.cboPortName.Size = new System.Drawing.Size(147, 21);
            this.cboPortName.TabIndex = 1;
            this.cboPortName.Text = "COM1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Write Timeout";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Read Timeout";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Parity Bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Stop Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data Bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.btnDisconnect);
            this.groupBox2.Location = new System.Drawing.Point(12, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(781, 123);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connected Status";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblStatus.Location = new System.Drawing.Point(17, 49);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(66, 24);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(670, 46);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(90, 30);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // CauHinhView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "CauHinhView";
            this.Size = new System.Drawing.Size(810, 460);
            this.Load += new System.EventHandler(this.CauHinhView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWriteTimeout;
        private System.Windows.Forms.TextBox txtReadTimeout;
        private System.Windows.Forms.ComboBox cboParityBits;
        private System.Windows.Forms.ComboBox cboStopBits;
        private System.Windows.Forms.ComboBox cboDataBits;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.ComboBox cboPortName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lblStatus;
    }
}
