using OOP.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class XeController
    {
        public XeController()
        {
        }
        XeService xeService = new XeService();

        public void nhapLuaChon()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Nhập 0 để thoát. ");
                Console.WriteLine("1. Để thêm xe");
                Console.WriteLine("2. Để tìm xe");
                Console.WriteLine("3. Để xóa xe");
                Console.Write("Nhập lựa chọn của bạn: ");
                string choose = Console.ReadLine().ToUpper();
                Console.WriteLine();

                switch (choose)
                {
                    case "0":
                        return;
                    case "1":
                        addXe();
                        break;
                    case "2":
                        findXe();
                        break;
                    case "3":
                        removeXe();
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ");
                        break;
                }
            }
            Console.WriteLine();
        }
        public void addXe()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Nhap vao so luong xe");
                int soxe = int.Parse(Console.ReadLine());
                for (int i = 0; i < soxe; i++)
                {
                    Console.WriteLine("Nhập 0 để thoát. ");
                    Console.WriteLine("Nhập vào (H) để thêm xe chở hàng.");
                    Console.WriteLine("Nhập vào (D) để thêm xe du lịch.");
                    Console.Write("Nhập lựa chọn của bạn: ");
                    string choose = Console.ReadLine().ToUpper();
                    Console.WriteLine();

                    switch (choose)
                    {
                        case "0":
                            return;
                        case "H":
                            xeService.inputXechohang();
                            break;
                        case "D":
                            xeService.inputXedulich();
                            break;
                    }
                    Console.WriteLine();
                }
                flag = optionInput(flag);

            }
        }

        private bool optionInput(bool flag)
        {
            Console.Write("Bạn có muốn tiếp tục không y/N: ");
            string choose = Console.ReadLine().ToLower();
            switch (choose)
            {
                case "y":
                    flag = true;
                    break;
                case "n":
                    flag = false;
                    break;
            }
            return flag;
        }

        public void findXe()
        {
            Console.Write("Nhập biển số xe muốn tìm: ");
            string bienSo = Console.ReadLine();
            if (xeService.findXeService(bienSo) is null)
            {
                Console.WriteLine("Xe không tồn tại");
            }
            else
            {
                Xe xe = xeService.findXeService(bienSo);
                Console.WriteLine($"Thông tin xe với biển số {bienSo}: ");
                xe.Xuat();
            }
        }

        public void removeXe()
        {
            Console.Write("Nhập biển số cần xóa: ");
            string bienSo = Console.ReadLine();
            xeService.removeXeService(bienSo);
        }
    }
}
