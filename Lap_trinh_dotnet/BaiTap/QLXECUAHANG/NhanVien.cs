using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXECUAHANG
{
    class NhanVien : Nguoi
    {
        string manhanvien;
        DateTime ngayvaocoquan;
        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
        public DateTime Ngayvaocoquan { get => ngayvaocoquan; set => ngayvaocoquan = value; }
        public override void Nhap()
        {
            Console.WriteLine("*****Nhap thong tin nhan vien*****");
            Console.WriteLine("Nhap vao ma so nhan vien");
            Manhanvien = Console.ReadLine();
            Console.WriteLine("Nhap vao So chung minh");
            Socm = long.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao ho ten");
            Hoten = Console.ReadLine();
            Console.WriteLine("Nhap vao dia chi");
            Diachi = Console.ReadLine();
            Console.WriteLine("Nhap vao dien thoai");
            Dienthoai = Console.ReadLine();
            Console.WriteLine("Nhap vao ngay vao co quan");
            Ngayvaocoquan = DateTime.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("*****Thong tin nhan vien*****");
            Console.WriteLine("Ma so nhan vien la: " + Manhanvien);
            Console.WriteLine("So cmnd nhan vien la: " + Socm);
            Console.WriteLine("Ho ten nhan vien la: " + Hoten);
            Console.WriteLine("Dia chi nhan vien la: " + Diachi);
            Console.WriteLine("Dien thoai nhan vien la: " + Dienthoai);
            Console.WriteLine("Ngay vao co quan nhan vien la: " + Ngayvaocoquan);
        }
    }
}
