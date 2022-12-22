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
    public partial class formQuanLyKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        TinhTienDienEntities data = new TinhTienDienEntities();
        string opt = "";
        public formQuanLyKhuVuc()
        {
            InitializeComponent();
        } 

        private void formQuanLyKhuVuc_Load(object sender, EventArgs e)
        {
            khuVucBindingSource.DataSource = data.KhuVucs.ToList();
        }

        public void clear()
        {
            txtMaKV.Text = txtTenKV.Text = txtQH.Text = ""; 
        }

        private void btnMovePrevious_ItemClick(object sender, ItemClickEventArgs e)
        {
            khuVucBindingSource.MovePrevious();
        }

        private void btnMoveNext_ItemClick(object sender, ItemClickEventArgs e)
        {
            khuVucBindingSource.MoveNext();
        }

        private void btnMoveFirst_ItemClick(object sender, ItemClickEventArgs e)
        {
            khuVucBindingSource.MoveFirst();
        }

        private void btnMoveLast_ItemClick(object sender, ItemClickEventArgs e)
        {
            khuVucBindingSource.MoveLast();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opt = "1";
            khuVucBindingSource.AddNew();
            txtTenKV.Focus();
        }

        public void add()
        {
            var kv = new KhuVuc
            {
                MaKhuVuc = txtMaKV.Text.Trim(),
                TenKhuVuc = txtTenKV.Text.Trim(),
                QuanHuyen = txtQH.Text.Trim()
            };
            var makv = data.KhuVucs.FirstOrDefault(x => x.MaKhuVuc.Contains(kv.MaKhuVuc));
            if (makv != null)
            {
                MessageBox.Show("Không thêm được dữ liệu vì trùng khóa chính!");
            }
            else
            {
                data.KhuVucs.Add(kv);
                data.SaveChanges();
                MessageBox.Show("Dữ liệu đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void update()
        {
            if (txtMaKV.Text != "" || txtTenKV.Text != "" || txtQH.Text != "")
            {
                if (MessageBox.Show("Bạn thật sự muốn sửa?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var kv = data.KhuVucs.Where(k => k.MaKhuVuc == txtMaKV.Text.Trim()).FirstOrDefault();
                    kv.TenKhuVuc = txtTenKV.Text.Trim();
                    kv.QuanHuyen = txtQH.Text.Trim();
                    data.SaveChanges();
                    MessageBox.Show("Dữ liệu đã được chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Thông tin không tồn tại, phải chọn thêm mới thông tin trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSave_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (txtMaKV.Text != "" || txtTenKV.Text != "" || txtQH.Text != "")
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
                formQuanLyKhuVuc_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Dữ liệu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var makv = data.DienKes.FirstOrDefault(x => x.MaKhuVuc.Contains(txtMaKV.Text.Trim()));
                if (makv != null)
                {
                    MessageBox.Show("Khu vực này đã có dữ liệu. Không được phép xóa!");
                }
                else
                {
                    var kv = data.KhuVucs
                    .Where(x => x.MaKhuVuc == txtMaKV.Text.Trim())
                    .FirstOrDefault();
                    data.KhuVucs.Remove(kv);
                    data.SaveChanges();
                    formQuanLyKhuVuc_Load(sender, e);
                }
            }
        }

        private void btnCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtMaKV.ReadOnly = false;
            clear();
        }

        private void btnOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}