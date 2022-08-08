using System;

namespace InheritanceInterfaceProject
{
    public class HouseModel : InventoryItemModel, IPurchase
    {
        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This house has been purchased");
        }
    }
}
