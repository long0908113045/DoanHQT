namespace QLBH1.Khachhang
{
    partial class QuanLyKhachHang
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
            this.textBoxMaKH = new System.Windows.Forms.TextBox();
            this.textBoxTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonThemKH = new System.Windows.Forms.Button();
            this.buttonXoaKH = new System.Windows.Forms.Button();
            this.buttonCapNhatKH = new System.Windows.Forms.Button();
            this.dataGridViewKH = new System.Windows.Forms.DataGridView();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH1DataSet = new QLBH1.QLBH1DataSet();
            this.khachHangTableAdapter = new QLBH1.QLBH1DataSetTableAdapters.KhachHangTableAdapter();
            this.textBoxTimKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách Hàng:";
            // 
            // textBoxMaKH
            // 
            this.textBoxMaKH.Location = new System.Drawing.Point(215, 50);
            this.textBoxMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.Size = new System.Drawing.Size(163, 22);
            this.textBoxMaKH.TabIndex = 1;
            // 
            // textBoxTenKH
            // 
            this.textBoxTenKH.Location = new System.Drawing.Point(215, 108);
            this.textBoxTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenKH.Name = "textBoxTenKH";
            this.textBoxTenKH.Size = new System.Drawing.Size(163, 22);
            this.textBoxTenKH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khách Hàng:";
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Location = new System.Drawing.Point(215, 162);
            this.textBoxDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiaChi.Multiline = true;
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(163, 63);
            this.textBoxDiaChi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa Chỉ:";
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Location = new System.Drawing.Point(215, 252);
            this.textBoxSDT.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(163, 22);
            this.textBoxSDT.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "SĐT:";
            // 
            // buttonThemKH
            // 
            this.buttonThemKH.Location = new System.Drawing.Point(215, 304);
            this.buttonThemKH.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThemKH.Name = "buttonThemKH";
            this.buttonThemKH.Size = new System.Drawing.Size(167, 33);
            this.buttonThemKH.TabIndex = 8;
            this.buttonThemKH.Text = "Thêm Khách Hàng";
            this.buttonThemKH.UseVisualStyleBackColor = true;
            this.buttonThemKH.Click += new System.EventHandler(this.buttonThemKH_Click);
            // 
            // buttonXoaKH
            // 
            this.buttonXoaKH.Location = new System.Drawing.Point(689, 304);
            this.buttonXoaKH.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXoaKH.Name = "buttonXoaKH";
            this.buttonXoaKH.Size = new System.Drawing.Size(167, 33);
            this.buttonXoaKH.TabIndex = 9;
            this.buttonXoaKH.Text = "Xóa Khách Hàng";
            this.buttonXoaKH.UseVisualStyleBackColor = true;
            this.buttonXoaKH.Click += new System.EventHandler(this.buttonXoaKH_Click);
            // 
            // buttonCapNhatKH
            // 
            this.buttonCapNhatKH.Location = new System.Drawing.Point(448, 304);
            this.buttonCapNhatKH.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCapNhatKH.Name = "buttonCapNhatKH";
            this.buttonCapNhatKH.Size = new System.Drawing.Size(167, 33);
            this.buttonCapNhatKH.TabIndex = 10;
            this.buttonCapNhatKH.Text = "Cập Nhật Khách Hàng";
            this.buttonCapNhatKH.UseVisualStyleBackColor = true;
            this.buttonCapNhatKH.Click += new System.EventHandler(this.buttonCapNhatKH_Click);
            // 
            // dataGridViewKH
            // 
            this.dataGridViewKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKH.Location = new System.Drawing.Point(448, 89);
            this.dataGridViewKH.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewKH.Name = "dataGridViewKH";
            this.dataGridViewKH.RowHeadersWidth = 51;
            this.dataGridViewKH.Size = new System.Drawing.Size(603, 188);
            this.dataGridViewKH.TabIndex = 11;
            this.dataGridViewKH.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKH_RowEnter_1);
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.qLBH1DataSetBindingSource;
            // 
            // qLBH1DataSetBindingSource
            // 
            this.qLBH1DataSetBindingSource.DataSource = this.qLBH1DataSet;
            this.qLBH1DataSetBindingSource.Position = 0;
            // 
            // qLBH1DataSet
            // 
            this.qLBH1DataSet.DataSetName = "QLBH1DataSet";
            this.qLBH1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxTimKH
            // 
            this.textBoxTimKH.Location = new System.Drawing.Point(689, 50);
            this.textBoxTimKH.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTimKH.Name = "textBoxTimKH";
            this.textBoxTimKH.Size = new System.Drawing.Size(360, 22);
            this.textBoxTimKH.TabIndex = 12;
            this.textBoxTimKH.TextChanged += new System.EventHandler(this.textBoxTimKH_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tìm kiếm theo tên khách hàng:";
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1067, 363);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTimKH);
            this.Controls.Add(this.dataGridViewKH);
            this.Controls.Add(this.buttonCapNhatKH);
            this.Controls.Add(this.buttonXoaKH);
            this.Controls.Add(this.buttonThemKH);
            this.Controls.Add(this.textBoxSDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDiaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTenKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMaKH);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaKH;
        private System.Windows.Forms.TextBox textBoxTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonThemKH;
        private System.Windows.Forms.Button buttonXoaKH;
        private System.Windows.Forms.Button buttonCapNhatKH;
        private System.Windows.Forms.DataGridView dataGridViewKH;
        private System.Windows.Forms.BindingSource qLBH1DataSetBindingSource;
        private QLBH1DataSet qLBH1DataSet;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private QLBH1DataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.TextBox textBoxTimKH;
        private System.Windows.Forms.Label label5;
    }
}