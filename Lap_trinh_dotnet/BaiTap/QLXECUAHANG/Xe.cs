using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXECUAHANG
{
    class Xe
    {
        string bienso, tenxe;
        int trongtai, tieuchuanbang;
        DateTime ngaydangkiem;
        public string Bienso { get => bienso; set => bienso = value; }
        public string Tenxe { get => tenxe; set => tenxe = value; }
        public int Trongtai { get => trongtai; set => trongtai = value; }
        public int Tieuchuanbang { get => tieuchuanbang; set => tieuchuanbang = value; }
        public DateTime Ngaydangkiem { get => ngaydangkiem; set => ngaydangkiem = value; }
        public virtual void Nhap()
        {
            Console.WriteLine("*****Nhap vao thong tin xe*****");
            Console.WriteLine("Nhap vao bien so xe");
            Bienso = Console.ReadLine();
            Console.WriteLine("Nhap vao ten xe");
            Tenxe = Console.ReadLine();
            Console.WriteLine("Nhap vao trong tai xe");
            Trongtai = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao tieu chuan bang xe");
            Tieuchuanbang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao ngay dang kiem xe");
            Ngaydangkiem = DateTime.Parse(Console.ReadLine());
        }
        public  void Xuat()
        {
            Console.WriteLine("*****THONG TIN XE*****");
            Console.WriteLine("Bien so xe la: {0}", Bienso);
            Console.WriteLine("Ten xe la: "+Tenxe);
            Console.WriteLine("Trong tai xe la: " + Trongtai);
            Console.WriteLine("Tieu chuan bang xe la: " + Tieuchuanbang);
            Console.WriteLine("Ngay dang kiem xe la: " + Ngaydangkiem);
        }
    }
}
