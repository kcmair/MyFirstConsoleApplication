using System;

class MyFirstConsoleApplication
{
    static void Main()
    {
        string name = "Keith";
        string location = "Utah";
        Console.WriteLine($"My name is {name}.");
        Console.WriteLine($"I am from {location}.");

        var currentDate = DateOnly.FromDateTime(DateTime.Now);
        Console.WriteLine($"Today is {currentDate}.");

        var xmasDay = new DateOnly(2023, 12, 25);
        int daysToXmas = (xmasDay.DayNumber - currentDate.DayNumber);
        Console.WriteLine($"There are {daysToXmas} days to Christmas.\n");

        double width, height, woodLength, glassArea;
        string widthString, heightString;

        Console.WriteLine("What is the width of the window in meters?");
        widthString = Console.ReadLine();
        width = double.Parse(widthString);

        Console.WriteLine("What is the height of the window in meters?");
        heightString = Console.ReadLine();
        height = double.Parse(heightString);

        woodLength = 2 * (width + height) * 3.25;

        glassArea = 2 * (width * height);

        Console.WriteLine("The length of the wood is " + woodLength + " feet");
        Console.WriteLine("The area of the glass is " + glassArea + " square meters");
        Console.Write("Press <Enter> to exit... ");
        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
    }
}