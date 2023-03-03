using System;

class Program
{
     static void Main(string[] args)
    {
    
        string entry = "";
        

        while (entry != "4")
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string userEntry = Console.ReadLine();
            entry = userEntry;
            int input = int.Parse(entry);
            Console.Clear();
            Activity activity = new Activity();

            if (input == 1)
            {
                Activity activity1 = new Activity();
                activity1.runActivity(input);
            }
            if (input == 2)
            {
                Activity activity2 = new Activity();
                activity2.runActivity(input);
            }
            if (input == 3)
            {
                Activity activity3 = new Activity();
                activity3.runActivity(input);
            }
            else
            {
                Console.WriteLine("Thank you for your participation!");
                Console.WriteLine("");
                Environment.Exit(0);
            }
    }
    }
}