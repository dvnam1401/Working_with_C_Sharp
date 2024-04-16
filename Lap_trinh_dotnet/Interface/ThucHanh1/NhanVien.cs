using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh1
{
    internal class NhanVien
    {
        public string HoTen { get; set; }
        public DateTime NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string SoCMND { get; set; }
        public string MaNhanVien { get; set; }
        public void Nhap()
        {
            Console.WriteLine("===Nhâp thông tin nhân viên===");
            Console.Write("Họ tên nhân viên: ");
            HoTen = Console.ReadLine();
            Console.Write("Năm sinh: ");
            NamSinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Giới tinh: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Số chứng minh: ");
            SoCMND = Console.ReadLine();
            Console.Write("Mã nhân viên: ");
            MaNhanVien = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine("===Thông tin nhân viên===");
            Console.WriteLine("Họ tên nhân viên: " + HoTen);
            Console.WriteLine("Năm sinh: " + NamSinh);
            Console.WriteLine("Giới tinh: " + GioiTinh);
            Console.WriteLine("Số chứng minh: " + SoCMND);
            Console.WriteLine("Mã nhân viên: " + MaNhanVien);

        }
    }
}
