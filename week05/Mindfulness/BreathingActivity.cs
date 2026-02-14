using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
    }

    public override void Run()
    {
        StartMessage();

        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.WriteLine();
            elapsed += 4;

            if (elapsed >= duration) break;

            Console.Write("Now breathe out... ");
            ShowCountDown(4);
            Console.WriteLine();
            elapsed += 4;
        }

        EndMessage();
    }
}
