using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap6
{
    internal class Program
    {
        static Dictionary<string, string> quanLyXe = new Dictionary<string, string>();

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("\nCHƯƠNG TRÌNH QUẢN LÝ XE");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("1. Nhập xe mới");
                Console.WriteLine("2. Xóa xe theo biển số");
                Console.WriteLine("3. Tìm kiếm xe theo biển số");
                Console.Write("Nhập lựa chọn của bạn: ");

                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "0":
                        Console.WriteLine("Thoát chương trình");
                        return;
                    case "1":
                        NhapXeMoi();
                        break;
                    case "2":
                        XoaXe();
                        break;
                    case "3":
                        TimKiemXe();
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại.");
                        break;
                }
            }
        }

        static void NhapXeMoi()
        {
            Console.Write("Nhập biển số xe: ");
            string bienSo = Console.ReadLine();
            if (quanLyXe.ContainsKey(bienSo))
            {
                Console.WriteLine("Xe này đã tồn tại trong hệ thống.");
                return;
            }

            Console.Write("Nhập thông tin xe: ");
            string thongTinXe = Console.ReadLine();
            quanLyXe.Add(bienSo, thongTinXe);
            Console.WriteLine("Đã thêm xe mới thành công.");
        }

        static void XoaXe()
        {
            Console.Write("Nhập biển số xe muốn xóa: ");
            string bienSo = Console.ReadLine();
            if (quanLyXe.ContainsKey(bienSo))
            {
                quanLyXe.Remove(bienSo);
                Console.WriteLine("Đã xóa xe thành công.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy xe với biển số này.");
            }
        }

        static void TimKiemXe()
        {
            Console.Write("Nhập biển số xe muốn tìm: ");
            string bienSo = Console.ReadLine();
            if (quanLyXe.ContainsKey(bienSo))
            {
                Console.WriteLine($"Thông tin xe với biển số {bienSo}: {quanLyXe[bienSo]}");
            }
            else
            {
                Console.WriteLine("Không tìm thấy xe với biển số này.");
            }
        }
    }
}
