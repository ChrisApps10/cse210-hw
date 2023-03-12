using System;

class Reflecting : Activity
{
   private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
   private string _startingMessage = "Welcome to the Reflecting Activity!";
   private List<string> _promptList = new List<string>{
        "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
   private string _considerPrompt = "Consider the following prompt:";
   private List<string> _questionList = new List<string>{"Why was this experience meaningful to you?", 
        "Have you ever done anything like this before?", "How did you get started?", 
        "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", 
        "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", 
        "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    private List<string> _animationList = new List<string>{"|", "/", "-", "\\", "|",  "/", "-", "\\" };
   private string _finishingMessage = "";
   private string _name = "Reflecting Activity";
   private int _timeDuration;
   public Reflecting(int timeDuration) : base(timeDuration)
   {

    _timeDuration = timeDuration;
      
      
   }

   public void runReflectingActivity(int timeDuration)
   {
        Console.WriteLine(_startingMessage);
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Activity activity = new Activity();
        activity.setTimeDuration();
        _timeDuration = activity.getTimeDuration();
        Console.WriteLine("");
        reflecting();
        Console.WriteLine(_congratsMessage);
        Console.WriteLine("");
        _finishingMessage = $"You finished {_timeDuration / 100} seconds of reflecting.";
        Console.WriteLine(_finishingMessage);
        Thread.Sleep(3000);
    
   }

   public void reflecting()
    {

        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine(_considerPrompt);
        Console.WriteLine("");
        var random = new Random();
        int index = random.Next(_promptList.Count);
        string randomPrompt = _promptList[index];
        Console.WriteLine(randomPrompt);
        Console.WriteLine("");
        Console.WriteLine("Press enter when you are ready");
        string userInput = Console.ReadLine();
        if (userInput == "")
        {
            Console.Clear();
            for (int i = (_timeDuration/100) / 5; i > 0; i--)
            {
                var random1 = new Random();
                int index1 = random1.Next(_promptList.Count);
                string randomQuestion = _questionList[index1];
                Console.WriteLine(randomQuestion);
                Console.Write("");
                int a = _animationList.Count - 1;
                for (int j = 7; j > 0; j--)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(_animationList[a]);
                    if (a <= 0)
                    {
                        a = _animationList.Count - 1;
                    }
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    Console.ForegroundColor = ConsoleColor.White;
                    a--;
                }
                Console.Clear();

            }
        }  
        Thread.Sleep(3000);
        
    }

    

   public void displayPrompt()
   {}
}