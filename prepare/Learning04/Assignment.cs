//Creating the base Assignment class
public class Assignment
{
    //Adding the student's name
    private string _studentName;
    //Adding the topic
    private string _topic;
    //Connecting both the student's name and the topic together.
    public Assignment(string studentName, string topic)
    {
        //Setting the strings to variables
        _studentName = studentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public string GetSummary()
    {
        return _studentName +" - "+ _topic;
    }

}