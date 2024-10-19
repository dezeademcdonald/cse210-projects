public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problem;

    public MathAssignment(string studentName, string Topic, string textBookSection, string problem) : base(studentName, Topic)
    {
        _textBookSection = textBookSection;
        _problem = problem;
    }

    public string GetHomeWorkList()
    {
        return $"Section {_textBookSection} Problems {_problem}";
    }
}