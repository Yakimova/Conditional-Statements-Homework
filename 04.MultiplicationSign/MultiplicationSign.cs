﻿using System;
/*
    Problem 4. Multiplication Sign

    Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
        Use a sequence of if operators.
 */
class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Please enter the first real number - a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second real number - b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third real number - c: ");
        double c = double.Parse(Console.ReadLine());
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine(0);
        }
        else if (a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine("+");
        }
        else if (a > 0 && b < 0 && c < 0)
        {
            Console.WriteLine("+");
        }
        else if (a < 0 && b > 0 && c < 0)
        {
            Console.WriteLine("+");
        }
        else if (a < 0 && b < 0 && c > 0)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}