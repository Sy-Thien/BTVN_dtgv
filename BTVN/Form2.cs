using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN
{
    public partial class NhanVienForm : Form
    {
        public NhanVien NhanVienMoi { get; private set; }
        public NhanVienForm()
        {
            InitializeComponent();
        }

        public NhanVienForm(NhanVien nhanVien)
        {
            InitializeComponent();

            // Hiển thị dữ liệu cũ trên form
            txtMSNV.Text = nhanVien.MSNV;
            txtTen.Text = nhanVien.TenNV;
            txtLuong.Text = nhanVien.LuongCB.ToString();

            // Lưu tham chiếu để sửa
            NhanVienMoi = nhanVien;
        }

        private void btn_Dongy_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu rỗng
            if (string.IsNullOrWhiteSpace(txtMSNV.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(txtLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng lương
            if (!double.TryParse(txtLuong.Text, out double luongCB))
            {
                MessageBox.Show("Lương cơ bản phải là số.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật dữ liệu mới
            NhanVienMoi = new NhanVien
            {
                MSNV = txtMSNV.Text.Trim(),
                TenNV = txtTen.Text.Trim(),
                LuongCB = luongCB
            };

            // Đóng form và trả về kết quả
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
