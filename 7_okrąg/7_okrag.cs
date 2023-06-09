using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double x, y, r;
        Console.WriteLine("Podaj x)");
        x = inputValue();
        Console.WriteLine("Podaj y");
        y = inputValue();
        Console.WriteLine("Podaj r)");
        r = inputValue();
        if (Math.Sqrt(x + y) <= Math.Sqrt(r))
        {
            Console.WriteLine("Punkt leży w obrębie koła o środku O(0,0)");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Punkt leży poza obrębem koła o środku O(0,0)");
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
