namespace InheritanceInterfaceProject
{
    public interface IRent : IInventoryItem
    {
        void Rent();
        void ReturnRental();
    }
}
