using System;

class Item
{
    private string _productID = "";
    private string _productName = "";
    private int _productPrice = 0;
    private int _totalPrice = 0;
    private int _quantity = 0;

    public Item()
    {

    }

    public Item(string ID, string productName, int productPrice, int quantity)
    {
        _productID = ID;
        _productName = productName;
        _quantity = quantity;
        _productPrice = productPrice;
        _totalPrice = productPrice * quantity;
    }

    public void DisplayItem()
    {
        Console.WriteLine($"Item: {_productName}");
        Console.WriteLine($"Item Price: ${_productPrice}");
        Console.WriteLine($"Quantity: {_quantity}");
        Console.WriteLine($"Subtotal: ${_totalPrice}");
        
    }

    public int GetTotalPrice()
    {
        return _totalPrice;
    }

}