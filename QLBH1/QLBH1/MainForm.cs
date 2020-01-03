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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Sanpham.QuanLySanPham sp = new Sanpham.QuanLySanPham();            
            sp.ShowDialog();
        }

        private void quảnLýLoạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string con = "Data Source=(local);Initial Catalog=QLBH1;Integrated Security=False; User ID=" + Globals.GlobalUserId + ";Password=" + Globals.GlobalPass;
            string queryString = "SELECT * FROM LoaiSanPham";
            StringBuilder errorMessages = new StringBuilder();
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    Sanpham.QuanLyLoaiSanPham sp = new Sanpham.QuanLyLoaiSanPham();
                    sp.ShowDialog();
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string con = "Data Source=(local);Initial Catalog=QLBH1;Integrated Security=False; User ID=" + Globals.GlobalUserId + ";Password=" + Globals.GlobalPass;
            string queryString = "SELECT * FROM NhanVien";
            StringBuilder errorMessages = new StringBuilder();
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    Nhanvien.QuanLiNhanVien nv = new Nhanvien.QuanLiNhanVien();
                    nv.ShowDialog();                   
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Khachhang.QuanLyKhachHang kh = new Khachhang.QuanLyKhachHang();
            kh.ShowDialog();
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhacungcap.QuanLyNhaCungCap ncc = new Nhacungcap.QuanLyNhaCungCap();
            ncc.ShowDialog();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon1.FormHoaDon hd = new HoaDon1.FormHoaDon();
            hd.ShowDialog();
        }

        private void nHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quanLyDonHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDonHang ql = new QuanLyDonHang();
            ql.ShowDialog();
        }
    }
}
