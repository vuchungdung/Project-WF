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
    public partial class ChamCong : UserControl
    {
        public ChamCong()
        {
            InitializeComponent();
        }
        ChamCong_BUL chamCong = new ChamCong_BUL();
        int ngay = DateTime.Now.Day, thang = DateTime.Now.Month, nam = DateTime.Now.Year, dem = 0;
        string manv = null, a = null, b = null;
        private void btCapNhat_Click(object sender, EventArgs e)
        {
            int d = 0;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (dataGridView2.Rows[i].Cells["TinhTrang"].Value == null)
                {
                    dataGridView2.Rows[i].Cells["TinhTrang"].Selected = true;
                    d = 0;
                }
                else d++;
            }
            if (d != 0)
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    string tinhtrang = dataGridView2.Rows[i].Cells["TinhTrang"].Value.ToString();
                    manv = dataGridView2.Rows[i].Cells["Ma"].Value.ToString();
                    
                }
                
            }
        }


        private void ChamCong_Load(object sender, EventArgs e)
        {
            LoadDataChamCong();
        }
        public void LoadDataChamCong()
        {
            dataGridView2.DataSource = typeof(List<ChamCong_DTO_View>);
            dataGridView2.DataSource = chamCong.LoadChamCong();
        }
    }
}
