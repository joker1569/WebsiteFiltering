namespace Website_Filtering
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLichSuDuyetWeb = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongSo = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnHinhAnh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongtin = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongtin2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnContact = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpageQLWeb = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpageNoiDungWeb = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPageHotronguoidung = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Website_Filtering.frmWaiting), true, true);
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnLichSuDuyetWeb,
            this.barButtonItem1,
            this.btnThongSo,
            this.btnThoat,
            this.btnHinhAnh,
            this.btnThongtin,
            this.btnExit,
            this.btnThongtin2,
            this.btnContact});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1201, 155);
            // 
            // btnLichSuDuyetWeb
            // 
            this.btnLichSuDuyetWeb.Caption = "Quét lịch sử duyệt web";
            this.btnLichSuDuyetWeb.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLichSuDuyetWeb.Glyph")));
            this.btnLichSuDuyetWeb.Id = 1;
            this.btnLichSuDuyetWeb.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLichSuDuyetWeb.LargeGlyph")));
            this.btnLichSuDuyetWeb.Name = "btnLichSuDuyetWeb";
            this.btnLichSuDuyetWeb.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLichSuDuyetWeb_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đánh giá nội dung website";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnThongSo
            // 
            this.btnThongSo.Caption = "Thông số chức năng";
            this.btnThongSo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThongSo.Glyph")));
            this.btnThongSo.Id = 3;
            this.btnThongSo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThongSo.LargeGlyph")));
            this.btnThongSo.Name = "btnThongSo";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Đóng ứng dụng";
            this.btnThoat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThoat.Glyph")));
            this.btnThoat.Id = 4;
            this.btnThoat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThoat.LargeGlyph")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnHinhAnh
            // 
            this.btnHinhAnh.Caption = "Thống kê hình ảnh";
            this.btnHinhAnh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHinhAnh.Glyph")));
            this.btnHinhAnh.Id = 5;
            this.btnHinhAnh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnHinhAnh.LargeGlyph")));
            this.btnHinhAnh.Name = "btnHinhAnh";
            this.btnHinhAnh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHinhAnh_ItemClick);
            // 
            // btnThongtin
            // 
            this.btnThongtin.Caption = "Thông tin phần mềm";
            this.btnThongtin.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThongtin.Glyph")));
            this.btnThongtin.Id = 6;
            this.btnThongtin.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThongtin.LargeGlyph")));
            this.btnThongtin.Name = "btnThongtin";
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExit.Glyph")));
            this.btnExit.Id = 7;
            this.btnExit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnExit.LargeGlyph")));
            this.btnExit.Name = "btnExit";
            // 
            // btnThongtin2
            // 
            this.btnThongtin2.Caption = "Thông tin phần mềm";
            this.btnThongtin2.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThongtin2.Glyph")));
            this.btnThongtin2.Id = 8;
            this.btnThongtin2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThongtin2.LargeGlyph")));
            this.btnThongtin2.Name = "btnThongtin2";
            this.btnThongtin2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongtin2_ItemClick);
            // 
            // btnContact
            // 
            this.btnContact.Caption = "Gửi ý kiến phản hồi";
            this.btnContact.Glyph = ((System.Drawing.Image)(resources.GetObject("btnContact.Glyph")));
            this.btnContact.Id = 9;
            this.btnContact.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnContact.LargeGlyph")));
            this.btnContact.Name = "btnContact";
            this.btnContact.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnContact_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpageQLWeb,
            this.rbpageNoiDungWeb});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý website";
            // 
            // rbpageQLWeb
            // 
            this.rbpageQLWeb.ItemLinks.Add(this.btnLichSuDuyetWeb);
            this.rbpageQLWeb.Name = "rbpageQLWeb";
            this.rbpageQLWeb.Text = "Quản lý lịch sử duyệt web";
            // 
            // rbpageNoiDungWeb
            // 
            this.rbpageNoiDungWeb.ItemLinks.Add(this.barButtonItem1);
            this.rbpageNoiDungWeb.ItemLinks.Add(this.btnHinhAnh);
            this.rbpageNoiDungWeb.Name = "rbpageNoiDungWeb";
            this.rbpageNoiDungWeb.Text = "Đánh giá nội dung website";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage2.Appearance.Options.UseFont = true;
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.rbPageHotronguoidung});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Hỗ trợ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnThongtin2);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Thông tin";
            // 
            // rbPageHotronguoidung
            // 
            this.rbPageHotronguoidung.ItemLinks.Add(this.btnContact);
            this.rbPageHotronguoidung.Name = "rbPageHotronguoidung";
            this.rbPageHotronguoidung.Text = "Hỗ trợ người dùng";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThongtin);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hỗ trợ";
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 745);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản lý và đánh giá nội dung website";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpageQLWeb;
        private DevExpress.XtraBars.BarButtonItem btnLichSuDuyetWeb;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpageNoiDungWeb;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnThongSo;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnHinhAnh;
        private DevExpress.XtraBars.BarButtonItem btnThongtin;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnThongtin2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnContact;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPageHotronguoidung;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}

