using System;
namespace Basic_Assignments.Condition_Assignments
{
	public class Bai2
	{
		public Bai2()
		{
		}

		public void Display()
		{
			Console.Write("Nhap mot so nguyen: ");
			int x = Convert.ToInt32(Console.ReadLine());
			check(x);
		}

		private void check(int x)
		{
			string[] smallNum = new[] { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
			string[] otherNum = new[] { "Âm", "Mười", "Chục", "Trăm", "Nghìn", "Triệu", "Tỷ" };
			if (x is >= 0 and <= 9)
			{
				Console.WriteLine(smallNum[x]);
			}
			else if(x is > 9 and < 20)
			{
				if (x is 10) Console.WriteLine("Mười");
				else Console.WriteLine($"Mười {smallNum[x % 10]}");
			}
		}
	}
}

