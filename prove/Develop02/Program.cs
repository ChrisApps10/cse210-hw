using System;
using System.IO;

class Program
{
    public static void Main()
    {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
        
        string entry;
        Console.Write("What would you like to do? ");
        entry = Console.ReadLine(); 

        while (entry == "1" || entry == "2")

            if (entry == "1")
            {
             Journal.questionGenerator();
             Console.Write("What would you like to do? ");
             entry = Console.ReadLine();
            }

            else if (entry == "2")
            {
             Read.fileRead();
             string text = File.ReadAllText(@"C:Journal.txt");  
             Console.Write("What would you like to do? ");
             entry = Console.ReadLine();
            }

        if (entry == "3")
        {
         Console.WriteLine("What is the name of the file?");
         Console.Write("What would you like to do? ");
         entry = Console.ReadLine();
        }
        
        if (entry == "5")
        {
         Console.WriteLine("Thanks for recording your entries!");
         Environment.Exit(0);
        }

        else
        {
         Console.WriteLine("Input not recognized. Please try again.");
         Console.Write("What would you like to do? ");
         entry = Console.ReadLine();
        }
        Console.ReadLine();
    }
}