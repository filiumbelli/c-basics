using System.Collections.Generic;

namespace ExampleConstructor
{
    public class Customer
    {
        public string Name;
        public int Age;
        public static int Id = -1;
        public List<Order> Orders = new List<Order>();

        public double GetTotalCost()
        {
            double totalCost = 0;
            foreach (var order in Orders)
            {
                totalCost += order.Price;
            }

            return totalCost;
        }
        public Customer(string name, int age)
        {
            Id = ++Id;
            Name = name;
            Age = age;
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public void RemoveOrder(Order order)
        {
            Orders.Remove(order);
        }

    }
}