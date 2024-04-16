using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double a, b, c;
            a = NhapHeSo("A");
            b = NhapHeSo("B");
            c = NhapHeSo("C");

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine(c == 0 ? "Phương trình có vô số nghiệm." : "Phương trình vô nghiệm.");
                }
                else
                {
                    Console.WriteLine($"Phương trình có một nghiệm: x = {-c / b}");
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Phương trình có hai nghiệm phân biệt:");
                    Console.WriteLine($"x1 = {x1}");
                    Console.WriteLine($"x2 = {x2}");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Phương trình có nghiệm kép: x1 = x2 = {x}");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
            }
            Console.ReadLine();
        }

        static double NhapHeSo(string tenHeSo)
        {
            double heSo;
            Console.Write($"Nhập hệ số {tenHeSo}: ");
            while (!double.TryParse(Console.ReadLine(), out heSo))
            {
                Console.WriteLine("Giá trị nhập vào không phải là số, vui lòng nhập lại!");
                Console.Write($"Nhập hệ số {tenHeSo}: ");
            }
            return heSo;
        }
    }
}
