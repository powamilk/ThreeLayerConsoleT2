using ThreeLayerConsoleT2.BUS.ViewModel;

namespace ThreeLayerConsoleT2.BUS.Interface
{
    public interface ISanPhamService
    {
        bool AddSanPham(SanPhamCreateVM createVM);
        List<SanPhamVM> GetListByTenSanPham(string TenSanPham);
        List<SanPhamVM> GetListSanPham();
        List<SanPhamVM> GetListByHanSuDungRange(DateTime fromHSD, DateTime toHSD);
        int UpdateSanPham(SanPhamUpdateVM updateVM);
        int DeleteSanPham(int maSanPham);

    }
}
