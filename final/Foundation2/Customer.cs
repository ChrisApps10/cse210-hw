using System;

class Customer
{
    private string _customerName = "";
    Address _customerAddress;
    
    

    public Customer()
    {

    }

    public Customer(string customerName)
    {
        _customerName = customerName;

    }

    public void SetAddress(Address address)
    {
        _customerAddress = address;
    }


    public string GetAddress()
    {
        return _customerAddress.GetAddress();
    }
    
    public string GetCustName()
    {
        return _customerName;
    }

    public bool GetUSA()
    {
        return _customerAddress.GetUSA();
    }

    
}