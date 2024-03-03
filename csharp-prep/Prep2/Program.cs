using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your Grade Percentage: ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);
        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your current grade is: {letter}");

        if(percent >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You failed the class!");
        }
    }
}
