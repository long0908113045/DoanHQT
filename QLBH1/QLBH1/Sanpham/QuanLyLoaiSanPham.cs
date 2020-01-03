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
    public partial class QuanLyLoaiSanPham : Form
    {
        public QuanLyLoaiSanPham()
        {
            InitializeComponent();
        }

        private void buttonThemLSP_Click(object sender, EventArgs e)
        {
            
            if (verif())
            {
                Loaisanpham loaisanpham = new Loaisanpham();
                string malsp = textBoxMaLSP.Text;
                string tenlsp = textBoxTenLSP.Text; 
                try
                {
                    if (loaisanpham.themLoaiSanPham(malsp, tenlsp))
                    {
                        MessageBox.Show("Thêm loại sản phẩm thành công", "Thêm loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //SqlCommand command = new SqlCommand("SELECT * FROM LoaiSanPham");
                        dataGridViewLSP.ReadOnly = true;
                        DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                        //dataGridViewLSP.RowTemplate.Height = 100;
                        dataGridViewLSP.DataSource = loaisanpham.getLoaiSanPham();
                        dataGridViewLSP.AllowUserToAddRows = false;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thêm loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi SQL exception !/n" + ex.Message);
                }
               
            }
            else
            {
                MessageBox.Show("Thiếu giá trị", "Thêm loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((textBoxMaLSP.Text.Trim() == "")
                || (textBoxTenLSP.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void QuanLyLoaiSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH1DataSet.LoaiSanPham' table. You can move, or remove it, as needed.
            //this.loaiSanPhamTableAdapter.Fill(this.qLBH1DataSet.LoaiSanPham);
            Loaisanpham loaisanpham = new Loaisanpham();
            //SqlCommand command = new SqlCommand("SELECT * FROM LoaiSanPham");

            dataGridViewLSP.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            //dataGridViewLSP.RowTemplate.Height = 100;
            dataGridViewLSP.DataSource = loaisanpham.getLoaiSanPham();
            dataGridViewLSP.AllowUserToAddRows = false;

            //string mainconn = ConfigurationManager.ConnectionStrings["QLBH1.Properties.Settings.QLBH1ConnectionString"].ConnectionString;
            //SqlConnection sqlconn = new SqlConnection(mainconn);
            //string sqlquery = "Select * from [dbo].[LoaiSanPham]";
            //sqlconn.Open();
            //SqlCommand sqlcom = new SqlCommand(sqlquery, sqlconn);
            //SqlDataAdapter dr = new SqlDataAdapter(sqlcom);
            //DataTable dt = new DataTable();
            //dr.Fill(dt);
            //dataGridViewLSP.DataSource = dt;
            //sqlconn.Close();
        }
       
        private void buttonXoaLSP_Click(object sender, EventArgs e)
        {
            Loaisanpham loaisanpham = new Loaisanpham();
            try
            {
                string malsp = textBoxMaLSP.Text;
                if ((MessageBox.Show("Bạn thực sự muốn xóa loại sản phẩm này?", "Xóa loại sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (loaisanpham.xoaLoaiSanPham(malsp))
                    {
                        MessageBox.Show("Xóa loại sản phẩm thành công", "Xóa loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxMaLSP.Text = "";
                        textBoxTenLSP.Text = "";
                        //SqlCommand command = new SqlCommand("SELECT * FROM LoaiSanPham");
                        dataGridViewLSP.ReadOnly = true;
                        DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                       // dataGridViewLSP.RowTemplate.Height = 100;
                        dataGridViewLSP.DataSource = loaisanpham.getLoaiSanPham();
                        dataGridViewLSP.AllowUserToAddRows = false;
                    }
                    else
                    {
                        MessageBox.Show("Xóa loại sản phẩm thất bại", "Xóa loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xoá sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonCapNhatLSP_Click(object sender, EventArgs e)
        {
            Loaisanpham loaisanpham = new Loaisanpham();
            string malsp = textBoxMaLSP.Text;
            string tenlsp = textBoxTenLSP.Text;
            try
            {
                if (loaisanpham.capnhatLoaiSanPham(malsp, tenlsp))
                {
                    MessageBox.Show("Cập nhật thông tin loại sản phẩm thành công", "Cập nhật loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //SqlCommand command = new SqlCommand("SELECT * FROM LoaiSanPham");
                    dataGridViewLSP.ReadOnly = true;
                    DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                    //dataGridViewLSP.RowTemplate.Height = 100;
                    dataGridViewLSP.DataSource = loaisanpham.getLoaiSanPham();
                    dataGridViewLSP.AllowUserToAddRows = false;
                }
                else
                {
                    MessageBox.Show("Lỗi", "Cập nhật loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cập nhật loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridViewLSP_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaLSP.Text = dataGridViewLSP.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxTenLSP.Text = dataGridViewLSP.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void textBoxTimLSP_TextChanged(object sender, EventArgs e)
        {
            //string mainconn = ConfigurationManager.ConnectionStrings["QLBH1.Properties.Settings.QLBH1ConnectionString"].ConnectionString;
            //SqlConnection sqlconn = new SqlConnection(mainconn);
            //string sqlquery = "Select * from [dbo].[LoaiSanPham] where TenLSP like N'%" + textBoxTimLSP.Text + "%'";
            //sqlconn.Open();

            //SqlCommand sqlcom = new SqlCommand(sqlquery, sqlconn);
            My_DB mydb = new My_DB();
            SqlCommand sqlcom = new SqlCommand("SPGetByNameLoaiSanPham", mydb.getConnection);
            sqlcom.CommandType = CommandType.StoredProcedure;
            sqlcom.Parameters.Add(new SqlParameter("@TenLSP", textBoxTimLSP.Text));
            SqlDataAdapter dr = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridViewLSP.DataSource = dt;
            //sqlconn.Close();
        }
    }
}
