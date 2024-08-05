﻿using DAL.IRepo;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class QuanLyKhachHang : IQuanLyKhachHang
    {
        private readonly ShopSanPhamContext _context;
        public QuanLyKhachHang(ShopSanPhamContext context)
        {
            _context = context;
        }

        public void AddKhachHang(KhachHang kh)
        {
            _context.KhachHangs.Add(kh);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<KhachHang>> GetAllKHachHang()
        {
            return await _context.KhachHangs.ToListAsync();
        }

        public KhachHang GetKhachHang(string sdt)
        {
            return _context.KhachHangs.FirstOrDefault(kh => kh.SoDienThoai == sdt);
        }

        public void UpdateKhachHang(KhachHang kh)
        {
            var khach = _context.KhachHangs.Find(kh.IdKhachHang);
            khach.Ten = kh.Ten;
            khach.SoDienThoai = kh.SoDienThoai;
            khach.DiaChi = kh.DiaChi;
            khach.Email = kh.Email;

            _context.KhachHangs.Update(khach);
            _context.SaveChanges();
        }
    }
}