namespace AbstractClassHomework
{
    public interface IInventoryItem
    {
        string ProductName { get; set; }
        int QuantityInStock { get; set; }
        double Price { get; set; }
    }
}
