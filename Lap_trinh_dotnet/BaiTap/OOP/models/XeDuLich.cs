using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class XeDuLich : Xe
    {
        private int SoChoNgoi;
        public XeDuLich()
        {            
        }

        public XeDuLich(string bienSo, string tenXe, int trongTai, DateTime ngayDangKiem, int tieuChuanBang, int soChoNgoi) 
            : base(bienSo, tenXe, trongTai, ngayDangKiem, tieuChuanBang)
        {            
            SoChoNgoi = soChoNgoi;
        }        

        public int Sochongoi
        {
            get { return SoChoNgoi; }
            set { SoChoNgoi = value; }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Số chỗ ngồi: ");
            SoChoNgoi = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Số chỗ ngồi của xe: " + Sochongoi);
        }

    }
}
