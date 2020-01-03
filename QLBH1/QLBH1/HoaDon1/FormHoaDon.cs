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

namespace QLBH1.HoaDon1
{
    public partial class FormHoaDon : Form
    {
        HoaDonObj OBJ = new HoaDonObj();
        Khachhang.Khachhang khachhang = new Khachhang.Khachhang();
        Sanpham.Sanpham sanpham = new Sanpham.Sanpham();
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                load();
                loadcombobox();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("loi SqlException" + ex.Message);
            }
            textBoxDonGia.ReadOnly = true;
            textBoxThanhTien.ReadOnly = true;
            
        }
        public void load()
        {
            HoaDonObj obj = new HoaDonObj();
            dataGridViewHD.DataSource = obj.getHoaDon();            
        }
        public void loadcombobox()
        {
            try
            {
                comboBoxMaKH.DataSource = khachhang.getKhachHang();
                comboBoxMaKH.DisplayMember = "TenKH";
                comboBoxMaKH.ValueMember = "MaKH";
                comboBoxMaSP.DataSource = sanpham.getSanPham();
                comboBoxMaSP.DisplayMember = "TenSP";
                comboBoxMaSP.ValueMember = "MaSP";
            }
            catch(SqlException ex)
            {
                MessageBox.Show("loi SqlException" + ex.Message);
            }
            
        }
        private void buttonThemHD_Click(object sender, EventArgs e)
        {
            string MaHD = textBoxMaHD.Text;
            DateTime NgayLap = dateTimePickerNgayLap.Value;
            int TongTien = Convert.ToInt32(textBoxTongTien.Text);
            string MaKH = comboBoxMaKH.ValueMember;
            string TrangThai = textBoxTrangThai.Text;
            string MaNV = LabelMaNV.Text;

            OBJ = new HoaDonObj(MaHD, NgayLap, TongTien, TrangThai, MaNV, MaKH);
            try
            {
                if(OBJ.themHoaDon(MaHD, NgayLap, TongTien, TrangThai, MaNV, MaKH))
                {
                    MessageBox.Show(" thanh cong");
                }
                else
                {
                    MessageBox.Show(" that bai");
                }
                load();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("loi SqlException" + ex.Message);
            }
            
        }

        private void buttonHuyHD_Click(object sender, EventArgs e)
        {
            string MaHD = textBoxMaHD.Text;
            DateTime NgayLap = dateTimePickerNgayLap.Value;
            int TongTien = Convert.ToInt32(textBoxTongTien.Text);
            string MaKH = comboBoxMaKH.Text;
            string TrangThai = textBoxTrangThai.Text;
            string MaNV = LabelMaNV.Text;

            OBJ = new HoaDonObj(MaHD, NgayLap, TongTien, TrangThai, MaNV, MaKH);
            try
            {
                if (OBJ.xoaHoaDon(MaHD))
                {
                    MessageBox.Show(" thanh cong");
                }
                else
                {
                    MessageBox.Show(" that bai");
                }
                load();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("loi SqlException" + ex.Message);
            }
        }

        private void buttonLuuHD_Click(object sender, EventArgs e)
        {
            string MaHD = textBoxMaHD.Text;
            DateTime NgayLap = dateTimePickerNgayLap.Value;
            int TongTien = Convert.ToInt32(textBoxTongTien.Text);
            string MaKH = comboBoxMaKH.ValueMember;
            string TrangThai = textBoxTrangThai.Text;
            string MaNV = LabelMaNV.Text;

            OBJ = new HoaDonObj(MaHD, NgayLap, TongTien, TrangThai, MaNV, MaKH);
            try
            {
                if (OBJ.capnhatHoaDon(MaHD, NgayLap, TongTien, TrangThai, MaNV, MaKH))
                {
                    MessageBox.Show(" thanh cong");
                }
                else
                {
                    MessageBox.Show(" that bai");
                }
                load();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("loi SqlException" + ex.Message);
            }
        }
        

        private void dataGridViewHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxMaHD.Text = dataGridViewHD.CurrentRow.Cells[0].Value.ToString();
                dateTimePickerNgayLap.Value = (DateTime)dataGridViewHD.CurrentRow.Cells[1].Value;
                textBoxTongTien.Text = dataGridViewHD.CurrentRow.Cells[2].Value.ToString();
                comboBoxMaKH.Text = dataGridViewHD.CurrentRow.Cells[5].Value.ToString();
                textBoxTrangThai.Text = dataGridViewHD.CurrentRow.Cells[3].Value.ToString();
                ChiTietObj objchitet = new ChiTietObj(dataGridViewHD.CurrentRow.Cells[0].Value.ToString());
                dataGridViewCTHD.DataSource = objchitet.getChiTietHoaDon();
                LabelMaNV.Text = Globals.GlobalMaNV;
            }
            catch(SqlException ex)
            {
                MessageBox.Show("loi SqlException" + ex.Message);
            }
        }

        private void dataGridViewCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxMaSP.Text = dataGridViewCTHD.CurrentRow.Cells[1].Value.ToString();
            textBoxSoLuong.Text = dataGridViewCTHD.CurrentRow.Cells[2].Value.ToString();
            textBoxDonGia.Text = dataGridViewCTHD.CurrentRow.Cells[3].Value.ToString();
            textBoxThanhTien.Text = dataGridViewCTHD.CurrentRow.Cells[4].Value.ToString();            
        }

        private void comboBoxMaSP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable table = sanpham.getByIdSanPham(comboBoxMaSP.Text);
                textBoxDonGia.Text = table.Rows[0][3].ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("loi SqlException" + ex.Message);
            }
        }

        private void ThemChiTiet_Click(object sender, EventArgs e)
        {
            string MaHD = textBoxMaHD.Text;
            string MaSP = comboBoxMaSP.Text;
            int Soluong = Convert.ToInt32(textBoxSoLuong.Text);
            int Dongia = Convert.ToInt32(textBoxDonGia.Text);
            int ThanhTien = Soluong* Dongia;
            ChiTietObj chiTiet = new ChiTietObj(MaHD, MaSP, Soluong, Dongia,ThanhTien);
            try
            {
                if (chiTiet.themChiTietHoaDon())
                {
                    MessageBox.Show(" thanh cong");
                }
                else
                {
                    MessageBox.Show(" that bai");
                }
                load();
                ChiTietObj objchitet = new ChiTietObj(MaHD);
                dataGridViewCTHD.DataSource = objchitet.getChiTietHoaDon();
                LabelMaNV.Text = Globals.GlobalMaNV;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("loi SqlException" + ex.Message);
            }
        }

        private void XoaChiTiet_Click(object sender, EventArgs e)
        {
            string MaHD = textBoxMaHD.Text;
            string MaSP = comboBoxMaSP.Text;            
            
            ChiTietObj chiTiet = new ChiTietObj(MaHD, MaSP);
            try
            {
                if (chiTiet.xoaChiTietHoaDon())
                {
                    MessageBox.Show(" thanh cong");
                }
                else
                {
                    MessageBox.Show(" that bai");
                }
                load();
                ChiTietObj objchitet = new ChiTietObj(MaHD);
                dataGridViewCTHD.DataSource = objchitet.getChiTietHoaDon();
                LabelMaNV.Text = Globals.GlobalMaNV;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("loi SqlException" + ex.Message);
            }
        }
    }
}
