using System;
namespace OOP_Assignment.Models
{
	public class Candidate
	{
		public string? Id { get; set; }
		public string? Name { get; set; }
		public string? DoB { get; set; }
		public float MathMark { get; set; }
		public float LiteratureMark { get; set; }
		public float EnglishMark { get; set; }

		public Candidate()
		{
		}

		public Candidate(string id, string? name, string? dob, float mathMark, float literatureMark, float englishMark)
		{
			this.Id = id;
			this.Name = name;
			this.DoB = dob;
			this.MathMark = mathMark;
			this.LiteratureMark = literatureMark;
			this.EnglishMark = englishMark;
		}
	}
}

