using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlycuahang.BS_layer
{
    public class BLNguoiDung
    {
        public System.Data.Linq.Table<NguoiDung> LayNguoiDung()
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            return qlBH.NguoiDungs;
        }
        public bool ThemNguoiDung(string TenNguoiDung, string MatKhau, ref string err)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            NguoiDung tp = new NguoiDung();
            tp.TenNguoiDung = TenNguoiDung;
            tp.MatKhau = MatKhau;
            qlBH.NguoiDungs.InsertOnSubmit(tp);
            qlBH.NguoiDungs.Context.SubmitChanges();
            return true;

        }
        public bool XoaNguoiDung(ref string err, string TenNguoiDung)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var tpQuery = from nd in qlBH.NguoiDungs
                          where nd.TenNguoiDung == TenNguoiDung
                          select nd;
            qlBH.NguoiDungs.DeleteAllOnSubmit(tpQuery);
            qlBH.SubmitChanges();
            return true;
        }
        public bool CapNhatNguoiDung(string TenNguoiDung, string MatKhau, ref string err)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var tpQuery = (from nd in qlBH.NguoiDungs
                           where nd.TenNguoiDung == TenNguoiDung
                           select nd).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.MatKhau = MatKhau;
                qlBH.SubmitChanges();
            }
            return true;
        }
    }
}
