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
        List<PhongBan_DTO> listPB = new List<PhongBan_DTO>();
        public void LoadData()
        {
            dataGridViewPB.DataSource = typeof(List<PhongBan_DTO_View>);
            dataGridViewPB.DataSource = phongBan.LoadPB();
        }
        public void LoadData2()
        {
            dataGridViewPB2.DataSource = typeof(List<PhongBan_DTO>);
            dataGridViewPB2.DataSource = phongBan.LoadPBChuaNV();
        }
        private void PhongBan_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadData2();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PhongBan_DTO pb = new PhongBan_DTO();
            pb.MaPB = txtMaPB.Text;
            pb.TenPB = txtTen.Text;
            if (phongBan.ThemPhongBan(pb) == true)
            {
                listPB.Add(pb);
                LoadData2();
                ResetValueText();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
        }
        public void ResetValueText()
        {
            txtMaPB.ReadOnly = false;
            txtMaPB.Clear();
            txtTen.Clear();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            PhongBan_DTO pb = new PhongBan_DTO();
            pb.MaPB = txtMaPB.Text;
            pb.TenPB = txtTen.Text;
            phongBan.SuaPhongBan(pb);
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult R = MessageBox.Show("BẠN CÓ THỰC SỰ MUỐN XÓA", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                if (R == DialogResult.Yes)
                {
                    if (dataGridViewPB.SelectedRows != null)
                    {
                        string mapb = dataGridViewPB.SelectedRows[0].Cells[0].Value.ToString();
                        int sonv = Convert.ToInt32(dataGridViewPB.SelectedRows[0].Cells[2].Value);
                        if(sonv == 0)
                        {
                            phongBan.XoaPhongBan(mapb);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Phong ban này có nhân viên! Không thể xóa","Thông Báo");
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPB.ReadOnly = true;
            DataGridViewRow pb = dataGridViewPB.SelectedRows[0];
            txtMaPB.Text = pb.Cells["MaPB"].Value.ToString();
            txtTen.Text = pb.Cells["TenPB"].Value.ToString();
            lbSoNV.Text = pb.Cells["SoNV"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaPB.ReadOnly = false;
            txtMaPB.Clear();
            txtTen.Clear();
            lbSoNV.Text = null;
        }

    }
}
