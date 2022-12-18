using System.Collections;

namespace Basic_Assignments.String
{
    internal class Bai17
    {
        public void Display()
        {
            Console.Write("Nhap chuoi: ");
            var str = Console.ReadLine()!;
            Console.Write("Nhap ki tu: ");
            var c = Service.InputCharTypeValue();
            if (str.Contains(c))
            {
                ArrayList a = new();
                for (var i = 0; i < str.Length; i++)
                {
                    if (str[i] == c)
                    {
                        a.Add(i);
                    }
                }
                Console.Write("Ki tu o vi tri "); 
                foreach (var ob in a) Console.Write($"thu {ob} ");
            }
            else
            {
                Console.WriteLine("Khong ton tai trong chuoi");
            }
        }
    }
}
