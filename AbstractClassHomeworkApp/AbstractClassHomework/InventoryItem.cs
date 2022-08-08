namespace AbstractClassHomework
{
    public abstract class InventoryItem : IInventoryItem
    {
        public string ProductName { get; set; }
        public int QuantityInStock { get; set; }
        public double Price { get; set; }

    }
}
