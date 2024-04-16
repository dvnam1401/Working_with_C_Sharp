using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Xe
    {
        private string bienSo;
        private string tenXe;
        private int trongTai;
        private DateTime ngayDangKiem;
        private int tieuChuanBang;
        public Xe()
        {            
        }

        public Xe(string bienSo, string tenXe, int trongTai, DateTime ngayDangKiem, int tieuChuanBang)
        {
            this.bienSo = bienSo;
            this.tenXe = tenXe;
            this.trongTai = trongTai;
            this.ngayDangKiem = ngayDangKiem;
            this.tieuChuanBang = tieuChuanBang;
        }

        public string BienSo
        {
            get { return bienSo; }
            set { bienSo = value; }
        }

        public string TenXe
        {
            get { return tenXe; }
            set { tenXe = value; }
        }

        public int TrongTai
        {
            get { return trongTai; }
            set { trongTai = value; }
        }

        public DateTime NgayDangKiem
        {
            get { return ngayDangKiem; }
            set { ngayDangKiem = value; }
        }

        public int TieuChuanBang
        {
            get { return tieuChuanBang; }
            set { tieuChuanBang = value; }
        }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhập thông tin xe:");
            Console.Write("Biển số: ");
            BienSo = Console.ReadLine();

            Console.Write("Tên xe: ");
            TenXe = Console.ReadLine();

            Console.Write("Trọng tải: ");
            TrongTai = int.Parse(Console.ReadLine());

            Console.Write("Ngày đăng kiểm (dd-MM-yyyy): ");
            NgayDangKiem = DateTime.Parse(Console.ReadLine());

            Console.Write("Tiêu chuẩn bằng: ");
            TieuChuanBang = int.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Thông tin xe:");
            Console.WriteLine("Biển số: " + BienSo);
            Console.WriteLine("Tên xe: " + TenXe);
            Console.WriteLine("Trọng tải: " + TrongTai);
            Console.WriteLine("Ngày đăng kiểm: " + NgayDangKiem.ToString("dd-MM-yyyy"));
            Console.WriteLine("Tiêu chuẩn bằng: " + TieuChuanBang);
        }
    }
}
