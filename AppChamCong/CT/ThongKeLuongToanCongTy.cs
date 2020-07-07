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
using AppChamCong.CommonService;

namespace AppChamCong.CT
{
    public partial class ThongKeLuongToanCongTy : UserControl
    {
        public ThongKeLuongToanCongTy()
        {
            InitializeComponent();
        }
        BangLuong_BUL bangLuong = new BangLuong_BUL();
        public void LoadData()
        {
            comboBox2.Text = DateTime.Now.Year.ToString();
            dataGridView1.DataSource = bangLuong.ThongKeLuongToanCongTy(Convert.ToInt32(comboBox2.SelectedItem));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ThongKeLuongToanCongTy_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportExcel excel = new ExportExcel();
            excel.Export(dataGridView1, @"D:\", "DanhSachBangLuongCongTy");
            MessageBox.Show("Xuất thành công!", "Thông báo");
        }
    }
}
