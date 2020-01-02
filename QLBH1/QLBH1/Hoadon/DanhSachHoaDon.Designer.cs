namespace QLBH1.Hoadon
{
    partial class DanhSachHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDSHD = new System.Windows.Forms.DataGridView();
            this.textBoxTimHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDSHD
            // 
            this.dataGridViewDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.NgayLap,
            this.TongTien,
            this.MaNV,
            this.MaKH});
            this.dataGridViewDSHD.Location = new System.Drawing.Point(12, 56);
            this.dataGridViewDSHD.Name = "dataGridViewDSHD";
            this.dataGridViewDSHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDSHD.Size = new System.Drawing.Size(592, 262);
            this.dataGridViewDSHD.TabIndex = 0;
            this.dataGridViewDSHD.DoubleClick += new System.EventHandler(this.dataGridViewDSHD_DoubleClick);
            // 
            // textBoxTimHD
            // 
            this.textBoxTimHD.Location = new System.Drawing.Point(189, 21);
            this.textBoxTimHD.Name = "textBoxTimHD";
            this.textBoxTimHD.Size = new System.Drawing.Size(415, 20);
            this.textBoxTimHD.TabIndex = 1;
            this.textBoxTimHD.TextChanged += new System.EventHandler(this.textBoxTimHD_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm theo mã hóa đơn:";
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 110;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.NgayLap.DefaultCellStyle = dataGridViewCellStyle1;
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 110;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 109;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Nhân Viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 110;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Khách Hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 110;
            // 
            // DanhSachHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(616, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTimHD);
            this.Controls.Add(this.dataGridViewDSHD);
            this.Name = "DanhSachHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Hóa Đơn";
            this.Load += new System.EventHandler(this.DanhSachHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDSHD;
        private System.Windows.Forms.TextBox textBoxTimHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
    }
}