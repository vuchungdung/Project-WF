namespace AppChamCong.CT
{
    partial class BangLuong
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
            this.btXem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewBL = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhongPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btXem);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtThang);
            this.panel1.Controls.Add(this.txtNam);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewBL);
            this.panel1.Location = new System.Drawing.Point(14, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 431);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Xuất FIle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(582, 406);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(35, 20);
            this.txtThang.TabIndex = 11;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(631, 406);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(69, 20);
            this.txtNam.TabIndex = 12;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(250, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bảng Lương Nhân Viên";
            // 
            // dataGridViewBL
            // 
            this.dataGridViewBL.AllowUserToAddRows = false;
            this.dataGridViewBL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewBL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.NgayLuong,
            this.DiLam,
            this.KhongPhep,
            this.CoPhep,
            this.Thang,
            this.Nam,
            this.TongLuong});
            this.dataGridViewBL.Location = new System.Drawing.Point(0, 55);
            this.dataGridViewBL.Name = "dataGridViewBL";
            this.dataGridViewBL.ReadOnly = true;
            this.dataGridViewBL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBL.Size = new System.Drawing.Size(799, 351);
            this.dataGridViewBL.TabIndex = 0;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 92;
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
            this.NgayLuong.Width = 83;
            // 
            // DiLam
            // 
            this.DiLam.DataPropertyName = "DiLam";
            this.DiLam.HeaderText = "Số Ngày Làm";
            this.DiLam.Name = "DiLam";
            this.DiLam.ReadOnly = true;
            this.DiLam.Width = 70;
            // 
            // KhongPhep
            // 
            this.KhongPhep.DataPropertyName = "KhongPhep";
            this.KhongPhep.HeaderText = "Nghỉ Không Phép";
            this.KhongPhep.Name = "KhongPhep";
            this.KhongPhep.ReadOnly = true;
            this.KhongPhep.Width = 84;
            // 
            // CoPhep
            // 
            this.CoPhep.DataPropertyName = "CoPhep";
            this.CoPhep.HeaderText = "Nghỉ Có Phép";
            this.CoPhep.Name = "CoPhep";
            this.CoPhep.ReadOnly = true;
            this.CoPhep.Width = 68;
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Tháng";
            this.Thang.Name = "Thang";
            this.Thang.ReadOnly = true;
            this.Thang.Width = 63;
            // 
            // Nam
            // 
            this.Nam.DataPropertyName = "Nam";
            this.Nam.HeaderText = "Năm";
            this.Nam.Name = "Nam";
            this.Nam.ReadOnly = true;
            this.Nam.Width = 54;
            // 
            // TongLuong
            // 
            this.TongLuong.DataPropertyName = "TongLuong";
            this.TongLuong.HeaderText = "Tổng Lương";
            this.TongLuong.Name = "TongLuong";
            this.TongLuong.ReadOnly = true;
            this.TongLuong.Width = 83;
            // 
            // BangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.panel1);
            this.Name = "BangLuong";
            this.Size = new System.Drawing.Size(827, 471);
            this.Load += new System.EventHandler(this.BangLuong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhongPhep;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoPhep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongLuong;
    }
}
