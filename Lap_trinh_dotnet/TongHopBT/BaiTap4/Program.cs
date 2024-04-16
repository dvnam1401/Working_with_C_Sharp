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
            //int n;
            //Console.WriteLine("Nhập chiều cao của tam giác cân:");
            //n = Convert.ToInt32(Console.ReadLine());

            //// Vẽ tam giác cân
            //for (int i = 1; i <= n; i++)
            //{
            //    // In ra khoảng trắng
            //    for (int j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    // In ra các dấu *
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine(); // Xuống dòng
            //}

            //Console.ReadLine();
            int n;
            Console.WriteLine("Nhập chiều cao của tam giác cân:");
            n = Convert.ToInt32(Console.ReadLine());

            // Vẽ tam giác cân rỗng ruột
            // In ra dòng đầu tiên (chỉ có một dấu *)
            for (int i = 1; i <= 2 * n - 1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); // Xuống dòng

            // In ra các dòng còn lại của tam giác
            for (int i = 2; i <= n; i++)
            {
                // In ra các khoảng trắng ở bên trái
                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write(" ");
                }

                // In ra dấu * ở vị trí đầu tiên của dòng
                Console.Write("*");

                // In ra các khoảng trắng ở giữa
                for (int k = 1; k <= 2 * i - 3; k++)
                {
                    Console.Write(" ");
                }

                // In ra dấu * ở vị trí cuối cùng của dòng
                if (i != n)
                    Console.Write("*");

                Console.WriteLine(); // Xuống dòng
            }

            Console.ReadLine();
        }
    }
}
