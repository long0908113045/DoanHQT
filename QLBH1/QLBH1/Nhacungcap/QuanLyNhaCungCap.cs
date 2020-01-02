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

namespace QLBH1.Nhacungcap
{
    public partial class QuanLyNhaCungCap : Form
    {
        public QuanLyNhaCungCap()
        {
            InitializeComponent();
        }

        private void buttonThemNCC_Click(object sender, EventArgs e)
        {
            Nhacungcap nhacungcap = new Nhacungcap();
            string mancc = textBoxMaNCC.Text;
            string tenncc = textBoxTenNCC.Text;
            string diachi = textBoxDiaChi.Text;
            string sdt = textBoxSDT.Text;
            string email = textBoxEmail.Text;
            string website = textBoxWebsite.Text;            
            if (verif())
            {
                if (nhacungcap.themNhaCungCap(mancc, tenncc, diachi, sdt, email, website))
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công", "Thêm nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //SqlCommand command = new SqlCommand("SELECT * FROM NhaCungCap");
                    dataGridViewNCC.ReadOnly = true;
                    DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                    //dataGridViewNCC.RowTemplate.Height = 100;
                    dataGridViewNCC.DataSource = nhacungcap.getNhaCungCap();
                    dataGridViewNCC.AllowUserToAddRows = false;
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thêm nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thiếu giá trị", "Thêm nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((textBoxMaNCC.Text.Trim() == "")
                || (textBoxTenNCC.Text.Trim() == "")
                || (textBoxDiaChi.Text.Trim() == "")
                || (textBoxSDT.Text.Trim() == "")
                || (textBoxEmail.Text.Trim() == "")
                || (textBoxWebsite.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void QuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH1DataSet.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.qLBH1DataSet.NhaCungCap);
            Nhacungcap nhacungcap = new Nhacungcap();
            //SqlCommand command = new SqlCommand("SELECT * FROM NhaCungCap");

            dataGridViewNCC.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            //dataGridViewNCC.RowTemplate.Height = 100;
            dataGridViewNCC.DataSource = nhacungcap.getNhaCungCap();
            dataGridViewNCC.AllowUserToAddRows = false;

            string mainconn = ConfigurationManager.ConnectionStrings["QLBH1.Properties.Settings.QLBH1ConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Select * from [dbo].[NhaCungCap]";
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter dr = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridViewNCC.DataSource = dt;
            sqlconn.Close();
        }

       

        private void buttonXoaNCC_Click(object sender, EventArgs e)
        {
            Nhacungcap nhacungcap = new Nhacungcap();
            try
            {
                string mancc = textBoxMaNCC.Text;
                if ((MessageBox.Show("Bạn thực sự muốn xóa nhà cung cấp này?", "Xóa nhà cung cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (nhacungcap.xoaNhaCungCap(mancc))
                    {
                        MessageBox.Show("Xóa nhà cung cấp thành công", "Xóa nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxMaNCC.Text = "";
                        textBoxTenNCC.Text = "";
                        textBoxDiaChi.Text = "";
                        textBoxSDT.Text = "";
                        textBoxEmail.Text = "";
                        textBoxWebsite.Text = "";
                        //SqlCommand command = new SqlCommand("SELECT * FROM NhaCungCap");
                        dataGridViewNCC.ReadOnly = true;
                        DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                        //dataGridViewNCC.RowTemplate.Height = 100;
                        dataGridViewNCC.DataSource = nhacungcap.getNhaCungCap();
                        dataGridViewNCC.AllowUserToAddRows = false;

                    }
                    else
                    {
                        MessageBox.Show("Xóa nhà cung cấp thất bại", "Xóa nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                }
            }
            catch
            {
                MessageBox.Show("Chọn nhà cung cấp muốn xóa", "Xóa nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonCapNhatNCC_Click(object sender, EventArgs e)
        {
            Nhacungcap nhacungcap = new Nhacungcap();
            string mancc = textBoxMaNCC.Text;
            string tenncc = textBoxTenNCC.Text;
            string diachi = textBoxDiaChi.Text;
            string sdt = textBoxSDT.Text;
            string email = textBoxEmail.Text;
            string website = textBoxWebsite.Text;
            
            if (verif())
            {
                try
                {
                    if (nhacungcap.capnhatNhaCungCap(mancc, tenncc,diachi, sdt, email, website))
                    {
                        MessageBox.Show("Cập nhật thông tin nhà cung cấp thành công", "Cập nhật nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //SqlCommand command = new SqlCommand("SELECT * FROM NhaCungCap");
                        dataGridViewNCC.ReadOnly = true;
                        DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                        //dataGridViewNCC.RowTemplate.Height = 100;
                        dataGridViewNCC.DataSource = nhacungcap.getNhaCungCap();
                        dataGridViewNCC.AllowUserToAddRows = false;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Cập nhật nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Cập nhật nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dataGridViewNCC_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaNCC.Text = dataGridViewNCC.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxTenNCC.Text = dataGridViewNCC.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxDiaChi.Text = dataGridViewNCC.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxSDT.Text = dataGridViewNCC.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxEmail.Text = dataGridViewNCC.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxWebsite.Text = dataGridViewNCC.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string mainconn = ConfigurationManager.ConnectionStrings["QLBH1.Properties.Settings.QLBH1ConnectionString"].ConnectionString;
            //SqlConnection sqlconn = new SqlConnection(mainconn);
            //string sqlquery = "Select * from [dbo].[NhaCungCap] where TenNCC like N'%" + textBox1.Text + "%'";
            //sqlconn.Open();
            //SqlCommand sqlcom = new SqlCommand(sqlquery, sqlconn);
            My_DB mydb = new My_DB();
            SqlCommand sqlcom = new SqlCommand("SPGetByNameNhaCungCap", mydb.getConnection);
            sqlcom.CommandType = CommandType.StoredProcedure;
            sqlcom.Parameters.Add(new SqlParameter("@TenNCC", textBox1.Text));
            SqlDataAdapter dr = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridViewNCC.DataSource = dt;
            //sqlconn.Close();
        }
    }
    
}
