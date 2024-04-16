using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student student = new Student();
            Input(student);
            Output(student);
            Console.ReadLine();
        }
        static private void Input(Student sv)
        {
            Console.WriteLine("NHẬP THÔNG TIN SINH VIÊN");
            Console.Write("Nhập họ và tên: ");
            sv.Hoten = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Nhập ngày sinh: ");
            string birthday = Console.ReadLine();
            sv.BirthDay = DateTime.Parse(birthday);
            Console.WriteLine();
        }
        
        static private void Output(Student sv)
        {
            Console.WriteLine("THÔNG TIN SINH VIÊN");
            Console.WriteLine($"Họ tên của sinh viên là {sv.Hoten} tuổi hiện tại là {sv.TinhTuoi()}");
            if (sv.BirthDay.Day == DateTime.Today.Day && sv.BirthDay.Month == DateTime.Today.Month)
            {
                Console.WriteLine("Chúc mừng sinh nhật");
            }
        }

    }
}
