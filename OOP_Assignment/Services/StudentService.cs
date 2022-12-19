using OOP_Assignment.Models;

namespace OOP_Assignment.Services;

public class StudentService : IOOPAssignments
{
    public StudentService()
    {
        StudentsList = new Student().FakeData();
        StudentTemp = new Student();
    }

    public List<Student> StudentsList { get; set; }
    public Student StudentTemp { get; set; }

    public void AddStudent()
    {
        try
        {
            Console.WriteLine("* Please enter student's info *");
            Console.Write("ID: ");
            StudentTemp.Id = Console.ReadLine();
            Console.Write("Name: ");
            StudentTemp.Name = Console.ReadLine();
            Console.Write("Age: ");
            StudentTemp.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Address: ");
            StudentTemp.Address = Console.ReadLine();
            Console.Write("GPA: ");
            StudentTemp.Gpa = Convert.ToSingle(Console.ReadLine());
            StudentsList.Add(StudentTemp);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void EditStudent(string? id)
    {
        try
        {
            var indexTemp = FindById(id);
            Console.Write("Change student's name to: ");
            StudentsList.ElementAt(indexTemp).Name = Console.ReadLine();
            Console.Write("Change student's age to: ");
            StudentsList.ElementAt(indexTemp).Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Change student's address to: ");
            StudentsList.ElementAt(indexTemp).Address = Console.ReadLine();
            Console.Write("Change student's GPA to: ");
            StudentsList.ElementAt(indexTemp).Gpa = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("*Changed successfully*");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void DeleteStudent(string? id)
    {
        try
        {
            StudentsList.RemoveAt(FindById(id));
            Console.WriteLine("*Deleted successfully*");
        }
        catch (Exception ex)
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
                    StudentsList = StudentsList.OrderBy(x => x.Gpa).ToList();
                    Console.WriteLine("Sorted by GPA in ascending, use option 6 to see result");
                    break;
                case "Name":
                    StudentsList = StudentsList.OrderBy(x => x.Name).ToList();
                    Console.WriteLine("Sorted by Name in ascending, use option 6 to see result");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void ShowStudent()
    {
        Console.WriteLine("*A table below shows the list of student*" +
                          $"\n{"ID",0}{"Name",15}{"Age",15}{"Address",30}{"GPA",25}");
        foreach (var student in StudentsList)
            Console.WriteLine($"{student.Id,0}{student.Name,15}{student.Age,15}{student.Address,30}{student.Gpa,25}");
    }

    public void Display()
    {
        try
        {
            int option;
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
                var select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        Console.Write("Enter student's id needed to change: ");
                        var idEdit = Console.ReadLine();
                        EditStudent(idEdit);
                        break;
                    case 3:
                        Console.Write("Enter student's id needed to delete: ");
                        var idDelete = Console.ReadLine();
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
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private int FindById(string? id)
    {
        try
        {
            return StudentsList.FindIndex(x => x.Id == id);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }
}