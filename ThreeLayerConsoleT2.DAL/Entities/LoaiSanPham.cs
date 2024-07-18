using System;
using System.Collections.Generic;

namespace ThreeLayerConsoleT2.DAL.Entities
{
    public partial class LoaiSanPham
    {
        public LoaiSanPham()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public int MaLoai { get; set; }
        public string TenLoai { get; set; } = null!;
        public string? MoTa { get; set; }
        public int TrangThai { get; set; }
        public DateTime NgayTao { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
