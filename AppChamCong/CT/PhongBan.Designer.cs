﻿namespace AppChamCong.CT
{
    partial class PhongBan
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MaPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lbSoNV = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(20, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 231);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPB,
            this.TenPB,
            this.SoNV});
            this.dataGridView2.Location = new System.Drawing.Point(0, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(788, 228);
            this.dataGridView2.TabIndex = 0;
            // 
            // MaPB
            // 
            this.MaPB.DataPropertyName = "MaPB";
            this.MaPB.FillWeight = 150F;
            this.MaPB.HeaderText = "Mã Phòng Ban";
            this.MaPB.Name = "MaPB";
            this.MaPB.ReadOnly = true;
            // 
            // TenPB
            // 
            this.TenPB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPB.DataPropertyName = "TenPB";
            this.TenPB.HeaderText = "Tên Phòng Ban";
            this.TenPB.Name = "TenPB";
            this.TenPB.ReadOnly = true;
            // 
            // SoNV
            // 
            this.SoNV.DataPropertyName = "SoNV";
            this.SoNV.FillWeight = 150F;
            this.SoNV.HeaderText = "Số Nhân Vên";
            this.SoNV.Name = "SoNV";
            this.SoNV.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaPB);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.lbSoNV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(20, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 163);
            this.panel1.TabIndex = 2;
            // 
            // txtMaPB
            // 
            this.txtMaPB.Location = new System.Drawing.Point(125, 65);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(244, 20);
            this.txtMaPB.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(125, 103);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(244, 20);
            this.txtTen.TabIndex = 2;
            // 
            // lbSoNV
            // 
            this.lbSoNV.AutoSize = true;
            this.lbSoNV.ForeColor = System.Drawing.Color.White;
            this.lbSoNV.Location = new System.Drawing.Point(541, 68);
            this.lbSoNV.Name = "lbSoNV";
            this.lbSoNV.Size = new System.Drawing.Size(0, 13);
            this.lbSoNV.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(459, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(308, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "PHÒNG BAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Phòng Ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Phòng Ban";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(711, 137);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(591, 137);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(476, 137);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(365, 137);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PhongBan";
            this.Size = new System.Drawing.Size(830, 487);
            this.Load += new System.EventHandler(this.PhongBan_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lbSoNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
    }
}
