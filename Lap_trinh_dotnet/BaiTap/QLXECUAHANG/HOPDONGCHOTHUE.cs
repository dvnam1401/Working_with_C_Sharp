using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXECUAHANG
{
    class HOPDONGCHOTHUE
    {
        string soHopDong;  
        int songaythue;
        string bs;
        QuanLyXe qlxe;
        NhanVien nv;
        KhachHang kh;
        public HOPDONGCHOTHUE()
        {
            qlxe = new QuanLyXe();
            nv = new NhanVien();
            kh = new KhachHang();
        }
        public void Nhap()
        {
            //LÀM SAO GỌI ĐƯỢC PHƯƠNG THỨC NHẬP Ở LỚP QUANLYXE
            qlxe.Nhap();
            Console.WriteLine("Nhap vao bien so xe can thue");
            bs = Console.ReadLine();
            //Nếu có xe cần thuê tức là trong List ở lớp QUANLYXE sẽ có biển số này
            if (qlxe.List.ContainsKey(bs) == true)
            {
                Console.WriteLine("Co xe can thue");
                Console.WriteLine("Nhap vao so ngay thue");
                songaythue = int.Parse(Console.ReadLine());
                nv.Nhap();
                kh.Nhap();
            }
        }
        public void Xuat()
        {
            qlxe.List[bs].Xuat();
            nv.Xuat();
            kh.Xuat();
            Console.WriteLine("So tien can phai tra la:" + ThanhTien());
        }
        public double ThanhTien()
        {
            if (qlxe.List[bs] is XeChoHang)
            {
                return songaythue * 500000;
            }
            else
            {
                if (((XeDuLich)qlxe.List[bs]).Sochongoi <= 5)
                {
                    return songaythue * 500000;

                }
                else if (((XeDuLich)qlxe.List[bs]).Sochongoi <= 7)
                {
                    return songaythue * 700000;
                }
            }
            return songaythue * 1000000;
        }
    }
}
