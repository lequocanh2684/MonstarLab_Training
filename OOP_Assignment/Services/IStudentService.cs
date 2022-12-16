using System;
using OOP_Assignment.Models;
namespace OOP_Assignment.Services
{
	public interface IStudentService
	{
		void AddStudent();
		void EditStudent(string id);
		void DeleteStudent(string id);
		void SortStudent(string shortBy);
		void ShowStudent();
		void Menu();
	}
}

