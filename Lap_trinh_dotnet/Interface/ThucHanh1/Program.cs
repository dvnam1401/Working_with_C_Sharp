using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DanhSachNhanVien danhSachNhanVien = new DanhSachNhanVien();
            while (true)
            {
                Console.WriteLine("Nhập 0 để thoát.");
                Console.WriteLine("Nhập 1 để thêm nhân viên.");
                Console.WriteLine("Nhập 2 để in ra nhân viên.");
                Console.WriteLine("Nhập 3 để tìm nhân viên.");
                Console.WriteLine("Nhập 4 để xóa nhân viên.");
                Console.WriteLine("Nhập 5 để tính tổng quỷ lương nhân viên.");
                Console.Write("Nhập lựa chọn của bạn: ");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        return;
                    case 1:
                        danhSachNhanVien.Nhap();
                        break;
                    case 2:
                        danhSachNhanVien.Xuat();
                        break;
                    case 3:
                        danhSachNhanVien.Tim();
                        break;
                    case 4:
                        danhSachNhanVien.Xoa();
                        break;
                    case 5:
                        Console.WriteLine("Tổng quỷ lương: " + danhSachNhanVien.TongQuyLuong());
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ");
                        break;
                }
            }
        }
    }
}
