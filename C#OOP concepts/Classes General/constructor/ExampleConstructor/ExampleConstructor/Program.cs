
using System;

namespace ExampleConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order(250, "Branda");
            Order order2 = new Order(100, "Dolap");
            Order order3 = new Order {Name="Lamp",Price=50};
            var customer = new Customer("Ahmed", 25);
            customer.AddOrder(order1);
            customer.AddOrder(order2);
            customer.AddOrder(order3);
            Console.WriteLine("Person: {0},{1}",customer.Name,customer.Age);
            Console.WriteLine("Total cost: " + customer.GetTotalCost());

        }
    } 
}
