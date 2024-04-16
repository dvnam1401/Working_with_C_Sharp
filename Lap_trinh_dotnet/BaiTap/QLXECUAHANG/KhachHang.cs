using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXECUAHANG
{
    class KhachHang:Nguoi
    {
        string makhachhang;
        DateTime hangbanglai;
        public string Makhachhang { get => makhachhang; set => makhachhang = value; }
        public DateTime Hangbanglai { get => hangbanglai; set => hangbanglai = value; }
        public override void Nhap()
        {
            Console.WriteLine("*****Nhap thong tin khach hang*****");
            Console.WriteLine("Nhap vao ma so khach hang");
            Makhachhang = Console.ReadLine();
            Console.WriteLine("Nhap vao So chung minh");
            Socm = long.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao ho ten");
            Hoten = Console.ReadLine();
            Console.WriteLine("Nhap vao dia chi");
            Diachi = Console.ReadLine();
            Console.WriteLine("Nhap vao dien thoai");
            Dienthoai = Console.ReadLine();
            Console.WriteLine("Nhap vao hang bang lai");
            Hangbanglai = DateTime.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("*****Thong tin nhan vien*****");
            Console.WriteLine("Ma so khach hang la: " + Makhachhang);
            Console.WriteLine("So cmnd khach hang la: " + Socm);
            Console.WriteLine("Ho ten khach hang la: " + Hoten);
            Console.WriteLine("Dia chi khach hang la: " + Diachi);
            Console.WriteLine("Dien thoai khach hang la: " + Dienthoai);
            Console.WriteLine("Ngay vao co quan khach hang la: " + Hangbanglai);
        }
    }
}