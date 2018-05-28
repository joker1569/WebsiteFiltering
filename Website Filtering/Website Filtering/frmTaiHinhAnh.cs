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
using Website_Filtering.Support;
using FilterContent.Support;
using System.IO;
using System.Net;

namespace Website_Filtering
{
    public partial class frmTaiHinhAnh : DevExpress.XtraEditors.XtraForm
    {
        public frmTaiHinhAnh()
        {
            InitializeComponent();
        }

        private void frmTaiHinhAnh_Load(object sender, EventArgs e)
        {
            btnDownload.Text = "Tải danh sách\n hình ảnh"; 
        }
        //Tải dữ liệu hình ảnh từ địa chỉ URL thu thập được
        private byte[] DownloadData(string Url, out string responseUrl)
        {
            byte[] downloadedData = new byte[0];
            try
            {
                WebRequest req = WebRequest.Create(Url);
                WebResponse response = req.GetResponse();
                Stream stream = response.GetResponseStream();
                responseUrl = response.ResponseUri.ToString();
                byte[] buffer = new byte[1024];
                int dataLength = (int)response.ContentLength;
                MemoryStream memStream = new MemoryStream();
                while (true)
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        break;
                    }
                    else
                    {
                        memStream.Write(buffer, 0, bytesRead);
                    }
                }
                downloadedData = memStream.ToArray();
                stream.Close();
                memStream.Close();
            }
            catch (Exception)
            {
                responseUrl = string.Empty;
                return new byte[0];
            }
            return downloadedData;
        }

        private string GetBaseURL(string Url)
        {
            int inx = Url.IndexOf("://") + "://".Length;
            int end = Url.IndexOf('/', inx);
            string baseUrl = string.Empty;
            if (end != -1)
                return Url.Substring(0, end);
            else
                return string.Empty;
        }

        //Quét mã nguồn html, phân tích các thẻ image để trích xuất hình ảnh
        private List<string> ScanImage(string Url)
        {
            List<string> imageList = new List<string>();
            if (!Url.StartsWith("http://") && !Url.StartsWith("https://"))
                Url = "http://" + Url;
            HttpsToHttp cv = new HttpsToHttp(Url);
            Url = cv.Convert();
            string responseUrl = string.Empty;
            string htmlData = ASCIIEncoding.ASCII.GetString(DownloadData(Url, out responseUrl));
            if (responseUrl != string.Empty)
                Url = responseUrl;
            if (htmlData != string.Empty)
            {
                string imageHtmlCode = "<img";
                string imageSrcCode = @"src=""";
                int index = htmlData.IndexOf(imageHtmlCode);
                while (index != -1)
                {
                    htmlData = htmlData.Substring(index);
                    int brackedEnd = htmlData.IndexOf('>'); 
                    int start = htmlData.IndexOf(imageSrcCode) + imageSrcCode.Length;
                    int end = htmlData.IndexOf('"', start + 1);
                    if (end > start && start < brackedEnd)
                    {
                        string loc = htmlData.Substring(start, end - start);
                        imageList.Add(loc);
                    }
                    if (imageHtmlCode.Length < htmlData.Length)
                        index = htmlData.IndexOf(imageHtmlCode, imageHtmlCode.Length);
                    else
                        index = -1;
                }
                for (int i = 0; i < imageList.Count; i++)
                {
                    string img = imageList[i];
                    string baseUrl = GetBaseURL(Url);
                    if ((!img.StartsWith("http://") && !img.StartsWith("https://"))
                        && baseUrl != string.Empty)
                        img = baseUrl + "/" + img.TrimStart('/');
                    imageList[i] = img;
                }
            }
            return imageList;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if(txtURL.Text == "")
            {
                XtraMessageBox.Show("Vui lòng điền dữ liệu URL!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LoadingInForm loading = new LoadingInForm(splashScreenManager1);
                loading.ShowWaitForm();
                listboxImage.Items.Clear();
                foreach(string image in ScanImage(txtURL.Text))
                {
                    listboxImage.Items.Add(image);
                }
                loading.CloseWaitForm();
            }
        }

        private byte[] DownloadData(string Url)
        {
            string empty = string.Empty;
            return DownloadData(Url, out empty);
        }

        private Image ImageFromURL(string Url)
        {
            byte[] imageData = DownloadData(Url);
            Image img = null;
            try
            {
                MemoryStream stream = new MemoryStream(imageData);
                img = Image.FromStream(stream);
                stream.Close();
            }
            catch (Exception) {}
            return img;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadingInForm loading = new LoadingInForm(splashScreenManager2);
            loading.ShowWaitForm();
            if (listboxImage.SelectedIndex != -1)
                boxImage.Image = ImageFromURL(listboxImage.SelectedItem.ToString());
            loading.CloseWaitForm();
        }       
    }
}