using System;
public class Journal
{
    public static void questionGenerator()
    {
        var random = new Random();
        var _Questions = new List<string>();
        _Questions.Add("Who was the most interesting person I interacted with today?");
        _Questions.Add("What was the best part of my day?");
        _Questions.Add("How did I see the hand of the Lord in my life today?");
        _Questions.Add("What was the strongest emotion I felt today?");
        _Questions.Add("If I had one thing I could do over today, what would it be?");
        
        int index = random.Next(_Questions.Count);
        Console.WriteLine(_Questions[index]);
        string questionEntry = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        questionEntry = dateText + " " + _Questions[index] + " " + questionEntry + "\n";  
        File.AppendAllText(@"C:cse210_hw\prove\Develop02\Journal.txt", questionEntry); 
    }    
}