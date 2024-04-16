using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    internal class QLSinhVien
    {
        Dictionary<string, SinhVien> _dsSinhVien = new Dictionary<string, SinhVien>();
        public void Nhap()
        {
            while (true)
            {
                Console.Write("Nhập (D) cho sinh viên điện tử, (C) cho sinh viên công nghệ thông tin: ");
                char choose = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                switch (choose)
                {
                    case '0':
                        return;
                    case 'D':
                        NhapSVDT();
                        break;
                    case 'C':
                        NhapSVCNTT();
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!!!");
                        break;
                }
            }

        }
        private void XuatThongTin<T>(Dictionary<string, T> danhSach) where T : SinhVien
        {
            foreach (var sv in danhSach)
            {
                sv.Value.Xuat();
            }
        }

        private void NhapSVCNTT()
        {
            Console.Write("Nhập số lượng sinh viên CNTT: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin sinh viên CNTT thứ {i + 1}:");
                SinhVienKCNTT sv = new SinhVienKCNTT();
                sv.Nhap();
                _dsSinhVien.Add(sv.MSSV, sv);
            }
            XuatThongTin(_dsSinhVien);
        }

        private void NhapSVDT()
        {
            Console.Write("Nhập số lượng sinh viên điện tử: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin sinh viên điện tử thứ {i + 1}:");
                SinhVienDienTu sv = new SinhVienDienTu();
                sv.Nhap();
                _dsSinhVien.Add(sv.MSSV, sv);
            }
            XuatThongTin(_dsSinhVien);
        }

        public void DemXepLoai()
        {
            int svGioi = 0, svKha = 0, svTB = 0, svYeu = 0;
            foreach (var sv in _dsSinhVien)
            {
                switch (sv.Value.TinhXepLoai())
                {
                    case "Giỏi":
                        svGioi++;
                        break;
                    case "Khá":
                        svKha++;
                        break;
                    case "Trung bình":
                        svTB++;
                        break;
                    default:
                        svYeu++;
                        break;
                }
            }
            Console.WriteLine($"Số lượng sinh viên giỏi: {svGioi}");
            Console.WriteLine($"Số lượng sinh viên khá: {svKha}");
            Console.WriteLine($"Số lượng sinh viên trung bình: {svTB}");
            Console.WriteLine($"Số lượng sinh viên yếu: {svYeu}");
        }
    }
}
