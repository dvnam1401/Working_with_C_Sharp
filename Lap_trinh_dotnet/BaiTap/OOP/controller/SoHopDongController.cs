using OOP.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.controller
{
    internal class SoHopDongController
    {
        SoHopDongService soHopDong = new SoHopDongService();
        public SoHopDongController()
        {
        }
        public void nhapLuaChon()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Nhập 0 để thoát. ");
                Console.WriteLine("1. Để thêm hợp đồng");
                Console.WriteLine("2. Để tìm hợp đồng");
                Console.WriteLine("3. Để xóa hợp đồng");
                Console.Write("Nhập lựa chọn của bạn: ");
                string choose = Console.ReadLine().ToUpper();
                Console.WriteLine();

                switch (choose)
                {
                    case "0":
                        return;
                    case "1":
                        addSoHopDong();
                        break;
                    case "2":
                        findHopDong();
                        break;
                    case "3":
                        xoadHopDong();
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ");
                        break;
                }
            }
            Console.WriteLine();
        }

        public void findHopDong()
        {
            Console.WriteLine("Nhập vào mã hợp đồng muốn tìm: ");
            string maHopDong = Console.ReadLine();
            soHopDong.findSoHopDong(maHopDong);
        }

        public void addSoHopDong()
        {
            Console.WriteLine("===Thông tin hợp đồng===");
            soHopDong.saveSoHopDong();
        }
        public void xoadHopDong()
        {
            Console.WriteLine("Nhập vào mã hợp đồng muốn xóa: ");
            string maHopDong = Console.ReadLine();
            soHopDong.removeSoHopDong(maHopDong);
        }
    }
}
