using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using FilterContent.ExtractClass;
using FilterContent.Support;
using Website_Filtering.Support;
using System.IO;

namespace Website_Filtering
{
    public partial class frmDanhGiaURL : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhGiaURL()
        {
            InitializeComponent();
        }

        public frmDanhGiaURL(String URL)
        {
            InitializeComponent();
            txtDiaChi.Text = URL;
        }

        private void XayDungBieuDo(string url)
        {
            HttpsToHttp cv = new HttpsToHttp(url);
            url = cv.Convert();
            GetContentFromURL get = new GetContentFromURL(new HistoryItem(url, "", DateTime.Now));
            CheckListString ck = new CheckListString(get.ExtractContentFromUrl());
            List<KeywordResult> list = ck.CheckingContent();

            Series series = new Series("URL", ViewType.Pie);
            foreach(KeywordResult kr in list)
            {
                if(kr.matchCount != 0)
                    series.Points.Add(new SeriesPoint(kr.Name, kr.matchCount));
            }
            series.LegendTextPattern = "{A}";
            ChartTitle titl = new ChartTitle();
            titl.Text = "Kết quả đánh giá nội dung";
            chartPie.Series.Add(series);
            chartPie.Titles[0].Text = titl.Text;

            Series series2 = new Series("Số lượng từ", ViewType.Bar);
            foreach (KeywordResult kr in list)
            {
                if(kr.matchCount != 0)
                    series2.Points.Add(new SeriesPoint(kr.Name, kr.matchCount));
            }
            chartBarSoLuong.Series.Add(series2);
            chartBarSoLuong.Legend.Visible = false;
            ChartTitle titl2 = new ChartTitle();
            titl2.Text = "Số lượng từ khóa phát hiện";
            chartBarSoLuong.Titles[0].Text = titl2.Text;
        }
        private void RemovePreviousSeries()
        {
            if (chartPie.Titles[0].Text != "Chờ dữ liệu...")
            {
                chartPie.Series.RemoveAt(0);
                chartBarSoLuong.Series.RemoveAt(0);
            }
        }

        private void frmDanhGiaURL_Load(object sender, EventArgs e)
        {
            ChartTitle title = new ChartTitle();
            title.Text = "Chờ dữ liệu...";
            ChartTitle title2 = new ChartTitle();
            title2.Text = "Chờ dữ liệu...";
            chartPie.Titles.Add(title);
            chartBarSoLuong.Titles.Add(title2);
        }

        private void btnQuet_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "")
            {
                XtraMessageBox.Show("Lỗi: Chưa nhập địa chỉ URL", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoadingInForm loading = new LoadingInForm(splashScreenManager1);
                loading.ShowWaitForm();
                RemovePreviousSeries();
                XayDungBieuDo(txtDiaChi.Text);
                loading.CloseWaitForm();
            }
        }
    }
}