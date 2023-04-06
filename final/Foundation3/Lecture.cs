using System;

class Lecture : Event
{
    private string _speaker = "";
    private int _capacity = 0;

    public Lecture()
        {
            
        }
    public Lecture(string speaker, int capacity, string title, string description, string date, string time, Address address, string type) : base(title, description, date, time, address, type )
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void DisplayFullDetails() 
    {
        Console.WriteLine("Full Details:");
        Console.WriteLine($"Event Type: {_type}");
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine(_date);
        Console.WriteLine(_time);
        Console.WriteLine(_address.GetAddress());
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
        
    }
}