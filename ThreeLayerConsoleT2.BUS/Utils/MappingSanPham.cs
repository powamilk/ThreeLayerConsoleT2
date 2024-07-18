using ThreeLayerConsoleT2.BUS.ViewModel;
using ThreeLayerConsoleT2.DAL.Entities;

namespace ThreeLayerConsoleT2.BUS.Utils
{
    public static class MappingSanPham
    {
        public static SanPhamVM MapEntityToVM(SanPham entity)
        {
            if (entity == null)
                return null;

            return new SanPhamVM
            {
                MaSanPham = entity.MaSanPham,
                TenSanPham = entity.TenSanPham,
                MoTa = entity.MoTa,
                GiaBan = entity.GiaBan,
                SoLuongTon = entity.SoLuongTon,
                NhaSanXuat = entity.NhaSanXuat,
                XuatXu = entity.XuatXu,
                HanSuDung = entity.HanSuDung,
                NgaySanXuat = entity.NgaySanXuat,
                TrangThai = entity.TrangThai,
                MaLoai = entity.MaLoai,
            };
        }

        public static SanPham MapCreateVMToEntity(SanPhamCreateVM createVM)
        {
            if (createVM == null)
                return null;

            return new SanPham
            {
                TenSanPham = createVM.TenSanPham,
                MoTa = createVM.MoTa,
                GiaBan = createVM.GiaBan,
                SoLuongTon = createVM.SoLuongTon,
                NhaSanXuat = createVM.NhaSanXuat,
                XuatXu = createVM.XuatXu,
                HanSuDung = createVM.HanSuDung,
                NgaySanXuat = createVM.NgaySanXuat,
                TrangThai = createVM.TrangThai,
                MaLoai = createVM.MaLoai,
            };
        }

        public static SanPham MapUpdateVMToEntity(SanPhamUpdateVM updateVM)
        {
            return new SanPham
            {
                TenSanPham = updateVM.TenSanPham,
                MoTa = updateVM.MoTa,
                GiaBan = updateVM.GiaBan,
                SoLuongTon = updateVM.SoLuongTon,
                NhaSanXuat = updateVM.NhaSanXuat,
                XuatXu = updateVM.XuatXu,
                HanSuDung = updateVM.HanSuDung,
                NgaySanXuat = updateVM.NgaySanXuat,
                TrangThai = updateVM.TrangThai,
                MaLoai = updateVM.MaLoai,
            };
        }
    }
}
