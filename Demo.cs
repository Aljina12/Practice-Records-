    class Shop
    {
        public string ItemName = "Notebook";
        public double Price = 120;
        public int Quantity = 3;

        public double GetTotal()
        {
            return Price * Quantity;
        }
    }

        class Task16
    {
        public static void Run()
        {
            Shop shop = new Shop();

            Console.WriteLine("Item: " + shop.ItemName);
            Console.WriteLine("Price: " + shop.Price);
            Console.WriteLine("Quantity: " + shop.Quantity);
            Console.WriteLine("Total: " + shop.GetTotal());
        }
    } 