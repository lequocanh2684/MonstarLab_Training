using System;
using OOP_Assignment.Models;
namespace OOP_Assignment.Services
{
	public class StudentService : IStudentService
	{
		public List<Student> studentsList { get; set; }
		public Student studentTemp { get; set; }
		public StudentService()
		{
			this.studentsList = new Student().FakeData();
			this.studentTemp = new();
		}

        public void AddStudent()
		{
			try
			{
				Console.WriteLine("* Please enter student's info *");
				Console.Write("ID: "); this.studentTemp.Id = Console.ReadLine();
				Console.Write("Name: "); this.studentTemp.Name = Console.ReadLine();
				Console.Write("Age: "); this.studentTemp.Age = Convert.ToInt32(Console.ReadLine());
				Console.Write("Address: "); this.studentTemp.Address = Console.ReadLine();
				Console.Write("GPA: "); this.studentTemp.GPA = Convert.ToSingle(Console.ReadLine());
				this.studentsList.Add(this.studentTemp);
			}catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

        public void EditStudent(string? id)
		{
			try
			{
				int indexTemp = FindById(id);
				Console.Write("Change student's name to: "); this.studentsList.ElementAt(indexTemp).Name = Console.ReadLine();
				Console.Write("Change student's age to: "); this.studentsList.ElementAt(indexTemp).Age = Convert.ToInt32(Console.ReadLine());
				Console.Write("Change student's address to: ");
				this.studentsList.ElementAt(indexTemp).Address = Console.ReadLine();
				Console.Write("Change student's GPA to: ");
				this.studentsList.ElementAt(indexTemp).GPA = Convert.ToSingle(Console.ReadLine());
				Console.WriteLine("*Changed successfully*");
			}catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

		}

        public void DeleteStudent(string? id)
		{
			try
			{
				this.studentsList.RemoveAt(FindById(id));
				Console.WriteLine("*Deleted successfully*");
			}catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

		}

        public void SortStudent(string? shortBy)
		{
			try
			{
				switch (shortBy)
				{
					case "GPA":
						this.studentsList = this.studentsList.OrderBy(x => x.GPA).ToList();
						Console.WriteLine("Sorted by GPA in ascending, use option 6 to see result");
						break;
					case "Name":
						this.studentsList = this.studentsList.OrderBy(x => x.Name).ToList();
                        Console.WriteLine("Sorted by Name in ascending, use option 6 to see result");
                        break;
				}
			}catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

        public void ShowStudent()
		{
			Console.WriteLine("*A table below shows the list of student*" +
				$"\n{"ID",0}{"Name",15}{"Age",15}{"Address",30}{"GPA", 25}");
			foreach(var student in studentsList)
			{
				Console.WriteLine($"{student.Id,0}{student.Name,15}{student.Age,15}{student.Address,30}{student.GPA,25}");
			}
		}

        public void Menu()
		{
			try
			{
				int option = 0;
				do
				{
					Console.Write("******Menu******" +
						"\n1. Add a student" +
						"\n2. Edit student by id" +
						"\n3. Delete student by id" +
						"\n4. Sort students by gpa" +
						"\n5. Sort students by name" +
						"\n6. Show students" +
						"\n0. Exit" +
						"\nEnter your selectin: ");
					int select = Convert.ToInt32(Console.ReadLine());
					switch (select)
					{
						case 1:
							AddStudent();
							break;
						case 2:
							Console.Write("Enter student's id needed to change: ");
							string? idEdit = Console.ReadLine();
							EditStudent(idEdit);
							break;
						case 3:
                            Console.Write("Enter student's id needed to delete: ");
                            string? idDelete = Console.ReadLine();
							DeleteStudent(idDelete);
							break;
						case 4:
							SortStudent("GPA");
							break;
						case 5:
							SortStudent("Name");
							break;
						case 6:
							ShowStudent();
							break;
						case 0:
							break;
					}
					Console.WriteLine("\nBack to menu or not?" +
						"\n1. Yes, 2. No");
					Console.Write("Enter your Selection: ");
					option = Convert.ToInt32(Console.ReadLine());
				} while (option == 1);
			}catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private int FindById(string? id)
		{
			try
			{
				return studentsList.FindIndex(x => x.Id == id);
			}catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
		}
	}
}

