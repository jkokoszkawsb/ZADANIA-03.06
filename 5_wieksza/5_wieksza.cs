using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b;
        Console.WriteLine("Podaj pierwszą liczbę");
        a = inputValue();
        Console.WriteLine("Podaj drugą liczbę");
        b = inputValue();

        if (a == b)
        {
            Console.WriteLine("Liczby są takie same");
            Console.ReadLine();
        }
        else if (a > b)
        {
            Console.WriteLine("Większa jest liczba: " + a);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Większa jest liczba: " + b);
            Console.ReadLine();
        }
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
