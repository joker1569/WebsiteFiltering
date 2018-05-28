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

namespace Website_Filtering
{
    public partial class frmChiTiet : DevExpress.XtraEditors.XtraForm
    {
        public frmChiTiet()
        {
            InitializeComponent();
        }

        public frmChiTiet(String URL, String Title, String DateTime, String Content)
        {
            InitializeComponent();
            txtURL.Text = URL;
            txtTitle.Text = Title;
            dateEnter.EditValue = Convert.ToDateTime(DateTime);
            txtContent.Text = Content;
        }
    }
}