using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;


    }

    public virtual void Run()
    {
        // Se define en las clases hijas (override)
    }

    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void EndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
        Console.Clear();
    }

    public int GetDuration()
    {
        return _duration;
    }

    public string GetName()
    {
        return _name;
    }

    public void ShowSpinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        int total = seconds * 10;
        for (int i = 0; i < total; i++)
        {
            Console.Write(frames[i % frames.Length]);
            Thread.Sleep(100);
            Console.Write("\b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
