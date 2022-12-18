namespace Basic_Assignments.Array
{
    internal class Bai11
    {
        public void Display()
        {
            Console.Write("Nhap so tu nhien n: ");
            var n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[100];
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < n; j++)
            {
                sum += a[j];
            }
            Console.WriteLine($"Gia tri trung binh cua mang: {sum / a.Length}");
        }
    }
}
