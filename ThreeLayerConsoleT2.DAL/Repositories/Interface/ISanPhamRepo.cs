using ThreeLayerConsoleT2.DAL.Entities;

namespace ThreeLayerConsoleT2.DAL.Repositories.Interface
{
    public interface ISanPhamRepo
    {
        void AddSanPham(SanPham sanPham);
        List<SanPham> GetListSanPham();
        List<SanPham> GetListByTenSanPham(string TenSanPham);
        List<SanPham> GetListByHanSuDungRange(DateTime fromHSD, DateTime toHSD);
        int UpdateSanPham(SanPham sanPham);
        int DeleteSanPham(int MaSanPham);
    }
}
