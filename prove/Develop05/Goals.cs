using System;

class Goals
{
    private List<goalType> _goalList = new List<goalType>();

    public Goals()
    {
    }

    public void createGoal(int goalType, string fileString, string fileTitle )
    {
        goalType goal = new goalType();
        Console.WriteLine(goal.getNameQuestion());
        string goalTitle = Console.ReadLine();
        Console.WriteLine(goal.getDesQuestion());
        string goalDescription = Console.ReadLine();
        Console.WriteLine(goal.getPointsQuestion());
        string goalPointsStr = Console.ReadLine();
        int goalPoints = int.Parse(goalPointsStr);
        goal.setGoalTitle(goalTitle);
        goal.setGoalDescription(goalDescription);
        goal.setGoalPoints(goalPoints);
        bool isCompleted = goal.getCompleted();
        string fGoalString = "";
        if (isCompleted == true)
        {
            fGoalString = fGoalString = $"[X],{goalTitle},{goalDescription},{goalPointsStr}";
        } 
        else 
        {
            fGoalString = $"[ ],{goalTitle},{goalDescription},{goalPointsStr}";
        }

        
        goal.addGoal(fGoalString, fileString, fileTitle);
        if (goalType == 3)
        {
            Console.WriteLine(goal.getCompletionsQuestion());
            string res = Console.ReadLine();
            int numRequired = int.Parse(res);
            goal.setNeededCompletions(numRequired);
            Console.WriteLine(goal.getBonusQuestion());
            string res1 = Console.ReadLine();
            int bonus = int.Parse(res1);
            goal.setBonusPoints(bonus);
        }
    }

    public string saveGoals(string currentFileName)
    {
        Console.Write("What would you like to name your file?");
        string newFileName = Console.ReadLine();
        File.Move(currentFileName, newFileName);
        return newFileName;
    }

    public string loadGoals()
    {
        Console.Write("What is the name of the file you would like to load?");
        string newFileName = Console.ReadLine();
        return newFileName;

    }

    public void recordEvent(int goalNum)
    {

    }

    public void showAllGoals(string fileString)
    {
        string line;
        using (StreamReader file = new StreamReader(fileString))
        {
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        Thread.Sleep(3000);
    }
}