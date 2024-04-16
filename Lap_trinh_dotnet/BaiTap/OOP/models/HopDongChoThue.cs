using OOP.models.inteface;
using OOP.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.models
{
    internal class HopDongChoThue
    {
        public string soHopDong { get; set; }
        public Xe xe { get; set; }
        public INguoi nhanVien { get; set; }
        public INguoi khachHang { get; set; }
        public int soNgayThue { get; set; }
        public double donGia { get; set; }
        public DateTime ngayThue { get; set; }
        public XeService xeService = XeService.Instance;
        private string bienSo;
        public HopDongChoThue()
        {           
        }
        public HopDongChoThue(string soHopDong, Xe xe, INguoi nhanVien, INguoi khachHang, int soNgayThue, double donGia, DateTime ngayThue)
        {
            this.soHopDong = soHopDong;
            this.xe = xe;
            this.nhanVien = nhanVien;
            this.khachHang = khachHang;
            this.soNgayThue = soNgayThue;
            this.donGia = donGia;
            this.ngayThue = ngayThue;
        }

        public bool Nhap()
        {
            Console.WriteLine("Nhập biển số xe muốn thuê: ");
            bienSo = Console.ReadLine();
            if (xeService.checkBienSo(bienSo))
            {
                Console.WriteLine("Nhập số hợp đồng thuê: ");
                string soHopDong = Console.ReadLine();
                this.xe = xeService.List[bienSo];
                this.xe.Xuat();
                Console.WriteLine("===Thông tin nhân viên===");
                nhanVien.Nhap();
                Console.WriteLine("===Thông tin khách hàng===");
                khachHang.Nhap();
                return true;
            }
            else
            {
                Console.WriteLine("Biển số xe chưa được thêm vào");
                return false;
            }
        }

        public void Xuat()
        {
            this.xe = xeService.List[bienSo];
            this.xe.Xuat();
            nhanVien.Xuat();
            khachHang.Xuat();
            Console.WriteLine($"Số tiền phải trả: {thanhTien(bienSo)}");
        }

        public double thanhTien(string bienSo)
        {

            Xe xe = xeService.List[bienSo];
            if (xe is XeDuLich)
            {
                XeDuLich xeDuLich = (XeDuLich)xe;
                if (xeDuLich.Sochongoi <= 5)
                {
                    return 500000;
                }
                else if (xeDuLich.Sochongoi <= 7)
                {
                    return 700000;
                }
                else
                {
                    return 1000000;
                }
            }
            else if (xe is XeChoHang)
            {
                return 500000;
            }
            else
            {
                throw new Exception("Biển số không tồn tại");
            }
        }
    }
}
