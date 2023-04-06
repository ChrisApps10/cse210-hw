using System;

class Reception : Event
{
    private List<string> _emails = new List<string>();

    public Reception()
        {
            
        }
    public Reception(string title, string description, string date, string time, Address address, string type) : base(title, description, date, time, address, type)
    {
        _address = address;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _type = type;
    }

    public void AddEmails(string [] emails)
    {
        foreach(string email in emails)
        {
            _emails.Add(email);
        } 
    }

    public void GetEmails()
    {
        foreach (string email in _emails)
        Console.WriteLine(email);
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
        Console.WriteLine($"Email RSVP List:");
        GetEmails();
    }

   
}