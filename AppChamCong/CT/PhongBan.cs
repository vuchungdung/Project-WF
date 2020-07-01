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
    public partial class PhongBan : UserControl
    {
        public PhongBan()
        {
            InitializeComponent();
        }
        public PhongBan_BUL phongBan = new PhongBan_BUL();
        public void LoadData()
        {
            dataGridView2.DataSource = typeof(List<PhongBan_DTO_View>);
            dataGridView2.DataSource = phongBan.LoadPB();
        }

        private void PhongBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
