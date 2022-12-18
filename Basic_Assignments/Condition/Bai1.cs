namespace Basic_Assignments.Condition
{
    public class Bai1
    {
        public void Display()
        {
            Console.Write("Nhap mot so nguyen: ");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x >= 0 ? "Day la mot so nguyen duong" : "Day la mot so nguyen am");
        }
    }
}

