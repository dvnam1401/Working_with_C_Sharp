using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.models.inteface
{
    internal abstract class INguoi
    {
        protected long soChungMinh;
        protected string hoTen;
        protected string diaChi;
        protected string dienThoai;

        public abstract void Nhap();
        public abstract void Xuat();
    }
}
