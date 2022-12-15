using System;
using OOP_Assignment.Models;

namespace OOP_Assignment.Services
{
	public class TestCandidate : ICandidateService
	{
		public TestCandidate()
		{
		}

		public float TongDiem(Candidate candidate) => candidate.MathMark + candidate.LiteratureMark + candidate.EnglishMark;

		public void Display()
		{
			Console.Write("Hay nhap vao so thi sinh: ");
			int n = Convert.ToInt32(Console.ReadLine());
			List<Candidate> candidatesList = new(n);
			foreach(var candidate in candidatesList)
			{
				

			}
;		}
	}
}

