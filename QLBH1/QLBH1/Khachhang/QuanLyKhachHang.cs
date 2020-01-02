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

namespace QLBH1.Khachhang
{
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void buttonThemKH_Click(object sender, EventArgs e)
        {
            Khachhang khachhang = new Khachhang();
            string makh = textBoxMaKH.Text;
            string tenkh = textBoxTenKH.Text;
            string diachi = textBoxDiaChi.Text;
            string sdt = textBoxSDT.Text;            
            if (verif())
            {
                if (khachhang.themKhachHang(makh, tenkh, diachi, sdt))
                {
                    MessageBox.Show("Thêm khách hàng thành công", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //SqlCommand command = new SqlCommand("SELECT * FROM KhachHang");
                    dataGridViewKH.ReadOnly = true;
                    DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                    //dataGridViewKH.RowTemplate.Height = 100;
                    dataGridViewKH.DataSource = khachhang.getKhachHang();
                    dataGridViewKH.AllowUserToAddRows = false;
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thiếu giá trị", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((textBoxMaKH.Text.Trim() == "")
                || (textBoxTenKH.Text.Trim() == "")
                || (textBoxDiaChi.Text.Trim() == "")
                || (textBoxSDT.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        
    }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH1DataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qLBH1DataSet.KhachHang);
            Khachhang khachhang = new Khachhang();
            //SqlCommand command = new SqlCommand("SELECT * FROM KhachHang");

            dataGridViewKH.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            //dataGridViewKH.RowTemplate.Height = 100;
            dataGridViewKH.DataSource = khachhang.getKhachHang();
            dataGridViewKH.AllowUserToAddRows = false;

            string mainconn = ConfigurationManager.ConnectionStrings["QLBH1.Properties.Settings.QLBH1ConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Select * from [dbo].[KhachHang]";
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter dr = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridViewKH.DataSource = dt;
            sqlconn.Close();
        }

       

        private void buttonXoaKH_Click(object sender, EventArgs e)
        {
            Khachhang khachhang = new Khachhang();
            try
            {
                string makh = textBoxMaKH.Text;
                if ((MessageBox.Show("Bạn thực sự muốn xóa khách hàng này?", "Xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (khachhang.xoaKhachHang(makh))
                    {
                        MessageBox.Show("Xóa khách hàng thành công", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxMaKH.Text = "";
                        textBoxTenKH.Text = "";                       
                        textBoxDiaChi.Text = "";
                        textBoxSDT.Text = "";
                        //SqlCommand command = new SqlCommand("SELECT * FROM KhachHang");
                        dataGridViewKH.ReadOnly = true;
                        DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                        //dataGridViewKH.RowTemplate.Height = 100;
                        dataGridViewKH.DataSource = khachhang.getKhachHang();
                        dataGridViewKH.AllowUserToAddRows = false;
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Chọn khách hàng muốn xóa", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonCapNhatKH_Click(object sender, EventArgs e)
        {
            Khachhang khachhang = new Khachhang();
            string makh = textBoxMaKH.Text;
            string tenkh = textBoxTenKH.Text;           
            string diachi = textBoxDiaChi.Text;
            string sdt = textBoxSDT.Text;
            if (verif())
            {
                try
                {
                    if (khachhang.capnhatKhachHang(makh, tenkh, diachi, sdt))
                    {
                        MessageBox.Show("Cập nhật thông tin khách hàng thành công", "Cập nhật khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //SqlCommand command = new SqlCommand("SELECT * FROM KhachHang");
                        dataGridViewKH.ReadOnly = true;
                        DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                        //dataGridViewKH.RowTemplate.Height = 100;
                        dataGridViewKH.DataSource = khachhang.getKhachHang();
                        dataGridViewKH.AllowUserToAddRows = false;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Cập nhật khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Cập nhật khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dataGridViewKH_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaKH.Text = dataGridViewKH.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxTenKH.Text = dataGridViewKH.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxDiaChi.Text = dataGridViewKH.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxSDT.Text = dataGridViewKH.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void textBoxTimKH_TextChanged(object sender, EventArgs e)
        {
            //string mainconn = ConfigurationManager.ConnectionStrings["QLBH1.Properties.Settings.QLBH1ConnectionString"].ConnectionString;
            //SqlConnection sqlconn = new SqlConnection(mainconn);
            //string sqlquery = "Select * from [dbo].[KhachHang] where TenKH like N'%" + textBoxTimKH.Text + "%'";
            //sqlconn.Open();
            //SqlCommand sqlcom = new SqlCommand(sqlquery, sqlconn);
            My_DB mydb = new My_DB();
            SqlCommand sqlcom = new SqlCommand("SPGetByNameKhachHang", mydb.getConnection);
            sqlcom.CommandType = CommandType.StoredProcedure;
            sqlcom.Parameters.Add(new SqlParameter("@TenKH", textBoxTimKH.Text));
            SqlDataAdapter dr = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridViewKH.DataSource = dt;
            //sqlconn.Close();
        }
    }
}
