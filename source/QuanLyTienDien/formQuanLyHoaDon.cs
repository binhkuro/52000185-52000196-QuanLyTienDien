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
    public partial class formQuanLyHoaDon : DevExpress.XtraEditors.XtraForm
    {
        TinhTienDienEntities data = new TinhTienDienEntities();
        string opt = "";
        public formQuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void formQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            hoaDonBindingSource.DataSource = data.HoaDons.ToList();
            dienKeBindingSource.DataSource = data.DienKes.ToList();
        }

        private void txtThanhtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("You must enter numbers!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("You must enter numbers!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clear()
        {
            txtSohoadon.Text = txtThanhtien.Text = txtThang.Text = "";
        }

        private void btnMovePrevious_ItemClick(object sender, ItemClickEventArgs e)
        {
            hoaDonBindingSource.MovePrevious();
        }

        private void btnMoveNext_ItemClick(object sender, ItemClickEventArgs e)
        {
            hoaDonBindingSource.MoveNext();
        }

        private void btnMoveFirst_ItemClick(object sender, ItemClickEventArgs e)
        {
            hoaDonBindingSource.MoveFirst();
        }

        private void btnMoveLast_ItemClick(object sender, ItemClickEventArgs e)
        {
            hoaDonBindingSource.MoveLast();
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            opt = "1";
            hoaDonBindingSource.AddNew();
            txtThanhtien.Focus();
        }

        public void add()
        {
            var hd = new HoaDon
            {
                SoHoaDon = txtSohoadon.Text.Trim(),
                ThanhTien = decimal.Parse(txtThanhtien.Text.Trim()),
                Thang = int.Parse(txtThang.Text.Trim()),
                MaDienKe = luMadienke.Text.ToString(),
            };
            var sohoadon = data.HoaDons.FirstOrDefault(x => x.SoHoaDon.Contains(hd.SoHoaDon));
            if (sohoadon != null)
            {
                MessageBox.Show("Không thêm được dữ liệu vì trùng khóa chính!");
            }
            else
            {
                data.HoaDons.Add(hd);
                data.SaveChanges();
                MessageBox.Show("Dữ liệu đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void update()
        {
            if (txtSohoadon.Text != "" || txtThanhtien.Text != "" || txtThang.Text != "")
            {
                if (MessageBox.Show("Bạn thật sự muốn sửa?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var hd = data.HoaDons.Where(h => h.SoHoaDon == txtSohoadon.Text.Trim()).FirstOrDefault();
                    hd.ThanhTien = decimal.Parse(txtThanhtien.Text.Trim());
                    hd.Thang = int.Parse(txtThang.Text.Trim());
                    hd.MaDienKe = luMadienke.Text.ToString();
                    data.SaveChanges();
                    MessageBox.Show("Dữ liệu đã được chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Thông tin không tồn tại, phải chọn thêm mới thông tin trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtSohoadon.Text != "" || txtThanhtien.Text != "" || txtThang.Text != "")
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
                formQuanLyHoaDon_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Dữ liệu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn xóa?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var sohd = data.ChiTietHoaDons.FirstOrDefault(x => x.SoHoaDon.Contains(txtSohoadon.Text.Trim()));
                if (sohd != null)
                {
                    MessageBox.Show("Hóa đơn này đã có dữ liệu. Không được phép xóa!");
                }
                else
                {
                    var hd = data.HoaDons
                    .Where(x => x.SoHoaDon == txtSohoadon.Text.Trim())
                    .FirstOrDefault();
                    data.HoaDons.Remove(hd);
                    data.SaveChanges();
                    formQuanLyHoaDon_Load(sender, e);
                }
            }
        }

        private void btnCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtSohoadon.ReadOnly = false;
            clear();
        }

        private void btnOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}