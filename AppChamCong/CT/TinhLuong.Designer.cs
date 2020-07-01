namespace AppChamCong.CT
{
    partial class TinhLuong
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.lbTen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTL = new System.Windows.Forms.DataGridView();
            this.lbTB = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhongPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbChucVu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btCapNhat);
            this.panel1.Controls.Add(this.lbTen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewTL);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 439);
            this.panel1.TabIndex = 10;
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucVu.ForeColor = System.Drawing.Color.White;
            this.lbChucVu.Location = new System.Drawing.Point(88, 85);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(55, 13);
            this.lbChucVu.TabIndex = 8;
            this.lbChucVu.Text = "Chức Vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Chức Vụ:";
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(615, 85);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(181, 28);
            this.btCapNhat.TabIndex = 4;
            this.btCapNhat.Text = "Cập Nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.ForeColor = System.Drawing.Color.White;
            this.lbTen.Location = new System.Drawing.Point(106, 52);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(41, 13);
            this.lbTen.TabIndex = 2;
            this.lbTen.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhân Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(221, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tính Lương Nhân Viên";
            // 
            // dataGridViewTL
            // 
            this.dataGridViewTL.AllowUserToAddRows = false;
            this.dataGridViewTL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.NgayLuong,
            this.DiLam,
            this.KhongPhep,
            this.CoPhep,
            this.Thang,
            this.TongLuong});
            this.dataGridViewTL.Location = new System.Drawing.Point(0, 119);
            this.dataGridViewTL.Name = "dataGridViewTL";
            this.dataGridViewTL.ReadOnly = true;
            this.dataGridViewTL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTL.Size = new System.Drawing.Size(796, 320);
            this.dataGridViewTL.TabIndex = 0;
            // 
            // lbTB
            // 
            this.lbTB.AutoSize = true;
            this.lbTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTB.ForeColor = System.Drawing.Color.Red;
            this.lbTB.Location = new System.Drawing.Point(477, 454);
            this.lbTB.Name = "lbTB";
            this.lbTB.Size = new System.Drawing.Size(10, 13);
            this.lbTB.TabIndex = 14;
            this.lbTB.Text = ".";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // NgayLuong
            // 
            this.NgayLuong.DataPropertyName = "NgayLuong";
            this.NgayLuong.HeaderText = "Ngày Lương";
            this.NgayLuong.Name = "NgayLuong";
            this.NgayLuong.ReadOnly = true;
            // 
            // DiLam
            // 
            this.DiLam.DataPropertyName = "DiLam";
            this.DiLam.HeaderText = "Số Ngày Làm";
            this.DiLam.Name = "DiLam";
            this.DiLam.ReadOnly = true;
            // 
            // KhongPhep
            // 
            this.KhongPhep.DataPropertyName = "KhongPhep";
            this.KhongPhep.HeaderText = "Nghỉ Không Phép";
            this.KhongPhep.Name = "KhongPhep";
            this.KhongPhep.ReadOnly = true;
            // 
            // CoPhep
            // 
            this.CoPhep.DataPropertyName = "CoPhep";
            this.CoPhep.HeaderText = "Nghỉ Có Phép";
            this.CoPhep.Name = "CoPhep";
            this.CoPhep.ReadOnly = true;
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Tháng";
            this.Thang.Name = "Thang";
            this.Thang.ReadOnly = true;
            // 
            // TongLuong
            // 
            this.TongLuong.DataPropertyName = "TongLuong";
            this.TongLuong.HeaderText = "Tổng Lương";
            this.TongLuong.Name = "TongLuong";
            this.TongLuong.ReadOnly = true;
            // 
            // TinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTB);
            this.Name = "TinhLuong";
            this.Size = new System.Drawing.Size(833, 477);
            this.Load += new System.EventHandler(this.TinhLuong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTL;
        private System.Windows.Forms.Label lbTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhongPhep;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoPhep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongLuong;
    }
}
