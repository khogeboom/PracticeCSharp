using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInterfaceProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IRent> rentals = new List<IRent>();
            List<IPurchase> purchases = new List<IPurchase>();

            var car = new CarModel { ProductName = "Audi E-tron", QuantityInStock = 2 };
            var truck = new TruckModel { ProductName = "Ford Raptor", QuantityInStock = 2 };
            var house = new HouseModel { ProductName = "Country Club Neighborhood", QuantityInStock = 4 };
            var apartment = new ApartmentModel { ProductName = "Billionaires Row", QuantityInStock = 3 };

            rentals.Add(car);
            rentals.Add(truck);
            rentals.Add(apartment);

            purchases.Add(car);
            purchases.Add(truck);
            purchases.Add(house);

            Console.Write("Do you want to rent or purchase (rent/purchase): ");
            string decision = Console.ReadLine();

            if (decision.ToLower() == "rent")
            {
                foreach (var item in rentals)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to rent this item (yes/no): ");
                    string wantToRent = Console.ReadLine();

                    if (wantToRent.ToLower() == "yes")
                    {
                        item.Rent();

                        Console.Write("Do you want to return this item (yes/no): ");
                        string wantToReturn = Console.ReadLine();
                        if (wantToReturn.ToLower() == "yes")
                        {
                            item.ReturnRental();
                        }
                    }
                }
            }
            else
            {
                foreach (var item in purchases)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to purchase this item (yes/no): ");
                    string wantToPurchase = Console.ReadLine();

                    if (wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
