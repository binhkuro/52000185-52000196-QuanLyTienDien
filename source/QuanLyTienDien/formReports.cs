using DevExpress.Xpo.Metadata.Helpers;
using DevExpress.XtraReports.UI;
using QuanLyTienDien.Reports;
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
    public partial class formReports : Form
    {
        TinhTienDienEntities data = new TinhTienDienEntities();
        public formReports()
        {
            InitializeComponent();
        }

        private void FormReports_Load(object sender, EventArgs e)
        {
            getKhuVuc();
            getHoaDon();
        }

        void getKhuVuc()
        {
            cboKhuvuc.DisplayMember = "TenKhuVuc";
            cboKhuvuc.ValueMember = "MaKhuVuc";
            cboKhuvuc.DataSource = data.KhuVucs.ToList();
        }

        void getHoaDon()
        {
            cboSohoadon.DisplayMember = "SoHoaDon";
            cboSohoadon.ValueMember = "SoHoaDon";
            cboSohoadon.DataSource = data.HoaDons.ToList();
        }

        private void btnXem1_Click(object sender, EventArgs e)
        {
            rpDK_KV report = new rpDK_KV();
            report.LabelKhuVuc.Text = cboKhuvuc.SelectedValue.ToString();

            List<DienKe> list = data.DienKes.Where(k => k.MaKhuVuc == cboKhuvuc.SelectedValue.ToString()).ToList();
            report.DataSource = list;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        private void btnXem2_Click(object sender, EventArgs e)
        {
            rpHoaDon report = new rpHoaDon();

            List<HoaDon> list = data.HoaDons.Where(k => k.SoHoaDon == cboSohoadon.SelectedValue.ToString()).ToList();
            report.DataSource = list;
           
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        private void btnDongia_Click(object sender, EventArgs e)
        {
            rpDonGia report = new rpDonGia();

            List<DonGia> list = data.DonGias.ToList();
            report.DataSource = list;

            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }
    }
}
