using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh1
{
    internal class NhanVienHopDong : NhanVien, ILuong
    {
        public double MucLuong { get; set; }
        public double PhuCap()
        {
            return MucLuong / 10;
        }

        public double ThucLinh()
        {
            return MucLuong + PhuCap();
        }
        public void Nhap()
        {
            base.Nhap();
            Console.Write("Mức lương nhân viên: ");
            MucLuong = Double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Mức lương nhân viên: " + MucLuong);
        }
    }
}
