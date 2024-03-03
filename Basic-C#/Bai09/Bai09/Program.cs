using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai09
{
    internal class Program
    {
        static void TestToanHoc()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời bạn nhập vào số a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Căn bậc 2 của {0} = {1}", a, Math.Sqrt(a));
            Console.WriteLine("Mời bạn nhập vào số b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}^{1}={2}", a, b, Math.Pow(a, b));
            Console.WriteLine("Mời bạn nhập vào 1 góc: ");
            int goc = Convert.ToInt32(Console.ReadLine());
            double radian = Math.PI * goc / 180;
            Console.WriteLine("sin({0})={1}", goc, Math.Sin(radian));
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            TestToanHoc();
        }
    }
}
