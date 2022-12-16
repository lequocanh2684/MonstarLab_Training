using System;
namespace OOP_Assignment.Models
{
	public class Student
	{
		public string? Id { get; set; }
		public string? Name { get; set; }
		public int Age { get; set; }
		public string? Address { get; set; }
		public float GPA { get; set; }

		public Student()
		{
		}

		public Student(string? id, string? name, int age, string? address, float gpa)
		{
			this.Id = id;
			this.Name = name;
			this.Age = age;
			this.Address = address;
			this.GPA = gpa;
		}

		public List<Student> FakeData()
		{
			return new List<Student>
			{
				new("1","a",1,"a",3),
				new("2","b",2,"b",1)
			};
		}
	}
}

