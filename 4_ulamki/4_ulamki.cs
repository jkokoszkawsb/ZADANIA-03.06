using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, c, d, x, y;
        Console.WriteLine("Podaj 1 liczbę całkowitą");
        a = (int)inputValue();
        Console.WriteLine("Podaj 2 liczbę całkowitą");
        b = (int)inputValue();
        Console.WriteLine("Podaj 3 liczbę całkowitą");
        c = (int)inputValue();
        Console.WriteLine("Podaj 4 liczbę całkowitą");
        d = (int)inputValue();

        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak rozwiązania");
            Console.ReadLine();
        }
        else if ( b == d)
        {
            x = a + c;
            Console.WriteLine("Licznik wynosi:" + x);
            Console.WriteLine("Mianownik wynosi: " + b);
            Console.ReadLine();
        }
        else
        {
            y = b * d;
            a = a * d;
            c = c * b;
            x = a + c;
            Console.WriteLine("Licznik wynosi:" + x);
            Console.WriteLine("Mianownik wynosi: " + y);
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
