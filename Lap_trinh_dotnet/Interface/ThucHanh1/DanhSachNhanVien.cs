using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh1
{
    internal class DanhSachNhanVien : NhanVien
    {
        Dictionary<string, NhanVien> ListNhanVien;
        public DanhSachNhanVien()
        {
            ListNhanVien = new Dictionary<string, NhanVien>();
        }
        NhanVienBienChe nhanVienBienChe = new NhanVienBienChe();
        NhanVienHopDong nhanVienHopDong = new NhanVienHopDong();
        public void Nhap()
        {
            while (true)
            {
                Console.WriteLine("Nhập 0 để thoát.");
                Console.WriteLine("Nhập 1 để thêm nhân viên biên chế.");
                Console.WriteLine("Nhập 2 để thêm nhân viên hợp đồng.");
                Console.Write("Nhập lựa chọn của bạn: ");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        return;
                    case 1:
                        NhapNhanVienBienChe();
                        break;
                    case 2:
                        NhapNhanVienHopDong();
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ");
                        break;
                }
            }
        }

        public void Xuat()
        {
            while (true)
            {
                Console.WriteLine("Nhập 0 để thoát.");
                Console.WriteLine("Nhập 1 để xem nhân viên biên chế.");
                Console.WriteLine("Nhập 2 để xem nhân viên hợp đồng.");
                Console.Write("Nhập lựa chọn của bạn: ");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        return;
                    case 1:
                        nhanVienBienChe.Xuat();
                        break;
                    case 2:
                        nhanVienHopDong.Xuat();
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ");
                        break;
                }
            }
        }

        public void NhapNhanVienBienChe()
        {
            nhanVienBienChe.Nhap();
            ListNhanVien.Add(nhanVienBienChe.MaNhanVien, nhanVienBienChe);
        }
        public void NhapNhanVienHopDong()
        {
            nhanVienHopDong.Nhap();
            ListNhanVien.Add(nhanVienHopDong.MaNhanVien, nhanVienBienChe);
        }

        public double TongQuyLuong()
        {
            double sum = 0;
            foreach (var nhanvien in ListNhanVien)
            {
                if (nhanvien is NhanVienBienChe)
                {
                    var nhanVienBienChe = (NhanVienBienChe)nhanvien.Value;
                    // Sử dụng hàm ThucLinh của NhanVienBienChe
                    sum += nhanVienBienChe.ThucLinh();

                }
                else if (nhanvien is NhanVienHopDong)
                {
                    var nhanVienHopDong = (NhanVienHopDong)nhanvien.Value;
                    // Sử dụng hàm ThucLinh của NhanVienHopDong
                    sum += nhanVienHopDong.ThucLinh();
                }
            }
            return sum;
        }

        public void Tim()
        {
            Console.Write("Nhập mã nhân viên cần tìm: ");
            string maNhanVien = Console.ReadLine();
            ListNhanVien.ContainsKey(maNhanVien);
            NhanVien nhanVien = ListNhanVien[maNhanVien];
            nhanVien.Xuat();
        }

        public void Xoa()
        {
            Console.Write("Nhập mã nhân viên cần xóa: ");
            string maNhanVien = Console.ReadLine();
            if (ListNhanVien.Remove(maNhanVien))
            {
                Console.WriteLine("Xóa thành công");
            }
            else
            {
                Console.WriteLine("Nhân viên không tồn tại");
            }
        }
    }
}
