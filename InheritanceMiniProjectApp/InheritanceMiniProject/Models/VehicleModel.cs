using System;

namespace InheritanceMiniProject
{
    public class VehicleModel : InventoryItemModel, IPurchase, IRental
    {
        public decimal DealerFee { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This vehicle has been purchased");
        }

        public void Rent ()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This vehicle has been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("The vehicle has been returned");
        }
    }
}
