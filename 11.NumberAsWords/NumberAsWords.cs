using System;
/*
    Problem 11.* Number as Words

    Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
 */
class NumberAsWords
{
    static void Main()
    {
        Console.Write("Please enter a number (0-999): ");
        int number = 0;
        bool isNumber = Int32.TryParse(Console.ReadLine(), out number);
        if (isNumber)
        {
            if (number > 999 || number < 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                int firstDigit = number / 100;
                int secondDigit = (number - (firstDigit * 100)) / 10;
                int thirdDigit = number % 10;

                switch (firstDigit)
                {
                    case 0:
                        break;
                    case 1:
                        if (secondDigit == 0 && thirdDigit == 0)
                        {
                            Console.Write("one hundred");
                            break;
                        }
                        else
                        {
                            Console.Write("one hundred and ");
                            break;
                        }
                    case 2:
                        if (secondDigit == 0 && thirdDigit == 0)
                        {
                            Console.Write("two hundred");
                            break;
                        }
                        else
                        {
                            Console.Write("two hundred and ");
                            break;
                        }
                    case 3:
                        if (secondDigit == 0 && thirdDigit == 0)
                        {
                            Console.Write("three hundred");
                            break;
                        }
                        else
                        {
                            Console.Write("three hundred and ");
                            break;
                        }
                    case 4:
                        if (secondDigit == 0 && thirdDigit == 0)
                        {
                            Console.Write("four hundred");
                            break;
                        }
                        else
                        {
                            Console.Write("four hundred and ");
                            break;
                        }
                    case 5:
                        if (secondDigit == 0 && thirdDigit == 0)
                        {
                            Console.Write("five hundred");
                            break;
                        }
                        else
                        {
                            Console.Write("five hundred and ");
                            break;
                        }
                    case 6:
                        if (secondDigit == 0 && thirdDigit == 0)
                        {
                            Console.Write("six hundred");
                            break;
                        }
                        else
                        {
                            Console.Write("six hundred and ");
                            break;
                        }
                    case 7:
                        if (secondDigit == 0 && thirdDigit == 0)
                        {
                            Console.Write("seven hundred");
                            break;
                        }
                        else
                        {
                            Console.Write("seven hundred and ");
                            break;
                        }
                    case 8:
                        if (secondDigit == 0 && thirdDigit == 0)
                        {
                            Console.Write("eight hundred");
                            break;
                        }
                        else
                        {
                            Console.Write("eight hundred and ");
                            break;
                        }
                    case 9:
                        if (secondDigit == 0 && thirdDigit == 0)
                        {
                            Console.Write("nine hundred");
                            break;
                        }
                        else
                        {
                            Console.Write("nine hundred and ");
                            break;
                        }
                }

                switch (secondDigit)
                {
                    case 0:
                        break;
                    case 1:
                        switch (thirdDigit)
                        {
                            case 0:
                                Console.Write("ten"); break;
                            case 1:
                                Console.Write("eleven"); break;
                            case 2:
                                Console.Write("twelve"); break;
                            case 3:
                                Console.Write("thirteen"); break;
                            case 4:
                                Console.Write("fourteen"); break;
                            case 5:
                                Console.Write("fifteen"); break;
                            case 6:
                                Console.Write("sixteen"); break;
                            case 7:
                                Console.Write("seventeen"); break;
                            case 8:
                                Console.Write("eighteen"); break;
                            case 9:
                                Console.Write("nineteen"); break;
                        }
                        break;
                    case 2:
                        Console.Write("twenty "); break;
                    case 3:
                        Console.Write("thirty "); break;
                    case 4:
                        Console.Write("fourty "); break;
                    case 5:
                        Console.Write("fifty "); break;
                    case 6:
                        Console.Write("sixty "); break;
                    case 7:
                        Console.Write("seventy "); break;
                    case 8:
                        Console.Write("eighty "); break;
                    case 9:
                        Console.Write("ninety "); break;
                }

                switch (thirdDigit)
                {
                    case 0:
                        if (firstDigit == 0 && secondDigit == 0)
                        {
                            Console.Write("zero"); break;
                        }
                        else
                        {
                            break;
                        }
                    case 1:
                        if (secondDigit == 1)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("one"); break;
                        }
                    case 2:
                        if (secondDigit == 1)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("two"); break;
                        }
                    case 3:
                        if (secondDigit == 1)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("three"); break;
                        }
                    case 4:
                        if (secondDigit == 1)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("four"); break;
                        }
                    case 5:
                        if (secondDigit == 1)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("five"); break;
                        }
                    case 6:
                        if (secondDigit == 1)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("six"); break;
                        }
                    case 7:
                        if (secondDigit == 1)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("seven"); break;
                        }
                    case 8:
                        if (secondDigit == 1)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("eight"); break;
                        }
                    case 9:
                        if (secondDigit == 1)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("nine"); break;
                        }
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Not a number");
        }
    }
}
