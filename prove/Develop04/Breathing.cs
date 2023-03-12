using System;

class Breathing : Activity
{
    private string _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    private string _startingMessage = "Welcome to the Breathing Activity";
    private string _finishingMessage = "";
    private string _title = "Breathing Activity";
    private int _timeDuration;
    public Breathing(int timeDuration) : base(timeDuration)
    {
        _timeDuration = timeDuration;

    }

    public void runBreathingActivity(int timeDuration)
    {
        Console.WriteLine(_startingMessage);
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Activity activity = new Activity();
        activity.setTimeDuration();
        _timeDuration = activity.getTimeDuration();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(5);

        if (currentTime < futureTime)
        {
            Console.Clear();
            Console.Write("Get ready");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            breathing();
            Console.WriteLine(_congratsMessage);
            Console.WriteLine("");
            _finishingMessage = $"You finished {_timeDuration / 100} seconds of breathing.";
            Console.WriteLine(_finishingMessage);
            Thread.Sleep(5000);
        }
    }

    public void breathing()
    {
        Console.Clear();
        for (int i = (_timeDuration/100) / 5; i > 0; i--)
        {
            Console.WriteLine("Breathe in...");
            for (int j = 5; j > 0; j--)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\b \b");
                Console.Write(j);
                Thread.Sleep(900);
                Console.Write("\b \b");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Clear();
            Console.WriteLine("Now breathe out...");
            for (int k = 5; k > 0; k--)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\b \b");
                Console.Write(k);
                Thread.Sleep(900);
                Console.Write("\b \b");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Clear();
        }
        Thread.Sleep(1000);   
    }
}