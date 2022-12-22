using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTienDien
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void menuKhuVuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            formQuanLyKhuVuc form = new formQuanLyKhuVuc();
            form.MdiParent = this;
            form.Show();
        }

        private void menuKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            formQuanLyKhachHang form = new formQuanLyKhachHang();
            form.MdiParent = this;
            form.Show();
        }

        private void menuDienKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            formQuanLyDienKe form = new formQuanLyDienKe();
            form.MdiParent = this;
            form.Show();
        }

        private void menuDonGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            formQuanLyDonGia form = new formQuanLyDonGia();
            form.MdiParent = this;
            form.Show();
        }

        private void menuHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            formQuanLyHoaDon form = new formQuanLyHoaDon();
            form.MdiParent = this;
            form.Show();
        }

        private void menuChiTietHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            formChiTietHoaDon form = new formChiTietHoaDon();
            form.MdiParent = this;
            form.Show();
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void menuReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            formReports form = new formReports();
            form.MdiParent = this;
            form.Show();
        }
    }
}