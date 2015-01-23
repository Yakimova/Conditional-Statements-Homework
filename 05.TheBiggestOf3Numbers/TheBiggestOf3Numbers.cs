using System;
/*
    Problem 5. The Biggest of 3 Numbers

    Write a program that finds the biggest of three numbers.
 */
class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("Please enter the first number - a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number - b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number - c: ");
        double c = double.Parse(Console.ReadLine());
        if (a >= b && a >= c)
        {
            Console.WriteLine("The biggest number is {0}", a);
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine("The biggest number is {0}", b);
        }
        else
        {
            Console.WriteLine("The biggest number is {0}", c);
        }
    }
}
