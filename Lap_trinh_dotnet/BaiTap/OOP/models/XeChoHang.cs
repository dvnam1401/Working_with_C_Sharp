using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class XeChoHang : Xe
    {
        private double SoTan;
        public XeChoHang()
        {            
        }
        public XeChoHang(string bienSo, string tenXe, int trongTai, DateTime ngayDangKiem, int tieuChuanBang, double SoTan) 
            : base(bienSo, tenXe, trongTai, ngayDangKiem, tieuChuanBang)
        {
            this.SoTan = SoTan;
        }

        public double Sotan
        {
            get { return SoTan; }
            set { SoTan = value; }
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Số tấn của xe: ");
            SoTan = double.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.Write("Số tấn của xe: " + Sotan);
        }
    }
}
