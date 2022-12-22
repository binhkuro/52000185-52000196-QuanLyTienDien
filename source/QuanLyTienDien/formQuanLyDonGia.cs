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
    public partial class formQuanLyDonGia : DevExpress.XtraEditors.XtraForm
    {
        TinhTienDienEntities data = new TinhTienDienEntities();
        string opt = "";
        public formQuanLyDonGia()
        {
            InitializeComponent();
        }

        private void formQuanLyDonGia_Load(object sender, EventArgs e)
        {
            donGiaBindingSource.DataSource = data.DonGias.ToList();
        }

        public void clear()
        {
            txtMaDonGia.Text = txtSoTien.Text = txtTuKW.Text = txtDenKW.Text = txtGhiChu.Text = "";
        }

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("You must enter numbers!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTuKW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("You must enter numbers!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDenKW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("You must enter numbers!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMovePrevious_ItemClick(object sender, ItemClickEventArgs e)
        {
            donGiaBindingSource.MovePrevious();
        }

        private void btnMoveNext_ItemClick(object sender, ItemClickEventArgs e)
        {
            donGiaBindingSource.MoveNext();
        }

        private void btnMoveFirst_ItemClick(object sender, ItemClickEventArgs e)
        {
            donGiaBindingSource.MoveFirst();
        }

        private void btnMoveLast_ItemClick(object sender, ItemClickEventArgs e)
        {
            donGiaBindingSource.MoveLast();
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            opt = "1";
            donGiaBindingSource.AddNew();
            txtSoTien.Focus();
        }

        public void add()
        {
            var dg = new DonGia
            {
                MaDonGia = txtMaDonGia.Text.Trim(),
                TuKW = int.Parse(txtTuKW.Text.Trim()),
                DenKW = int.Parse(txtDenKW.Text.Trim()),
                SoTien = decimal.Parse(txtSoTien.Text.Trim()),
                GhiChu = txtGhiChu.Text.Trim(),
            };
            var madg = data.DonGias.FirstOrDefault(x => x.MaDonGia.Contains(dg.MaDonGia));
            if (madg != null)
            {
                MessageBox.Show("Không thêm được dữ liệu vì trùng khóa chính!");
            }
            else
            {
                data.DonGias.Add(dg);
                data.SaveChanges();
                MessageBox.Show("Dữ liệu đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void update()
        {
            if (txtMaDonGia.Text != "")
            {
                if (MessageBox.Show("Bạn thật sự muốn sửa?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var dg = data.DonGias.Where(d => d.MaDonGia == txtMaDonGia.Text.Trim()).FirstOrDefault();
                    dg.TuKW = int.Parse(txtTuKW.Text.Trim());
                    dg.DenKW = int.Parse(txtDenKW.Text.Trim());
                    dg.SoTien = decimal.Parse(txtSoTien.Text.Trim());
                    dg.GhiChu = txtGhiChu.Text.Trim();
                    data.SaveChanges();
                    MessageBox.Show("Dữ liệu đã được chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Thông tin không tồn tại, phải chọn thêm mới thông tin trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtMaDonGia.Text != "" || txtSoTien.Text != "" || txtTuKW.Text != "" || txtDenKW.Text != "")
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
                formQuanLyDonGia_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Dữ liệu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var madg = data.ChiTietHoaDons.FirstOrDefault(x => x.MaDonGia.Contains(txtMaDonGia.Text.Trim()));
                if (madg != null)
                {
                    MessageBox.Show("Đơn giá này đã có dữ liệu. Không được phép xóa!");
                }
                else
                {
                    var dg = data.DonGias
                    .Where(x => x.MaDonGia == txtMaDonGia.Text.Trim())
                    .FirstOrDefault();
                    data.DonGias.Remove(dg);
                    data.SaveChanges();
                    formQuanLyDonGia_Load(sender, e);
                }
            }
        }

        private void btnCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtMaDonGia.ReadOnly = false;
            clear();
        }

        private void btnOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}