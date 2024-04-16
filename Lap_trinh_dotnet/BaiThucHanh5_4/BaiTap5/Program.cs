using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap5
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = NhapMang();
            Console.WriteLine("\nCác phần tử lẻ trong mảng:");
            InPhanTuLe(arr);
            Console.WriteLine($"\nSố lượng phần tử lẻ: {DemPhanTuLe(arr)}");

            Console.WriteLine("\nCác số nguyên tố trong mảng:");
            InSoNguyenTo(arr);
            Console.WriteLine($"\nSố lượng số nguyên tố: {DemSoNguyenTo(arr)}");

            Console.WriteLine("\nMảng sau khi sắp xếp:");
            SapXepMang(arr);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }

        static int[] NhapMang()
        {
            int n;
            do
            {
                Console.Write("Nhập số lượng phần tử của mảng (0<n<=100): ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n > 100);

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }

        static void InPhanTuLe(int[] arr)
        {
            foreach (var item in arr.Where(x => x % 2 != 0))
            {
                Console.Write(item + " ");
            }
        }

        static int DemPhanTuLe(int[] arr)
        {
            return arr.Count(x => x % 2 != 0);
        }

        static void InSoNguyenTo(int[] arr)
        {
            foreach (var item in arr.Where(IsPrime))
            {
                Console.Write(item + " ");
            }
        }

        static int DemSoNguyenTo(int[] arr)
        {
            return arr.Count(IsPrime);
        }

        static void SapXepMang(int[] arr)
        {
            Array.Sort(arr);
        }

        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
