using System;

class Program
{
    static void Main(string[] args)
    {
        Item item1 = new Item("123", "Grapes", 2, 3);
        Item item2 = new Item("321", "Bananas", 7, 4);
        Address address1 = new Address("1234 Main Street Columbus, OH USA 654321", true);
        address1.setUSA(true);
        Customer customer1 = new Customer("Bob Smith");
        customer1.setAddress(address1);
        Order order1 = new Order();
        order1.addItem(item1);
        order1.addItem(item2);
        order1.setCustomer(customer1);
        Console.WriteLine("");
        Console.WriteLine("/////////////////////////////////////////////////////////////////////////");
        order1.displayPackingSlip();
        order1.calculateCost();
        Console.WriteLine("");
        order1.displayShippingLabel();
        Console.WriteLine("/////////////////////////////////////////////////////////////////////////");
        Console.WriteLine("");



        Item item3 = new Item("483974", "Milk", 4, 5);
        Item item4 = new Item("321", "Bread", 2, 4);
        Address address2 = new Address("1234 Candido Pujato Santa Fe, Santa Fe Argentina 123456", false);
        address2.setUSA(false);
        Customer customer2 = new Customer("Jane Smith");
        customer2.setAddress(address2);
        Order order2 = new Order();
        order2.addItem(item3);
        order2.addItem(item4);
        order2.setCustomer(customer2);
        order2.displayPackingSlip();
        order2.calculateCost();
        Console.WriteLine("");
        order2.displayShippingLabel();
    }
}