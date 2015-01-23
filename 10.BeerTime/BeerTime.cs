using System;
/*
    Problem 10.* Beer Time

    A beer time is after 1:00 PM and before 3:00 AM.
    Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.
 */
class BeerTime
{
    static void Main()
    {
        Console.Write("Please enter a time in format hh:mm tt: ");
        string input = Console.ReadLine();
        DateTime inputTime;
        bool possible = DateTime.TryParse(input, out inputTime);
        if (possible)
        {
            TimeSpan time = inputTime.TimeOfDay;
            string start = "01:00 pm";
            DateTime startBeerTime = DateTime.Parse(start);
            TimeSpan startTime = startBeerTime.TimeOfDay;
            string end = "03:00 am";
            DateTime endBeerTime = DateTime.Parse(end);
            TimeSpan endTime = endBeerTime.TimeOfDay;
            if (time >= startTime || time <= endTime)
            {
                Console.WriteLine("Beer time");
            }
            else
            {
                Console.WriteLine("Non-beer time");
            }
        }

        else
        {
            Console.WriteLine("Invalid time");
        }
    }
}
