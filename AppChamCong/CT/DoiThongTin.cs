using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUL;
using AppChamCong.CommonService;

namespace AppChamCong.CT
{
    public partial class DoiThongTin : UserControl
    {
        public DoiThongTin()
        {
            InitializeComponent();
        }
        NhanVien_BUL nhanVien = new NhanVien_BUL();
        private void DoiThongTin_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }
        public void LoadThongTin()
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv = nhanVien.GetNhanVien(MaNhanVien.MANHANVIEN);
            lbMaNV.Text = MaNhanVien.MANHANVIEN;
            txtTen.Text = nv.HoTen;
            txtDT.Text = nv.SoDienThoai;
            dtpNgaySinh.Value = Convert.ToDateTime(nv.NgaySinh);
            if(nv.GioiTinh == true)
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            txtDiaChi.Text = nv.DiaChi;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.HoTen = txtTen.Text;
            nv.SoDienThoai = txtDT.Text;
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.DiaChi = txtDiaChi.Text;
            if(rdNam.Checked == true)
            {
                nv.GioiTinh = true;
            }
            else
            {
                nv.GioiTinh = false;
            }
            nv.MaNhanVien = lbMaNV.Text;
            if (nhanVien.UpdateTTNhanVien(nv) == true)
            {
                LoadThongTin();
                MessageBox.Show("Cập nhật thành công!", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông Báo");
                LoadThongTin();
            }
        }
    }
}
