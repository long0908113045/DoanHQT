using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBH1
{
    public partial class QuanLyDonHang : Form
    {
        public QuanLyDonHang()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        private void QuanLyDonHang_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from View_thongtinkhachmuahang", mydb.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Loi SqlException " + ex.Message);
            }
        }
    }
}
