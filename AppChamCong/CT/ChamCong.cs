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
        private void btCapNhat_Click(object sender, EventArgs e)
        {
            int d = 0;
            int c = 0;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (dataGridView2.Rows[i].Cells["TinhTrang"].Value == null)
                {
                    dataGridView2.Rows[i].Cells["TinhTrang"].Selected = true;
                    d = 0;
                }
                else d++;
            }
            if (d == dataGridView2.RowCount)
            {
                
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    ChamCong_DTO cc = new ChamCong_DTO();
                    string tinhtrang = dataGridView2.Rows[i].Cells["TinhTrang"].Value.ToString();
                    cc.MaNV = dataGridView2.Rows[i].Cells["MaNV"].Value.ToString();
                    cc.Ngay = dtpNgay.Value;
                    cc.TinhTrang = dataGridView2.Rows[i].Cells["TinhTrang"].Value.ToString();
                    if (chamCong.ThemChamCong(cc) == true)
                    {
                        c++;
                    }
                    else
                    {
                        c = 0;
                    }
                }
                if (c == 0)
                {
                    MessageBox.Show("Hôm nay đã chấm công!", "Lỗi");
                }
                else
                {
                    MessageBox.Show("Đã chấm công", "Thông Báo");
                }
            }
            else
            {
                MessageBox.Show("Thông tin chưa đầy đủ!", "Thông Báo");
            }
        }

        private void ChamCong_Load(object sender, EventArgs e)
        {
            LoadDataChamCong();
        }
        public void LoadDataChamCong()
        {
            DateTime date = dtpNgay.Value;
            dataGridView2.DataSource = typeof(List<ChamCong_DTO_View>);
            dataGridView2.DataSource = chamCong.LoadChamCong();
        }

        private void cbCC_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCC.Checked == true)
                for (int i = 0; i < dataGridView2.RowCount; i++)
                    dataGridView2.Rows[i].Cells["TinhTrang"].Value = "Đi Làm";
            else
                for (int i = 0; i < dataGridView2.RowCount; i++)
                    dataGridView2.Rows[i].Cells["TinhTrang"].Value = "";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                lbMa.Text = dataGridView2.CurrentRow.Cells["MaNV"].Value.ToString();
                lbTen.Text = dataGridView2.CurrentRow.Cells["HoTen"].Value.ToString();
                if(dataGridView2.CurrentRow.Cells["TinhTrang"].Value == null)
                {
                    lbTinhTrang.Text = "";
                }
                else
                {
                    lbTinhTrang.Text = dataGridView2.CurrentRow.Cells["TinhTrang"].Value.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChamCong_DTO cc = new ChamCong_DTO();
            cc.MaNV = lbMa.Text;
            cc.Ngay = dtpNgay.Value;
            cc.TinhTrang = lbTinhTrang.Text;
            if(chamCong.SuaChamCong(cc) == true)
            {
                MessageBox.Show("Sửa thành công!", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Thông Báo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult R = MessageBox.Show("BẠN CÓ THỰC SỰ MUỐN XÓA", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                if (R == DialogResult.Yes)
                {
                    DateTime ngay = dtpNgay.Value;
                    if (chamCong.XoaChamCong(ngay) == true)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông Báo");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông Báo");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
