using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh1
{
    internal class NhanVienBienChe : NhanVien, ILuong
    {
        public double HeSoLuong { get; set; }
        public double LuongCoBan { get; set; }
        public double PhuCap()
        {
            return LuongCoBan / 10;
        }

        public double ThucLinh()
        {
            return HeSoLuong * LuongCoBan + PhuCap();
        }

        public void Nhap()
        {
            base.Nhap();
            Console.Write("Hệ số lương nhân viên: ");
            HeSoLuong = Double.Parse(Console.ReadLine());
            Console.Write("Lương căn bản: ");
            LuongCoBan = Double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Hệ số lương nhân viên: " + HeSoLuong);            
            Console.WriteLine("Lương căn bản: " + LuongCoBan);            
        }
    }
}
