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
    public partial class ChucVu : UserControl
    {
        public ChucVu()
        {
            InitializeComponent();
        }
        ChucVu_BUL chucVu = new ChucVu_BUL();
        List<ChucVu_DTO> listCV = new List<ChucVu_DTO>();
        private void ChucVu_Load(object sender, EventArgs e)
        {
            LoadDataChucVu();
        }
        public void LoadDataChucVu()
        {
            dataGridView1.DataSource = typeof(List<ChucVu_DTO>);
            dataGridView1.DataSource = chucVu.LoadChucVu();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValueText();
            LoadDataChucVu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ChucVu_DTO cv = new ChucVu_DTO();
            cv.MaChucVu = txtMaCV.Text;
            cv.TenChucVu = txtTenCV.Text;
            cv.NgayLuong = Convert.ToInt32(textBox1.Text);
            if (chucVu.ThemChucVu(cv) == true)
            {
                listCV.Add(cv);
                LoadDataChucVu();
                ResetValueText();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ChucVu_DTO cv = new ChucVu_DTO();
            cv.MaChucVu = txtMaCV.Text;
            cv.TenChucVu = txtTenCV.Text;
            cv.NgayLuong = Convert.ToInt32(textBox1.Text);
            chucVu.SuaChucVu(cv);
            LoadDataChucVu();
        }

        public void ResetValueText()
        {
            txtMaCV.ReadOnly = false;
            txtMaCV.Clear();
            txtTenCV.Clear();
            textBox1.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCV.ReadOnly = true;
            DataGridViewRow dv = dataGridView1.SelectedRows[0];
            txtMaCV.Text = dv.Cells["MaChucVu"].Value.ToString();
            txtTenCV.Text = dv.Cells["TenChucVu"].Value.ToString();
            textBox1.Text = dv.Cells["NgayLuong"].Value.ToString();
        }
    }
}
