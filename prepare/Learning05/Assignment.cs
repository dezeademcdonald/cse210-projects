public class Assignment
{
    private string _studentName;
    private string _topic;
    public Assignment(string studentName, string Topic)
    {
        _studentName = studentName;
        _topic = Topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}