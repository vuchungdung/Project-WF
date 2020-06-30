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
            this.btXem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.lbTen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbTB = new System.Windows.Forms.Label();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhongPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btXem
            // 
            this.btXem.Location = new System.Drawing.Point(706, 404);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(90, 23);
            this.btXem.TabIndex = 16;
            this.btXem.Text = "Xem";
            this.btXem.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btXem);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtThang);
            this.panel1.Controls.Add(this.lbChucVu);
            this.panel1.Controls.Add(this.txtNam);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btCapNhat);
            this.panel1.Controls.Add(this.lbTen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 431);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Xuất FIle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(582, 406);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(35, 20);
            this.txtThang.TabIndex = 11;
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucVu.ForeColor = System.Drawing.Color.White;
            this.lbChucVu.Location = new System.Drawing.Point(97, 112);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(59, 13);
            this.lbChucVu.TabIndex = 8;
            this.lbChucVu.Text = "Chức Vụ:";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(631, 406);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(69, 20);
            this.txtNam.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Chức Vụ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(617, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(461, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bảng lương theo tháng";
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(615, 110);
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
            this.lbTen.Location = new System.Drawing.Point(100, 79);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(41, 13);
            this.lbTen.TabIndex = 2;
            this.lbTen.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 79);
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
            this.label1.Location = new System.Drawing.Point(212, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bảng Lương Nhân Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.TenNV,
            this.NgayLuong,
            this.SNL,
            this.KhongPhep,
            this.CoPhep,
            this.TL});
            this.dataGridView1.Location = new System.Drawing.Point(0, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(796, 255);
            this.dataGridView1.TabIndex = 0;
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
            // Ma
            // 
            this.Ma.DataPropertyName = "MaNhanVien";
            this.Ma.HeaderText = "Mã Nhân Viên";
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
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
            // SNL
            // 
            this.SNL.DataPropertyName = "NL";
            this.SNL.HeaderText = "Số Ngày Làm";
            this.SNL.Name = "SNL";
            this.SNL.ReadOnly = true;
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
            // TL
            // 
            this.TL.DataPropertyName = "TL";
            this.TL.HeaderText = "Tổng Lương";
            this.TL.Name = "TL";
            this.TL.ReadOnly = true;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhongPhep;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoPhep;
        private System.Windows.Forms.DataGridViewTextBoxColumn TL;
    }
}
