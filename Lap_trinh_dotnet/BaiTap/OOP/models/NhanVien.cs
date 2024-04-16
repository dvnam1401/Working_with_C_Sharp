using OOP.models.inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.models
{
    internal class NhanVien : INguoi
    {
        public string maNhanVien { get; set; }
        public DateTime ngayVaoCoQuan { get; set; }
        public override void Nhap()
        {
            Console.WriteLine("Nhập số chứng minh nhân viên: ");
            soChungMinh = long.Parse(Console.ReadLine());
            Console.WriteLine("Nhập họ tên nhân viên: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ nhân viên: ");
            diaChi = Console.ReadLine();
            Console.WriteLine("Nhập số điện thoại nhân viên: ");
            dienThoai = Console.ReadLine();
            Console.WriteLine("Nhập mã nhân viên: ");
            maNhanVien = Console.ReadLine();
            Console.WriteLine("Ngày vào làm việc: ");
            ngayVaoCoQuan = DateTime.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            Console.WriteLine();
            Console.WriteLine($"Thông tin nhân viên {maNhanVien}");
            Console.WriteLine($"Họ tên: {hoTen}");
            Console.WriteLine($"Địa chỉ: {diaChi}");
            Console.WriteLine($"Số chứng minh nhân viên: {soChungMinh}");
            Console.WriteLine($"Số điện thoại: {dienThoai}");
            Console.WriteLine($"Ngày vào làm việc: {ngayVaoCoQuan}");
        }
    }
}
