using System;
using OOP_Assignment.Models;

namespace OOP_Assignment.Services
{
	public class TestCandidate : ICandidateService
	{
        public List<Candidate> candidatesList { get; set; }
		public TestCandidate()
		{
            this.candidatesList = new();
		}

		public float TongDiem(Candidate candidate) => candidate.MathMark + candidate.LiteratureMark + candidate.EnglishMark;

		public void Display()
		{
			try
			{
                Input();
                Console.WriteLine("\nThong tin ve cac thi sinh co tong diem lon hon 1");
				Console.WriteLine($"{"ID",0}{"Ten",15}{"Ngay thang nam sinh",30}{"Diem toan", 15}{"Diem van",10}{"Diem anh",10}");
                foreach (var candidate in this.candidatesList)
				{
                    Console.WriteLine($"{candidate.Id,0}{candidate.Name,15}{candidate.DoB,25}{candidate.MathMark,15}{candidate.LiteratureMark,10}{candidate.EnglishMark,10}");
                }
			}catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
;		}

		private Candidate? checkCondition(Candidate candidateCheck) => TongDiem(candidateCheck) > 1 ? candidateCheck : null;

		private void Input()
		{
            Console.Write("Hay nhap vao so thi sinh: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin thi sinh thu {i + 1}");
                Console.Write("Nhap ten: ");
                string? tenTemp = Console.ReadLine();
                Console.Write("Nhap ngay thang nam sinh: ");
                string? dobTemp = Console.ReadLine();
                Console.Write("Nhap diem toan: ");
                float markMathTemp = Convert.ToSingle(Console.ReadLine());
                Console.Write("Nhap diem van: ");
                float markLiteratureTemp = Convert.ToSingle(Console.ReadLine());
                Console.Write("Nhap diem anh: ");
                float markEnglishTemp = Convert.ToSingle(Console.ReadLine());
                Candidate candidateTemp = new(Convert.ToString(i + 1), tenTemp, dobTemp, markMathTemp, markLiteratureTemp, markEnglishTemp);
                if (checkCondition(candidateTemp) != null)
                {
                    this.candidatesList.Add(candidateTemp);
                }
            }
        }
	}
}

