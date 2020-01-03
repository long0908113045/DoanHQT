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

namespace QLBH1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxTaiKhoan.Focus();
            textBoxMatKhau.Focus();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dangnhap()
        {
            if (textBoxTaiKhoan.Text.Length == 0 && textBoxMatKhau.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập mật khẩu");
            else
                if (this.textBoxTaiKhoan.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập tài khoản");
                else
                    if (this.textBoxMatKhau.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                    else
                        if (this.textBoxTaiKhoan.Text == "admin" && this.textBoxMatKhau.Text == "123456")
                        MessageBox.Show("Đăng nhập thành công");
                        else
                        MessageBox.Show("Mật khẩu không đúng");
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            //MainForm mf = new MainForm();
            //this.Hide();
            //if (this.textBoxTaiKhoan.Text == "admin" && this.textBoxMatKhau.Text == "123456")
            //{                
            //    mf.Show();                
            //}            
            //dangnhap();  
            string userid = textBoxTaiKhoan.Text;
            string pass = textBoxMatKhau.Text;
            Globals.SetGlobalUserId(userid);
            Globals.SetGlobalPass(pass);
            try {
                My_DB db = new My_DB();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                //db.openConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM TaiKhoan WHERE TaiKhoan = @User AND MatKhau = @Pass", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.NVarChar).Value = textBoxTaiKhoan.Text;
                command.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = textBoxMatKhau.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                //SqlDataReader reader = command.ExecuteReader();
                if (table.Rows.Count > 0)
                {

                    //else
                    string manv = table.Rows[0][3].ToString();
                    Globals.SetGlobalMaNV(manv);
                    Form fr = new MainForm();
                    fr.Show(this);
                    this.DialogResult = DialogResult.OK;

                }

                else MessageBox.Show("Invalid Username or Password");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
