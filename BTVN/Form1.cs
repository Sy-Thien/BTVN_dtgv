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
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Add("MSNV", "Mã số NV");
            dataGridView1.Columns.Add("TenNV", "Tên nhân viên");
            dataGridView1.Columns.Add("LuongCB", "Lương cơ bản");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var form = new NhanVienForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Thêm dữ liệu mới vào DataGridView
                var nv = form.NhanVienMoi;
                dataGridView1.Rows.Add(nv.MSNV, nv.TenNV, nv.LuongCB);
            }
        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Lấy dữ liệu dòng được chọn
                int index = dataGridView1.CurrentRow.Index;
                var nv = new NhanVien
                {
                    MSNV = dataGridView1.Rows[index].Cells[0].Value.ToString(),
                    TenNV = dataGridView1.Rows[index].Cells[1].Value.ToString(),
                    LuongCB = Convert.ToDouble(dataGridView1.Rows[index].Cells[2].Value)
                };

                // Mở form Nhân viên để sửa
                var form = new NhanVienForm(nv);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Cập nhật dữ liệu đã chỉnh sửa vào DataGridView
                    var nvMoi = form.NhanVienMoi;
                    dataGridView1.Rows[index].Cells[0].Value = nvMoi.MSNV;
                    dataGridView1.Rows[index].Cells[1].Value = nvMoi.TenNV;
                    dataGridView1.Rows[index].Cells[2].Value = nvMoi.LuongCB;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Xóa dòng được chọn
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
