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
    public partial class TheoDoiChamCong : UserControl
    {
        public TheoDoiChamCong()
        {
            InitializeComponent();
        }
        ChamCong_BUL ChamCong = new ChamCong_BUL();
        private void TheoDoiChamCong_Load(object sender, EventArgs e)
        {
            comboBox2.Text = DateTime.Now.Year.ToString();
            LoadTheoDoi();
        }
        public void LoadTheoDoi()
        {
            comboBox1.Text = "All";
            dataGridView1.DataSource = ChamCong.TheoDoiChamCong(MaNhanVien.MANHANVIEN,DateTime.Now.Year);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text =="All")
            {
                dataGridView1.DataSource = ChamCong.TheoDoiChamCong(MaNhanVien.MANHANVIEN, Convert.ToInt32(comboBox2.SelectedItem));
            }
            else
            {
                dataGridView1.DataSource = ChamCong.TheoDoiChamCong2(MaNhanVien.MANHANVIEN, Convert.ToInt32(comboBox1.SelectedItem),Convert.ToInt32(comboBox2.SelectedItem));
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ChamCong.TheoDoiChamCong(MaNhanVien.MANHANVIEN, Convert.ToInt32(comboBox2.SelectedItem));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportExcel excel = new ExportExcel();
            excel.Export(dataGridView1, @"D:\", "DanhSachChamCong");
            MessageBox.Show("Xuất thành công!", "Thông báo");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
