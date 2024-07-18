namespace ThreeLayerConsoleT2.BUS.ViewModel
{
    public class SanPhamCreateVM
    {
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
    }
}
