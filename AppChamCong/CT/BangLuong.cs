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
using DAL;

namespace AppChamCong.CT
{
    public partial class BangLuong : UserControl
    {
        public BangLuong()
        {
            InitializeComponent();
        }
        BangLuong_BUL bangLuong = new BangLuong_BUL();
        private void BangLuong_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            txtNam.Text = DateTime.Now.Year.ToString();
            dataGridViewBL.DataSource = bangLuong.XemBangLuongTheoNam(Convert.ToInt32(txtNam.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportExcel excel = new ExportExcel();
            excel.Export(dataGridViewBL, @"D:\", "DanhSachBangLuong");
            MessageBox.Show("Xuất thành công!", "Thông báo");
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtThang.Text))
            {
                int thang = Convert.ToInt32(txtThang.Text);
                int nam = Convert.ToInt32(txtNam.Text);
                dataGridViewBL.DataSource = bangLuong.XemBangLuongTheoThang(thang, nam);
            }
            else
            {
                dataGridViewBL.DataSource = bangLuong.XemBangLuongTheoNam(Convert.ToInt32(txtNam.Text));
            }
        }
    }
}
