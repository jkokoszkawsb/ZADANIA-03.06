using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;
        Console.WriteLine("Podaj 1 liczbę");
        a = inputValue();
        Console.WriteLine("Podaj 2 liczbę");
        b = inputValue();
        Console.WriteLine("Podaj 3 liczbę");
        c = inputValue();
        double srednia;

        srednia = (a + b + c) / 3;
        Console.WriteLine("Srednia wynosi:" + srednia);
        Console.ReadLine();
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
