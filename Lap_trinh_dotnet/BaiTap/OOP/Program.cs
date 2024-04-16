using OOP.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            XeController xeController = new XeController();
            SoHopDongController soHopDongController = new SoHopDongController();
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
                        xeController.nhapLuaChon();
                        break;
                    case "2":
                        soHopDongController.nhapLuaChon();
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại.");
                        break;
                }
            }
        }
    }
}
