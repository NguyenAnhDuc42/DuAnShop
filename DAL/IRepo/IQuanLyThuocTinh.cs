using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepo
{
    public interface IQuanLyThuocTinh
    {

        bool CreateHang(HangSanPham hang);
        bool UpdateHang(HangSanPham hang);
        IEnumerable<HangSanPham> GetAllHang();
        HangSanPham GetHangByID(int id);

        bool CreateGioiTinh(GioiTinh gioiTinh);
        bool UpdateGioiTinh(GioiTinh gioiTinh);
        IEnumerable<GioiTinh> GetAllGioiTinh();
        GioiTinh GetGioiTinhByID(int id);

        bool CreateKichCo(KichCo kichCo);
        bool UpdateKichCo(KichCo kichCo);
        IEnumerable<KichCo> GetAllKichCo();
        KichCo GetKichCoByID(int id);

        bool CreateMauSac(MauSac mauSac);
        bool UpdateMauSac(MauSac mauSac);
        IEnumerable<MauSac> GetAllMauSac();
        MauSac GetMauSacByID(int id);

        bool CreateGiamGia(GiamGium giamGia);
        bool UpdateGiamGia(GiamGium giamGia);
        IEnumerable<GiamGium> GetAllGiamGia();
        GiamGium GetGiamGiaByID(int id);

        IEnumerable<SanPham> GetAllSanPhamsByGiamGiaId(int idGiamGia);
        bool UpdateSanPham(SanPham sanPham);
    }
}
