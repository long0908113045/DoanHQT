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
    

        public QuanLyHoaDon()
        {
            InitializeComponent();
            ketnoi.ConnectionString = Properties.Settings.Default.QLBH1ConnectionString;
            ketnoi.Open();
            lenh.Connection = ketnoi;
            lenh2.Connection = ketnoi;

        }
        void NapMaKH()
        {
            lenh2.CommandText = "Select MaKH, TenKH from KhachHang";
            lenh2.Parameters.Clear();
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable("KH");
            da2.Fill(dt);
            comboBoxKH.DataSource = dt;
            comboBoxKH.ValueMember = "MaKH";
            comboBoxKH.DisplayMember = "TenKH";
        }
        void NapMaNV()
        {
            lenh2.CommandText = "Select MaNV, TenNV from NhanVien";
            lenh2.Parameters.Clear();
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable("NV");
            da2.Fill(dt);
            comboBoxNV.DataSource = dt;
            comboBoxNV.ValueMember = "MaNV";
            comboBoxNV.DisplayMember = "TenNV";
        }
        void NapMaSP()
        {
            lenh2.CommandText = "Select MaSP, TenSP, DonGia from SanPham";
            lenh2.Parameters.Clear();
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable("SP");
            da2.Fill(dt);
            MaSP.DataSource = dt;
            MaSP.ValueMember = "MaSP";
            MaSP.DisplayMember = "TenSP";
            if (cbm != null)
            {
                DataRowView drv = cbm.SelectedItem as DataRowView;
                if (drv != null)
                {
                    
                    this.dataGridViewCTHD[currentCell.ColumnIndex + 2, currentCell.RowIndex].Value = drv["DonGia"].ToString();
                    
                    this.dataGridViewCTHD.EndEdit();
                }
            }
        }
        
       
        void NapCTHD(string mahd)
        {
            
            NapMaSP();
            lenh.CommandText = "Select MaHD, MaSP, SoLuong, DonGia, ThanhTien from ChiTietHoaDon where MaHD = @mahd";
            lenh.Parameters.Clear();
            lenh.Parameters.AddWithValue("@mahd", mahd);            
            da.SelectCommand = lenh;
            dtCTHD.Clear();
            da.Fill(dtCTHD);
            dataGridViewCTHD.DataSource = dtCTHD;

            dataGridViewCTHD.CellEndEdit += new DataGridViewCellEventHandler(dataGridViewCTHD_CellEndEdit);
            dataGridViewCTHD.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridViewCTHD_EditingControlShowing);
                        
            TinhTongTien();

            
        }
        void TinhTongTien()
        {
            int TongTien = 0;
            for (int i = 0; i < dtCTHD.Rows.Count; i++)
            {
                int soluong = Convert.ToInt32(dtCTHD.Rows[i]["SoLuong"]);
                int dongia = Convert.ToInt32(dtCTHD.Rows[i]["DonGia"]);
                TongTien += soluong * dongia;
            }
            textBoxTongTien.Text = TongTien.ToString();
            

        }
        void NapHoaDon(string mahd)
        {
            
            lenh2.CommandText = "Select * from HoaDon where MaHD = @mahd";
            lenh2.Parameters.Clear();
            lenh2.Parameters.AddWithValue("@mahd", mahd);
            da2.SelectCommand = lenh2;
            
            DataTable dt = new DataTable("HD");
             da2.Fill(dt);
            
            if (dt.Rows.Count > 0)
            {
                textBoxMaHD.Text = dt.Rows[0]["MaHD"].ToString();
                dateTimePickerNL.Value = Convert.ToDateTime(dt.Rows[0]["NgayLap"].ToString());
                textBoxTongTien.Text = dt.Rows[0]["TongTien"].ToString();
                comboBoxNV.SelectedValue = dt.Rows[0]["MaNV"].ToString();
                comboBoxKH.SelectedValue = dt.Rows[0]["MaKH"].ToString();
                textBoxTinhTrang.Text = dt.Rows[0]["TinhTrang"].ToString();
            }
            

        }
        void NapDanhSachHoaDon()
        {
            
            lenh2.CommandText = "Select * from HoaDon";
            lenh2.Parameters.Clear();
            da2.SelectCommand = lenh2;
            dtHoaDon.Clear();
            da2.Fill(dtHoaDon);


        }
        void DiChuyenDenHoaDon(int i)
        {
            textBoxMaHD.Text = dtHoaDon.Rows[i]["MaHD"].ToString();
            dateTimePickerNL.Value = Convert.ToDateTime(dtHoaDon.Rows[i]["NgayLap"]);
            comboBoxNV.SelectedValue = dtHoaDon.Rows[i]["MaNV"].ToString();
            comboBoxKH.SelectedValue = dtHoaDon.Rows[i]["MaKH"].ToString();
            textBoxTongTien.Text = dtHoaDon.Rows[i]["TongTien"].ToString();
        }
        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH1DataSet.ChiTietHoaDon' table. You can move, or remove it, as needed.
            this.chiTietHoaDonTableAdapter.Fill(this.qLBH1DataSet.ChiTietHoaDon);
            NapMaNV();
            NapMaKH();
            NapDanhSachHoaDon();
            
            if (dtHoaDon.Rows.Count > 0)
            {
                ViTri = 0;
                DiChuyenDenHoaDon(ViTri);
                NapCTHD(textBoxMaHD.Text);
            }
            
            
            

        }

        private void buttonThemHD_Click(object sender, EventArgs e)
        {            
            textBoxTinhTrang.Text = "Hoàn tất";
            lenh2.CommandText = "Insert into HoaDon(MaHD, NgayLap, TongTien, TinhTrang , MaNV, MaKH)" + 
            "Values(@mahd, @ngaylap, @tongtien, @tinhtrang, @manv, @makh)";
            lenh2.Parameters.Clear();
            lenh2.Parameters.AddWithValue("@mahd", textBoxMaHD.Text);
            lenh2.Parameters.AddWithValue("@ngaylap", dateTimePickerNL.Value);
            lenh2.Parameters.AddWithValue("@tongtien", textBoxTongTien.Text);
            lenh2.Parameters.AddWithValue("@tinhtrang",textBoxTinhTrang.Text);
            lenh2.Parameters.AddWithValue("@manv", comboBoxNV.SelectedValue);
            lenh2.Parameters.AddWithValue("@makh", comboBoxKH.SelectedValue);
            lenh2.ExecuteNonQuery();
            MessageBox.Show("Thêm hóa đơn thành công");
            NapDanhSachHoaDon();
            NapCTHD(textBoxMaHD.Text);
            
        }

        private void buttonTruoc_Click(object sender, EventArgs e)
        {
            if (ViTri>0)
            {
                ViTri -= 1;
                DiChuyenDenHoaDon(ViTri);
                NapCTHD(textBoxMaHD.Text);
            }
        }

        private void buttonSau_Click(object sender, EventArgs e)
        {
            if (ViTri < dtHoaDon.Rows.Count -1)
            {
                ViTri += 1;
                DiChuyenDenHoaDon(ViTri);
                NapCTHD(textBoxMaHD.Text);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tongtien = textBoxTongTien.Text;
            DanhSachHoaDon f = new DanhSachHoaDon();
            f.ShowDialog();
            if (Lienket.MaHD != "")
            {
                NapHoaDon(Lienket.MaHD);
                NapCTHD(Lienket.MaHD);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(dtCTHD);
            }
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
            
            BeginInvoke(new MethodInvoker(NapMaSP));
        }

        private void buttonHuyHD_Click(object sender, EventArgs e)
        {

            textBoxTinhTrang.Text = "Đã hủy";
            lenh2.CommandText = "Update HoaDon set TinhTrang=@tinhtrang where MaHD = @mahd";
            lenh2.Parameters.Clear();
            lenh2.Parameters.AddWithValue("@mahd", textBoxMaHD.Text);
            lenh2.Parameters.AddWithValue("@tinhtrang", textBoxTinhTrang.Text);
            lenh2.ExecuteNonQuery();
            MessageBox.Show("Hủy hóa đơn thành công");
            NapDanhSachHoaDon();
        }          
                                          
    }
}
