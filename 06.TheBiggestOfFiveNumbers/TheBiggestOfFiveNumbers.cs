using System;
/*
    Problem 6. The Biggest of Five Numbers

    Write a program that finds the biggest of five numbers by using only five if statements.
 */
class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Please enter the first number - a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number - b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number - c: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Please enter the fourth number - d: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Please enter the fifth number - e: ");
        double e = double.Parse(Console.ReadLine());

        double biggest = a;
        if (biggest<b)
        {
            biggest = b;
        }
        if (biggest<c)
        {
            biggest = c;
        }
        if (biggest<d)
        {
            biggest = d;
        }
        if (biggest<e)
        {
            biggest = e;
        }
        Console.WriteLine("The biggest number is: " + biggest);
    }
}