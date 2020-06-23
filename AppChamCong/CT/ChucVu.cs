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
        private void ChucVu_Load(object sender, EventArgs e)
        {
            LoadDataNhanVien();
        }
        public void LoadDataNhanVien()
        {
            dataGridView1.DataSource = typeof(List<ChucVu_DTO>);
            dataGridView1.DataSource = chucVu.LoadChucVu();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
