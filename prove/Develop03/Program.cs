using System;

class Program
{
    static void Main(string[] args)
    {

        Scripture scripture = new Scripture();
        scripture.Display();
        string input = "";

        

        while (input != "quit")
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish.");
            string userInput = Console.ReadLine();
            input = userInput;
            scripture.removeWord();
            Console.Clear();
            scripture.Display();
        } 
        while (input == "quit")
        {
            Console.WriteLine("Thanks for using the Scripture Memorization Program.");
            Environment.Exit(0);
        }  
    }
}