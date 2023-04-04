using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---------------------------------------------------------");
        Address address1 = new Address(" ");
        Reception reception1 = new Reception(" ", " "," ", " ", address1, " ");
        reception1.AddEmails(new string[] { " ", " ", " " });
        reception1.DisplayShortDeets();
        reception1.DisplayStandardDeets();
        reception1.DisplayFullDeets();
        Console.WriteLine("---------------------------------------------------------");

        Address address2 = new Address(" ");
        Lecture lecture1 = new Lecture(" ", ," ", " "," ", " ", address2, " ");
        lecture1.DisplayShortDeets();
        lecture1.DisplayStandardDeets();
        lecture1.DisplayFullDeets();
        Console.WriteLine("---------------------------------------------------------");

        Address address3 = new Address(" ");
        Gathering gathering1 = new Gathering(" ", " ", " "," ", " ", address3, " ");
        gathering1.DisplayShortDeets();
        gathering1.DisplayStandardDeets();
        gathering1.DisplayFullDeets();
        Console.WriteLine("---------------------------------------------------------");
    }
}