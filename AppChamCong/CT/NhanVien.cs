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
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        NhanVien_BUL nhanVien = new NhanVien_BUL();
        ChucVu_BUL chucVu = new ChucVu_BUL();
        PhongBan_BUL phongban = new PhongBan_BUL();
        List<ChucVu_DTO> listCV = new List<ChucVu_DTO>();
        List<PhongBan_DTO> listPB = new List<PhongBan_DTO>();
        List<NhanVien_DTO> listNV = new List<NhanVien_DTO>();

        public void ResetValueText()
        {
            txtMaNV.ReadOnly = false;
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            cbNam.Checked = true;
        }
        public void LoadDataNhanVien()
        {
            dataGridViewNV.DataSource = typeof(List<NhanVien_DTO>);
            dataGridViewNV.DataSource = nhanVien.LoadNhanVien();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            listCV = chucVu.LoadChucVu();
            cbChucVu.DataSource = listCV;
            cbChucVu.DisplayMember = "TenChucVu";
            cbChucVu.ValueMember = "MaChucVu";
            listPB = phongban.LoadAllPB();
            comboBox1.DataSource = listPB;
            comboBox1.DisplayMember = "TenPB";
            comboBox1.ValueMember = "MaPB";
            LoadDataNhanVien();
        }

        private void dataGridViewNV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.ReadOnly = true;
            DataGridViewRow dv = dataGridViewNV.SelectedRows[0];
            txtMaNV.Text = dv.Cells["MaNhanVien"].Value.ToString();
            txtHoTen.Text = dv.Cells["HoTen"].Value.ToString();
            txtSDT.Text = dv.Cells["SoDienThoai"].Value.ToString();
            txtDiaChi.Text = dv.Cells["DiaChi"].Value.ToString();
            if ((bool)dv.Cells["GioiTinh"].Value == true)
            {
                cbNam.Checked = true;
            }
            else
            {
                cbNu.Checked = true;
            }
            dtNgaySinh.Value = (DateTime)dv.Cells["NgaySinh"].Value;
            cbChucVu.SelectedValue = dv.Cells["ChucVu"].Value;
            comboBox1.SelectedValue = dv.Cells["PhongBan"].Value;
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            ResetValueText();
            LoadDataNhanVien();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.MaNhanVien = txtMaNV.Text;
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
            nv.PhongBan = comboBox1.SelectedValue.ToString();
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

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult R = MessageBox.Show("BẠN CÓ THỰC SỰ MUỐN XÓA", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                if (R == DialogResult.Yes)
                {
                    if (dataGridViewNV.SelectedRows != null)
                    {
                        string manv = dataGridViewNV.SelectedRows[0].Cells[0].Value.ToString();
                        if (nhanVien.DeleteNhanVien(manv) == true)
                        {
                            LoadDataNhanVien();
                            MessageBox.Show("Xóa thành công!", "Thông Báo");
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại!", "Thông Báo");
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.MaNhanVien = txtMaNV.Text;
            nv.HoTen = txtHoTen.Text;
            if(cbNam.Checked == true)
            {
                nv.GioiTinh = true;
            }
            else
            {
                nv.GioiTinh = false;
            }
            nv.NgaySinh = dtNgaySinh.Value.Date;
            nv.SoDienThoai = txtSDT.Text;
            nv.ChucVu = cbChucVu.SelectedValue.ToString();
            nv.PhongBan = comboBox1.SelectedValue.ToString();
            nv.DiaChi = txtDiaChi.Text;
            nhanVien.UpdateNhanVien(nv);
            LoadDataNhanVien();
            ResetValueText();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string keyword = comboBox1.SelectedValue.ToString();
                dataGridViewNV.DataSource = typeof(List<NhanVien_DTO>);
                dataGridViewNV.DataSource = nhanVien.LoadNhanVienTheoPB(keyword);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
