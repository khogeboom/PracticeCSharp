using System;

namespace InheritanceInterfaceProject
{
    public class VehicleModel : InventoryItemModel, IPurchase, IRent
    {
        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This vehicle has been purchased");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This vehicle has been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("This vehicle has been returned");
        }

    }
}
