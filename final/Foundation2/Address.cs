using System;

class Address
{
    string _address = "";
    private bool _inUSA;

    public Address()
    {

    }

    public Address(string address, bool inUSA)
    {
        _address = address;
        _inUSA = inUSA;
    }

    public string GetAddress()
    {
        return _address;
    }

    public void SetAddress()
    {
        Console.WriteLine("Please provide the address" );
        string userResp = Console.ReadLine();
        _address = userResp;
    }

    public void SetUSA(bool inUSA)
    {
        _inUSA = inUSA;
    }

    public bool GetUSA()
    {
        return _inUSA;

    }
}