using OOP_Assignment.Models;

namespace OOP_Assignment.Services;

public class TestCandidate : IOOPAssignments
{
    public TestCandidate()
    {
        CandidatesList = new List<Candidate>();
    }

    public List<Candidate> CandidatesList { get; set; }

    public float TongDiem(Candidate candidate)
    {
        return candidate.MathMark + candidate.LiteratureMark + candidate.EnglishMark;
    }

    public void Display()
    {
        try
        {
            Input();
            Console.WriteLine("\nThong tin ve cac thi sinh co tong diem lon hon 1");
            Console.WriteLine(
                $"{"ID",0}{"Ten",15}{"Ngay thang nam sinh",30}{"Diem toan",15}{"Diem van",10}{"Diem anh",10}");
            foreach (var candidate in CandidatesList)
                Console.WriteLine(
                    $"{candidate.Id,0}{candidate.Name,15}{candidate.DoB,25}{candidate.MathMark,15}{candidate.LiteratureMark,10}{candidate.EnglishMark,10}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private Candidate? CheckCondition(Candidate candidateCheck)
    {
        return TongDiem(candidateCheck) > 1 ? candidateCheck : null;
    }

    private void Input()
    {
        Console.Write("Hay nhap vao so thi sinh: ");
        var n = Convert.ToInt32(Console.ReadLine());
        for (var i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap thong tin thi sinh thu {i + 1}");
            Console.Write("Nhap ten: ");
            var tenTemp = Console.ReadLine();
            Console.Write("Nhap ngay thang nam sinh: ");
            var dobTemp = Console.ReadLine();
            Console.Write("Nhap diem toan: ");
            var markMathTemp = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap diem van: ");
            var markLiteratureTemp = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap diem anh: ");
            var markEnglishTemp = Convert.ToSingle(Console.ReadLine());
            Candidate candidateTemp = new(Convert.ToString(i + 1), tenTemp, dobTemp, markMathTemp, markLiteratureTemp,
                markEnglishTemp);
            if (CheckCondition(candidateTemp) != null) CandidatesList.Add(candidateTemp);
        }
    }
}