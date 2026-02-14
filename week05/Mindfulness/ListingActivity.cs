using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private Random _random = new Random();

    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public override void Run()
    {
        StartMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();

        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                count++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {count} items!");

        EndMessage();
    }
}
