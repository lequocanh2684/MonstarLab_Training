using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Assignments.Condition
{
    internal class Bai4
    {
        public void Display()
        {
            Console.WriteLine("Kiem tra 3 so co phai la 3 canh cua mot tam giac");
            Console.Write("Nhap so thu nhat: ");
            var a = Service.InputDoubleTypeValue();
            Console.Write("Nhap so thu hai: ");
            var b = Service.InputDoubleTypeValue();
            Console.Write("Nhap so thu ba: ");
            var c = Service.InputDoubleTypeValue();
            if (Service.IsTriangle(a, b, c) && Service.IsRightTriangle(a, b, c))
            {
                Console.WriteLine("La 3 canh cua 1 tam giac vuong");
            }
            else
            {
                Console.WriteLine("Khong phai 3 canh cua 1 tam giac vuong");
            }
        }
    }
}
