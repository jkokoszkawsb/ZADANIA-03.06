using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;
        Console.WriteLine("Podaj pierwszy bok");
        a = inputValue();
        Console.WriteLine("Podaj drugi bok");
        b = inputValue();
        Console.WriteLine("Podaj trzeci bok");
        c = inputValue();
        if (a == b && b == c && c == a)
        {
            Console.WriteLine("Z takich boków można utworzyć trójkąt równoboczny");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Z takich boków nie można utworzyć trójkąt równoboczny");
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
