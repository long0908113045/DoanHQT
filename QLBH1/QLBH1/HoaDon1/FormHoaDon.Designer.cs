namespace QLBH1.HoaDon1
{
    partial class FormHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTrangThai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonThemHD = new System.Windows.Forms.Button();
            this.buttonHuyHD = new System.Windows.Forms.Button();
            this.buttonLuuHD = new System.Windows.Forms.Button();
            this.dataGridViewHD = new System.Windows.Forms.DataGridView();
            this.comboBoxMaKH = new System.Windows.Forms.ComboBox();
            this.comboBoxMaSP = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDonGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.textBoxThanhTien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ThemChiTiet = new System.Windows.Forms.Button();
            this.XoaChiTiet = new System.Windows.Forms.Button();
            this.dataGridViewCTHD = new System.Windows.Forms.DataGridView();
            this.LabelMaNV = new System.Windows.Forms.Label();
            this.dateTimePickerNgayLap = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn:";
            // 
            // textBoxMaHD
            // 
            this.textBoxMaHD.Location = new System.Drawing.Point(135, 37);
            this.textBoxMaHD.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaHD.Name = "textBoxMaHD";
            this.textBoxMaHD.Size = new System.Drawing.Size(132, 22);
            this.textBoxMaHD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Lập:";
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.Location = new System.Drawing.Point(135, 128);
            this.textBoxTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.Size = new System.Drawing.Size(132, 22);
            this.textBoxTongTien.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng Tiền:";
            // 
            // textBoxTrangThai
            // 
            this.textBoxTrangThai.Location = new System.Drawing.Point(441, 87);
            this.textBoxTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTrangThai.Name = "textBoxTrangThai";
            this.textBoxTrangThai.Size = new System.Drawing.Size(160, 22);
            this.textBoxTrangThai.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Trạng Thái:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Khách Hàng:";
            // 
            // buttonThemHD
            // 
            this.buttonThemHD.Location = new System.Drawing.Point(51, 186);
            this.buttonThemHD.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThemHD.Name = "buttonThemHD";
            this.buttonThemHD.Size = new System.Drawing.Size(149, 36);
            this.buttonThemHD.TabIndex = 12;
            this.buttonThemHD.Text = "Thêm Hóa Đơn";
            this.buttonThemHD.UseVisualStyleBackColor = true;
            this.buttonThemHD.Click += new System.EventHandler(this.buttonThemHD_Click);
            // 
            // buttonHuyHD
            // 
            this.buttonHuyHD.Location = new System.Drawing.Point(236, 186);
            this.buttonHuyHD.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHuyHD.Name = "buttonHuyHD";
            this.buttonHuyHD.Size = new System.Drawing.Size(149, 36);
            this.buttonHuyHD.TabIndex = 13;
            this.buttonHuyHD.Text = "Hủy Hóa Đơn";
            this.buttonHuyHD.UseVisualStyleBackColor = true;
            this.buttonHuyHD.Click += new System.EventHandler(this.buttonHuyHD_Click);
            // 
            // buttonLuuHD
            // 
            this.buttonLuuHD.Location = new System.Drawing.Point(432, 186);
            this.buttonLuuHD.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLuuHD.Name = "buttonLuuHD";
            this.buttonLuuHD.Size = new System.Drawing.Size(149, 36);
            this.buttonLuuHD.TabIndex = 14;
            this.buttonLuuHD.Text = "Lưu Hóa Đơn";
            this.buttonLuuHD.UseVisualStyleBackColor = true;
            this.buttonLuuHD.Click += new System.EventHandler(this.buttonLuuHD_Click);
            // 
            // dataGridViewHD
            // 
            this.dataGridViewHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHD.Location = new System.Drawing.Point(28, 244);
            this.dataGridViewHD.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewHD.Name = "dataGridViewHD";
            this.dataGridViewHD.RowHeadersWidth = 51;
            this.dataGridViewHD.Size = new System.Drawing.Size(588, 295);
            this.dataGridViewHD.TabIndex = 15;
            this.dataGridViewHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHD_CellClick);
            // 
            // comboBoxMaKH
            // 
            this.comboBoxMaKH.FormattingEnabled = true;
            this.comboBoxMaKH.Location = new System.Drawing.Point(441, 41);
            this.comboBoxMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMaKH.Name = "comboBoxMaKH";
            this.comboBoxMaKH.Size = new System.Drawing.Size(160, 24);
            this.comboBoxMaKH.TabIndex = 17;
            // 
            // comboBoxMaSP
            // 
            this.comboBoxMaSP.FormattingEnabled = true;
            this.comboBoxMaSP.Location = new System.Drawing.Point(784, 37);
            this.comboBoxMaSP.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMaSP.Name = "comboBoxMaSP";
            this.comboBoxMaSP.Size = new System.Drawing.Size(292, 24);
            this.comboBoxMaSP.TabIndex = 19;
            this.comboBoxMaSP.TextChanged += new System.EventHandler(this.comboBoxMaSP_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(697, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Sản Phẩm:";
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.Location = new System.Drawing.Point(784, 82);
            this.textBoxDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDonGia.Name = "textBoxDonGia";
            this.textBoxDonGia.Size = new System.Drawing.Size(96, 22);
            this.textBoxDonGia.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(711, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Đơn Giá:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(896, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Số Lượng:";
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Location = new System.Drawing.Point(979, 82);
            this.textBoxSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(97, 22);
            this.textBoxSoLuong.TabIndex = 23;
            // 
            // textBoxThanhTien
            // 
            this.textBoxThanhTien.Location = new System.Drawing.Point(784, 132);
            this.textBoxThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxThanhTien.Name = "textBoxThanhTien";
            this.textBoxThanhTien.Size = new System.Drawing.Size(185, 22);
            this.textBoxThanhTien.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(689, 135);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Thành Tiền:";
            // 
            // ThemChiTiet
            // 
            this.ThemChiTiet.Location = new System.Drawing.Point(784, 186);
            this.ThemChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.ThemChiTiet.Name = "ThemChiTiet";
            this.ThemChiTiet.Size = new System.Drawing.Size(105, 36);
            this.ThemChiTiet.TabIndex = 26;
            this.ThemChiTiet.Text = "Thêm";
            this.ThemChiTiet.UseVisualStyleBackColor = true;
            this.ThemChiTiet.Click += new System.EventHandler(this.ThemChiTiet_Click);
            // 
            // XoaChiTiet
            // 
            this.XoaChiTiet.Location = new System.Drawing.Point(925, 186);
            this.XoaChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.XoaChiTiet.Name = "XoaChiTiet";
            this.XoaChiTiet.Size = new System.Drawing.Size(105, 36);
            this.XoaChiTiet.TabIndex = 27;
            this.XoaChiTiet.Text = "Xóa";
            this.XoaChiTiet.UseVisualStyleBackColor = true;
            this.XoaChiTiet.Click += new System.EventHandler(this.XoaChiTiet_Click);
            // 
            // dataGridViewCTHD
            // 
            this.dataGridViewCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTHD.Location = new System.Drawing.Point(693, 244);
            this.dataGridViewCTHD.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCTHD.Name = "dataGridViewCTHD";
            this.dataGridViewCTHD.RowHeadersWidth = 51;
            this.dataGridViewCTHD.Size = new System.Drawing.Size(384, 295);
            this.dataGridViewCTHD.TabIndex = 28;
            this.dataGridViewCTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCTHD_CellClick);
            // 
            // LabelMaNV
            // 
            this.LabelMaNV.AutoSize = true;
            this.LabelMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMaNV.ForeColor = System.Drawing.Color.Red;
            this.LabelMaNV.Location = new System.Drawing.Point(417, 137);
            this.LabelMaNV.Name = "LabelMaNV";
            this.LabelMaNV.Size = new System.Drawing.Size(93, 32);
            this.LabelMaNV.TabIndex = 29;
            this.LabelMaNV.Text = "label6";
            // 
            // dateTimePickerNgayLap
            // 
            this.dateTimePickerNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayLap.Location = new System.Drawing.Point(135, 80);
            this.dateTimePickerNgayLap.Name = "dateTimePickerNgayLap";
            this.dateTimePickerNgayLap.Size = new System.Drawing.Size(132, 22);
            this.dateTimePickerNgayLap.TabIndex = 30;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 554);
            this.Controls.Add(this.dateTimePickerNgayLap);
            this.Controls.Add(this.LabelMaNV);
            this.Controls.Add(this.dataGridViewCTHD);
            this.Controls.Add(this.XoaChiTiet);
            this.Controls.Add(this.ThemChiTiet);
            this.Controls.Add(this.textBoxThanhTien);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxSoLuong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxDonGia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxMaSP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxMaKH);
            this.Controls.Add(this.dataGridViewHD);
            this.Controls.Add(this.buttonLuuHD);
            this.Controls.Add(this.buttonHuyHD);
            this.Controls.Add(this.buttonThemHD);
            this.Controls.Add(this.textBoxTrangThai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTongTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMaHD);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTrangThai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonThemHD;
        private System.Windows.Forms.Button buttonHuyHD;
        private System.Windows.Forms.Button buttonLuuHD;
        private System.Windows.Forms.DataGridView dataGridViewHD;
        private System.Windows.Forms.ComboBox comboBoxMaKH;
        private System.Windows.Forms.ComboBox comboBoxMaSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDonGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.TextBox textBoxThanhTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ThemChiTiet;
        private System.Windows.Forms.Button XoaChiTiet;
        private System.Windows.Forms.DataGridView dataGridViewCTHD;
        private System.Windows.Forms.Label LabelMaNV;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLap;
    }
}