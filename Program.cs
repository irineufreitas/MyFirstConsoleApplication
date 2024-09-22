using System;

class Program
{
    static void Main()
    {
        // variables for name and location
        string myName = "Irineu de Freitas";  
        string myLocation = "Brazil";          

        // display name and location using string interpolation
        Console.WriteLine($"My name is {myName}.");
        Console.WriteLine($"I am from {myLocation}.");

        // display the current date (without time)
        DateTime currentDate = DateTime.Now;
        Console.WriteLine($"Today's date is {currentDate.ToString("MM/dd/yyyy")}.");

        // display the number of days until Christmas this year
        DateTime christmasDate = new DateTime(currentDate.Year, 12, 25);
        int daysUntilChristmas = (christmasDate - currentDate).Days;
        Console.WriteLine($"There are {daysUntilChristmas} days until Christmas this year.");

        // section 2.1 of the C# Yellow Book
        // Requesting user input with appropriate labels for dimensions
        double width, height, woodLength, glassArea;
        string widthString, heightString;

        // Request width input from the user
        Console.Write("Enter the width of the window: ");
        widthString = Console.ReadLine();
        width = double.Parse(widthString);  

        // Request height input from the user
        Console.Write("Enter the height of the window: ");
        heightString = Console.ReadLine();
        height = double.Parse(heightString);  

        // Calculate the length of the wood required and the area of the glass
        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width * height);

        // display the results using string interpolation and formatting to 2 decimal places
        Console.WriteLine($"The length of the wood is {woodLength:F2} feet.");
        Console.WriteLine($"The area of the glass is {glassArea:F2} square metres.");

        // display the console so that the window doesn't close immediately
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
