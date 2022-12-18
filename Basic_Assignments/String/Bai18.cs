using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Assignments.String
{
    internal class Bai18
    {
        public void Display()
        {
            Console.Write("Nhap chuoi: ");
            var str = Console.ReadLine()!;
            var flag = false;
            foreach (var c in str)
            {
                if (c >= '0' && c <= '9')
                {
                    flag = true;
                }
            }
            Console.WriteLine(flag ? "Co" : "Khong");
        }
    }
}
