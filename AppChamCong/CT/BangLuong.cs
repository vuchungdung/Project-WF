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

namespace AppChamCong.CT
{
    public partial class BangLuong : UserControl
    {
        public BangLuong()
        {
            InitializeComponent();
        }
        BangLuong_BUL bangLuong = new BangLuong_BUL();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

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
            // Lấy về nguồn dữ liệu cần Export là 1 DataTable
            // DataTable này mỗi bạn lấy mỗi khác. 
            // Ở đây tôi dùng BindingSouce có tên bs nên tôi ép kiểu như sau:
            // Bạn nào gán trực tiếp vào DataGridView thì ép kiểu DataSource của
            // DataGridView nhé 
            DataTable dt = new DataTable();
            dt = dataGridViewBL.DataSource as DataTable;
            excel.Export(dt, "Danh sach", "DANH SÁCH BẢNG LƯƠNG");
        }
    }
}
