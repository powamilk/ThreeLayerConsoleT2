using ThreeLayerConsoleT2.DAL.Entities;
using ThreeLayerConsoleT2.DAL.Repositories.Interface;

namespace ThreeLayerConsoleT2.DAL.Repositories.Implement
{
    public class SanPhamRepo : ISanPhamRepo
    {
        private readonly ThreeLayerDB_2Context _dbContext;
        public SanPhamRepo()
        {
            _dbContext = new ThreeLayerDB_2Context();
        }

        public void AddSanPham(SanPham sanPham)
        {
            _dbContext.SanPhams.Add(sanPham);
            _dbContext.SaveChanges();
        }
        public List<SanPham> GetListSanPham()
        {
            return _dbContext.SanPhams.ToList();
        }
        public List<SanPham> GetListByTenSanPham(string TenSanPham)
        {
            return _dbContext.SanPhams.Where(sp => TenSanPham.Contains(TenSanPham)).ToList();
        }
        public List<SanPham> GetListByHanSuDungRange(DateTime fromHSD, DateTime toHSD)
        {
            return _dbContext.SanPhams.Where(sp => sp.HanSuDung >= fromHSD && sp.HanSuDung <= toHSD).ToList();
        }
        public int UpdateSanPham(SanPham sanPham)
        {
            var existingSP = _dbContext.SanPhams.Find(sanPham.MaSanPham);

            if (existingSP != null)
            {
                existingSP.NhaSanXuat = sanPham.NhaSanXuat;
                existingSP.MoTa = sanPham.MoTa;
                existingSP.GiaBan = sanPham.GiaBan;
                existingSP.SoLuongTon = sanPham.SoLuongTon;
                existingSP.HanSuDung = sanPham.HanSuDung;
                existingSP.XuatXu = sanPham.XuatXu;
                existingSP.NgaySanXuat = sanPham.NgaySanXuat;
                existingSP.TenSanPham = sanPham.TenSanPham;
                existingSP.TrangThai = sanPham.TrangThai;
                existingSP.MaLoai = sanPham.MaLoai;

                _dbContext.SaveChanges();
                return 1;
            }
            else
            {
                return 3;
            }
        }
        public int DeleteSanPham(int MaSanPham)
        {
            var sanPham = _dbContext.SanPhams.Find(MaSanPham);
            if (sanPham == null)
            {
                _dbContext.SanPhams.Remove(sanPham);
                _dbContext.SaveChanges();
                return 1;
            }
            else
            {
                return 3;
            }
        }
    }
}
