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
    public partial class formQuanLyDienKe : DevExpress.XtraEditors.XtraForm
    {
        TinhTienDienEntities data = new TinhTienDienEntities();
        string opt = "";
        public formQuanLyDienKe()
        {
            InitializeComponent();
        }

        private void formQuanLyDienKe_Load(object sender, EventArgs e)
        {
            dienKeBindingSource.DataSource = data.DienKes.ToList();
            khachHangBindingSource.DataSource = data.KhachHangs.ToList();
            khuVucBindingSource.DataSource = data.KhuVucs.ToList();
        }

        private void txtHDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("You must enter numbers!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clear()
        {
            txtMaDK.Text = txtHDT.Text = txtNSX.Text = txtGhiChu.Text = "";
        }

        private void btnMovePrevious_ItemClick(object sender, ItemClickEventArgs e)
        {
            dienKeBindingSource.MovePrevious();
        }

        private void btnMoveNext_ItemClick(object sender, ItemClickEventArgs e)
        {
            dienKeBindingSource.MoveNext();
        }

        private void btnMoveFirst_ItemClick(object sender, ItemClickEventArgs e)
        {
            dienKeBindingSource.MoveFirst();
        }

        private void btnMoveLast_ItemClick(object sender, ItemClickEventArgs e)
        {
            dienKeBindingSource.MoveLast();
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            opt = "1";
            dienKeBindingSource.AddNew();
            txtHDT.Focus();
        }

        public void add()
        {
            var dk = new DienKe
            {
                MaDienKe = txtMaDK.Text.Trim(),
                HieuDienThe = int.Parse(txtHDT.Text.Trim()),
                MaKH = luMaKH.Text.ToString(),
                MaKhuVuc = luMaKV.Text.ToString(),
                NuocSanXuat = txtNSX.Text.Trim(),
                GhiChu = txtGhiChu.Text.Trim()
            };
            var madk = data.DienKes.FirstOrDefault(x => x.MaDienKe.Contains(dk.MaDienKe));
            if (madk != null)
            {
                MessageBox.Show("Không thêm được dữ liệu vì trùng khóa chính!");
            }
            else
            {
                data.DienKes.Add(dk);
                data.SaveChanges();
                MessageBox.Show("Dữ liệu đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void update()
        {
            if (txtMaDK.Text != "" || txtHDT.Text != "" || txtNSX.Text != "")
            {
                if (MessageBox.Show("Bạn thật sự muốn sửa?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var dk = data.DienKes.Where(d => d.MaDienKe == txtMaDK.Text.Trim()).FirstOrDefault();
                    dk.HieuDienThe = int.Parse(txtHDT.Text.Trim());
                    dk.MaKH = luMaKH.Text.ToString();
                    dk.MaKhuVuc = luMaKV.Text.ToString();
                    dk.NuocSanXuat = txtNSX.Text.Trim();
                    dk.GhiChu = txtGhiChu.Text.Trim();
                    data.SaveChanges();
                    MessageBox.Show("Dữ liệu đã được chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Thông tin không tồn tại, phải chọn thêm mới thông tin trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtMaDK.Text != "" || txtHDT.Text != "" || txtNSX.Text != "")
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
                formQuanLyDienKe_Load(sender, e);
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
                var madk = data.HoaDons.FirstOrDefault(x => x.MaDienKe.Contains(txtMaDK.Text.Trim()));
                if (madk != null)
                {
                    MessageBox.Show("Điện kế này đã có dữ liệu. Không được phép xóa!");
                }
                else
                {
                    var dk = data.DienKes.FirstOrDefault(x => x.MaDienKe.Contains(txtMaDK.Text.Trim()));
                    data.DienKes.Remove(dk);
                    data.SaveChanges();
                    formQuanLyDienKe_Load(sender, e);
                }
            }
        }

        private void btnCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtMaDK.ReadOnly = false;
            clear();
        }

        private void btnOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}