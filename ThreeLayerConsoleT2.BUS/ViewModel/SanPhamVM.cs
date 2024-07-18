namespace ThreeLayerConsoleT2.BUS.ViewModel
{
    public class SanPhamVM
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

        public void InThongTin()
        {
            Console.WriteLine($"MaSanPham: {MaSanPham}, TenSanPham: {TenSanPham}, GiaBan: {GiaBan}, SoLuongTon: {SoLuongTon}, NhaSanXuat: {NhaSanXuat}, XuatXu: {XuatXu}, NgaySanXuat: {NgaySanXuat.ToString("dd/MM/yyyy")}, HanSuDung: {HanSuDung.ToString("dd/MM/yyyy")}, TrangThai: {TrangThai}, MaLoai: {MaLoai}");
        }
    }
}
