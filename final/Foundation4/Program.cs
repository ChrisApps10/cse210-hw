using System;

class Program
{
    static void Main(string[] args)
    {
        Swimming swim1 = new Swimming("01 Apr 2023", "Swimming", 15, 10);
        Cycling cycle1 = new Cycling("28 Mar 2023", "Cycling", 30, 10);
        Running run1 = new Running("23 Mar 2023", "Running", 15, 2);

        Activities list = new Activities();
        list._activities.Add(swim1);
        list._activities.Add(cycle1);
        list._activities.Add(run1);

        list.showActivities();
    }
    
}