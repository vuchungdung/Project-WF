using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChamCong
{
    public partial class QuanLyNhanVien : Form
    {
        NhanVien_BUL nhanVien = new NhanVien_BUL();
        ChucVu_BUL chucVu = new ChucVu_BUL();
        List<ChucVu_DTO> listCV = new List<ChucVu_DTO>();
        List<NhanVien_DTO> listNV = new List<NhanVien_DTO>();
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {            
            listCV = chucVu.LoadChucVu();
            cbChucVu.DataSource = listCV;
            cbChucVu.DisplayMember = "TenChucVu";
            cbChucVu.ValueMember = "MaChucVu";
            LoadDataNhanVien();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.HoTen = txtHoTen.Text;
            if (cbNam.Checked)
            {
                nv.GioiTinh = true;
            }
            else
            {
                nv.GioiTinh = false;
            }
            nv.NgaySinh = dtNgaySinh.Value;
            nv.DiaChi = txtDiaChi.Text;
            nv.SoDienThoai = txtSDT.Text;
            nv.ChucVu = cbChucVu.SelectedValue.ToString();           
            if (nhanVien.InsertNhanVien(nv) == true)
            {
                listNV.Add(nv);
                LoadDataNhanVien();
                ResetValueText();
                MessageBox.Show("Thêm thành công", "Thông báo");                
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
        }
        public void ResetValueText()
        {
            txtMaNV.ReadOnly = false;
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            cbChucVu.Text = null;
            cbNam.Checked = true;
        }
        public void LoadDataNhanVien()
        {
            dataGridViewNV.DataSource = typeof(List<NhanVien_DTO>);
            dataGridViewNV.DataSource = nhanVien.LoadNhanVien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbChucVu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbChucVu.SelectedItem != null)
            {
                string keyword = cbChucVu.SelectedValue.ToString();
                dataGridViewNV.DataSource = typeof(List<NhanVien_DTO>);
                dataGridViewNV.DataSource = nhanVien.LoadNhanVienTheoCV(keyword);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValueText();
            LoadDataNhanVien();
        }

        private void dataGridViewNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.ReadOnly = true;
            DataGridViewRow dv = dataGridViewNV.SelectedRows[0];
            txtMaNV.Text = dv.Cells["MaNhanVien"].Value.ToString();
            txtHoTen.Text = dv.Cells["HoTen"].Value.ToString();
            txtSDT.Text = dv.Cells["SoDienThoai"].Value.ToString();
            txtDiaChi.Text = dv.Cells["DiaChi"].Value.ToString();
            if((bool)dv.Cells["GioiTinh"].Value == true)
            {
                cbNam.Checked = true;
            }
            else
            {
                cbNu.Checked = true;
            }
            dtNgaySinh.Value = (DateTime)dv.Cells["NgaySinh"].Value;
            cbChucVu.SelectedValue = dv.Cells["ChucVu"].Value;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
