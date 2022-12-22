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
    public partial class formQuanLyKhachHang : DevExpress.XtraEditors.XtraForm
    {
        TinhTienDienEntities data = new TinhTienDienEntities();
        string opt = "";
        public formQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void formQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            khachHangBindingSource.DataSource = data.KhachHangs.ToList();
        }

        public void clear()
        {
            txtMaKH.Text = txtDiaChi.Text = txtSDT.Text = "";
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("You must enter numbers!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMovePrevious_ItemClick(object sender, ItemClickEventArgs e)
        {
            khachHangBindingSource.MovePrevious();
        }

        private void btnMoveNext_ItemClick(object sender, ItemClickEventArgs e)
        {
            khachHangBindingSource.MoveNext();
        }

        private void btnMoveFirst_ItemClick(object sender, ItemClickEventArgs e)
        {
            khachHangBindingSource.MoveFirst();
        }

        private void btnMoveLast_ItemClick(object sender, ItemClickEventArgs e)
        {
            khachHangBindingSource.MoveLast();
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            opt = "1";
            khachHangBindingSource.AddNew();
            txtDiaChi.Focus();
        }

        public void add()
        {
            var kh = new KhachHang
            {
                MaKH = txtMaKH.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                SoDienThoai = txtSDT.Text.Trim()
            };
            var makh = data.KhachHangs.FirstOrDefault(x => x.MaKH.Contains(kh.MaKH));
            if (makh != null)
            {
                MessageBox.Show("Không thêm được dữ liệu vì trùng khóa chính!");
            }
            else
            {
                data.KhachHangs.Add(kh);
                data.SaveChanges();
                MessageBox.Show("Dữ liệu đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void update()
        {
            if (txtMaKH.Text != "" || txtDiaChi.Text != "" || txtSDT.Text != "")
            {
                if (MessageBox.Show("Bạn thật sự muốn sửa?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var kh = data.KhachHangs.Where(k => k.MaKH == txtMaKH.Text.Trim()).FirstOrDefault();
                    kh.DiaChi = txtDiaChi.Text.Trim();
                    kh.SoDienThoai = txtSDT.Text.Trim();
                    data.SaveChanges();
                    MessageBox.Show("Dữ liệu đã được chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Thông tin không tồn tại, phải chọn thêm mới thông tin trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtMaKH.Text != "" || txtDiaChi.Text != "" || txtSDT.Text != "")
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
                formQuanLyKhachHang_Load(sender, e);
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
                var makh = data.DienKes.FirstOrDefault(x => x.MaKH.Contains(txtMaKH.Text.Trim()));
                if (makh != null)
                {
                    MessageBox.Show("Khách hàng này đã có dữ liệu. Không được phép xóa!");
                }
                else
                {
                    var kh = data.KhachHangs
                    .Where(x => x.MaKH == txtMaKH.Text.Trim())
                    .FirstOrDefault();
                    data.KhachHangs.Remove(kh);
                    data.SaveChanges();
                    formQuanLyKhachHang_Load(sender, e);
                }
            }
        }

        private void btnCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtMaKH.ReadOnly = false;
            clear();
        }

        private void btnOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}