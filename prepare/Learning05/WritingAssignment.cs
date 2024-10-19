using System.Reflection;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string Topic, string Title) : base(studentName, Topic)
    {
        _title = Title;
    }

    public string GetWritingInfo()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}