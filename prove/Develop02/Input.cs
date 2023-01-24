using System;
public class Read
{
    public static void fileRead()
    {
        string[] lines = File.ReadAllLines("Journal.txt");
        foreach (string line in lines)  
        Console.WriteLine(line);   
    }
}