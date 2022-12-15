using System;
using OOP_Assignment.Models;
namespace OOP_Assignment.Services
{
	public interface ICandidateService
	{
		float TongDiem(Candidate candidate);
		void Display();
	}
}

