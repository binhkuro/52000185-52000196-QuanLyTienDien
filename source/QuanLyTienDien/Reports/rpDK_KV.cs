using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QuanLyTienDien.Reports
{
    public partial class rpDK_KV : DevExpress.XtraReports.UI.XtraReport
    {
        public rpDK_KV()
        {
            InitializeComponent();
        }

        public XRLabel LabelKhuVuc { 
            get { return lblKhuvuc; } 
            set { lblKhuvuc = value; }
        }
    }
}
