using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, z, w;
        Console.WriteLine("Wprowadź pierwszą liczbę");
        a = inputValue();
        Console.WriteLine("Wprowadź drugą liczbę");
        b = inputValue();
        Console.WriteLine("Podaj jakie działanie chcesz wykonać: 1 - dodawanie, 2 - odejmowanie, 3 - mnożenie, 4 - dzielenie");
        z = inputValue();
        if (z == 1)
        {
            w = a + b;
            Console.WriteLine("Wynik dodawania wynosi: " + w);
            Console.ReadLine();
        }
        else if (z == 2)
        {
            w = a - b;
            Console.WriteLine("Wynik odejmowania wynosi: " + w);
            Console.ReadLine();
        }
        else if (z == 3)
        {
            w = a * b;
            Console.WriteLine("Wynik mnożenia wynosi: " + w);
            Console.ReadLine();
        }
        else if (z == 4)
        {
            if (b == 0)
            {
                Console.WriteLine("Wynik dzielenia wynosi: " + a + " / " + b);
                Console.ReadLine();
            }
            else
            {
                w = a / b;
                Console.WriteLine("Wynik dzielenia wynosi: " + w);
                Console.ReadLine();
            }
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
