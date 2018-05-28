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
using System.Xml;
using FilterContent.ExtractClass;
using FilterContent.Support;
using Website_Filtering.ExtractClass;
using Website_Filtering.Support;
using DevExpress.XtraSplashScreen;

namespace Website_Filtering
{
    public partial class frmQuetLichSu : DevExpress.XtraEditors.XtraForm
    {
        public frmQuetLichSu()
        {
            InitializeComponent();
            ResizeColumn(listviewURL);
        }

        private void ResizeColumn(ListView lv)
        {
            int x = lv.Width / 17 == 0 ? 1 : lv.Width / 17;
            lv.Columns[0].Width = x;
            lv.Columns[1].Width = x * 6;
            lv.Columns[2].Width = x * 3;
            lv.Columns[3].Width = x * 3;
            lv.Columns[4].Width = x * 3;
            lv.Columns[5].Width = x;
        }


        private void frmQuetLichSu_Load(object sender, EventArgs e)
        {
            //GhiFileXML();
            //HienThiFileXML();
        }
        #region XML
        private void createNode(string pID, string pName, string pPrice, XmlTextWriter writer)
        {
            writer.WriteStartElement("Product");
            writer.WriteStartElement("Product_id");
            writer.WriteString(pID);
            writer.WriteEndElement();
            writer.WriteStartElement("Product_name");
            writer.WriteString(pName);
            writer.WriteEndElement();
            writer.WriteStartElement("Product_price");
            writer.WriteString(pPrice);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        private void GhiFileXML()
        {
            XmlTextWriter writer = new XmlTextWriter("product.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Table");
            createNode("1", "Product 1", "1000", writer);
            createNode("2", "Product 2", "2000", writer);
            createNode("3", "Product 3", "3000", writer);
            createNode("4", "Product 4", "4000", writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            MessageBox.Show("XML File created ! ");
        }
        #endregion
        private void frmQuetLichSu_Resize(object sender, EventArgs e)
        {
            ResizeColumn(listviewURL);
            ResizeInformation();
        }

        private void ResizeInformation()
        {
            int x, y;
            x = panelOption.Height;
            y = panelOption.Width;

        }

        private void SetValueToListView(List<HistoryItem> list)
        {
            listviewURL.Items.Clear();
            int Count = 1;
            listviewURL.SmallImageList = imageList1;
            foreach (HistoryItem item in list)
            {
                HttpsToHttp cv = new HttpsToHttp(item.URL);
                item.URL = cv.Convert();
                GetContentFromURL getc = new GetContentFromURL(item);
                String content = getc.ExtractContentFromUrl();
                ListViewItem lvi;
                if (content == "")
                {
                    lvi = new ListViewItem("", 1);
                }
                else
                {
                    lvi = new ListViewItem("", 0);
                }
                lvi.SubItems.Add(item.URL);
                lvi.SubItems.Add(item.Title);
                lvi.SubItems.Add(item.VisitedTime.ToString());
                
                lvi.SubItems.Add(getc.ExtractContentFromUrl());
                lvi.SubItems.Add("BT");
                listviewURL.Items.Add(lvi);
                Count++;
            }
        }

        private void ChromeExtract(int NumURL)
        {
            LoadingInForm loading = new LoadingInForm(splashScreenManager1);
            loading.ShowWaitForm();
            ChromeHistoryExtract extract = new ChromeHistoryExtract(Environment.UserName, NumURL);
            List<HistoryItem> list = extract.getHistoryBrowser();
            SetValueToListView(list);
            loading.CloseWaitForm();
        }

        private void IEExtract(int NumURL)
        {
            LoadingInForm loading = new LoadingInForm(splashScreenManager1);
            loading.ShowWaitForm();
            IEHistoryExtract extract = new IEHistoryExtract();
            List<HistoryItem> list = extract.GetHistory(NumURL);
            if(list != null) SetValueToListView(list);
            loading.CloseWaitForm();
        }

        private void FirefoxExtract(int NumURL)
        {
            LoadingInForm loading = new LoadingInForm(splashScreenManager1);
            loading.ShowWaitForm();
            FirefoxHistoryExtract extract = new FirefoxHistoryExtract(NumURL);
            List<HistoryItem> list = extract.GetHistory();
            SetValueToListView(list);
            loading.CloseWaitForm();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if(cbbBrowser.Text == "")
            {
                XtraMessageBox.Show("Vui lòng chọn trình duyệt để tiến hành quét", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txtNumURL.Text == "")
            {
                XtraMessageBox.Show("Vui lòng điền số lượng URL cần quét (Quét từ các địa chỉ truy nhập gần đây)", 
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(cbbBrowser.Text == "Chrome")
                {
                    ChromeExtract(Convert.ToInt32(txtNumURL.Text));
                }
                else if(cbbBrowser.Text == "IE")
                {
                    IEExtract(Convert.ToInt32(txtNumURL.Text));
                }
                else if(cbbBrowser.Text == "Firefox")
                {
                    FirefoxExtract(Convert.ToInt32(txtNumURL.Text));
                }
            }

        }

        private void listviewURL_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                Point pt = listviewURL.PointToScreen(e.Location);
                contextMenuStrip1.Show(pt);
            }
        }

        private void ChiTietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listviewURL.SelectedItems.Count > 0)
            {
                ListViewItem item = listviewURL.SelectedItems[0];
                String Content = item.SubItems[4].Text.Replace("\n", "\r\n");
                frmChiTiet frm = new frmChiTiet(item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, Content);
                frm.Show();
            }
            else
                MessageBox.Show("Lỗi khi xử lý yêu cầu", "Thong bao", MessageBoxButtons.OK);
        }

        private void quetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listviewURL.SelectedItems.Count > 0)
            {
                ListViewItem item = listviewURL.SelectedItems[0];
                String URL = item.SubItems[1].Text;
                frmDanhGiaURL frm = new frmDanhGiaURL(URL);
                frm.Show();
            }
            else
                MessageBox.Show("Lỗi khi xử lý yêu cầu", "Thong bao", MessageBoxButtons.OK);
        }   
    }
}