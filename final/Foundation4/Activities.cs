using System;

class Activities
{
    public List<Activity> _activities = new List<Activity>();
    public Activities()
    {

    }

    public void showActivities()
    {
        Console.WriteLine("");
        Console.WriteLine("Activities");
        Console.WriteLine("");
        foreach (Activity activity in _activities)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(activity.GetSummary());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------");
            
        }
    }

}