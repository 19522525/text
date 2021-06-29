
namespace QuanLySoTietKiem
{
    partial class freport
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtDay = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.BCnbutton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataDay = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtMonth = new System.Windows.Forms.DateTimePicker();
            this.cbLoaiSo = new System.Windows.Forms.ComboBox();
            this.BCTbutton2 = new System.Windows.Forms.Button();
            this.BCTbutton1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataMonth = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDay)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-4, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1057, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::QuanLySoTietKiem.Properties.Resources.hinh_nen_may_tinh_don_gian;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.dtDay);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.BCnbutton2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataDay);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1049, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NGÀY";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtDay
            // 
            this.dtDay.CustomFormat = "\"dd-MM-yyyy\"";
            this.dtDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDay.Location = new System.Drawing.Point(131, 50);
            this.dtDay.Name = "dtDay";
            this.dtDay.Size = new System.Drawing.Size(200, 30);
            this.dtDay.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(921, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BCnbutton2
            // 
            this.BCnbutton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BCnbutton2.Location = new System.Drawing.Point(717, 82);
            this.BCnbutton2.Name = "BCnbutton2";
            this.BCnbutton2.Size = new System.Drawing.Size(122, 33);
            this.BCnbutton2.TabIndex = 3;
            this.BCnbutton2.Text = "Kiểm Tra";
            this.BCnbutton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày: ";
            // 
            // dataDay
            // 
            this.dataDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDay.Location = new System.Drawing.Point(0, 121);
            this.dataDay.Name = "dataDay";
            this.dataDay.ReadOnly = true;
            this.dataDay.RowHeadersWidth = 51;
            this.dataDay.RowTemplate.Height = 24;
            this.dataDay.Size = new System.Drawing.Size(1046, 300);
            this.dataDay.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::QuanLySoTietKiem.Properties.Resources.hinh_nen_may_tinh_don_gian;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.dtMonth);
            this.tabPage2.Controls.Add(this.cbLoaiSo);
            this.tabPage2.Controls.Add(this.BCTbutton2);
            this.tabPage2.Controls.Add(this.BCTbutton1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataMonth);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1049, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "THÁNG";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtMonth
            // 
            this.dtMonth.CustomFormat = "\"MM-yyyy\"";
            this.dtMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMonth.Location = new System.Drawing.Point(124, 28);
            this.dtMonth.Name = "dtMonth";
            this.dtMonth.Size = new System.Drawing.Size(116, 30);
            this.dtMonth.TabIndex = 24;
            // 
            // cbLoaiSo
            // 
            this.cbLoaiSo.FormattingEnabled = true;
            this.cbLoaiSo.Items.AddRange(new object[] {
            "Kì hạn 3 tháng",
            "Kì hạn 6 tháng",
            "Không kỳ hạn"});
            this.cbLoaiSo.Location = new System.Drawing.Point(124, 89);
            this.cbLoaiSo.Name = "cbLoaiSo";
            this.cbLoaiSo.Size = new System.Drawing.Size(236, 30);
            this.cbLoaiSo.TabIndex = 23;
            this.cbLoaiSo.SelectedIndexChanged += new System.EventHandler(this.cbLoaiSo_SelectedIndexChanged);
            // 
            // BCTbutton2
            // 
            this.BCTbutton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BCTbutton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCTbutton2.Location = new System.Drawing.Point(914, 96);
            this.BCTbutton2.Name = "BCTbutton2";
            this.BCTbutton2.Size = new System.Drawing.Size(122, 33);
            this.BCTbutton2.TabIndex = 9;
            this.BCTbutton2.Text = "Thoát";
            this.BCTbutton2.UseVisualStyleBackColor = true;
            this.BCTbutton2.Click += new System.EventHandler(this.BCTbutton2_Click);
            // 
            // BCTbutton1
            // 
            this.BCTbutton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BCTbutton1.Location = new System.Drawing.Point(738, 96);
            this.BCTbutton1.Name = "BCTbutton1";
            this.BCTbutton1.Size = new System.Drawing.Size(122, 33);
            this.BCTbutton1.TabIndex = 8;
            this.BCTbutton1.Text = "Kiểm Tra";
            this.BCTbutton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loại Sổ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tháng: ";
            // 
            // dataMonth
            // 
            this.dataMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMonth.Location = new System.Drawing.Point(0, 153);
            this.dataMonth.Name = "dataMonth";
            this.dataMonth.ReadOnly = true;
            this.dataMonth.RowHeadersWidth = 51;
            this.dataMonth.RowTemplate.Height = 24;
            this.dataMonth.Size = new System.Drawing.Size(1049, 264);
            this.dataMonth.TabIndex = 0;
            // 
            // freport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySoTietKiem.Properties.Resources.hinh_nen_may_tinh_don_gian;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "freport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "freport";
            this.Load += new System.EventHandler(this.freport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDay)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataDay;
        private System.Windows.Forms.Button BCnbutton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BCTbutton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataMonth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BCTbutton2;
        private System.Windows.Forms.DateTimePicker dtDay;
        private System.Windows.Forms.ComboBox cbLoaiSo;
        private System.Windows.Forms.DateTimePicker dtMonth;
    }
}