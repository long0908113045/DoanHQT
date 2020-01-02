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

namespace QLBH1.Nhanvien
{
    public partial class QuanLiNhanVien : Form
    {
        public QuanLiNhanVien()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            Nhanvien nhanvien = new Nhanvien();
            string manv = textBoxMaNV.Text;
            string tennv = textBoxTenNV.Text;
            DateTime ngaysinh = dateTimePickerNS.Value;
            string sdt = textBoxSDT.Text;
            string diachi = textBoxDiaChi.Text;
            string gioitinh = "Nam";
            if (radioButtonNu.Checked)
            {
                gioitinh = "Nữ";
            }

            int born_year = dateTimePickerNS.Value.Year;
            int this_year = DateTime.Now.Year;
            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("Tuổi nhân viên trong khoảng 10 đến 100", "Ngày sinh không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (verif())
            {
                if (nhanvien.themNhanVien(manv, tennv, gioitinh, ngaysinh, diachi, sdt))
                {
                    MessageBox.Show("Thêm nhân viên thành công", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    dataGridView1.ReadOnly = true;
                    DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                    //dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.DataSource = nhanvien.getNhanVien();
                    dataGridView1.AllowUserToAddRows = false;
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thiếu giá trị", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((textBoxMaNV.Text.Trim() == "")
                || (textBoxTenNV.Text.Trim() == "")
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

        private void QuanLiNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH1DataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLBH1DataSet.NhanVien);
            Nhanvien nhanvien = new Nhanvien();
           // SqlCommand command = new SqlCommand("SELECT * FROM NhanVien");

            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            //dataGridView1.RowTemplate.Height = 100;
            dataGridView1.DataSource = nhanvien.getNhanVien();
            dataGridView1.AllowUserToAddRows = false;

            string mainconn = ConfigurationManager.ConnectionStrings["QLBH1.Properties.Settings.QLBH1ConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Select * from [dbo].[NhanVien]";
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter dr = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();

        }

       

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            Nhanvien nhanvien = new Nhanvien();
            try
            {
                string manv = textBoxMaNV.Text;
                if ((MessageBox.Show("Bạn thực sự muốn xóa nhân viên này?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (nhanvien.xoaNhanVien(manv))
                    {
                        MessageBox.Show("Xóa nhân viên thành công", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxMaNV.Text = "";
                        textBoxTenNV.Text = "";
                        dateTimePickerNS.Value = DateTime.Now;
                        textBoxDiaChi.Text = "";
                        textBoxSDT.Text = "";
                        //SqlCommand command = new SqlCommand("SELECT * FROM NhanVien");
                        dataGridView1.ReadOnly = true;
                        DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                        //dataGridView1.RowTemplate.Height = 100;
                        dataGridView1.DataSource = nhanvien.getNhanVien();
                        dataGridView1.AllowUserToAddRows = false;
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Chọn nhân viên muốn xóa", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            Nhanvien nhanvien = new Nhanvien();
            string manv = textBoxMaNV.Text;
            string tennv = textBoxTenNV.Text;
            DateTime ngaysinh = dateTimePickerNS.Value;
            string diachi = textBoxDiaChi.Text;
            string sdt = textBoxSDT.Text;
            string gioitinh = "Nam";
            if (radioButtonNu.Checked)
            {
                gioitinh = "Nữ";
            }
            int born_year = dateTimePickerNS.Value.Year;
            int this_year = DateTime.Now.Year;
            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("Tuổi nhân viên trong khoảng từ 10 đến 100", "Ngày sinh không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (verif())
            {
                try
                {
                    if (nhanvien.capnhatNhanVien(manv, tennv, gioitinh, ngaysinh, diachi, sdt))
                    {
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công", "Cập nhật nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);                       
                        //SqlCommand command = new SqlCommand("SELECT * FROM NhanVien");
                        dataGridView1.ReadOnly = true;
                        DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                       // dataGridView1.RowTemplate.Height = 100;
                        dataGridView1.DataSource = nhanvien.getNhanVien();
                        dataGridView1.AllowUserToAddRows = false;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Cập nhật nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Cập nhật nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaNV.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxTenNV.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            if ((dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() == "Nữ"))
            {
                radioButtonNu.Checked = true;

            }
            else
            {
                radioButtonNam.Checked = true;
            }
            dateTimePickerNS.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[3].Value;

            textBoxDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxSDT.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void textBoxTim_TextChanged(object sender, EventArgs e)
        {
            //string mainconn = ConfigurationManager.ConnectionStrings["QLBH1.Properties.Settings.QLBH1ConnectionString"].ConnectionString;
            //SqlConnection sqlconn = new SqlConnection(mainconn);
            //string sqlquery = "Select * from [dbo].[NhanVien] where TenNV like N'%" + textBoxTim.Text + "%'";
            //sqlconn.Open();
            //SqlCommand sqlcom = new SqlCommand(sqlquery, sqlconn);
            My_DB mydb = new My_DB();
            SqlCommand sqlcom = new SqlCommand("SPGetByNameNhanVien", mydb.getConnection);
            sqlcom.CommandType = CommandType.StoredProcedure;
            sqlcom.Parameters.Add(new SqlParameter("@TenNV", textBoxTim.Text));
            SqlDataAdapter dr = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
            //sqlconn.Close();
        }
    }
}
