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
using System.Net.Mail;
using System.Net;
using Website_Filtering.Support;

namespace Website_Filtering
{
    public partial class frmSendEmail : DevExpress.XtraEditors.XtraForm
    {
        public frmSendEmail()
        {
            InitializeComponent();
        }

        private void btnGuiPhanHoi_Click(object sender, EventArgs e)
        {
            if(txtTieuDe.Text == "")
            {
                XtraMessageBox.Show("Vui lòng điền tiêu đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(txtNoidung.Text == "")
            {
                XtraMessageBox.Show("Vui lòng điền nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    LoadingInForm loading = new LoadingInForm(splashScreenManager1);
                    loading.ShowWaitForm();
                    string mailBodyhtml = "<p>" + txtNoidung.Text + "</p>";
                    var msg = new MailMessage("hotroqllw@gmail.com", "hkhongminh@gmail.com", txtTieuDe.Text, mailBodyhtml);
                    msg.IsBodyHtml = true;
                    var smtpClient = new SmtpClient("smtp.gmail.com", 587); 
                    smtpClient.UseDefaultCredentials = true;
                    smtpClient.Credentials = new NetworkCredential("hotroqllw@gmail.com", "hieusl1996");
                    smtpClient.EnableSsl = true;
                    smtpClient.Send(msg);
                    loading.CloseWaitForm();
                    XtraMessageBox.Show("Phản hồi đã được gửi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}