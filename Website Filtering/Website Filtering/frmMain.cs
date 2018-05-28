using DevExpress.XtraTabbedMdi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Website_Filtering.Support;

namespace Website_Filtering
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            xtraTabbedMdiManager1.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            xtraTabbedMdiManager1.FloatOnDrag = DevExpress.Utils.DefaultBoolean.True;
            xtraTabbedMdiManager1.FloatPageDragMode = FloatPageDragMode.Preview;
            /*** To Show form Icons in page headers ***/
            // xtraTabbedMdiManager1.UseFormIconAsPageImage = DefaultBoolean.True;

            xtraTabbedMdiManager1.BeginFloating += xtraTabbedMdiManager1_BeginFloating;
            xtraTabbedMdiManager1.FloatMDIChildDragging += xtraTabbedMdiManager1_FloatMDIChildDragging;
        }

        void xtraTabbedMdiManager1_FloatMDIChildDragging(object sender, FloatMDIChildDraggingEventArgs e)
        {
            /* 
             * To allow an XtraTabbedMdiManager to accept a dragged panel, 
             * the manager needs to be added to the e.Targets collection.
             */
        }

        void xtraTabbedMdiManager1_BeginFloating(object sender, FloatingCancelEventArgs e)
        {
            e.Cancel = false; // Allow all tab pages to be dragged away from XTraTabbedMDIManager
        }

        private void btnLichSuDuyetWeb_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadingInForm loading = new LoadingInForm(splashScreenManager1);
            loading.ShowWaitForm();
            frmQuetLichSu frm = new frmQuetLichSu();
            frm.MdiParent = this;
            frm.Show();
            loading.CloseWaitForm();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadingInForm loading = new LoadingInForm(splashScreenManager1);
            loading.ShowWaitForm();
            frmDanhGiaURL frm = new frmDanhGiaURL();
            frm.MdiParent = this;
            frm.Show();
            loading.CloseWaitForm();
        }

        private void btnHinhAnh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadingInForm loading = new LoadingInForm(splashScreenManager1);
            loading.ShowWaitForm();
            frmTaiHinhAnh frm = new frmTaiHinhAnh();
            frm.MdiParent = this;
            frm.Show();
            loading.CloseWaitForm();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThongtin2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmInformation frm = new frmInformation();
            frm.Show();
        }

        private void btnContact_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSendEmail frm = new frmSendEmail();
            frm.Show();
        }
    }
}
