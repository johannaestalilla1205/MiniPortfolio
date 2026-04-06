using System;

class Portfolio
{
    public string Name;
    public string Course;
    public string School;
    public string YearLevel;

    public void DisplayMiniPortfolio()
    {
        Console.WriteLine("===== MY MINI PORTFOLIO =====\n");

        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Course: " + Course);
        Console.WriteLine("School: " + School);
        Console.WriteLine("Year Level: " + YearLevel);

        Skills();

        Console.WriteLine("==============================");
    }

    public void Skills()
    {
        Console.WriteLine("Skills:");
        Console.WriteLine("- SQL Database");
        Console.WriteLine("- Java Programming\n");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Portfolio myPortfolio = new Portfolio();

        myPortfolio.Name = "Johanna Estalilla";
        myPortfolio.Course = "BS Information Technology";
        myPortfolio.School = "Polytechnic University of the Philippines";
        myPortfolio.YearLevel = "3rd Year";

        myPortfolio.DisplayMiniPortfolio();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
