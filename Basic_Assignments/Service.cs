namespace Basic_Assignments;

internal class Service
{
    public static bool IsTriangle(double a, double b, double c)
    {
        var flag1 = a > 0 && b > 0 && c > 0;
        var flag2 = a < b + c && b < a + c && c < a + b;

        return flag1 && flag2;
    }

    public static bool IsRightTriangle(double a, double b, double c)
    {
        if (!IsTriangle(a, b, c))
        {
            return false;
        }

        var flag = a * a == b * b + c * c || b * b == a * a + c * c || c * c == b * b + a * a;
        return flag;
    }

    private static bool ValidateTypeDouble(string a)
    {
        return double.TryParse(a, out _);
    }

    private static bool ValidateTypeChar(string a)
    {
        return char.TryParse(a, out _);
    }

    public static double InputDoubleTypeValue()
    {
        var a = Console.ReadLine()!;
        while (!ValidateTypeDouble(a))
        {
            Console.Write("Hay nhap ki tu la so thuc: ");
            a = Console.ReadLine()!;
        }
        return double.Parse(a);
    }

    public static char InputCharTypeValue()
    {
        var a = Console.ReadLine()!;
        while (!ValidateTypeChar(a))
        {
            Console.Write("Hay nhap 1 ki tu: ");
            a = Console.ReadLine()!;
        }
        return char.Parse(a);
    }

    public static void Check(int x)
    {
        string[] smallNum = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
        string[] otherNum = { "Âm", "Mười", "Chục", "Trăm", "Nghìn", "Triệu", "Tỷ" };
        if (x is >= 0 and <= 9)
        {
            Console.WriteLine(smallNum[x]);
        }
        else if (x is > 9 and < 20)
        {
            if (x is 10) Console.WriteLine("Mười");
            else Console.WriteLine($"Mười {smallNum[x % 10]}");
        }
    }

}