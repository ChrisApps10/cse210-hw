using System;

class Program
{
    static void Main(string[] args)
    {
        Running _running = new Running("10 Apr 2023", "Running", 25, 5);
        Cycling _cycling = new Cycling("25 Jun 2023", "Cycling", 10, 13);
        Swimming _swimming = new Swimming("18 May 2023", "Swimming", 17, 15);


        Activities list = new Activities();
        list._activities.Add(_running);
        list._activities.Add(_cycling);
        list._activities.Add(_swimming);
        list.showActivities();
    }
    
}