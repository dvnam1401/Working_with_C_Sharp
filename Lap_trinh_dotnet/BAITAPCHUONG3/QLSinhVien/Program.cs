using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            QLSinhVien qLSinhVien = new QLSinhVien();
            qLSinhVien.Nhap();
            qLSinhVien.DemXepLoai();
            Console.ReadLine();
        }
    }
}
