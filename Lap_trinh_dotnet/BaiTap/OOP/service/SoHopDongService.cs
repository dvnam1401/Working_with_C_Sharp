using OOP.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.service
{
    internal class SoHopDongService
    {
        HopDongChoThue hopDong = new HopDongChoThue();
        private Dictionary<string, HopDongChoThue> soHopDong;
        XeService xeService = new XeService();

        internal Dictionary<string, HopDongChoThue> SoHopDong { get => soHopDong; set => soHopDong = value; }

        public SoHopDongService()
        {
            SoHopDong = new Dictionary<string, HopDongChoThue>();
        }

        public void saveSoHopDong()
        {
            if (hopDong.Nhap())
            {
                SoHopDong.Add(hopDong.soHopDong, hopDong);
                Console.WriteLine("Lưu thành công");
            }
            else
            {
                Console.WriteLine("Lưu không thành công");
            }
        }
        private bool checkHopDong(string maHopDong)
        {
            return SoHopDong.ContainsKey(maHopDong);
        }
        public void findSoHopDong(string maHopDong)
        {
            if (!checkHopDong(maHopDong))
            {
                Console.WriteLine("Hợp đồng không tồn tại");
            }
            else
            {
                HopDongChoThue hopDongChoThue = SoHopDong[maHopDong];
                hopDongChoThue.Xuat();
            }
        }

        public void removeSoHopDong(string maHopDong)
        {
            bool flag = true;
            while (flag)
            {
                if (!checkHopDong(maHopDong))
                {
                    SoHopDong.Remove(maHopDong);
                    Console.WriteLine("Xóa thành công");
                    flag = option(flag);
                }
                else
                {
                    Console.WriteLine("Biển số không tồn tại");
                    flag = option(flag);
                }
            }
        }

        private bool option(bool flag)
        {
            Console.Write("Bạn có muốn tiếp tục không y/N: ");
            string choose = Console.ReadLine().ToLower();
            switch (choose)
            {
                case "y":
                    flag = true;
                    break;
                case "n":
                    flag = false;
                    break;
            }
            return flag;
        }
    }
}
