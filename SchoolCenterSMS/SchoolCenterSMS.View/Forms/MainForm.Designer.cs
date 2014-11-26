namespace SchoolCenterSMS.View.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tlsMainMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbHome = new System.Windows.Forms.ToolStripButton();
            this.tsbCongCu = new System.Windows.Forms.ToolStripButton();
            this.tsbTinNhan = new System.Windows.Forms.ToolStripButton();
            this.tsbHoTro = new System.Windows.Forms.ToolStripButton();
            this.tsbDuTru = new System.Windows.Forms.ToolStripButton();
            this.tlsSubMenu = new System.Windows.Forms.ToolStrip();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.sttBarStatusDevice = new System.Windows.Forms.StatusBar();
            this.tlsMainMenu.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsMainMenu
            // 
            this.tlsMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.tlsMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlsMainMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsbHome,
            this.tsbCongCu,
            this.tsbTinNhan,
            this.tsbHoTro,
            this.tsbDuTru});
            this.tlsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsMainMenu.Name = "tlsMainMenu";
            this.tlsMainMenu.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.tlsMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tlsMainMenu.Size = new System.Drawing.Size(884, 102);
            this.tlsMainMenu.TabIndex = 12;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(10, 70);
            this.toolStripLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // tsbHome
            // 
            this.tsbHome.AutoSize = false;
            this.tsbHome.BackColor = System.Drawing.Color.Transparent;
            this.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHome.ForeColor = System.Drawing.Color.Transparent;
            this.tsbHome.Image = global::SchoolCenterSMS.View.Properties.Resources.Home1;
            this.tsbHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHome.Name = "tsbHome";
            this.tsbHome.Size = new System.Drawing.Size(90, 79);
            this.tsbHome.ToolTipText = "Home";
            // 
            // tsbCongCu
            // 
            this.tsbCongCu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCongCu.ForeColor = System.Drawing.Color.Transparent;
            this.tsbCongCu.Image = global::SchoolCenterSMS.View.Properties.Resources.CongCu;
            this.tsbCongCu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCongCu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCongCu.Name = "tsbCongCu";
            this.tsbCongCu.Size = new System.Drawing.Size(90, 79);
            this.tsbCongCu.ToolTipText = "Công cụ";
            // 
            // tsbTinNhan
            // 
            this.tsbTinNhan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTinNhan.ForeColor = System.Drawing.Color.LightGray;
            this.tsbTinNhan.Image = global::SchoolCenterSMS.View.Properties.Resources.Message;
            this.tsbTinNhan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTinNhan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTinNhan.Name = "tsbTinNhan";
            this.tsbTinNhan.Size = new System.Drawing.Size(90, 79);
            this.tsbTinNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbTinNhan.ToolTipText = "Tin nhắn";
            // 
            // tsbHoTro
            // 
            this.tsbHoTro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHoTro.ForeColor = System.Drawing.Color.LightGray;
            this.tsbHoTro.Image = global::SchoolCenterSMS.View.Properties.Resources.Hotro;
            this.tsbHoTro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbHoTro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHoTro.Name = "tsbHoTro";
            this.tsbHoTro.Size = new System.Drawing.Size(90, 79);
            this.tsbHoTro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbHoTro.ToolTipText = "Hỗ trợ";
            // 
            // tsbDuTru
            // 
            this.tsbDuTru.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDuTru.ForeColor = System.Drawing.Color.LightGray;
            this.tsbDuTru.Image = ((System.Drawing.Image)(resources.GetObject("tsbDuTru.Image")));
            this.tsbDuTru.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDuTru.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDuTru.Name = "tsbDuTru";
            this.tsbDuTru.Size = new System.Drawing.Size(90, 79);
            this.tsbDuTru.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDuTru.ToolTipText = "Claim Info";
            this.tsbDuTru.Visible = false;
            // 
            // tlsSubMenu
            // 
            this.tlsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.tlsSubMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlsSubMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlsSubMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tlsSubMenu.Location = new System.Drawing.Point(0, 102);
            this.tlsSubMenu.Name = "tlsSubMenu";
            this.tlsSubMenu.Padding = new System.Windows.Forms.Padding(0, 10, 1, 0);
            this.tlsSubMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tlsSubMenu.Size = new System.Drawing.Size(26, 460);
            this.tlsSubMenu.TabIndex = 16;
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.pnlContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContent.Controls.Add(this.sttBarStatusDevice);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(26, 102);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(858, 460);
            this.pnlContent.TabIndex = 20;
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.pnlColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor.Location = new System.Drawing.Point(26, 102);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(3, 460);
            this.pnlColor.TabIndex = 21;
            // 
            // sttBarStatusDevice
            // 
            this.sttBarStatusDevice.Location = new System.Drawing.Point(0, 438);
            this.sttBarStatusDevice.Name = "sttBarStatusDevice";
            this.sttBarStatusDevice.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.sttBarStatusDevice.Size = new System.Drawing.Size(858, 22);
            this.sttBarStatusDevice.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.tlsSubMenu);
            this.Controls.Add(this.tlsMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS For Education";
            this.tlsMainMenu.ResumeLayout(false);
            this.tlsMainMenu.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip tlsMainMenu;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbHome;
        private System.Windows.Forms.ToolStripButton tsbCongCu;
        private System.Windows.Forms.ToolStripButton tsbTinNhan;
        private System.Windows.Forms.ToolStripButton tsbHoTro;
        private System.Windows.Forms.ToolStripButton tsbDuTru;
        public System.Windows.Forms.ToolStrip tlsSubMenu;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlColor;
        public System.Windows.Forms.StatusBar sttBarStatusDevice;
    }
}