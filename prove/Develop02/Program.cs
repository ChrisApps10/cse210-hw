using System;
using System.IO;

class Program
{
    public static void Main()
    {
        string path = @"C:cse210_hw\prove\Develop02";
        if (!File.Exists(path))
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Welcome to the Journal Program!");
                sw.WriteLine("Please select one of the following choices:");
                sw.WriteLine("1. Write");
                sw.WriteLine("2. Display");
                sw.WriteLine("3. Load");
                sw.WriteLine("4. Save");
                sw.WriteLine("5. Quit");
            }
        }

        using (StreamReader sr = File.OpenText(path))
        {
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
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
             string text = File.ReadAllText("Journal.txt");  
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