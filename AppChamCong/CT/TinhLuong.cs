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
    public partial class TinhLuong : UserControl
    {
        TinhLuong_BUL tinhLuong = new TinhLuong_BUL();
        NhanVien_BUL nhanVien = new NhanVien_BUL();
        public TinhLuong()
        {
            InitializeComponent();
        }
        public void LoadTinhLuong()
        {
            label4.Text = DateTime.Now.Month.ToString();
            dataGridViewTL.DataSource = tinhLuong.LoadTinhLuong(DateTime.Now.Month);
            for (int i = 0; i < dataGridViewTL.RowCount; i++)
            {
                string manv = dataGridViewTL.Rows[i].Cells["MaNV"].Value.ToString();
                dataGridViewTL.Rows[i].Cells["TongLuong"].Value = TinhLuongNV(manv,i);
            }
        }

        private void TinhLuong_Load(object sender, EventArgs e)
        {
            LoadTinhLuong();
        }
        public int TinhLuongNV(string manv,int i)
        {
            int songaydilam = Convert.ToInt32(dataGridViewTL.Rows[i].Cells["DiLam"].Value);
            int ngayluong = Convert.ToInt32(dataGridViewTL.Rows[i].Cells["NgayLuong"].Value);
            int nghicophep = Convert.ToInt32(dataGridViewTL.Rows[i].Cells["CoPhep"].Value);
            int result = (songaydilam * ngayluong) + nghicophep * (ngayluong / 2);
            return result;
        }
        
        private void btCapNhat_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Bạn muốn tiến hành tính lương ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (R == DialogResult.Yes)
            {
                BangLuong_DTO bangLuong = new BangLuong_DTO();
                int count = 0;
                for (int i = 0; i < dataGridViewTL.RowCount; i++)
                {
                    bangLuong.MaNV = dataGridViewTL.Rows[i].Cells["MaNV"].Value.ToString();
                    bangLuong.TenNV = dataGridViewTL.Rows[i].Cells["TenNV"].Value.ToString();
                    bangLuong.NgayLuong = Convert.ToInt32(dataGridViewTL.Rows[i].Cells["NgayLuong"].Value);
                    bangLuong.Thang = Convert.ToInt32(dataGridViewTL.Rows[i].Cells["Thang"].Value);
                    bangLuong.DiLam = Convert.ToInt32(dataGridViewTL.Rows[i].Cells["DiLam"].Value);
                    bangLuong.CoPhep = Convert.ToInt32(dataGridViewTL.Rows[i].Cells["CoPhep"].Value);
                    bangLuong.KhongPhep = Convert.ToInt32(dataGridViewTL.Rows[i].Cells["KhongPhep"].Value);
                    bangLuong.TongLuong = Convert.ToInt32(dataGridViewTL.Rows[i].Cells["TongLuong"].Value);
                    bangLuong.Nam = DateTime.Now.Year;
                    if (tinhLuong.ThemBangLuong(bangLuong) == true)
                    {
                        count++;
                    }
                }
                if (count == dataGridViewTL.RowCount)
                {
                    MessageBox.Show("Thêm bảng lương thành công!","Thông Báo");
                }
                else
                {
                    MessageBox.Show("Tháng lương đã tồn tại!","Lỗi");
                }
            }           
        }

        private void dataGridViewTL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dataGridViewTL.SelectedRows[0];
            lbTen.Text = dgv.Cells["TenNV"].Value.ToString();
            lbChucVu.Text = nhanVien.LayChucVu(dgv.Cells["MaNV"].Value.ToString());
        }
    }
}
