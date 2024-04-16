using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.service
{
    internal class XeService
    {
        private Dictionary<string, Xe> list;
        private static XeService _instance;
        internal Dictionary<string, Xe> List { get => list; set => list = value; }

        public XeService()
        {
            List = new Dictionary<string, Xe>();
        }

        public static XeService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new XeService();
                }
                return _instance;
            }
        }
        public void inputXedulich()
        {
            XeDuLich xe = new XeDuLich();

            xe.Nhap();
            if (!checkBienSo(xe.BienSo))
            {
                list.Add(xe.BienSo, xe);
            }
            else
            {
                Console.WriteLine("Biển số đã tồn tại");
                Console.Write("Mời bạn nhập lại biển số xe: ");
                string bienSo = Console.ReadLine();
                Xe result = new XeDuLich(bienSo, xe.TenXe, xe.TrongTai, xe.NgayDangKiem, xe.TieuChuanBang, xe.Sochongoi);
                list.Add(result.BienSo, result);
            }

        }

        public void inputXechohang()
        {
            XeChoHang xe = new XeChoHang();

            xe.Nhap();
            if (!checkBienSo(xe.BienSo))
            {
                list.Add(xe.BienSo, xe);
            }
            else
            {
                Console.WriteLine("Biển số đã tồn tại");
                Console.Write("Mời bạn nhập lại biển số xe: ");
                string bienSo = Console.ReadLine();
                Xe result = new XeChoHang(bienSo, xe.TenXe, xe.TrongTai, xe.NgayDangKiem, xe.TieuChuanBang, xe.Sotan);
                list.Add(result.BienSo, result);
            }
        }
        public bool checkBienSo(string bienSo)
        {
            return list.ContainsKey(bienSo);
        }

        public Xe findXeService(string bienSo)
        {
            if (checkBienSo(bienSo))
            {
                return list[bienSo];
            }
            else
            {
                Console.WriteLine("Xe không tồn tại");
                return null;
            }
        }

        public void removeXeService(string bienSo)
        {
            if (checkBienSo(bienSo))
            {
                list.Remove(bienSo);
                Console.WriteLine("Đã xóa xe thành công.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy xe với biển số này.");
            }
        }

        public void outPut()
        {
            foreach (var xe in list)
            {
                xe.Value.Xuat();
            }
        }
    }
}
