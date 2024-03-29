using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_DaTra
    {
        private QLThuVienDataContext db;
        public BLL_DaTra()
        {
            db = new QLThuVienDataContext();
        }
        public object GetPhieuTraInfos(int? day = null, int? month = null, int? year = null)
        {
            var query = from pt in db.PHIEUTRAs
                        join phieumuon in db.PHIEUMUONs on pt.MaPhieuMuon equals phieumuon.MaPhieuMuon
                        join docgia in db.DOCGIAs on phieumuon.MaDocGia equals docgia.MaDocGia
                        join sach in db.SACHes on phieumuon.MaSach equals sach.MaSach
                        join nguoitao in db.DOCGIAs on pt.NguoiTao equals nguoitao.MaDocGia
                        where (!day.HasValue || pt.NgayTra.Day == day) &&
                              (!month.HasValue || pt.NgayTra.Month == month) &&
                              (!year.HasValue || pt.NgayTra.Year == year)
                        select new
                        {
                            pt.MaPhieuTra,
                            pt.MaPhieuMuon,
                            TenNguoiTra = docgia.HoTen,
                            TenSachTra = sach.TenSach,
                            pt.NgayTra,
                            NguoiTao = nguoitao.HoTen
                        };
            return query;
        }

    }
}
