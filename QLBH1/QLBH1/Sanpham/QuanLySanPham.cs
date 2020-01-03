using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace QLBH1.Sanpham
{
    public partial class QuanLySanPham : Form
    {
        My_DB mydb = new My_DB();        
        Loaisanpham loaisanpham = new Loaisanpham();
        QLBH1.Nhacungcap.Nhacungcap nhacungcap = new QLBH1.Nhacungcap.Nhacungcap();
        public QuanLySanPham()
        {
            InitializeComponent();
        }

        private void buttonThemSP_Click(object sender, EventArgs e)
        {
           
            if (verif())
            {
                Sanpham sanpham = new Sanpham();
                string masp = textBoxMaSP.Text;
                string tensp = textBoxTenSP.Text;
                string dvtinh = textBoxDVTinh.Text;
                int dongia = Convert.ToInt32(textBoxDonGia.Text);
                int soluong = Convert.ToInt32(textBoxSoLuong.Text);
                string malsp = comboBoxLSP.SelectedValue.ToString();
                string mancc = comboBoxNCC.SelectedValue.ToString();
                try {
                    if (sanpham.themSanPham(masp, tensp, dvtinh, dongia, soluong, malsp, mancc))
                    {
                        MessageBox.Show("Thêm sản phẩm thành công", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //SqlCommand command = new SqlCommand("SELECT * FROM SanPham");
                        dataGridViewSP.ReadOnly = true;
                        DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                        //dataGridViewSP.RowTemplate.Height = 100;
                        dataGridViewSP.DataSource = sanpham.getSanPham();
                        dataGridViewSP.AllowUserToAddRows = false;

                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi SQL exception !\n" + ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Thiếu giá trị", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((textBoxMaSP.Text.Trim() == "")
                || (textBoxTenSP.Text.Trim() == "")
                || (textBoxDVTinh.Text.Trim() == "")
                || (textBoxDonGia.Text.Trim() == "")
                || (textBoxSoLuong.Text.Trim() == "")
                || (comboBoxLSP.SelectedItem == null)
                || (comboBoxNCC.SelectedItem == null))

            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void fill()
        {
            //SqlCommand cmd1 = new SqlCommand("select * from LoaiSanPham", mydb.getConnection);
            comboBoxLSP.DataSource = loaisanpham.getLoaiSanPham();
            comboBoxLSP.DisplayMember = "TenLSP";
            comboBoxLSP.ValueMember = "MaLSP";
            //comboBoxLSP.SelectedItem = null;
            //SqlCommand cmd = new SqlCommand("select * from NhaCungCap", mydb.getConnection);
            comboBoxNCC.DataSource = nhacungcap.getNhaCungCap();
            comboBoxNCC.DisplayMember = "TenNCC";
            comboBoxNCC.ValueMember = "MaNCC";
            //comboBoxNCC.SelectedItem = null;

        }
        
        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH1DataSet.SanPham' table. You can move, or remove it, as needed.
            //this.sanPhamTableAdapter.Fill(this.qLBH1DataSet.SanPham);            
            fill();

            //string mainconn = ConfigurationManager.ConnectionStrings["QLBH1.Properties.Settings.QLBH1ConnectionString"].ConnectionString;
            //SqlConnection sqlconn = new SqlConnection(mainconn);
            //string sqlquery = "Select * from [dbo].[SanPham]";
            //sqlconn.Open();
            //SqlCommand sqlcom = new SqlCommand(sqlquery, sqlconn);
            //SqlDataAdapter dr = new SqlDataAdapter(sqlcom);
            Sanpham sanpham = new Sanpham();
            DataTable dt = sanpham.getSanPham();
            dataGridViewSP.ReadOnly = true;
            //DataTable dt = new DataTable();          
            dataGridViewSP.DataSource = dt;
            dataGridViewSP.AllowUserToAddRows = false;

        }

        private void buttonXoaSP_Click(object sender, EventArgs e)
        {
            Sanpham sanpham = new Sanpham();
            try
            {
                string masp = textBoxMaSP.Text;
                if ((MessageBox.Show("Bạn thực sự muốn xóa sản phẩm này?", "Xóa loại sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (sanpham.xoaSanPham(masp))
                    {
                        MessageBox.Show("Xóa sản phẩm thành công", "Xóa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxMaSP.Text = "";
                        textBoxTenSP.Text = "";
                        textBoxDVTinh.Text = "";
                        textBoxDonGia.Text = "";
                        textBoxSoLuong.Text = "";
                        comboBoxLSP.DisplayMember = null;
                        comboBoxNCC.DisplayMember = null;
                        //SqlCommand command = new SqlCommand("SELECT * FROM SanPham");                        
                        dataGridViewSP.ReadOnly = true;
                        DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                        //dataGridViewSP.RowTemplate.Height = 100;
                        dataGridViewSP.DataSource = sanpham.getSanPham();
                        dataGridViewSP.AllowUserToAddRows = false;
                        fill();
                    }
                    else
                    {
                        MessageBox.Show("Xóa sản phẩm thất bại", "Xóa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL exception !\n" + ex.Message);
            }
        }

        private void buttonCapNhatSP_Click(object sender, EventArgs e)
        {
            Sanpham sanpham = new Sanpham();
            string masp = textBoxMaSP.Text;
            string tensp = textBoxTenSP.Text;
            string dvtinh = textBoxDVTinh.Text;
            int dongia = Convert.ToInt32(textBoxDonGia.Text);
            int soluong = Convert.ToInt32(textBoxSoLuong.Text);
            string malsp = comboBoxLSP.SelectedValue.ToString();
            string mancc = comboBoxNCC.SelectedValue.ToString();
            if (verif())
            {
                try
                {
                    if (sanpham.capnhatSanPham(masp, tensp, dvtinh, dongia, soluong, malsp, mancc))
                    {
                        MessageBox.Show("Cập nhật thông tin sản phẩm thành công", "Cập nhật sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       // SqlCommand command = new SqlCommand("SELECT * FROM SanPham");
                        dataGridViewSP.ReadOnly = true;
                        DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                        //dataGridViewSP.RowTemplate.Height = 100;
                        dataGridViewSP.DataSource = sanpham.getSanPham();
                        dataGridViewSP.AllowUserToAddRows = false;
                        fill();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Cập nhật sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Cập nhật sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void dataGridViewSP_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //textBoxMaSP.Text = dataGridViewSP.Rows[e.RowIndex].Cells[0].Value.ToString();
            //textBoxTenSP.Text = dataGridViewSP.Rows[e.RowIndex].Cells[1].Value.ToString();
            //textBoxDVTinh.Text = dataGridViewSP.Rows[e.RowIndex].Cells[2].Value.ToString();
            //textBoxDonGia.Text = dataGridViewSP.Rows[e.RowIndex].Cells[3].Value.ToString();
            //textBoxSoLuong.Text = dataGridViewSP.Rows[e.RowIndex].Cells[4].Value.ToString();
            //comboBoxLSP.SelectedValue = dataGridViewSP.Rows[e.RowIndex].Cells[5].Value.ToString();
            //comboBoxNCC.SelectedValue = dataGridViewSP.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void textBoxTimSP_TextChanged(object sender, EventArgs e)
        {
            //string mainconn = ConfigurationManager.ConnectionStrings["QLBH1.Properties.Settings.QLBH1ConnectionString"].ConnectionString;
            //SqlConnection sqlconn = new SqlConnection(mainconn);
            //string sqlquery = "Select * from [dbo].[SanPham] where TenSP like N'%" + textBoxTimSP.Text + "%'";
            //sqlconn.Open();
            //SqlCommand sqlcom = new SqlCommand(sqlquery, sqlconn);
            SqlCommand sqlcom = new SqlCommand("SPGetByNameSanPham", mydb.getConnection);
            sqlcom.CommandType = CommandType.StoredProcedure;
            sqlcom.Parameters.Add(new SqlParameter("@TenSP", textBoxTimSP.Text));
            SqlDataAdapter dr = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridViewSP.DataSource = dt;
            
        }

        private void dataGridViewSP_DoubleClick(object sender, EventArgs e)

        {
        //    textBoxMaSP.Text = dataGridViewSP.Rows[e.RowIndex].Cells[0].Value.ToString();
        //    textBoxTenSP.Text = dataGridViewSP.Rows[e.RowIndex].Cells[1].Value.ToString();
        //    textBoxDVTinh.Text = dataGridViewSP.Rows[e.RowIndex].Cells[2].Value.ToString();
        //    textBoxDonGia.Text = dataGridViewSP.Rows[e.RowIndex].Cells[3].Value.ToString();
        //    textBoxSoLuong.Text = dataGridViewSP.Rows[e.RowIndex].Cells[4].Value.ToString();
        //    comboBoxLSP.SelectedValue = dataGridViewSP.Rows[e.RowIndex].Cells[5].Value.ToString();
        //    comboBoxNCC.SelectedValue = dataGridViewSP.Rows[e.RowIndex].Cells[6].Value.ToString();
    }
    private void dataGridViewSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
            textBoxMaSP.Text = dataGridViewSP.CurrentRow.Cells[0].Value.ToString();
            textBoxTenSP.Text = dataGridViewSP.CurrentRow.Cells[1].Value.ToString();
            textBoxDVTinh.Text = dataGridViewSP.CurrentRow.Cells[2].Value.ToString();
            textBoxDonGia.Text = dataGridViewSP.CurrentRow.Cells[3].Value.ToString();
            textBoxSoLuong.Text = dataGridViewSP.CurrentRow.Cells[4].Value.ToString();
            comboBoxLSP.SelectedValue = dataGridViewSP.CurrentRow.Cells[5].Value.ToString();
            comboBoxNCC.SelectedValue = dataGridViewSP.CurrentRow.Cells[6].Value.ToString();
        }
    }
    
}
