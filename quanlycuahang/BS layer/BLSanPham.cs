using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlycuahang.BS_layer
{
    public class BLSanPham
    {
        public System.Data.Linq.Table<SanPham> LaySanPham()
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            return qlBH.SanPhams;
        }
        public bool ThemSanPham(string MaSP, string TenSP, string DonViTinh, float DonGia, ref string err)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            SanPham sp = new SanPham();
            sp.MaSP = MaSP;
            sp.TenSP = TenSP;
            sp.DonViTinh = DonViTinh;
            sp.DonGia = DonGia;
            qlBH.SanPhams.InsertOnSubmit(sp);
            qlBH.SanPhams.Context.SubmitChanges();
            return true;
        }
        public bool XoaSanPham(ref string err, string MaSP)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var tpQuery = from sp in qlBH.SanPhams
                          where sp.MaSP == MaSP
                          select sp;
            qlBH.SanPhams.DeleteAllOnSubmit(tpQuery);
            qlBH.SubmitChanges();
            return true;
        }
        public bool CapNhatSanPham(string MaSP, string TenSP, string DonViTinh, float DonGia, ref string err)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var tpQuery = (from sp in qlBH.SanPhams
                           where sp.MaSP == MaSP
                           select sp).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.TenSP = TenSP;
                tpQuery.DonViTinh = DonViTinh;
                tpQuery.DonGia = DonGia;
                qlBH.SubmitChanges();
            }
            return true;
        }
    }
}
