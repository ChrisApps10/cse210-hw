using System;

class Address
{
    string _address = "";
    private bool _isUSA;

    public Address()
    {

    }

    public Address(string address, bool isUSA)
    {
        _address = address;
        _isUSA = isUSA;
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

    public void SetUSA(bool isUSA)
    {
        _isUSA = isUSA;
    }

    public bool GetUSA()
    {
        return _isUSA;

    }
}