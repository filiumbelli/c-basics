namespace ExampleConstructor
{
    public class Order
    {
        public double Price { get; set; }
        public string Name { get; set; }

        public Order(double price, string name)
        {
            Price = price;
            Name = name;
        }

        public Order()
        {
            
        }

    }
}