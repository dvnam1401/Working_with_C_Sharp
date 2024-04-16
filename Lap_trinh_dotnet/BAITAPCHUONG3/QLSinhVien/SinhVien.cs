using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    internal abstract class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public virtual double DiemTB { get; }   
        public void Nhap()
        {
            Console.Write("Nhập MSSV: ");
            MSSV = Console.ReadLine();
            Console.Write("Nhập Họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập Địa chỉ: ");
            DiaChi = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.Write("Nhập Ngày sinh (dd/MM/yyyy): ");
                    NgaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                    break;
                }
                catch
                {
                    Console.WriteLine("Ngày sinh không hợp lệ, vui lòng nhập lại.");
                }
            }
        }
        public void Xuat()
        {
            Console.WriteLine($"MSSV: {MSSV}, Họ tên: {HoTen}, Địa chỉ: {DiaChi}, Ngày sinh: {NgaySinh.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Điểm trung bình: {DiemTB}, Xếp loại: {TinhXepLoai()}");
        }
        public string TinhXepLoai()
        {
            if (DiemTB >= 8) return "Giỏi";
            else if (DiemTB >= 6.5) return "Khá";
            else if (DiemTB >= 5) return "Trung Bình";
            else return "Yếu";
        }
    }
}
