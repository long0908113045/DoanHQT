namespace QLBH1.Hoadon
{
    partial class QuanLyHoaDon
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerNL = new System.Windows.Forms.DateTimePicker();
            this.comboBoxNV = new System.Windows.Forms.ComboBox();
            this.comboBoxKH = new System.Windows.Forms.ComboBox();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewCTHD = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonThemHD = new System.Windows.Forms.Button();
            this.buttonHuyHD = new System.Windows.Forms.Button();
            this.qLBH1DataSet = new QLBH1.QLBH1DataSet();
            this.qLBH1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietHoaDonTableAdapter = new QLBH1.QLBH1DataSetTableAdapters.ChiTietHoaDonTableAdapter();
            this.textBoxTinhTrang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSau = new System.Windows.Forms.Button();
            this.buttonTruoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn:";
            // 
            // textBoxMaHD
            // 
            this.textBoxMaHD.Location = new System.Drawing.Point(203, 31);
            this.textBoxMaHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMaHD.Name = "textBoxMaHD";
            this.textBoxMaHD.Size = new System.Drawing.Size(145, 22);
            this.textBoxMaHD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Lập: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhân Viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Khách Hàng:";
            // 
            // dateTimePickerNL
            // 
            this.dateTimePickerNL.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNL.Location = new System.Drawing.Point(203, 76);
            this.dateTimePickerNL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerNL.Name = "dateTimePickerNL";
            this.dateTimePickerNL.Size = new System.Drawing.Size(145, 22);
            this.dateTimePickerNL.TabIndex = 5;
            // 
            // comboBoxNV
            // 
            this.comboBoxNV.FormattingEnabled = true;
            this.comboBoxNV.Location = new System.Drawing.Point(203, 122);
            this.comboBoxNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxNV.Name = "comboBoxNV";
            this.comboBoxNV.Size = new System.Drawing.Size(145, 24);
            this.comboBoxNV.TabIndex = 6;
            // 
            // comboBoxKH
            // 
            this.comboBoxKH.FormattingEnabled = true;
            this.comboBoxKH.Location = new System.Drawing.Point(203, 169);
            this.comboBoxKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxKH.Name = "comboBoxKH";
            this.comboBoxKH.Size = new System.Drawing.Size(145, 24);
            this.comboBoxKH.TabIndex = 7;
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.Location = new System.Drawing.Point(203, 215);
            this.textBoxTongTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.Size = new System.Drawing.Size(145, 22);
            this.textBoxTongTien.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng Tiền:";
            // 
            // dataGridViewCTHD
            // 
            this.dataGridViewCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaSP,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dataGridViewCTHD.Location = new System.Drawing.Point(404, 58);
            this.dataGridViewCTHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCTHD.Name = "dataGridViewCTHD";
            this.dataGridViewCTHD.RowHeadersWidth = 51;
            this.dataGridViewCTHD.Size = new System.Drawing.Size(613, 228);
            this.dataGridViewCTHD.TabIndex = 10;
            this.dataGridViewCTHD.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewCTHD_EditingControlShowing);
            this.dataGridViewCTHD.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCTHD_RowValidated);
            this.dataGridViewCTHD.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewCTHD_UserAddedRow);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.FillWeight = 87.01308F;
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.FillWeight = 111.2111F;
            this.MaSP.HeaderText = "Tên Sản Phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.FillWeight = 97.49782F;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.FillWeight = 102.7551F;
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.FillWeight = 101.5228F;
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // buttonThemHD
            // 
            this.buttonThemHD.Location = new System.Drawing.Point(12, 303);
            this.buttonThemHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonThemHD.Name = "buttonThemHD";
            this.buttonThemHD.Size = new System.Drawing.Size(155, 36);
            this.buttonThemHD.TabIndex = 11;
            this.buttonThemHD.Text = "Thêm Hóa Đơn";
            this.buttonThemHD.UseVisualStyleBackColor = true;
            this.buttonThemHD.Click += new System.EventHandler(this.buttonThemHD_Click);
            // 
            // buttonHuyHD
            // 
            this.buttonHuyHD.Location = new System.Drawing.Point(195, 303);
            this.buttonHuyHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHuyHD.Name = "buttonHuyHD";
            this.buttonHuyHD.Size = new System.Drawing.Size(155, 36);
            this.buttonHuyHD.TabIndex = 12;
            this.buttonHuyHD.Text = "Hủy Hóa Đơn";
            this.buttonHuyHD.UseVisualStyleBackColor = true;
            this.buttonHuyHD.Click += new System.EventHandler(this.buttonHuyHD_Click);
            // 
            // qLBH1DataSet
            // 
            this.qLBH1DataSet.DataSetName = "QLBH1DataSet";
            this.qLBH1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLBH1DataSetBindingSource
            // 
            this.qLBH1DataSetBindingSource.DataSource = this.qLBH1DataSet;
            this.qLBH1DataSetBindingSource.Position = 0;
            // 
            // chiTietHoaDonBindingSource
            // 
            this.chiTietHoaDonBindingSource.DataMember = "ChiTietHoaDon";
            this.chiTietHoaDonBindingSource.DataSource = this.qLBH1DataSetBindingSource;
            // 
            // chiTietHoaDonTableAdapter
            // 
            this.chiTietHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxTinhTrang
            // 
            this.textBoxTinhTrang.Location = new System.Drawing.Point(203, 261);
            this.textBoxTinhTrang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTinhTrang.Name = "textBoxTinhTrang";
            this.textBoxTinhTrang.Size = new System.Drawing.Size(145, 22);
            this.textBoxTinhTrang.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 265);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tình trạng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(863, 303);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Danh Sách Hóa Đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Chi Tiết Hóa Đơn:";
            // 
            // buttonSau
            // 
            this.buttonSau.Location = new System.Drawing.Point(716, 303);
            this.buttonSau.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSau.Name = "buttonSau";
            this.buttonSau.Size = new System.Drawing.Size(72, 36);
            this.buttonSau.TabIndex = 16;
            this.buttonSau.Text = ">";
            this.buttonSau.UseVisualStyleBackColor = true;
            this.buttonSau.Click += new System.EventHandler(this.buttonSau_Click);
            // 
            // buttonTruoc
            // 
            this.buttonTruoc.Location = new System.Drawing.Point(612, 303);
            this.buttonTruoc.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTruoc.Name = "buttonTruoc";
            this.buttonTruoc.Size = new System.Drawing.Size(72, 36);
            this.buttonTruoc.TabIndex = 15;
            this.buttonTruoc.Text = "<";
            this.buttonTruoc.UseVisualStyleBackColor = true;
            this.buttonTruoc.Click += new System.EventHandler(this.buttonTruoc_Click);
            // 
            // QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1033, 388);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSau);
            this.Controls.Add(this.buttonTruoc);
            this.Controls.Add(this.textBoxTinhTrang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonHuyHD);
            this.Controls.Add(this.buttonThemHD);
            this.Controls.Add(this.dataGridViewCTHD);
            this.Controls.Add(this.textBoxTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxKH);
            this.Controls.Add(this.comboBoxNV);
            this.Controls.Add(this.dateTimePickerNL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMaHD);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuanLyHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hóa Đơn";
            this.Load += new System.EventHandler(this.QuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerNL;
        private System.Windows.Forms.ComboBox comboBoxNV;
        private System.Windows.Forms.ComboBox comboBoxKH;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.BindingSource qLBH1DataSetBindingSource;
        private QLBH1DataSet qLBH1DataSet;
        private System.Windows.Forms.Button buttonThemHD;
        private System.Windows.Forms.Button buttonHuyHD;
        private System.Windows.Forms.BindingSource chiTietHoaDonBindingSource;
        private QLBH1DataSetTableAdapters.ChiTietHoaDonTableAdapter chiTietHoaDonTableAdapter;
        private System.Windows.Forms.TextBox textBoxTinhTrang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSau;
        private System.Windows.Forms.Button buttonTruoc;
    }
}