using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào số nguyên n có 3 chữ số: ");
            int n = int.Parse(Console.ReadLine());

            // Đảm bảo số nguyên n có 3 chữ số
            while (true)
            {
                if (n >= 100 && n <= 999)
                {                    
                    break;
                }
                Console.WriteLine("Số nhập vào không hợp lệ. Vui lòng nhập số có 3 chữ số.");
                n = int.Parse(Console.ReadLine());
            }

            int chuSoDau = n / 100;
            int chuSoCuoi = n % 10;

            int tong = chuSoDau + chuSoCuoi;
            int tich = chuSoDau * chuSoCuoi;

            Console.WriteLine($"Chữ số đầu tiên: {chuSoDau}");
            Console.WriteLine($"Chữ số cuối cùng: {chuSoCuoi}");
            Console.WriteLine($"Tổng của chữ số đầu tiên và cuối cùng: {tong}");
            Console.WriteLine($"Tích của chữ số đầu tiên và cuối cùng: {tich}");
            Console.ReadLine();
        }
    }
}
