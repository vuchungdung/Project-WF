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
    public partial class ThongKeLuongCaNhan : UserControl
    {
        public ThongKeLuongCaNhan()
        {
            InitializeComponent();
        }
        BangLuong_BUL bangLuong = new BangLuong_BUL();
        private void ThongKeLuongCaNhan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            comboBox2.Text = DateTime.Now.Year.ToString();
            dataGridView1.DataSource = bangLuong.ThongKeLuongCaNhan(MaNhanVien.MANHANVIEN,Convert.ToInt32(comboBox2.SelectedItem));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportExcel excel = new ExportExcel();
            excel.Export(dataGridView1, @"D:\", "DanhSachLuongCaNhan");
            MessageBox.Show("Xuất thành công!", "Thông báo");
        }
    }
}
