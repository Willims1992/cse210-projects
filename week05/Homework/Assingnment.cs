/*public class Assignment
{
    private string _studentName;
    private string _topic;


    private Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

}*/
public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    //  Add this method so derived classes can access the student name
    public string GetStudentName()
    {
        return _studentName;
    }
}




