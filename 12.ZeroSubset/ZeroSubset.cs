using System;
/*
    Problem 12.* Zero Subset

    We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
    Assume that repeating the same subset several times is not a problem.
 */
class ZeroSubset
{
    static void Main()
    {
        Console.WriteLine("PLease enter the 5 integer numbers, separated by space: ");
        string numbers = Console.ReadLine();
        string[] separateNumbers = numbers.Split(' ');
        int[] clearNumbers = new int[5];
        bool zeroSubset = false;
        for (int i = 0; i < 5; i++)
        {
            clearNumbers[i] = int.Parse(separateNumbers[i]);
        }
        for (int i = 0; i < 5; i++)
        {
            if (clearNumbers[i] == 0)
            {
                Console.WriteLine("{0} = 0", clearNumbers[i]);
                zeroSubset = true;
            }
            for (int j = i + 1; j < 5; j++)
            {
                if ((clearNumbers[i] + clearNumbers[j]) == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", clearNumbers[i], clearNumbers[j]);
                    zeroSubset = true;
                }
                for (int k = j+1; k < 5; k++)
                {
                    if ((clearNumbers[i] + clearNumbers[j] + clearNumbers[k]) == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} = 0", clearNumbers[i], clearNumbers[j], clearNumbers[k]);
                        zeroSubset = true;
                    }
                    for (int l = k+1; l < 5; l++)
                    {
                        if ((clearNumbers[i] + clearNumbers[j] + clearNumbers[k] + clearNumbers[l]) == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} + {3} = 0", clearNumbers[i], clearNumbers[j], clearNumbers[k], clearNumbers[l]);
                            zeroSubset = true;
                        }
                    }
                }
            }
        }
        if ((clearNumbers[0] + clearNumbers[1] + clearNumbers[2] + clearNumbers[3] + clearNumbers[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", clearNumbers[0], clearNumbers[1], clearNumbers[2], clearNumbers[3], clearNumbers[4]);
            zeroSubset = true;
        }
        if (zeroSubset == false)
        {
            Console.WriteLine("There are no zero subsets.");
        }
    }
}
