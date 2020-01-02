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

namespace QLBH1.Hoadon
{
    public partial class DanhSachHoaDon : Form
    {
        Hoadon hd = new Hoadon();
        SqlConnection ketnoi = new SqlConnection();
        SqlCommand lenh = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        public DanhSachHoaDon()
        {
            InitializeComponent();
            ketnoi.ConnectionString = Properties.Settings.Default.QLBH1ConnectionString;
            ketnoi.Open();
            lenh.Connection = ketnoi;
        }
        
        void NapDanhSachHoaDon()
        {
            
            lenh.CommandText = "Select MaHD, NgayLap, TongTien, MaNV, MaKH from HoaDon";
            lenh.Parameters.Clear();            
            da.SelectCommand = lenh;
            DataTable dt = new DataTable("DS");            
            da.Fill(dt);            
            dataGridViewDSHD.DataSource = dt;

            

        }
        
        private void DanhSachHoaDon_Load(object sender, EventArgs e)
        {
            NapDanhSachHoaDon();
            
            string mainconn = ConfigurationManager.ConnectionStrings["QLBH1.Properties.Settings.QLBH1ConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Select * from HoaDon";
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter dr = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();            
            dr.Fill(dt);
            dataGridViewDSHD.DataSource = dt;
            sqlconn.Close();

            dataGridViewDSHD.Columns[2].Visible = false;
        }

        private void dataGridViewDSHD_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewDSHD.SelectedRows.Count > 0)
            {
                Lienket.MaHD = dataGridViewDSHD.SelectedRows[0].Cells["MaHD"].Value.ToString();
                Close();
            }
        }

        private void textBoxTimHD_TextChanged(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["QLBH1.Properties.Settings.QLBH1ConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Select * from [dbo].[HoaDon] where MaHD like N'%" + textBoxTimHD.Text + "%'";
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter dr = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridViewDSHD.DataSource = dt;
            sqlconn.Close();
        }
       
    }
}
