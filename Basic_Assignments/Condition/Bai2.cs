namespace Basic_Assignments.Condition;

public class Bai2
{
    public void Display()
    {
        Console.Write("Nhap mot so nguyen: ");
        var x = Convert.ToInt32(Console.ReadLine());
        Service.Check(x);
    }
}