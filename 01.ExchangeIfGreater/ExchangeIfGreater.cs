﻿using System;
/*
    Problem 1. Exchange If Greater

    Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
 */
class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Please enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter b: ");
        double b = double.Parse(Console.ReadLine());
        double change = 0;
        if (a > b)
        {
            change = a;
            a = b;
            b = change;
        }
        Console.WriteLine("Result: {0} {1}", a, b);
    }
}
