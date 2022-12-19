using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Assignments.Array
{
    internal class Bai14
    {
        public void Display()
        {
            int[] newArray = Service.InputIntArray();
            newArray = (from value in newArray orderby value descending select value).ToArray();
            foreach(var value in newArray)
            {
                Console.Write($"{value} ");
            }
        }
    }
}
