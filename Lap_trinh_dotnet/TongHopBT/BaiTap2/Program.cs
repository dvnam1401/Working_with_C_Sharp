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
            Console.WriteLine("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += Math.Pow(i, 2);
            }
            Console.WriteLine("Tong day la: {0}", sum);
            Console.ReadLine();
        }
    }
}
