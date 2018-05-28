namespace Website_Filtering
{
    partial class frmQuetLichSu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuetLichSu));
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Website_Filtering.frmWaiting), true, true);
            this.panelOption = new DevExpress.XtraEditors.PanelControl();
            this.btnScan = new DevExpress.XtraEditors.SimpleButton();
            this.txtNumURL = new DevExpress.XtraEditors.TextEdit();
            this.cbbBrowser = new System.Windows.Forms.ComboBox();
            this.lbCount = new DevExpress.XtraEditors.LabelControl();
            this.lbBrowser = new DevExpress.XtraEditors.LabelControl();
            this.panelShow = new DevExpress.XtraEditors.PanelControl();
            this.listviewURL = new System.Windows.Forms.ListView();
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colYN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChiTietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelOption)).BeginInit();
            this.panelOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumURL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelShow)).BeginInit();
            this.panelShow.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOption
            // 
            this.panelOption.Controls.Add(this.btnScan);
            this.panelOption.Controls.Add(this.txtNumURL);
            this.panelOption.Controls.Add(this.cbbBrowser);
            this.panelOption.Controls.Add(this.lbCount);
            this.panelOption.Controls.Add(this.lbBrowser);
            this.panelOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOption.Location = new System.Drawing.Point(0, 0);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(820, 122);
            this.panelOption.TabIndex = 0;
            // 
            // btnScan
            // 
            this.btnScan.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.Appearance.Options.UseFont = true;
            this.btnScan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnScan.Image = ((System.Drawing.Image)(resources.GetObject("btnScan.Image")));
            this.btnScan.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnScan.Location = new System.Drawing.Point(541, 12);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(228, 87);
            this.btnScan.TabIndex = 4;
            this.btnScan.Text = "QUÉT";
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // txtNumURL
            // 
            this.txtNumURL.Location = new System.Drawing.Point(189, 64);
            this.txtNumURL.Name = "txtNumURL";
            this.txtNumURL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumURL.Properties.Appearance.Options.UseFont = true;
            this.txtNumURL.Size = new System.Drawing.Size(261, 30);
            this.txtNumURL.TabIndex = 3;
            // 
            // cbbBrowser
            // 
            this.cbbBrowser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBrowser.FormattingEnabled = true;
            this.cbbBrowser.Items.AddRange(new object[] {
            "Chrome",
            "Firefox",
            "IE"});
            this.cbbBrowser.Location = new System.Drawing.Point(189, 21);
            this.cbbBrowser.Name = "cbbBrowser";
            this.cbbBrowser.Size = new System.Drawing.Size(261, 32);
            this.cbbBrowser.TabIndex = 2;
            // 
            // lbCount
            // 
            this.lbCount.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.Location = new System.Drawing.Point(68, 67);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(85, 24);
            this.lbCount.TabIndex = 1;
            this.lbCount.Text = "Số lượng:";
            // 
            // lbBrowser
            // 
            this.lbBrowser.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrowser.Location = new System.Drawing.Point(68, 24);
            this.lbBrowser.Name = "lbBrowser";
            this.lbBrowser.Size = new System.Drawing.Size(115, 24);
            this.lbBrowser.TabIndex = 0;
            this.lbBrowser.Text = "Trình duyệt: ";
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.listviewURL);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(0, 122);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(820, 383);
            this.panelShow.TabIndex = 1;
            // 
            // listviewURL
            // 
            this.listviewURL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStatus,
            this.colURL,
            this.colTitle,
            this.colTime,
            this.colContent,
            this.colYN});
            this.listviewURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listviewURL.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listviewURL.FullRowSelect = true;
            this.listviewURL.GridLines = true;
            this.listviewURL.Location = new System.Drawing.Point(2, 2);
            this.listviewURL.Name = "listviewURL";
            this.listviewURL.Size = new System.Drawing.Size(816, 379);
            this.listviewURL.TabIndex = 0;
            this.listviewURL.UseCompatibleStateImageBehavior = false;
            this.listviewURL.View = System.Windows.Forms.View.Details;
            this.listviewURL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listviewURL_MouseClick);
            // 
            // colStatus
            // 
            this.colStatus.Tag = "STT";
            this.colStatus.Text = "Trạng thái";
            // 
            // colURL
            // 
            this.colURL.Tag = "Địa chỉ URL";
            this.colURL.Text = "Địa chỉ URL";
            this.colURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colURL.Width = 300;
            // 
            // colTitle
            // 
            this.colTitle.Tag = "Tiêu đề";
            this.colTitle.Text = "Tiêu đề";
            this.colTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTitle.Width = 150;
            // 
            // colTime
            // 
            this.colTime.Tag = "Thời gian";
            this.colTime.Text = "Thời gian";
            this.colTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTime.Width = 120;
            // 
            // colContent
            // 
            this.colContent.Tag = "Nội dung";
            this.colContent.Text = "Nội dung";
            this.colContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colContent.Width = 120;
            // 
            // colYN
            // 
            this.colYN.Tag = "Độ an toàn";
            this.colYN.Text = "Đánh giá";
            this.colYN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colYN.Width = 120;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "accept.jpg");
            this.imageList1.Images.SetKeyName(1, "decline.png");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChiTietToolStripMenuItem,
            this.quetToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(220, 84);
            // 
            // ChiTietToolStripMenuItem
            // 
            this.ChiTietToolStripMenuItem.Name = "ChiTietToolStripMenuItem";
            this.ChiTietToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.ChiTietToolStripMenuItem.Text = "Xem chi tiết";
            this.ChiTietToolStripMenuItem.Click += new System.EventHandler(this.ChiTietToolStripMenuItem_Click);
            // 
            // quetToolStripMenuItem
            // 
            this.quetToolStripMenuItem.Name = "quetToolStripMenuItem";
            this.quetToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.quetToolStripMenuItem.Text = "Quét nội dung URL";
            this.quetToolStripMenuItem.Click += new System.EventHandler(this.quetToolStripMenuItem_Click);
            // 
            // frmQuetLichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 505);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelOption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuetLichSu";
            this.Text = "Lịch sử duyệt web";
            this.Load += new System.EventHandler(this.frmQuetLichSu_Load);
            this.Resize += new System.EventHandler(this.frmQuetLichSu_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.panelOption)).EndInit();
            this.panelOption.ResumeLayout(false);
            this.panelOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumURL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelShow)).EndInit();
            this.panelShow.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelOption;
        private DevExpress.XtraEditors.PanelControl panelShow;
        private System.Windows.Forms.ListView listviewURL;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colURL;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colContent;
        private System.Windows.Forms.ColumnHeader colYN;
        private DevExpress.XtraEditors.SimpleButton btnScan;
        private DevExpress.XtraEditors.TextEdit txtNumURL;
        private System.Windows.Forms.ComboBox cbbBrowser;
        private DevExpress.XtraEditors.LabelControl lbCount;
        private DevExpress.XtraEditors.LabelControl lbBrowser;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ChiTietToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quetToolStripMenuItem;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}