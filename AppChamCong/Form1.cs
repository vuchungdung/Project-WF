using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChamCong
{
    public partial class QuanLyNhanVien : Form
    {
        NhanVien_BUL nhanVien = new NhanVien_BUL();
        TrinhDo_BUL trinhDo = new TrinhDo_BUL();
        List<TrinhDo_DTO> listTD = new List<TrinhDo_DTO>();
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            listTD = trinhDo.LoadTrinhDo();
            txtTrinhDo.DataSource = listTD;
            txtTrinhDo.DisplayMember = "TenTrinhDo";
            txtTrinhDo.ValueMember = "MaTrinhDo";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
