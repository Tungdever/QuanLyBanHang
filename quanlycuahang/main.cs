﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
namespace quanlycuahang
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void exitClick(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void KhachHangClick(object sender, EventArgs e)
        {
            frmQLDanhMucKhachHang myKH = new frmQLDanhMucKhachHang();
            myKH.ShowDialog();
        }

        private void NhanVienClick(object sender, EventArgs e)
        {
            frmQLDanhMucNhanVien myNV = new frmQLDanhMucNhanVien();
            myNV.ShowDialog();

        }

        private void city_Click(object sender, EventArgs e)
        {
            frmQLDanhMucThanhPho myCity = new frmQLDanhMucThanhPho();
            myCity.ShowDialog();
        }

        private void NguoiDungClick(object sender, EventArgs e)
        {
            frmQLDanhMucNguoiDung myND = new frmQLDanhMucNguoiDung();
            myND.ShowDialog();
        }

        private void SanPhamClick(object sender, EventArgs e)
        {
            frmQLDanhMucSanPham mySP = new frmQLDanhMucSanPham();
            mySP.ShowDialog();
        }

        private void CTHDCLick(object sender, EventArgs e)
        {
            frmQLDanhMucChiTietHopDong myCTHD = new frmQLDanhMucChiTietHopDong();
            myCTHD.ShowDialog();
        }

        private void HoaDonClick(object sender, EventArgs e)
        {

            frmQLDanhMucHoaDon myHD = new frmQLDanhMucHoaDon();
            myHD.ShowDialog();
        }

        private void login_Click(object sender, EventArgs e)
        {
            frmLogin myLogin = new frmLogin();
            myLogin.ShowDialog();
        }
    }
}
