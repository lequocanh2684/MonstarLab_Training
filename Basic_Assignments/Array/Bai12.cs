﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Assignments.Array
{
    internal class Bai12
    {
        public void Display()
        {
            int[] newArray = Service.InputIntArray();
            Console.WriteLine($"Phan tu co gia tri lon nhat la: {newArray.Max()}");
        }
    }
}
