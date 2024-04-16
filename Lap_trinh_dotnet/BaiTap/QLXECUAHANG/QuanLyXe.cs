using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXECUAHANG
{
    class QuanLyXe
    {
        Dictionary<string, Xe> list;
        internal Dictionary<string, Xe> List { get => list; set => list = value; }
        public QuanLyXe()
        {
            List = new Dictionary<string, Xe>();
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap vao so luong xe");
            int soxe = int.Parse(Console.ReadLine());
            for (int i = 0; i < soxe; i++)
            {
                Console.WriteLine("(H) de nhap xe hang, (D) de nhap xe du lich");
                char kytu = char.Parse(Console.ReadLine().ToUpper());
                switch (kytu)
                {
                    case 'D':
                        XeDuLich xedl = new XeDuLich();
                        xedl.Nhap();
                        List.Add(xedl.Bienso, xedl);
                        break;
                    case 'H':
                        XeChoHang xehang = new XeChoHang();
                        xehang.Nhap();
                        List.Add(xehang.Bienso, xehang);
                        break;
                }
            }
        }
        public void TimXe()
        {
            Console.WriteLine("Nhap vao bien so can tim");
            string bs = Console.ReadLine();
            if (List.ContainsKey(bs)==true)
            {
                Console.WriteLine("Co xe can tim");
                List[bs].Xuat();
            }
            else Console.WriteLine("Khong co xe can tim");
        }
        public void XoaXe()
        {
            Console.WriteLine("Nhap vao bien so can xoa");
            string bs = Console.ReadLine();
            if (List.ContainsKey(bs) == true)
            {
                Console.WriteLine("Co xe can xoa");
                List.Remove(bs);
            }
            else Console.WriteLine("Khong co xe can xoa");
        }
        public void XuatXe()
        {
            foreach (var xe in List.Values)
            {
                xe.Xuat();
            }
        }
    }

}
