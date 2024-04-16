using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXECUAHANG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SoHopDong soHopDong = new SoHopDong();
            QuanLyXe qLXECUAHANG = new QuanLyXe();
            while (true)
            {
                Console.WriteLine("\nQUẢN LÝ XE CHO THUÊ");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("1. Thêm xe mới");
                Console.WriteLine("2. Thêm hợp đồng thuê");
                Console.Write("Nhập lựa chọn của bạn: ");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "0":
                        Console.WriteLine("Thoát chương trình");
                        return;
                    case "1":
                        qLXECUAHANG.Nhap();
                        break;
                    case "2":
                        soHopDong.Luu();
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại.");
                        break;
                }
            }
        }
    }
}
