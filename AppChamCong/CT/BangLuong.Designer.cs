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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btXem);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtThang);
            this.panel1.Controls.Add(this.txtNam);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(14, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 431);
            this.panel1.TabIndex = 11;
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(796, 351);
            this.dataGridView1.TabIndex = 0;
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
            // BangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.panel1);
            this.Name = "BangLuong";
            this.Size = new System.Drawing.Size(827, 471);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhongPhep;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoPhep;
        private System.Windows.Forms.DataGridViewTextBoxColumn TL;
    }
}
