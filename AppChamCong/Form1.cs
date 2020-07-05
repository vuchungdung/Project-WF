using AppChamCong.CommonService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChamCong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {

        }

        private void btnThongTinCN_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void btnTKNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            CT.NhanVien nv = new CT.NhanVien();
            panel1.Controls.Clear();
            panel1.Controls.Add(nv);
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            CT.ChamCong nv = new CT.ChamCong();
            panel1.Controls.Clear();
            panel1.Controls.Add(nv);
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            CT.ChucVu nv = new CT.ChucVu();
            panel1.Controls.Clear();
            panel1.Controls.Add(nv);
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Chu Ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                Application.Exit();
        }

        private void btnDoiMK_Click_1(object sender, EventArgs e)
        {
            CT.DoiMatKhau nv = new CT.DoiMatKhau();
            panel1.Controls.Clear();
            panel1.Controls.Add(nv);
        }

        private void btnThongTinCN_Click_1(object sender, EventArgs e)
        {
            CT.DoiThongTin nv = new CT.DoiThongTin();
            panel1.Controls.Clear();
            panel1.Controls.Add(nv);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CT.TinhLuong nv = new CT.TinhLuong();
            panel1.Controls.Clear();
            panel1.Controls.Add(nv);
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            CT.PhongBan nv = new CT.PhongBan();
            panel1.Controls.Clear();
            panel1.Controls.Add(nv);
        }

        private void btnTaoTK_Click_1(object sender, EventArgs e)
        {
            CT.TaoTaiKhoan nv = new CT.TaoTaiKhoan();
            panel1.Controls.Clear();
            panel1.Controls.Add(nv);
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Chu Ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CT.BangLuong nv = new CT.BangLuong();
            panel1.Controls.Clear();
            panel1.Controls.Add(nv);
        }

        public void LoadForm()
        {
            tabControl1.SelectedTab = tabPage2;
            LoadQuyen(QuyenHan.QUYEN_HAN);
        }
        public void LoadQuyen(string quyen)
        {
            if (quyen == "member")
            {
                btnTaoTK.Enabled = false;
                btnNhanVien.Enabled = false;
                btnPhongBan.Enabled = false;
                btnChamCong.Enabled = false;
                btnChucVu.Enabled = false;
                button5.Enabled = false;
            }
            if (quyen == "admin")
            {
                btnTaoTK.Enabled = true;
                btnNhanVien.Enabled = true;
                btnPhongBan.Enabled = true;
                btnChamCong.Enabled = true;
                btnChucVu.Enabled = true;
                button5.Enabled = true;
            }
            if (quyen == "editor")
            {
                btnTaoTK.Enabled = false;
                btnNhanVien.Enabled = true;
                btnPhongBan.Enabled = false;
                btnChamCong.Enabled = true;
                btnChucVu.Enabled = false;
                button5.Enabled = true;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
