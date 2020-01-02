using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            Sanpham.QuanLyLoaiSanPham lsp = new Sanpham.QuanLyLoaiSanPham();
            lsp.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhanvien.QuanLiNhanVien nv = new Nhanvien.QuanLiNhanVien();
            nv.ShowDialog();
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
            Hoadon.QuanLyHoaDon hd = new Hoadon.QuanLyHoaDon();
            hd.ShowDialog();
        }
    }
}
