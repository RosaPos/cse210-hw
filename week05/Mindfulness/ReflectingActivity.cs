using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you stood up for someone else."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "What did you learn about yourself through this experience?"
    };

    private Random _random = new Random();

    public ReflectingActivity(string name, string description) : base(name, description)
    {
    }

    public override void Run()
    {
        StartMessage();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {_prompts[_random.Next(_prompts.Count)]} ---");
        Console.WriteLine();
        Console.Write("When you have something in mind, press Enter to continue. ");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string question = _questions[_random.Next(_questions.Count)];
            Console.WriteLine($"> {question}");
            ShowSpinner(5);
            Console.WriteLine();
        }

        EndMessage();
    }
}

