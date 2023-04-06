using System;

class Gathering : Event
{

private string _weather;

public Gathering()
    {
        
    }
public Gathering(string weather, string title, string description, string date, string time, Address address, string type) : base(title, description, date, time, address, type )
{
    _weather = weather;
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
        Console.WriteLine($"Weather Forecast: {_weather}");
        
        
    }
}