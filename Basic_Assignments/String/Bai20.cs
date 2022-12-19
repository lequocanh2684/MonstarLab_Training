using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Basic_Assignments.String
{
    internal class Bai20
    {
        public void Display()
        {
            string[] newArray = Service.InputMssvArray();
            bool check = true;
            Regex rx = new("^[A-Z][^\\s]{1,18}[0-9]$");
            foreach (var value in newArray)
            {
                if (!rx.IsMatch(value))
                {
                    check = false;
                }
            }
            Console.WriteLine(check ? "Duyet" : "Khong duyet");
        }
    }
}
