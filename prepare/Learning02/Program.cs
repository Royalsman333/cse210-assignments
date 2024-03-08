using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Line Cook";
        job1._company = "Culvers";
        job1._startYear = 2015;
        job1._endYear = 2016;

        Job job2 = new Job();
        job2._jobTitle = "Shift Lead";
        job2._company = "Noodles World Kitchen";
        job2._startYear = 2017;
        job2._endYear = 2016;

        Job job3 = new Job();
        job3._jobTitle = "Security Guard";
        job3._company = "Frisbie Memorial Hospital";
        job3._startYear = 2021;
        job3._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Jeremy Untch";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        myResume.Display();
    }
}