using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* List<InventoryItemModel> inventory = new List<InventoryItemModel>();

            inventory.Add(new VehicleModel { DealerFee = 25, ProductName = "Kia Optima" });

            inventory.Add(new BookModel { ProductName = "A Tale of Two Cities", NumberOfPages = 350 });
            */

            List<IRental> rentals = new List<IRental>();
            List<IPurchase> purchases = new List<IPurchase>();

            var vehicle = new VehicleModel {DealerFee = 25, ProductName = "Kia Optima" };
            var book = new BookModel { ProductName = "A Tale of Two Cities", NumberOfPages = 350 };
            var excavator = new Excavator { ProductName = "Bulldozer", QuantityInStock = 2 };

            rentals.Add(vehicle);
            rentals.Add(excavator);

            purchases.Add(book);
            purchases.Add(vehicle);

            Console.Write("Do you want to rent or purchase something (rent/purchase): ");
            string rentalDecision = Console.ReadLine();

            if (rentalDecision.ToLower() == "rent")
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

// PROP TIP: Just because you can doesn't mean you should. Know why you are doing something before doing it.
// HOMEWORK: Build a similar project to what we did here but change it just a bit so you are sure you understand it.