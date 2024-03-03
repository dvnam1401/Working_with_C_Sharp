using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //int a = 5;
            //a += 2; // tương đương a = a + 2;
            //Console.WriteLine("a = {0}",a);
            //Console.ReadLine();

            // nhap vao 1 so, hoi so nay chan hay le
            //int b;
            //console.writeline("moi ban nhap vao so b: ");
            //b = int.parse(console.readline());
            //// console.readline() ==> chờ người dùng nhập 1 giá trị rồi nhấn enter
            //// nếu nhạp 5 ==> hiểu là "5" ==> cần đưa 5 về 5
            //// ==> int.parse("5")
            //if (b %2 == 0) {
            //    console.writeline("{0} la so chan", b);
            //} else
            //{
            //    console.writeline("{0} la so le ", b);
            //}

            int year;
            Console.WriteLine("Mời bạn nhập vào 1 năm: ");
            year = int .Parse(Console.ReadLine());
            if(year % 4 == 0 && year % 100 == 0 || year  % 400 == 0)
            {
                Console.WriteLine("{0} là năm nhuần", year);
            }
            else
            {
                Console.WriteLine("{0} không phải là năm nhuần", year);
            }
            Console.ReadLine();
        }
    }
}
