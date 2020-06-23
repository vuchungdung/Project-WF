using BUL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChamCong
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        TaiKhoan_BUL taiKhoan_BUL = new TaiKhoan_BUL();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtTaiKhoan.Text;
            string pass = txtMatKhau.Text;
            if(taiKhoan_BUL.DangNhap(user,pass) == true)
            {
                this.Hide();
                Form1 f = new Form1();
                f.Show();
            }
        }
    }
}
