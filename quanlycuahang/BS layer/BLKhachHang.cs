using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace quanlycuahang.BS_layer
{
   
    public class BLKhachHang
    {
        BLThanhPho dbTP = new BLThanhPho();
        public System.Data.Linq.Table<KhachHang> LayKhachHang()
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();                       
            return qlBH.KhachHangs;
        }
        public void CheckThanhPho(string Makh, string TenCongTy, string DiaChi, string TenThanhPho, string DienThoai, ref string err)
        {
            var dsTP = from tp in dbTP.LayThanhPho()
                                select tp.ThanhPho1;
            
            if (!dsTP.ToList().Contains(TenThanhPho))
            {
                this.CapNhatKhachHang(Makh, TenCongTy, DiaChi, "00", DienThoai,ref err);
            }
        }
        public bool ThemKhachHang(string Makh, string TenCongTy, string DiaChi,string TenThanhPho,string DienThoai, ref string err)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            KhachHang kh = new KhachHang();
            kh.MaKH = Makh;
            kh.TenCty = TenCongTy;
            kh.DiaChi= DiaChi;
            kh.ThanhPho = TenThanhPho;
            kh.DienThoai= DienThoai;
            qlBH.KhachHangs.InsertOnSubmit(kh);
            qlBH.KhachHangs.Context.SubmitChanges();
            return true;
        }
        public bool XoaKhachHang(ref string err, string Makh)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var tpQuery = from kh in qlBH.KhachHangs
                          where kh.MaKH == Makh
                          select kh;
            qlBH.KhachHangs.DeleteAllOnSubmit(tpQuery);
            qlBH.SubmitChanges();
            return true;
        }
        public bool CapNhatKhachHang(string Makh, string TenCongTy, string DiaChi, string TenThanhPho, string DienThoai, ref string err)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var tpQuery = (from kh in qlBH.KhachHangs
                           where kh.MaKH == Makh
                           select kh).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.TenCty = TenCongTy;
                tpQuery.DiaChi= DiaChi;
                tpQuery.ThanhPho= TenThanhPho;
                tpQuery.DienThoai= DienThoai;
                qlBH.SubmitChanges();
            }
            return true;
        }
    }
}
