using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_DangMuon
    {
        private QLThuVienDataContext db;
        public BLL_DangMuon()
        {
            db = new QLThuVienDataContext();
        }
        public object GetPhieuMuonInfos()
        {
            var query = from pm in db.PHIEUMUONs
                        join tendocgia in db.DOCGIAs
                        on pm.MaDocGia equals tendocgia.MaDocGia
                        join sach in db.SACHes
                        on pm.MaSach equals sach.MaSach
                        join tennguoitao in db.DOCGIAs
                        on pm.NguoiTao equals tennguoitao.MaDocGia
                        let tinhTrang = pm.NgayPhaiTra.HasValue && pm.NgayPhaiTra.Value.Date >= DateTime.Now.Date ? "Đang mượn" : "Đã trả"
                        where tinhTrang == "Đang mượn"
                        select new
                        {
                            pm.MaPhieuMuon,
                            TenDocGia = tendocgia.HoTen,
                            TenSach = sach.TenSach,
                            pm.NgayMuon,
                            NgayPhaiTra = pm.NgayPhaiTra.HasValue ? pm.NgayPhaiTra.Value : (DateTime?)null,
                            TenNguoiTao = tennguoitao.HoTen,
                            TinhTrang = tinhTrang
                        };
            return query;
        }
        public IQueryable GetPhieuMuonByMa(int maPhieuMuon)
        {
            var query = from pm in db.PHIEUMUONs
                        join tendocgia in db.DOCGIAs on pm.MaDocGia equals tendocgia.MaDocGia
                        join sach in db.SACHes on pm.MaSach equals sach.MaSach
                        join tennguoitao in db.DOCGIAs on pm.NguoiTao equals tennguoitao.MaDocGia
                        where pm.MaPhieuMuon == maPhieuMuon
                        select new
                        {
                            pm.MaPhieuMuon,
                            TenDocGia = tendocgia.HoTen,
                            TenSach = sach.TenSach,
                            pm.NgayMuon,
                            NgayPhaiTra = pm.NgayPhaiTra.HasValue ? pm.NgayPhaiTra.Value : (DateTime?)null,
                            TenNguoiTao = tennguoitao.HoTen,
                            TinhTrang = pm.NgayPhaiTra.HasValue && pm.NgayPhaiTra.Value.Date >= DateTime.Now.Date ? "Đang mượn" : "Đã trả"
                        };
            return query;
        }
    }
    
   
}
