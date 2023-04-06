using System;

class Order
{

    private List<Item> _items = new List<Item>();
    private Customer Customer;
    private int _shippingCost = 0;
    private int _totalCost = 0;
    private int _subtotal = 0;

    public Order()
    {

    }

    public void CalculateCost()
    {
        foreach (Item item in _items)
        {
            _subtotal = _subtotal + item.GetTotalPrice();
        }
        _totalCost = _subtotal;
        Console.WriteLine($"Cost without shipping: ${_totalCost}");
        CalculateShipping();
        _totalCost = _totalCost + _shippingCost;
        Console.WriteLine($"Shipping charge: ${_shippingCost}");
        Console.WriteLine($"Total Cost: ${_totalCost}");
        
    }


    public void CalculateShipping() 
    {
        if (Customer.GetUSA() == true)
        {
            _shippingCost = 5;
        }
        else {
            _shippingCost = 35;
        }
        
    }


    public void SetCustomer(Customer customer)
    {
        Customer = customer;
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label");
        Console.WriteLine($"Shipping Address: {Customer.GetAddress()}");
    }

    public void DisplayPackingSlip()
    {
        Console.WriteLine($"Customer Name: {Customer.GetCustomerName()}");
        Console.WriteLine("Packing Label");
        Console.WriteLine("");
        foreach (Item item in _items)
        {
            item.DisplayItem();
            Console.WriteLine("");
        }
    }

    public void AddItem(Item item)
    {
        _items.Add(item);
    }
}