namespace InheritanceMiniProject
{
    public interface IRental : IInventoryItem
    {
        void Rent();
        void ReturnRental();
    }
}
