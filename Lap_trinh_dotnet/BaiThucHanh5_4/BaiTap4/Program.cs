using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào 3 cạnh của tam giác:");
            double a = NhapCanh("a");
            double b = NhapCanh("b");
            double c = NhapCanh("c");

            if (LaTamGiac(a, b, c))
            {
                if (LaTamGiacDeu(a, b, c))
                {
                    Console.WriteLine("Đây là tam giác đều.");
                }
                else if (LaTamGiacCan(a, b, c))
                {
                    Console.WriteLine("Đây là tam giác cân.");
                }
                else if (LaTamGiacVuong(a, b, c))
                {
                    if (LaTamGiacCan(a, b, c))
                    {
                        Console.WriteLine("Đây là tam giác vuông cân.");
                    }
                    else
                    {
                        Console.WriteLine("Đây là tam giác vuông.");
                    }
                }
                else
                {
                    Console.WriteLine("Đây là tam giác thường.");
                }
            }
            else
            {
                Console.WriteLine("Ba cạnh a, b, c không tạo thành một tam giác.");
            }
            Console.ReadLine();
        }

        static double NhapCanh(string tenCanh)
        {
            Console.Write($"Nhập độ dài cạnh {tenCanh}: ");
            return double.Parse(Console.ReadLine());
        }

        static bool LaTamGiac(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        static bool LaTamGiacDeu(double a, double b, double c)
        {
            return a == b && b == c;
        }

        static bool LaTamGiacCan(double a, double b, double c)
        {
            return a == b || a == c || b == c;
        }

        static bool LaTamGiacVuong(double a, double b, double c)
        {
            double max = Math.Max(a, Math.Max(b, c));
            if (max == a)
            {
                return Math.Abs(b * b + c * c - a * a) < 0.001;
            }
            else if (max == b)
            {
                return Math.Abs(a * a + c * c - b * b) < 0.001;
            }
            else
            {
                return Math.Abs(a * a + b * b - c * c) < 0.001;
            }
        }
    }
}

