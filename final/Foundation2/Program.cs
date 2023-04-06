using System;

class Program
{
    static void Main(string[] args)
    {
        Item item1 = new Item("1", "Salad", 3, 5);
        Item item2 = new Item("1", "Hershey Chocolate Bar", 2, 1);

        Address address1 = new Address("3828 Piermont Dr, NM 87111, USA", true);
        address1.SetUSA(true);

        Customer customer1 = new Customer("Steve Gomez");
        customer1.SetAddress(address1);

        Order order1 = new Order();
        order1.AddItem(item1);
        order1.AddItem(item2);
        order1.SetCustomer(customer1);

        Console.WriteLine("");
        Console.WriteLine("-------------------------------------------------------------------------");

        order1.DisplayPackingSlip();
        order1.CalculateCost();

        Console.WriteLine("");
        Console.WriteLine("");
        order1.DisplayShippingLabel();
        Console.WriteLine("-------------------------------------------------------------------------");
        Console.WriteLine("");
        
        Item item3 = new Item("483974", "Milk", 4, 5);
        Item item4 = new Item("321", "Bread", 2, 4);
        Address address2 = new Address("1234 Candido Pujato Santa Fe, Santa Fe Argentina 123456", false);
        address2.SetUSA(false);
        Customer customer2 = new Customer(" ");
        customer2.SetAddress(address2);
        Console.WriteLine("");
        Order order2 = new Order();
        order2.AddItem(item3);
        order2.AddItem(item4);
        order2.SetCustomer(customer2);
        order2.DisplayPackingSlip();
        order2.CalculateCost();
        Console.WriteLine("");
        order2.DisplayShippingLabel();
    }
}