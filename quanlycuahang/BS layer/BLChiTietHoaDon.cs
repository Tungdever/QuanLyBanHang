using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlycuahang.BS_layer
{
    public class BLChiTietHoaDon
    {
        public System.Data.Linq.Table<ChiTietHoaDon> LayChiTietHoaDon()
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            return qlBH.ChiTietHoaDons;
        }
        public bool ThemChiTietHoaDon(string MaHD, string MaSP, float SoLuong, ref string err)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            ChiTietHoaDon cthd = new ChiTietHoaDon();
            cthd.MaHD = MaHD;
            cthd.MaSP = MaSP;
            cthd.Soluong = SoLuong;
            qlBH.ChiTietHoaDons.InsertOnSubmit(cthd);
            qlBH.ChiTietHoaDons.Context.SubmitChanges();
            return true;

        }
        public bool XoaChiTietHoaDon(ref string err, string MaHD, string MaSP)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var cthdQuery = from cthd in qlBH.ChiTietHoaDons
                            where cthd.MaSP == MaSP && cthd.MaHD== MaHD
                            select cthd;
            qlBH.ChiTietHoaDons.DeleteAllOnSubmit(cthdQuery);
            qlBH.SubmitChanges();
            return true;
        }
        public bool CapNhatChiTietHoaDon(string MaHD, string MaSP, float SoLuong, ref string err)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var cthdQuery = (from cthd in qlBH.ChiTietHoaDons
                             where cthd.MaSP == MaSP && cthd.MaHD == MaHD
                             select cthd).SingleOrDefault();
            if (cthdQuery != null)
            {
                cthdQuery.Soluong = SoLuong;
                qlBH.SubmitChanges();
            }
            return true;
        }
    }
}
