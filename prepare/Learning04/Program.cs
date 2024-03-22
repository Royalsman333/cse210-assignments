using System;
using System.Linq.Expressions;
//W04 Prepare: Learning Activity
//Inheritance Learning Activity
//Jeremy Untch
class Program
{
    static void Main(string[] args)
    {
        //Testing the GetSummary() method
        Assignment a1 = new Assignment("Jeremy Untch", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        //Testing both the GetSummary() and the GetHomeworkList() methods
        MathAssignment a2 = new MathAssignment("Karla Castaneda", "Fractions", "4.6", "5-21");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        //Testing both the GetSummary() and the GetWritingInformation() methods
        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}