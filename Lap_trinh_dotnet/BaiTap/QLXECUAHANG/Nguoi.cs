using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXECUAHANG
{
    abstract class Nguoi
    {
        long socm;
        string hoten, diachi, dienthoai;
        public long Socm { get => socm; set => socm = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Dienthoai { get => dienthoai; set => dienthoai = value; }
        public abstract void Nhap();
        public abstract void Xuat();
    }
}
