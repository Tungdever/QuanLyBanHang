using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlycuahang.BS_layer
{
    public class BLNhanVien
    {
        public System.Data.Linq.Table<NhanVien> LayNhanVien()
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            return qlBH.NhanViens;
        }
        public bool ThemNhanVien(string MaNV, string HoLot, string Ten, bool Nu, DateTime NgayNV, string DiaChi, string DienThoai,  ref string err)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            NhanVien nv = new NhanVien();
            nv.MaNV = MaNV;
            nv.Ho = HoLot;
            nv.Ten = Ten;
            nv.Nu = Nu;
            nv.NgayNV = NgayNV;
            nv.DiaChi= DiaChi;
            nv.DienThoai= DienThoai;
            qlBH.NhanViens.InsertOnSubmit(nv);
            qlBH.NhanViens.Context.SubmitChanges();
            return true;
        }
        public bool XoaNhanVien(ref string err, string MaNV)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var tpQuery = from nv in qlBH.NhanViens
                          where nv.MaNV == MaNV
                          select nv;
            qlBH.NhanViens.DeleteAllOnSubmit(tpQuery);
            qlBH.SubmitChanges();
            return true;
        }
        public bool CapNhatNhanVien(string MaNV, string HoLot, string Ten, bool Nu, DateTime NgayNV, string DiaChi, string DienThoai, ref string err)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var tpQuery = (from nv in qlBH.NhanViens
                           where nv.MaNV == MaNV
                           select nv).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.Ho = HoLot;
                tpQuery.Ten = Ten;
                tpQuery.Nu = Nu;
                tpQuery.NgayNV= NgayNV;
                tpQuery.DiaChi= DiaChi;
                tpQuery.DienThoai = DienThoai;
                qlBH.SubmitChanges();
            }
            return true;
        }
    }
}
