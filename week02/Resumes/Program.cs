using System;

class Program
{
    static void Main(string[] args)
    {
        // Job 1
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Tech Solutions Inc.";
        job1._startYear = 2018;
        job1._endYear = 2022;

        Console.WriteLine(job1._company);

        // Job 2
        Job job2 = new Job();
        job2._jobTitle = "Senior Developer";
        job2._company = "Innovatech Corp.";
        job2._startYear = 2022;
        job2._endYear = 2024;

        Console.WriteLine(job2._company);

        Resume myResume = new Resume();
        myResume._name = "Alex Johnson";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        Console.WriteLine(myResume._jobs[0]._jobTitle);

    }
}
