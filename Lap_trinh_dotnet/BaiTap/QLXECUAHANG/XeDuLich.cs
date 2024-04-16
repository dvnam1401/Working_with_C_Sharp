using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXECUAHANG
{
    class XeDuLich:Xe
    {
        int sochongoi;
        public int Sochongoi { get => sochongoi; set => sochongoi = value; }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap vao so cho ngoi xe");
            Sochongoi = int.Parse(Console.ReadLine());
        }
        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So cho ngoi cho hang " + Sochongoi);
        }
    }
}