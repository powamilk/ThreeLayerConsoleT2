using ThreeLayerConsoleT2.BUS.Implement;
using ThreeLayerConsoleT2.BUS.Interface;
using ThreeLayerConsoleT2.BUS.ViewModel;

namespace ThreeLayerConsoleT2.PL.UI
{
    public class SanPhamUI
    {
        private readonly ISanPhamService _sanPhamService;

        public SanPhamUI()
        {
            _sanPhamService = new SanPhamService();
        }

        public void Menu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Xin mời chọn chức năng:");
                Console.WriteLine("1. Thêm Sản Phẩm");
                Console.WriteLine("2. Xuất Danh Sách Sản Phẩm");
                Console.WriteLine("3. Xuất Danh Sách Sản Phẩm Theo Tên");
                Console.WriteLine("4. Lấy Danh Sách Sản Phẩm Có Hạn Sử Dụng Trong Khoảng");
                Console.WriteLine("5. Cập Nhật Sản Phẩm");
                Console.WriteLine("6. Xóa Sản Phẩm");
                Console.WriteLine("7. Thống Kê");
                Console.WriteLine("8. Thoát");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        {
                            SanPhamCreateVM createVM = new SanPhamCreateVM();

                            Console.WriteLine("Nhập tên sản phẩm:");
                            createVM.TenSanPham = Console.ReadLine();

                            Console.WriteLine("Nhập mô tả:");
                            createVM.MoTa = Console.ReadLine();

                            Console.WriteLine("Nhập giá bán:");
                            createVM.GiaBan = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Nhập số lượng tồn:");
                            createVM.SoLuongTon = int.Parse(Console.ReadLine());

                            Console.WriteLine("Nhập nhà sản xuất:");
                            createVM.NhaSanXuat = Console.ReadLine();

                            Console.WriteLine("Nhập xuất xứ:");
                            createVM.XuatXu = Console.ReadLine();

                            Console.WriteLine("Nhập ngày sản xuất (dd/MM/yyyy):");
                            if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime ngaySanXuat))
                            {
                                createVM.NgaySanXuat = ngaySanXuat;
                            }
                            else
                            {
                                Console.WriteLine("Ngày không hợp lệ.");
                                break;
                            }

                            Console.WriteLine("Nhập hạn sử dụng (dd/MM/yyyy):");
                            if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime hanSuDung))
                            {
                                createVM.HanSuDung = hanSuDung;
                            }
                            else
                            {
                                Console.WriteLine("Ngày không hợp lệ.");
                                break;
                            }

                            Console.WriteLine("Nhập trạng thái:");
                            string trangThaiStr = Console.ReadLine();
                            if (int.TryParse(trangThaiStr, out int trangThai))
                            {
                                createVM.TrangThai = trangThai;
                            }
                            else
                            {
                                Console.WriteLine("Trạng thái không hợp lệ. Vui lòng nhập lại.");
                                // Thêm xử lý bổ sung nếu cần thiết, ví dụ như yêu cầu nhập lại hoặc xử lý lỗi khác.
                            }

                            Console.WriteLine("Nhập mã loại:");
                            createVM.MaLoai = int.Parse(Console.ReadLine());

                            _sanPhamService.AddSanPham(createVM);
                            Console.WriteLine("Thêm sản phẩm thành công.");
                            break;
                        }
                    case "2":
                        {
                            var listSanPham = _sanPhamService.GetListSanPham();
                            foreach (var sanPham in listSanPham)
                            {
                                Console.WriteLine($"Mã sản phẩm: {sanPham.MaSanPham}, Tên sản phẩm: {sanPham.TenSanPham}, Giá bán: {sanPham.GiaBan}, Số lượng tồn: {sanPham.SoLuongTon}");
                            }
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Nhập tên sản phẩm:");
                            string tenSanPham = Console.ReadLine();

                            var listSanPham = _sanPhamService.GetListByTenSanPham(tenSanPham);
                            foreach (var sanPham in listSanPham)
                            {
                                Console.WriteLine($"Mã sản phẩm: {sanPham.MaSanPham}, Tên sản phẩm: {sanPham.TenSanPham}, Giá bán: {sanPham.GiaBan}, Số lượng tồn: {sanPham.SoLuongTon}");
                            }
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Nhập từ ngày hết hạn (dd/MM/yyyy):");
                            if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fromHSD))
                            {
                                Console.WriteLine("Nhập đến ngày hết hạn (dd/MM/yyyy):");
                                if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime toHSD))
                                {
                                    var listSanPham = _sanPhamService.GetListByHanSuDungRange(fromHSD, toHSD);
                                    foreach (var sanPham in listSanPham)
                                    {
                                        Console.WriteLine($"Mã sản phẩm: {sanPham.MaSanPham}, Tên sản phẩm: {sanPham.TenSanPham}, Hạn sử dụng: {sanPham.HanSuDung}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ngày không hợp lệ.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ngày không hợp lệ.");
                            }
                            break;
                        }
                    case "5":
                        {
                            SanPhamUpdateVM updateVM = new SanPhamUpdateVM();

                            Console.WriteLine("Nhập mã sản phẩm cần cập nhật:");
                            updateVM.MaSanPham = int.Parse(Console.ReadLine());

                            Console.WriteLine("Nhập giá bán mới:");
                            updateVM.GiaBan = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Nhập số lượng tồn mới:");
                            updateVM.SoLuongTon = int.Parse(Console.ReadLine());

                            int result = _sanPhamService.UpdateSanPham(updateVM);
                            if (result > 0)
                            {
                                Console.WriteLine("Cập nhật sản phẩm thành công.");
                            }
                            else
                            {
                                Console.WriteLine("Cập nhật sản phẩm thất bại.");
                            }
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine("Nhập mã sản phẩm cần xóa:");
                            int maSanPham = int.Parse(Console.ReadLine());

                            int result = _sanPhamService.DeleteSanPham(maSanPham);
                            if (result > 0)
                            {
                                Console.WriteLine("Xóa sản phẩm thành công.");
                            }
                            else
                            {
                                Console.WriteLine("Xóa sản phẩm thất bại.");
                            }
                            break;
                        }
                    case "7":
                        {
                            break;
                        }
                    case "8":
                        Console.WriteLine("Thoát chương trình.");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }

                // Đợi người dùng nhấn một phím để tiếp tục hoặc thoát
                if (!exit)
                {
                    Console.WriteLine("Nhấn phím bất kỳ để tiếp tục...");
                    Console.ReadKey();
                    Console.Clear(); // Xóa màn hình để chọn menu tiếp theo
                }

            }
            Console.ReadKey();
        }
    }
}
