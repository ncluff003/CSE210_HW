using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer(
            "Robbie Bosco",
            "1234 S University Ave.",
            "Provo",
            "Utah",
            "United States",
            "84601"
        );

        Order order1 = new Order(customer);
        Order order2 = new Order(customer);

        order1.AddProduct("Wheat Bread", 2345, 2.54, 4);
        order1.AddProduct("Pepper Jack Cheese", 345, 3.52);
        order1.AddProduct("Mountain Dew", 234, 8.67, 2);
        order1.AddProduct("Hot Wheels Car", 314, 1.25, 6);

        string packingSlip1 = order1.DisplayPackingSlip();
        string shippingLabel1 = order1.DisplayShippingLabel();

        Console.WriteLine(packingSlip1);
        Console.WriteLine();
        Console.WriteLine(shippingLabel1);

        order2.AddProduct("Wheat Bread", 2345, 2.54, 3);
        order2.AddProduct("Whole Milk", 356, 3.49);
        order2.AddProduct("Cereal", 134, 5.24, 2);
        order2.AddProduct("Pogo Stick", 244, 20.50);

        string packingSlip2 = order2.DisplayPackingSlip();
        string shippingLabel2 = order2.DisplayShippingLabel();

        Console.WriteLine(packingSlip2);
        Console.WriteLine();
        Console.WriteLine(shippingLabel2);
    }
}
