using ThreeLayerConsoleT2.BUS.Interface;
using ThreeLayerConsoleT2.BUS.Utils;
using ThreeLayerConsoleT2.BUS.ViewModel;
using ThreeLayerConsoleT2.DAL.Entities;
using ThreeLayerConsoleT2.DAL.Repositories.Implement;
using ThreeLayerConsoleT2.DAL.Repositories.Interface;

namespace ThreeLayerConsoleT2.BUS.Implement
{
    public class SanPhamService : ISanPhamService
    {
        private readonly ISanPhamRepo _sanPhamRepo;

        // Constructor không tham số, khởi tạo SanPhamrepo
        public SanPhamService()
        {
            _sanPhamRepo = new SanPhamRepo();
        }

        public bool AddSanPham(SanPhamCreateVM sanPhamCreateVM)
        {
            try
            {
                SanPham sanPham = MappingSanPham.MapCreateVMToEntity(sanPhamCreateVM);

                _sanPhamRepo.AddSanPham(sanPham);

                // Trả về true nếu thêm thành công
                return true;
            }
            catch (Exception)
            {
                // Trả về false nếu có lỗi xảy ra
                return false;
            }
        }
        public List<SanPhamVM> GetListByTenSanPham(string TenSanPham)
        {
            List<SanPham> listEntities = _sanPhamRepo.GetListByTenSanPham(TenSanPham);

            List<SanPhamVM> listVMs = new List<SanPhamVM>();

            foreach (var entity in listEntities)
            {
                listVMs.Add(MappingSanPham.MapEntityToVM(entity));
            }

            return listVMs;
        }
        public List<SanPhamVM> GetListSanPham()
        {
            List<SanPham> listEntities = _sanPhamRepo.GetListSanPham();

            List<SanPhamVM> listVMs = new List<SanPhamVM>();

            foreach (var entity in listEntities)
            {
                listVMs.Add(MappingSanPham.MapEntityToVM(entity));
            }

            return listVMs;
        }
        public List<SanPhamVM> GetListByHanSuDungRange(DateTime fromHSD, DateTime toHSD)
        {
            List<SanPham> listEntities = _sanPhamRepo.GetListByHanSuDungRange(fromHSD, toHSD);

            List<SanPhamVM> listVMs = new List<SanPhamVM>();

            foreach (var entity in listEntities)
            {
                listVMs.Add(MappingSanPham.MapEntityToVM(entity));
            }

            return listVMs;

        }
        public int UpdateSanPham(SanPhamUpdateVM sanPhamUpdateVM)
        {
            SanPham sanPham = MappingSanPham.MapUpdateVMToEntity(sanPhamUpdateVM);

            return _sanPhamRepo.UpdateSanPham(sanPham);
        }
        public int DeleteSanPham(int MaSanPham)
        {
            return _sanPhamRepo.DeleteSanPham(MaSanPham);
        }
    }
}
