using System;
namespace Basic_Assignments.Condition_Assignments
{
	public class Bai1
	{

		public Bai1()
		{
		}

		public void Display()
		{
			Console.Write("Nhap mot so nguyen: ");
			int x = Convert.ToInt32(Console.ReadLine());
			if (x >= 0)
			{
				Console.WriteLine("Day la mot so nguyen duong");
			}else
				Console.WriteLine("Day la mot so nguyen am");
		}
	}
}

