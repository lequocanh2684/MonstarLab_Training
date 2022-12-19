using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Assignments.String
{
    internal class Bai19
    {
        public void Display()
        {
            Console.Write("Nhap chuoi: ");
            var str = Console.ReadLine()!;
            Console.Write("Nhap ki tu: ");
            var c = Service.InputCharTypeValue();
            var count = 0;
            foreach (var a in str)
            {
                if (a == c)
                {
                    count++;
                }
            }
            Console.WriteLine($"So lan suat hien: {count}");
        }
    }
}
