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
                dataGridViewTL.Rows[i].Cells["TongLuong"].Value = TinhLuongNV(manv);
            }
        }

        private void TinhLuong_Load(object sender, EventArgs e)
        {
            LoadTinhLuong();
        }
        public int TinhLuongNV(string manv)
        {
            int result = 1000000;
            return result;
        }
    }
}
