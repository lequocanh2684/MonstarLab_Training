using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Basic_Assignments.Array
{
    internal class Bai15
    {
        public void Display()
        {
            string[] newArray = Service.InputMssvArray();
            bool check = true;
            Regex rx = new("^00[2-5]L[0-9]{4}$");
            foreach(var value in newArray)
            {
                if (!rx.IsMatch(value))
                {
                    check = false;
                }
            }
            Console.WriteLine(check ? "Dung roi" : "Sai roi");
        }
    }
}
