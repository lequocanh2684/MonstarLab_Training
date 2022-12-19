namespace OOP_Assignment.Models
{
    public class Student
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
        public float Gpa { get; set; }

        public Student()
        {
        }

        public Student(string? id, string? name, int age, string? address, float gpa)
        {
            Id = id;
            Name = name;
            Age = age;
            Address = address;
            Gpa = gpa;
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

