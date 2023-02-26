using System;

class Program
{
     static void Main(string[] args)
    {
    
        string response = "";
        

        while (response != "4")
        {
            Console.WriteLine();
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string userResponse = Console.ReadLine();
            response = userResponse;
            int userInput = int.Parse(response);
            Console.Clear();
            Activity activity = new Activity();

            if (userInput == 1)
            {
                Activity activity1 = new Activity();
                activity1.runActivity(userInput);
            }
            if (userInput == 2)
            {
                Activity activity2 = new Activity();
                activity2.runActivity(userInput);
            }
            if (userInput == 3)
            {
                Activity activity3 = new Activity();
                activity3.runActivity(userInput);
            }

        }
        {
            Console.WriteLine("Thank you for participating.");
            Console.WriteLine("");
        }
        
        
        
    }
}