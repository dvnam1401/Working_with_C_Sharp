using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class Student
    {
        public string Hoten { get; set; }
        public DateTime BirthDay { get; set; }

        public int TinhTuoi()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - BirthDay.Year;
            if (BirthDay > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
        
    }
}
