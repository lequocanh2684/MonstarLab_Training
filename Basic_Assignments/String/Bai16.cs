namespace Basic_Assignments.String;

internal class Bai16
{
    public void Display()
    {
        Console.Write("Nhap chuoi: ");
        var str = Console.ReadLine()!;
        Console.Write("Nhap ki tu: ");
        var c = Service.InputCharTypeValue();
        Console.WriteLine(str.Contains(c) ? "Co" : "Khong");
    }
}