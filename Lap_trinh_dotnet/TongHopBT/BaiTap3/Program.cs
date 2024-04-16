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
            Console.WriteLine("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int giaithua = 1;
            while (number > 0)
            {
                giaithua *= number;
                number--;
            }
            Console.WriteLine("Tong day la: {0}", giaithua);
            Console.ReadLine();
        }
    }
}
