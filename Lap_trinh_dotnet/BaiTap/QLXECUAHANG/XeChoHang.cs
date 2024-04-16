using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXECUAHANG
{
    class XeChoHang : Xe
    {
        int sotan;
        public int Sotan { get => sotan; set => sotan = value; }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap vao so tan xe");
            Sotan = int.Parse(Console.ReadLine());
        }
        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So Tan xe cho hang " + Sotan);
        }
    }
}
