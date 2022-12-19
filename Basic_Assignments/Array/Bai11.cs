namespace Basic_Assignments.Array
{
    internal class Bai11
    {
        public void Display()
        {
            int[] newArray = Service.InputIntArray();
            Console.WriteLine($"Gia tri trung binh cua mang: {newArray.Average()}");
        }
    }
}
