using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Basic_Assignments.Loop
{
    internal class Bai10
    {
        public void Display()
        {
            string[] newArray = Service.InputMssvArray();
            Regex rx = new("(^B170)[1-9]{4}$");
            foreach (var value in newArray)
            {
                Console.WriteLine(rx.IsMatch(value) ? $"Ma so sinh vien {value} dung dinh dang" : $"Ma so sinh vien {value} khong dung dinh dang");
            }
        }
    }
}
