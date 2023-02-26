using System;

class Reflecting : Activity
{
   private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
   private string _startMessage = "Welcome to the Reflecting Activity!";
   private List<string> _promptList = new List<string>{
        "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
   private string _considerPromptMessage = "Consider the following prompt:";
   private List<string> _questionList = new List<string>{"Why was this experience meaningful to you?", 
        "Have you ever done anything like this before?", "How did you get started?", 
        "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", 
        "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", 
        "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    private List<string> _animationsList = new List<string>{"|", "/", "-", "\\", "|",  "/", "-", "\\" };
   private string _endMessage = "";
   private string _name = "Reflecting Activity";
   private int _duration;
   public Reflecting(int duration) : base(duration)
   {

    _duration = duration;
      
      
   }

   public void runReflectingActivity(int duration)
   {
        Console.WriteLine(_startMessage);
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Activity activity = new Activity();
        activity.setDuration();
        _duration = activity.getDuration();
        Console.WriteLine("");
        reflecting();
        Console.WriteLine(_wellDone);
        Console.WriteLine("");
        _endMessage = $"You finished {_duration / 100} seconds of reflecting.";
        Console.WriteLine(_endMessage);
        Thread.Sleep(3000);
    
   }

   public void reflecting()
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
        Console.WriteLine("Press enter when you are ready");
        string userInput = Console.ReadLine();
        if (userInput == "")
        {
            Console.Clear();
            for (int i = (_duration/100) / 5; i > 0; i--)
            {
                var random1 = new Random();
                int index1 = random1.Next(_promptList.Count);
                string randomQuestion = _questionList[index1];
                Console.WriteLine(randomQuestion);
                Console.Write("");
                int a = _animationsList.Count - 1;
                for (int j = 7; j > 0; j--)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(_animationsList[a]);
                    if (a <= 0)
                    {
                        a = _animationsList.Count - 1;
                    }
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    Console.ForegroundColor = ConsoleColor.White;
                    a--;
                }
                Console.Clear();

            }
        }




        
        
        Thread.Sleep(2000);
        
    }



   public void displayPrompt()
   {

   }
    

  
}