using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    internal class Program
    {
        
        static void Choi()
        {
            Random rd = new Random();
            int soCuaMay = rd.Next(501);
            int soCuaNGuoi;
            int soLanDoan = 0;
            Console.WriteLine("Máy dã ra 1 số [0..500], mời bạn đoán: ");
            while (true)
            {
                soCuaNGuoi = int.Parse(Console.ReadLine());
                soLanDoan++;
                Console.WriteLine("Bạn đoán lần thứ {0}", soLanDoan);
                if (soCuaNGuoi == soCuaMay)
                {
                    Console.WriteLine("Bạn đã đoán đúng, số của máy = {0}", soCuaMay);
                    break;
                }
                if (soCuaNGuoi < soCuaMay)
                {
                    Console.WriteLine("Số bạn đoán < số của máy");
                }
                else
                {
                    Console.WriteLine("Số bạn đoán > số của máy");
                }
                if (soLanDoan == 7)
                {
                    Console.WriteLine("GAME OVER! bạn đã đoán 7 lần");
                    break;
                }    
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Choi();
        }
    }
}
