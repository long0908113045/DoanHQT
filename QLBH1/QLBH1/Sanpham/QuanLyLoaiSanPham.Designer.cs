namespace QLBH1.Sanpham
{
    partial class QuanLyLoaiSanPham
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
            this.textBoxMaLSP = new System.Windows.Forms.TextBox();
            this.textBoxTenLSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonThemLSP = new System.Windows.Forms.Button();
            this.buttonXoaLSP = new System.Windows.Forms.Button();
            this.buttonCapNhatLSP = new System.Windows.Forms.Button();
            this.dataGridViewLSP = new System.Windows.Forms.DataGridView();
            this.maLSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH1DataSet = new QLBH1.QLBH1DataSet();
            this.loaiSanPhamTableAdapter = new QLBH1.QLBH1DataSetTableAdapters.LoaiSanPhamTableAdapter();
            this.textBoxTimLSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại Sản Phẩm:";
            // 
            // textBoxMaLSP
            // 
            this.textBoxMaLSP.Location = new System.Drawing.Point(169, 60);
            this.textBoxMaLSP.Name = "textBoxMaLSP";
            this.textBoxMaLSP.Size = new System.Drawing.Size(142, 20);
            this.textBoxMaLSP.TabIndex = 1;
            // 
            // textBoxTenLSP
            // 
            this.textBoxTenLSP.Location = new System.Drawing.Point(169, 99);
            this.textBoxTenLSP.Name = "textBoxTenLSP";
            this.textBoxTenLSP.Size = new System.Drawing.Size(142, 20);
            this.textBoxTenLSP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Loại Sản Phẩm:";
            // 
            // buttonThemLSP
            // 
            this.buttonThemLSP.Location = new System.Drawing.Point(169, 250);
            this.buttonThemLSP.Name = "buttonThemLSP";
            this.buttonThemLSP.Size = new System.Drawing.Size(136, 30);
            this.buttonThemLSP.TabIndex = 4;
            this.buttonThemLSP.Text = "Thêm Loại Sản Phẩm";
            this.buttonThemLSP.UseVisualStyleBackColor = true;
            this.buttonThemLSP.Click += new System.EventHandler(this.buttonThemLSP_Click);
            // 
            // buttonXoaLSP
            // 
            this.buttonXoaLSP.Location = new System.Drawing.Point(550, 250);
            this.buttonXoaLSP.Name = "buttonXoaLSP";
            this.buttonXoaLSP.Size = new System.Drawing.Size(136, 30);
            this.buttonXoaLSP.TabIndex = 5;
            this.buttonXoaLSP.Text = "Xóa Loại Sản Phẩm";
            this.buttonXoaLSP.UseVisualStyleBackColor = true;
            this.buttonXoaLSP.Click += new System.EventHandler(this.buttonXoaLSP_Click);
            // 
            // buttonCapNhatLSP
            // 
            this.buttonCapNhatLSP.Location = new System.Drawing.Point(360, 250);
            this.buttonCapNhatLSP.Name = "buttonCapNhatLSP";
            this.buttonCapNhatLSP.Size = new System.Drawing.Size(136, 30);
            this.buttonCapNhatLSP.TabIndex = 6;
            this.buttonCapNhatLSP.Text = "Cập Nhật Loại Sản Phẩm";
            this.buttonCapNhatLSP.UseVisualStyleBackColor = true;
            this.buttonCapNhatLSP.Click += new System.EventHandler(this.buttonCapNhatLSP_Click);
            // 
            // dataGridViewLSP
            // 
            this.dataGridViewLSP.AutoGenerateColumns = false;
            this.dataGridViewLSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLSPDataGridViewTextBoxColumn,
            this.tenLSPDataGridViewTextBoxColumn});
            this.dataGridViewLSP.DataSource = this.loaiSanPhamBindingSource;
            this.dataGridViewLSP.Location = new System.Drawing.Point(360, 99);
            this.dataGridViewLSP.Name = "dataGridViewLSP";
            this.dataGridViewLSP.Size = new System.Drawing.Size(428, 124);
            this.dataGridViewLSP.TabIndex = 7;
            this.dataGridViewLSP.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLSP_RowEnter);
            // 
            // maLSPDataGridViewTextBoxColumn
            // 
            this.maLSPDataGridViewTextBoxColumn.DataPropertyName = "MaLSP";
            this.maLSPDataGridViewTextBoxColumn.HeaderText = "MaLSP";
            this.maLSPDataGridViewTextBoxColumn.Name = "maLSPDataGridViewTextBoxColumn";
            // 
            // tenLSPDataGridViewTextBoxColumn
            // 
            this.tenLSPDataGridViewTextBoxColumn.DataPropertyName = "TenLSP";
            this.tenLSPDataGridViewTextBoxColumn.HeaderText = "TenLSP";
            this.tenLSPDataGridViewTextBoxColumn.Name = "tenLSPDataGridViewTextBoxColumn";
            // 
            // loaiSanPhamBindingSource
            // 
            this.loaiSanPhamBindingSource.DataMember = "LoaiSanPham";
            this.loaiSanPhamBindingSource.DataSource = this.qLBH1DataSetBindingSource;
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
            // loaiSanPhamTableAdapter
            // 
            this.loaiSanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxTimLSP
            // 
            this.textBoxTimLSP.Location = new System.Drawing.Point(550, 60);
            this.textBoxTimLSP.Name = "textBoxTimLSP";
            this.textBoxTimLSP.Size = new System.Drawing.Size(238, 20);
            this.textBoxTimLSP.TabIndex = 8;
            this.textBoxTimLSP.TextChanged += new System.EventHandler(this.textBoxTimLSP_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tìm kiếm theo tên loại sản phẩm:";
            // 
            // QuanLyLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 304);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTimLSP);
            this.Controls.Add(this.dataGridViewLSP);
            this.Controls.Add(this.buttonCapNhatLSP);
            this.Controls.Add(this.buttonXoaLSP);
            this.Controls.Add(this.buttonThemLSP);
            this.Controls.Add(this.textBoxTenLSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMaLSP);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyLoaiSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Loại Sản Phẩm";
            this.Load += new System.EventHandler(this.QuanLyLoaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaLSP;
        private System.Windows.Forms.TextBox textBoxTenLSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonThemLSP;
        private System.Windows.Forms.Button buttonXoaLSP;
        private System.Windows.Forms.Button buttonCapNhatLSP;
        private System.Windows.Forms.DataGridView dataGridViewLSP;
        private System.Windows.Forms.BindingSource qLBH1DataSetBindingSource;
        private QLBH1DataSet qLBH1DataSet;
        private System.Windows.Forms.BindingSource loaiSanPhamBindingSource;
        private QLBH1DataSetTableAdapters.LoaiSanPhamTableAdapter loaiSanPhamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxTimLSP;
        private System.Windows.Forms.Label label3;
    }
}