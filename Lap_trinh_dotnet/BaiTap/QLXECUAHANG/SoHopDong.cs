using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXECUAHANG
{
    internal class SoHopDong
    {
        Dictionary<string, HOPDONGCHOTHUE> soCai;

        public SoHopDong()
        {
            this.SoCai = new Dictionary<string, HOPDONGCHOTHUE>();
        }
        HOPDONGCHOTHUE hopDongThueXe = new HOPDONGCHOTHUE();
        internal Dictionary<string, HOPDONGCHOTHUE> SoCai { get => soCai; set => soCai = value; }
        public void Luu()
        {
            Console.WriteLine("Nhập sổ hợp đồng: ");
            string soHopDong = Console.ReadLine();
            hopDongThueXe.Nhap();
            soCai.Add(soHopDong, hopDongThueXe);
        }

        public void Tim(string soHopDong)
        {
            if (soCai.ContainsKey(soHopDong))
            {
                hopDongThueXe = soCai[soHopDong];
                hopDongThueXe.Xuat();
            }
            else
            {
                Console.WriteLine("Hợp đồng không tồn tại");
            }
        }

        public void Xoa(string soHopDong)
        {
            if (soCai.ContainsKey(soHopDong))
            {
                soCai.Remove(soHopDong);
                Console.WriteLine("Xóa thành công");
            }
            else
            {
                Console.WriteLine("Hợp đồng không tồn tại");
            }
        }
    }
}
