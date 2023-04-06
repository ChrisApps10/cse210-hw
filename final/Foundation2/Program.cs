using System;

class Program
{
    static void Main(string[] args)
    {
        Item _item1 = new Item("1", "Salad", 3, 5);
        Item _item2 = new Item("1", "Hershey Chocolate Bar", 2, 1);

        Address _usaAddress = new Address("3828 Piermont Dr, Albuquerque, NM 87111", true);
        _usaAddress.SetUSA(true);
        Customer _customer1 = new Customer("Steve Gomez");
        _customer1.SetAddress(_usaAddress);
        Order _order1 = new Order();
        _order1.AddItem(_item1);
        _order1.AddItem(_item2);
        _order1.SetCustomer(_customer1);
        Console.WriteLine("");
        Console.WriteLine("-------------------------------------------------------------------------");
        _order1.DisplayPackingSlip();
        _order1.CalculateCost();
        Console.WriteLine("");
        Console.WriteLine("");
        _order1.DisplayShippingLabel();
        Console.WriteLine("-------------------------------------------------------------------------");
        Console.WriteLine("");
        
        Item _item3 = new Item("7099", "Avocado", 3, 10);
        Item _item4 = new Item("3095", "Chips", 1, 2);
        Address _foreignAddress = new Address("Av. Larco 1301, Miraflores 15074, Lima, Peru", false);
        _foreignAddress.SetUSA(false);
        Customer _customer2 = new Customer("Maria Galvez Lora");
        _customer2.SetAddress(_foreignAddress);
        Console.WriteLine("");
        Order _order2 = new Order();
        _order2.AddItem(_item3);
        _order2.AddItem(_item4);
        _order2.SetCustomer(_customer2);
        _order2.DisplayPackingSlip();
        _order2.CalculateCost();
        Console.WriteLine("");
        _order2.DisplayShippingLabel();
    }
}