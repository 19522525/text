﻿
namespace QuanLySoTietKiem
{
    partial class finformation
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaSo = new System.Windows.Forms.TextBox();
            this.TTSbutton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTenChuSo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLoaiSo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSoDu = new System.Windows.Forms.TextBox();
            this.TTSbutton2 = new System.Windows.Forms.Button();
            this.TTSbutton3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTenNV = new System.Windows.Forms.TextBox();
            this.TTSbutton4 = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 284);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sổ: ";
            // 
            // tbMaSo
            // 
            this.tbMaSo.Location = new System.Drawing.Point(131, 62);
            this.tbMaSo.Name = "tbMaSo";
            this.tbMaSo.ReadOnly = true;
            this.tbMaSo.Size = new System.Drawing.Size(100, 22);
            this.tbMaSo.TabIndex = 2;
            // 
            // TTSbutton1
            // 
            this.TTSbutton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTSbutton1.Location = new System.Drawing.Point(306, 9);
            this.TTSbutton1.Name = "TTSbutton1";
            this.TTSbutton1.Size = new System.Drawing.Size(112, 30);
            this.TTSbutton1.TabIndex = 3;
            this.TTSbutton1.Text = "Tìm Kiếm";
            this.TTSbutton1.UseVisualStyleBackColor = true;
            this.TTSbutton1.Click += new System.EventHandler(this.TTSbutton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thông Tin: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Chủ Sổ: ";
            // 
            // tbTenChuSo
            // 
            this.tbTenChuSo.Location = new System.Drawing.Point(131, 121);
            this.tbTenChuSo.Name = "tbTenChuSo";
            this.tbTenChuSo.Size = new System.Drawing.Size(184, 22);
            this.tbTenChuSo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loại Sổ: ";
            // 
            // tbLoaiSo
            // 
            this.tbLoaiSo.Location = new System.Drawing.Point(131, 183);
            this.tbLoaiSo.Name = "tbLoaiSo";
            this.tbLoaiSo.Size = new System.Drawing.Size(184, 22);
            this.tbLoaiSo.TabIndex = 8;
            this.tbLoaiSo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(421, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số Dư Tài khoản: ";
            // 
            // tbSoDu
            // 
            this.tbSoDu.Location = new System.Drawing.Point(582, 183);
            this.tbSoDu.Name = "tbSoDu";
            this.tbSoDu.ReadOnly = true;
            this.tbSoDu.Size = new System.Drawing.Size(139, 22);
            this.tbSoDu.TabIndex = 10;
            // 
            // TTSbutton2
            // 
            this.TTSbutton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTSbutton2.Location = new System.Drawing.Point(373, 265);
            this.TTSbutton2.Name = "TTSbutton2";
            this.TTSbutton2.Size = new System.Drawing.Size(112, 30);
            this.TTSbutton2.TabIndex = 11;
            this.TTSbutton2.Text = "Sửa";
            this.TTSbutton2.UseVisualStyleBackColor = true;
            // 
            // TTSbutton3
            // 
            this.TTSbutton3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTSbutton3.Location = new System.Drawing.Point(511, 266);
            this.TTSbutton3.Name = "TTSbutton3";
            this.TTSbutton3.Size = new System.Drawing.Size(112, 30);
            this.TTSbutton3.TabIndex = 12;
            this.TTSbutton3.Text = "Xóa";
            this.TTSbutton3.UseVisualStyleBackColor = true;
            this.TTSbutton3.Click += new System.EventHandler(this.TTSbutton3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(421, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "NV Mở Sổ: ";
            // 
            // tbTenNV
            // 
            this.tbTenNV.Location = new System.Drawing.Point(582, 121);
            this.tbTenNV.Name = "tbTenNV";
            this.tbTenNV.Size = new System.Drawing.Size(139, 22);
            this.tbTenNV.TabIndex = 14;
            // 
            // TTSbutton4
            // 
            this.TTSbutton4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTSbutton4.Location = new System.Drawing.Point(646, 265);
            this.TTSbutton4.Name = "TTSbutton4";
            this.TTSbutton4.Size = new System.Drawing.Size(112, 30);
            this.TTSbutton4.TabIndex = 15;
            this.TTSbutton4.Text = "Thoát";
            this.TTSbutton4.UseVisualStyleBackColor = true;
            this.TTSbutton4.Click += new System.EventHandler(this.TTSbutton4_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(131, 13);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(151, 22);
            this.tbSearch.TabIndex = 16;
            // 
            // finformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySoTietKiem.Properties.Resources.hinh_nen_may_tinh_don_gian;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.TTSbutton4);
            this.Controls.Add(this.tbTenNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TTSbutton3);
            this.Controls.Add(this.TTSbutton2);
            this.Controls.Add(this.tbSoDu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbLoaiSo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTenChuSo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TTSbutton1);
            this.Controls.Add(this.tbMaSo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "finformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN SỔ";
            this.Load += new System.EventHandler(this.finformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaSo;
        private System.Windows.Forms.Button TTSbutton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTenChuSo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLoaiSo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSoDu;
        private System.Windows.Forms.Button TTSbutton2;
        private System.Windows.Forms.Button TTSbutton3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTenNV;
        private System.Windows.Forms.Button TTSbutton4;
        private System.Windows.Forms.TextBox tbSearch;
    }
}