using System;

class Program
{
    static void Main(string[] args)
    {
        // 1) Fraction()  -> 1/1
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString()); // "1/1"
        Console.WriteLine(f1.GetDecimalValue());   // 1

        // 2) Fraction(5) -> 5/1
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString()); // "5/1"
        Console.WriteLine(f2.GetDecimalValue());   // 5

        // 3) Fraction(3,4) -> 3/4
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString()); // "3/4"
        Console.WriteLine(f3.GetDecimalValue());   // 0.75

        // 4) Fraction(1/3) -> 1/3
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString()); // "1/3"
        Console.WriteLine(f4.GetDecimalValue());   // 0.333...
    }
}