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
        public TinhLuong()
        {
            InitializeComponent();
        }
        public void LoadTinhLuong()
        {
            dataGridViewTL.DataSource = tinhLuong.LoadTinhLuong();
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
    }
}
