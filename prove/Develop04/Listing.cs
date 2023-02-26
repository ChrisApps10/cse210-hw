using System;

class Listing : Activity
{
    // attributes /////////////////////////////////////////////////
   private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
   private string _startMessage = "Welcome to the Listing Activity";
   private string _endMessage = "";
   private string _considerPromptMessage = "Consider the following prompt:";
   private List<string> _promptList = new List<string>{"Who are people that you appreciate?", 
        "What are personal strengths of yours?", "Who are people that you have helped this week?", 
        "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
   private string _name = "Listing Activity";
   private int _numberOfListItems;

   // constructors /////////////////////////////////////////////////
   public Listing(int duration) : base(duration)
   {
      _numberOfListItems = 0;
      _duration = duration;
      
   }

   
    // methods /////////////////////////////////////////////////
   public void runListingActivity(int duration)
   {
        Console.WriteLine(_startMessage);
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Activity activity = new Activity();
        activity.setDuration();
        _duration = activity.getDuration();
        Console.WriteLine("");
        listing();
        Console.WriteLine(_wellDone);
        Console.WriteLine("");
        _endMessage = $"You finished {_duration / 100} seconds of listing.";
        Console.WriteLine(_endMessage);
        Thread.Sleep(6000);
        Console.Clear();
    
   }

   public void listing()
   {
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine(_considerPromptMessage);
        Console.WriteLine("");
        var random = new Random();
        int index = random.Next(_promptList.Count);
        string randomPrompt = _promptList[index];
        Console.WriteLine(randomPrompt);
        Console.WriteLine("");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
        DateTime currentTime = DateTime.Now;
        if (currentTime < endTime)
        {
            Console.Write("Seconds until start:  ");
            for (int i = 5; i > 0; i--)
            {
                Console.Write("\b \b");
                Console.Write(i);
                Thread.Sleep(1000);
            }
            Console.Write("\b \b");
        }
        Console.WriteLine("");
        Console.Write(">");
        DateTime startTime1 = DateTime.Now;
        DateTime endTime1 = startTime1.AddSeconds(_duration / 100);
        while (DateTime.Now < endTime1)
        {
            string userInput = Console.ReadLine();
            _numberOfListItems ++;
            Console.Write("\b \b");
            Console.Write(">");
            
            
        }
        Thread.Sleep(1000);
        Console.WriteLine("");
        displayNumberOfListItems();
        Console.WriteLine("");

        
        
   }
   public void displayNumberOfListItems()
   {
        Console.WriteLine($"You listed {_numberOfListItems} items.");
        }
        }