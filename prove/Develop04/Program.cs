using System;
using System.Runtime.InteropServices;
using System.Security.Principal;

class Activity
{
    int duration;
    string name;

    public Activity(int duration, string name)
    {
        this.duration = duration;
        this.name = name;
    }

    public virtual void Start()
    {
        //The start up messages for each activty.
        Console.WriteLine($"Starting {name} activity...");
        Console.WriteLine($"This activity will last for {duration} seconds.");
        Console.WriteLine("Lets begin...");
        //This will pause the program for 3 seconds.
        Thread.Sleep(3000);
    }

    public virtual void End()
    {
        //The messages at the end of each activity.
        Console.WriteLine("Good Job!");
        Console.WriteLine($"You have completed the {name} activity.");
        Console.WriteLine($"Duration: {duration} seconds.");
        //This will pause the proogram for another 3 seconds.
        Thread.Sleep(3000);
    }

    //This is what will activate the loading spinner.
    public void ShowSpinner(int seconds)
    {
        Console.Write("Loading...");
        for (int i = 0; i < seconds; i++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.WriteLine();
    }
}

//This creates the Breathing Activity while using the Activity properties
class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration, "Breathing")
    {
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("This activity will help you relax by guiding you through a breathing excersise.");
        Console.WriteLine("Focus on your breathing...");
        //3 second pause allowing the reader time to read before the activity starts.
        Thread.Sleep(3000);
    }

    public override void End()
    {
        base.End();
    }

//This is the actual Breathing Activity
    public void Breathe()
    {
        Console.WriteLine("Breathe in...");
        //Calling upon the ShowSpinner to add a 3 second pause
        ShowSpinner(3);
        Console.WriteLine("Breathe out...");
        ShowSpinner(3);
    }
}

//The reflection activity with properties from activity
class ReflectionActivity : Activity
{
    //These are the prompts for the reflection activity
    private string[] prompt = {
        "Think about a time when you felt proud of yourself.",
        "Think about a time that you felt comfortable.",
        "Think about a time that you helped somebody.",
        "Think about a time that somebody helped you.",
        "Think about a time when you met your closest friend."
    };

    //These are the questions for the reflection activity.
    private string[] questions = {
        "Why was this experience important to you?",
        "What did you learn from this experience?",
        "How did this experience impact your life?",
        "If you could relive this experience, would you change anything?",
        "Have you had any experiences similar to this one?"
    };

    public ReflectionActivity(int duration) : base(duration, "Reflection")
    {
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("This activity will help you focus on the good things in life by having you answer questions, and reflect on those moments.");
        //3 second pause
        Thread.Sleep(3000);
    }

    public override void End()
    {
        base.End();
    }
    
    public void Reflect()
    {
        Random rand = new Random();
        foreach (string prompt in prompts)
        {
            Console.WriteLine(prompt);
            //3 second pause
            Thread.Sleep(3000);
            foreach ( string question in questions)
            {
                Console.WriteLine(question);
                ShowSpinner(3);
            }
        }
    }
}

//Listing Activity with Activity properties
class ListingActivity : Activity
{
    //The prompts to the activity
    private string[] promts = {
        "Who are some important people in your life?",
        "What is something that you could not live without?",
        "What are some ways that you can improve yourself starting today?",
        "What spiritual experiences have you had this month?"
    };

    public ListingActivity(int duration) : base(duration, "Listing")
    {}

    public override void Start()
    {
        base.Start();
        Console.WriteLine("This activity will help you reflect on certain questions, then you will be asked to reflect and list off answers about those questions.");
        //3 second pause
        Thread.Sleep(3000);
    }

    public override void End()
    {
        base.End();
    }
    public void ListItems()
    {
        Random rand = new Random();
        Console.WriteLine("Think about the following prompt:");
        Console.WriteLine(prompts[rand.Next(prompts.Length)]);
        Console.WriteLine("Ponder on this for a few seconds...");
        //5 seconds of waiting
        ShowSpinner(5);
        Console.WriteLine("Start Listiing items now!");

        int count = 0;
        string item;
        do{
            Console.WriteLine("Enter an item or type 'done' to finish: ");
            item = Console.ReadLine();
            //This will repeat as long as the user does not type done
            if (item.ToLower() != "done")
            {
                count++;
            }
        } while (item.ToLower() != "done");

        Console.WriteLine($"Number of items listen: {count}");
    }
}

//Actual Program
class Program
{
    static void Main(string[] args)
    {
        //This is the menu for the program
        Console.WriteLine("Menu:");
        Console.WriteLine("1.) Breathing Activity");
        Console.WriteLine("2.) Reflection Activity");
        Console.WriteLine("3.) Listing Activity");
        Console.Write("Please Enter Your Choice: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
            //to start the breathing activity
                ExecuteBreathingActivity();
                break;
            case 2:
            //to start the reflection activity
                ExecuteReflectionActivity();
                break;
            case 3:
            //to start the listing activity
                ExecuteListingActivity();
                break;
            default:
            //incase the user inputs an invalid option.
                Console.WriteLine("Sorry, that is not an option. Please try again.");
                break;
        }
    }

    //This is to start the breathing activity
    static void ExecuteBreathingActivity()
    {
        Console.Write("Enter duration (in seconds): ");
        int duration = int.Parse(Console.ReadLine());
        BreathingActivity breathingActivity = new BreathingActivity(duration);
        breathingActivity.Start();
        while (duration > 0)
        {
            //This will repeat the breathing exercise for the amount of time that the user inputed.
            breathingActivity.Breathe();
            duration--;
        }
        breathingActivity.End();
    }

    //This is to start the Reflection Activity
    static void ExecuteReflectionActivity()
    {
        Console.Write("Enter duration (in seconds): ");
        int duration = int.Parse(Console.ReadLine());
        ReflectionActivity reflectionActivity = new ReflectionActivity(duration);
        reflectionActivity.Start();
        while (duration > 0)
        {
            //This will control how long the activity will last
            reflectionActivity.Reflect();
            duration--;
        }
        reflectionActivity.End();
    }

    //This is to start the Listing Activity

}