using System;

class Portfolio
{
    public string Name;
    public string Course;
    public string School;
    public string YearLevel;
    public string Email;
    public string PhoneNumber;

    public void DisplayMiniPortfolio()
    {
        Console.WriteLine("===== MY MINI PORTFOLIO =====\n");

        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Course: " + Course);
        Console.WriteLine("School: " + School);
        Console.WriteLine("Year Level: " + YearLevel);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("PhoneNumber" + PhoneNumber);

        Skills();
        TesdaAchievements();

        Console.WriteLine("==============================");
    }

    public void Skills()
    {
        Console.WriteLine("Skills:");
        Console.WriteLine("- SQL Database");
        Console.WriteLine("- SQL Database");
        Console.WriteLine("- PHP Programming");
        Console.WriteLine("- Java Programming\n");
    }

    public void TesdaAchievements()
    {
        Console.WriteLine("Tesda Achievements:");
        Console.WriteLine("- TESDA NC II: Java Programming");
        Console.WriteLine("- TESDA NC II: Computer Servicing  Systems\n");
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
        myPortfolio.Email = "pupbsitestalillajohanna@gmail.com";
        myPortfolio.PhoneNumber = "+63 966 395 2110";

        myPortfolio.DisplayMiniPortfolio();

        Console.WriteLine("==============================");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
