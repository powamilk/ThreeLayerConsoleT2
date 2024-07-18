using System;
using System.Collections.Generic;

namespace ThreeLayerConsoleT2.DAL.Entities
{
    public partial class SanPham
    {
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; } = null!;
        public string? MoTa { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public string? NhaSanXuat { get; set; }
        public string? XuatXu { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public DateTime HanSuDung { get; set; }
        public int TrangThai { get; set; }
        public int MaLoai { get; set; }

        public virtual LoaiSanPham MaLoaiNavigation { get; set; } = null!;
    }
}
