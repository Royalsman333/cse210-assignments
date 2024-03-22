//Make the MathAssignment class and have it inherit the base Assignment class
public class MathAssignment : Assignment
{
    //Added the two private variables _textbookSection and _problems
    private string _textbookSection;
    private string _problems;

    //Created a constructor for your class that accepts all four parameters
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
        {
            _textbookSection = textbookSection;
            _problems = problems;
        }
    
// Add the GetHomeworkList() method
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
