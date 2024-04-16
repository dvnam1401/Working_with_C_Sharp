using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }
            Console.WriteLine("Tong day la: {0}", sum);
            Console.ReadLine();
        }
    }
}
