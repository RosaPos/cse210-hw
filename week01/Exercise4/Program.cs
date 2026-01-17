using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int enteredNumber = -1;
        while (enteredNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string response = Console.ReadLine();
            enteredNumber = int.Parse(response);

            if (enteredNumber != 0)
            {
                numbers.Add(enteredNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}
