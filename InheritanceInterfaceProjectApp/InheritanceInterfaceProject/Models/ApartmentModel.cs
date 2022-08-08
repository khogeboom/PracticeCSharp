using System;

namespace InheritanceInterfaceProject
{
    public class ApartmentModel : InventoryItemModel, IRent
    {
        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This apartment has been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("This apartment has been returned");
        }
    }
}
