using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Address _address1 = new Address("525 S Center St, Rexburg, ID 83460");
        Lecture _lecture = new Lecture("Brother Christopher Pitts", 150, "Christopher Pitts's Lecture", "Come join us as Professor Pitts's instructs us in the C# coding language", "12/10/2023", "7:00am", _address1, "Lecture");
        _lecture.DisplayStandardDetails();
        _lecture.DisplayFullDetails();
        _lecture.DisplayShortDetails();
        Console.WriteLine("");
        
        Address _address2 = new Address("");
        Reception _reception = new Reception("Emily and Steve's Wedding Reception", "Come celebrate with the newly wedded couple, Emily and Steve!", "5/25/2024", "8:00pm", _address2, "Reception");
        _reception.AddEmails(new string[] { "stevepaker90@gmail.com", "jane.tucker@hotmail.com", "juangarcia25@gmail.com"});
        _reception.DisplayStandardDetails();
        _reception.DisplayFullDetails();
        _reception.DisplayShortDetails();
        Console.WriteLine("");

        Address _address3 = new Address("18 Howe Ave, Passaic, NJ 07055");
        Gathering _gathering = new Gathering("Light Rain", "Return Missionary Reunion", "Return Missionary Reunion for all Missionaries that served in Passaic from 2019 to 2021", "7/27/2025", "5:00pm", _address3, "Gathering");
        _gathering.DisplayStandardDetails();
        _gathering.DisplayFullDetails();
        _gathering.DisplayShortDetails();
        Console.WriteLine("");
    }
}