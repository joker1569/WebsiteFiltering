namespace Website_Filtering
{
    partial class frmSendEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendEmail));
            this.lbTieude = new DevExpress.XtraEditors.LabelControl();
            this.txtTieuDe = new System.Windows.Forms.RichTextBox();
            this.lbNoiDung = new DevExpress.XtraEditors.LabelControl();
            this.txtNoidung = new System.Windows.Forms.RichTextBox();
            this.btnGuiPhanHoi = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Website_Filtering.frmMailWaiting), true, true);
            this.SuspendLayout();
            // 
            // lbTieude
            // 
            this.lbTieude.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieude.Location = new System.Drawing.Point(35, 38);
            this.lbTieude.Name = "lbTieude";
            this.lbTieude.Size = new System.Drawing.Size(55, 18);
            this.lbTieude.TabIndex = 0;
            this.lbTieude.Text = "Tiêu đề:";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTieuDe.Location = new System.Drawing.Point(112, 19);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(633, 58);
            this.txtTieuDe.TabIndex = 1;
            this.txtTieuDe.Text = "";
            // 
            // lbNoiDung
            // 
            this.lbNoiDung.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiDung.Location = new System.Drawing.Point(35, 215);
            this.lbNoiDung.Name = "lbNoiDung";
            this.lbNoiDung.Size = new System.Drawing.Size(62, 18);
            this.lbNoiDung.TabIndex = 0;
            this.lbNoiDung.Text = "Nội dung:";
            // 
            // txtNoidung
            // 
            this.txtNoidung.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoidung.Location = new System.Drawing.Point(112, 83);
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.Size = new System.Drawing.Size(633, 287);
            this.txtNoidung.TabIndex = 1;
            this.txtNoidung.Text = "";
            // 
            // btnGuiPhanHoi
            // 
            this.btnGuiPhanHoi.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiPhanHoi.Appearance.Options.UseFont = true;
            this.btnGuiPhanHoi.Location = new System.Drawing.Point(338, 396);
            this.btnGuiPhanHoi.Name = "btnGuiPhanHoi";
            this.btnGuiPhanHoi.Size = new System.Drawing.Size(120, 31);
            this.btnGuiPhanHoi.TabIndex = 2;
            this.btnGuiPhanHoi.Text = "GỬI";
            this.btnGuiPhanHoi.Click += new System.EventHandler(this.btnGuiPhanHoi_Click);
            // 
            // frmSendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 462);
            this.Controls.Add(this.btnGuiPhanHoi);
            this.Controls.Add(this.txtNoidung);
            this.Controls.Add(this.txtTieuDe);
            this.Controls.Add(this.lbNoiDung);
            this.Controls.Add(this.lbTieude);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSendEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gửi ý kiến phản hồi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbTieude;
        private System.Windows.Forms.RichTextBox txtTieuDe;
        private DevExpress.XtraEditors.LabelControl lbNoiDung;
        private System.Windows.Forms.RichTextBox txtNoidung;
        private DevExpress.XtraEditors.SimpleButton btnGuiPhanHoi;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;

    }
}