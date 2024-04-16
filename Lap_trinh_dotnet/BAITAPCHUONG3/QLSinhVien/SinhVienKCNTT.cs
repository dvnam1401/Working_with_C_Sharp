using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    internal class SinhVienKCNTT : SinhVien
    {
        public double DiemCS414 { get; set; }
        public double DiemIS311 { get; set; }
        public double DiemCS311 { get; set; }
        public override double DiemTB => (DiemCS414 + DiemIS311 + DiemCS311) / 3;

        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập điểm CS414: ");
            DiemCS414 = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm IS311: ");
            DiemIS311 = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm CS311: ");
            DiemCS311 = double.Parse(Console.ReadLine());
        }         
    }
}
