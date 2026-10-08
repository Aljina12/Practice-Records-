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