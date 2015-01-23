using System;
/*
    Problem 9. Play with Int, Double and String

    Write a program that, depending on the user’s choice, inputs an int, double or string variable.
        If the variable is int or double, the program increases it by one.
        If the variable is a string, the program appends * at the end.
    Print the result at the console. Use switch statement.
 */
class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.Write("Please choose a type: (1-->int; 2-->double; 3-->string): ");
        int type = int.Parse(Console.ReadLine());
        switch (type)
        {
            case 1:
                Console.Write("Please enter an int: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number+1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleNumber + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string stringVariable = Console.ReadLine();
                Console.WriteLine(stringVariable + "*");
                break;
            default:
                Console.WriteLine("Wrong input");
                break;
        }
    }
}
