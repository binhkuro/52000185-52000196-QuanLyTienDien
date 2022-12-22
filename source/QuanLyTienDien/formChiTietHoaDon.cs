using DevExpress.XtraBars;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyTienDien
{
    public partial class formChiTietHoaDon : DevExpress.XtraEditors.XtraForm
    {
        TinhTienDienEntities data = new TinhTienDienEntities();
        string opt = "";
        public formChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void formChiTietHoaDon_Load(object sender, EventArgs e)
        {
            chiTietHoaDonBindingSource.DataSource = data.ChiTietHoaDons.ToList();
            hoaDonBindingSource.DataSource = data.HoaDons.ToList();
            donGiaBindingSource.DataSource = data.DonGias.ToList();
        }

        private void txtSoluongKW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("You must enter numbers!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clear()
        {
            txtSoluongKW.Text = "";
        }

        private void btnMovePrevious_ItemClick(object sender, ItemClickEventArgs e)
        {
            chiTietHoaDonBindingSource.MovePrevious();
        }

        private void btnMoveNext_ItemClick(object sender, ItemClickEventArgs e)
        {
            chiTietHoaDonBindingSource.MoveNext();
        }

        private void btnMoveFirst_ItemClick(object sender, ItemClickEventArgs e)
        {
            chiTietHoaDonBindingSource.MoveFirst();
        }

        private void btnMoveLast_ItemClick(object sender, ItemClickEventArgs e)
        {
            chiTietHoaDonBindingSource.MoveLast();
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            opt = "1";
            chiTietHoaDonBindingSource.AddNew();
            txtSoluongKW.Focus();
        }

        public void add()
        {
            var cthd = new ChiTietHoaDon
            {
                SoHoaDon = luSohoadon.Text.ToString(),
                MaDonGia = luMadongia.Text.ToString(),
                SoLuongKW = int.Parse(txtSoluongKW.Text.Trim())
            };
            var keyprimary = data.ChiTietHoaDons.Where(x => x.SoHoaDon == luSohoadon.Text.ToString() && x.MaDonGia == luMadongia.Text.ToString()).FirstOrDefault();

            if (keyprimary != null)
            {
                MessageBox.Show("Không thêm được dữ liệu vì trùng khóa chính!");
            }
            else
            {
                data.ChiTietHoaDons.Add(cthd);
                data.SaveChanges();
                MessageBox.Show("Dữ liệu đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void update()
        {
            if (txtSoluongKW.Text != "")
            {
                if (MessageBox.Show("Bạn thật sự muốn sửa?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var cthd = data.ChiTietHoaDons.Where(x => x.SoHoaDon == luSohoadon.Text.ToString() && x.MaDonGia == luMadongia.Text.ToString()).FirstOrDefault();
                    cthd.SoLuongKW = int.Parse(txtSoluongKW.Text.Trim());
                    data.SaveChanges();
                    MessageBox.Show("Dữ liệu đã được chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Thông tin không tồn tại, phải chọn thêm mới thông tin trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtSoluongKW.Text != "")
            {
                if (opt == "1")
                {
                    add();
                }
                else
                {
                    update();
                }
                opt = "";
                formChiTietHoaDon_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Dữ liệu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var cthd = data.ChiTietHoaDons
                 .Where(x => x.SoHoaDon == luSohoadon.Text.ToString() && x.MaDonGia == luMadongia.Text.ToString())
                 .FirstOrDefault();
                data.ChiTietHoaDons.Remove(cthd);
                data.SaveChanges();
                formChiTietHoaDon_Load(sender, e);
            }
        }

        private void btnCancel_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            clear();
        }

        private void btnOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void luMadongia_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}