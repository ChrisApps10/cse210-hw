using System;

class Program
{
    static void Main(string[] args)
    {

        string cwd = Directory.GetCurrentDirectory();
        string fileTitle = "goals.txt";
        string fileString = $"{cwd}/{fileTitle}";
        string entry = "";

        while (entry != "6")
        {
            Console.WriteLine();
            Points points = new Points();
            int currentPoints = points.getPoints();
            Console.WriteLine($"You currently have {currentPoints} points.");
            Console.WriteLine();
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            string userEntry1 = Console.ReadLine();
            entry = userEntry1;
            int input = int.Parse(entry);
            Goals goal = new Goals();

            if (input == 1)
            {
                int goalType = 0;
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string userEntry2 = Console.ReadLine();
                goalType = int.Parse(userEntry2);
                if (goalType == 1) 
                {
                    goal.createGoal(goalType, fileString, fileTitle);
                }
                if (goalType == 2)
                {
                    goal.createGoal(goalType, fileString, fileTitle);
                }
                if (goalType == 3)
                {
                    goal.createGoal(goalType, fileString, fileTitle);
                }
                
            }
            if (input == 2)
            {
                Console.Clear();
                Console.WriteLine("");
                goal.showAllGoals(fileString);
                
            }
            if (input == 3)
            {
                fileTitle = goal.saveGoals(fileTitle);
                fileString = $"{cwd}/{fileTitle}";                
            }
            if (input == 4)
            {
                fileTitle = goal.loadGoals();
                fileString = $"{cwd}/{fileTitle}";
            }
            if (input == 5)
            {
            }
            if (input == 6)
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for your participation!");
                Console.WriteLine("");
                Environment.Exit(0);
            }
        }
    }
}  