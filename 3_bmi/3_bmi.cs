using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double w, h;
        Console.WriteLine("Podaj wage w kg");
        w = inputValue();
        Console.WriteLine("Podaj wzrost w metrach (maks 2 m)");
        h = inputValue();
        while (h > 2)
        {
            Console.WriteLine("Podałeś zbyt duży wzrost, podaj jeszcze raz");
            h = inputValue();
        }
        
        double bmi = w / (h * h);
        Console.WriteLine("Twoje BMI wynosi:" + bmi);
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
