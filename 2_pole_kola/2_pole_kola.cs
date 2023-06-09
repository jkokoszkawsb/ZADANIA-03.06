﻿using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj pole koła");
        double p = inputValue();
        double r = Math.Sqrt(p / Math.PI);
              
        double o = 2 * Math.PI * r;
        Console.WriteLine("Obwód koła wynosi " + o);
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
