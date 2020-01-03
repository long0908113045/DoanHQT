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

namespace QLBH1.Hoadon
{
    public partial class QuanLyHoaDon : Form
    {
        public static string tongtien;
        QLBH1.Sanpham.QuanLySanPham sp = new QLBH1.Sanpham.QuanLySanPham();
        SqlConnection ketnoi = new SqlConnection();
        SqlCommand lenh = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dtHoaDon = new DataTable("HoaDon");
        int ViTri = -1;
        DataTable dtCTHD = new DataTable("ChiTietHoaDon");

        SqlCommand lenh2 = new SqlCommand();
        SqlDataAdapter da2 = new SqlDataAdapter();

        ComboBox cbm;
        
        DataGridViewCell currentCell;        
    

    
        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH1DataSet.ChiTietHoaDon' table. You can move, or remove it, as needed.
            //this.chiTietHoaDonTableAdapter.Fill(this.qLBH1DataSet.ChiTietHoaDon);
            
            
            
            

        }

        private void buttonThemHD_Click(object sender, EventArgs e)
        {   
            
        }

        private void buttonTruoc_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSau_Click(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridViewCTHD_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dataGridViewCTHD.Rows[e.Row.Index - 1].Cells["MaHD"].Value = textBoxMaHD.Text;
            
        }

        private void dataGridViewCTHD_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Tính thành tiền

                int soluong = Convert.ToInt32(dataGridViewCTHD.Rows[e.RowIndex].Cells["SoLuong"].Value);

                int dongia = Convert.ToInt32(dataGridViewCTHD.Rows[e.RowIndex].Cells["DonGia"].Value);                
                int tt = soluong * dongia;
                dataGridViewCTHD.Rows[e.RowIndex].Cells["ThanhTien"].Value = tt;
                

               SqlCommandBuilder cb = new SqlCommandBuilder(da);
               da.Update(dtCTHD);

            }
            catch { }
        }

        void dataGridViewCTHD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (cbm != null)
            {
                
                cbm.SelectedIndexChanged -= new EventHandler(cbm_SelectedIndexChanged);
            }
        }
        void dataGridViewCTHD_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
            if (e.Control is ComboBox)
            {
                cbm = (ComboBox)e.Control;
                if (cbm != null)
                {
                    cbm.SelectedIndexChanged += new EventHandler(cbm_SelectedIndexChanged);
                }
                currentCell = this.dataGridViewCTHD.CurrentCell;
            }
        }
        void cbm_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void buttonHuyHD_Click(object sender, EventArgs e)
        {
            
        }          
                                          
    }
}
