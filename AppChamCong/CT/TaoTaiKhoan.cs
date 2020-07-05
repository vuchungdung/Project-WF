using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;

namespace AppChamCong.CT
{
    public partial class TaoTaiKhoan : UserControl
    {
        public TaoTaiKhoan()
        {
            InitializeComponent();
        }
        TaiKhoan_BUL taiKhoan = new TaiKhoan_BUL();
        private void TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadNVCoTK();
            LoadNVCTK();
        }
        public void LoadNVCoTK()
        {
            dataGridViewCoTK.DataSource = taiKhoan.NhanVienCoTK();
        }
        public void LoadNVCTK()
        {
            dataGridViewCTK.DataSource = taiKhoan.NhanVienCTK();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.TenDangNhap = txtTK.Text;
            tk.MatKhau = txtMK.Text;
            tk.QuyenHan = cbQuyen.Text;
            tk.MaNV = lbMaNV.Text;
            if (taiKhoan.ThemTaiKhoan(tk) == true)
            {
                LoadNVCoTK();
                LoadNVCTK();
                MessageBox.Show("Thêm thành công!", "Thông Báo");
                LamMoi();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thông Báo");
            }
        }

        private void dataGridViewCTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dv = dataGridViewCTK.SelectedRows[0];
            lbMaNV.Text = dv.Cells["MaNV"].Value.ToString();
        }

        private void dataGridViewCoTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dv = dataGridViewCoTK.SelectedRows[0];
            textBox1.Text = dv.Cells["TenDangNhap"].Value.ToString();
            textBox2.Text = dv.Cells["MatKhau"].Value.ToString();
            comboBox1.Text = dv.Cells["QuyenHan"].Value.ToString();
            textBox1.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.TenDangNhap = textBox1.Text;
            tk.MatKhau = textBox2.Text;
            tk.QuyenHan = comboBox1.Text;
            if (taiKhoan.CapNhatTaiKhoan(tk) == true)
            {
                LoadNVCoTK();
                LoadNVCTK();
                MessageBox.Show("Cập nhật thành công!", "Thông Báo");
                LamMoi();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông Báo");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
        public void LamMoi()
        {
            txtMK.Clear();
            txtTK.Clear();
            textBox1.Clear();
            textBox2.Clear();
            cbQuyen.Text = null;
            comboBox1.Text = null;
            textBox1.ReadOnly = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult R = MessageBox.Show("BẠN CÓ THỰC SỰ MUỐN XÓA", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                if (R == DialogResult.Yes)
                {
                    if (dataGridViewCoTK.SelectedRows != null)
                    {
                        string tk = dataGridViewCoTK.SelectedRows[0].Cells[3].Value.ToString();
                        taiKhoan.XoaTaiKhoan(tk);
                        LoadNVCoTK();
                        LoadNVCTK();
                        MessageBox.Show("Xóa thành công!", "Thông Báo");
                        LamMoi();
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Xóa thất bại!","Thông Báo");
            }
        }
    }
}
