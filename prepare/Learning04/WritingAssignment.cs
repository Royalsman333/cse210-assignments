using System.Reflection;
//Make sure that the WritingAssignment uses the base Assignment class
public class WritingAssignment : Assignment
{
    //Add the title string
    private string _title;
    
    //Connect the student name, the topic, and the title all together
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
        {
            //Set the title variable
            _title = title;
        }
    
    //Add the GetWritingInformation() method
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}