using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    internal class SinhVienDienTu : SinhVien
    {
        public double DiemEE200 { get; set; }
        public double DiemEE201 { get; set; }
        public double DiemEE205 { get; set; }
        public override double DiemTB => (DiemEE200 + DiemEE201 + DiemEE205) / 3;
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập điểm EE200: ");
            DiemEE200 = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm EE201: ");
            DiemEE201 = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm EE205: ");
            DiemEE205 = double.Parse(Console.ReadLine());
        }
    }
}
