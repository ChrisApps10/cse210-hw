using System;

class Item
{
    private string _itemID = "";
    private string _itemName = "";
    private int _itemPrice = 0;
    private int _totalPrice = 0;
    private int _quantity = 0;

    public Item()
    {

    }

    public Item(string ID, string itemName, int itemPrice, int quantity)
    {
        _itemID = ID;
        _itemName = itemName;
        _quantity = quantity;
        _itemPrice = itemPrice;
        _totalPrice = itemPrice * quantity;
    }

    public void DisplayItem()
    {
        Console.WriteLine($"Item: {_itemName}");
        Console.WriteLine($"Item Price: ${_itemPrice}");
        Console.WriteLine($"Quantity: {_quantity}");
        Console.WriteLine($"Subtotal: ${_totalPrice}");
        
    }

    public int GetTotalPrice()
    {
        return _totalPrice;
    }

}