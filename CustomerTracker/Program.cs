using System;
using System.Collections.Generic;
using System.IO;

namespace CustomerTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            do
            {
                input = MainMenu();

                if (input == 1)
                {
                    Console.Clear();
                    DisplayCustomers();
                }
                else if (input == 2)
                {
                    Console.Clear();
                    AddCustomer();
                }
                else if (input == 3)
                {
                    Console.Clear();
                    ReturningCustomer();
                }
                else if (input == 4)
                {
                    Console.Clear();
                    RemoveCustomer();
                }
                else if (input == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again...");
                    Console.ReadLine();
                }

                Console.Clear();

            } while (input != 5);

            Console.Write("Press any key to exit.");
            Console.ReadLine();
        }

        private static int MainMenu()
        {
            Console.WriteLine("Welcome to the Customer Tracker App");
            Console.WriteLine("***********************************");
            Console.WriteLine("\t1. Display Customer Names");
            Console.WriteLine("\t2. New Customer");
            Console.WriteLine("\t3. Returning Customer");
            Console.WriteLine("\t4. Remove Customer");
            Console.WriteLine("\t5. Exit App");
            Console.Write("Type number of desired option: ");
            string inputText = Console.ReadLine();
            bool success = int.TryParse(inputText, out int input);

            if (success)
            {
                return input;
            }
            else
            {
                return -1;
            }
        }

        private static void DisplayCustomers()
        {
            if (!File.Exists("CustomerTracker.txt") || string.IsNullOrWhiteSpace(File.ReadAllText("CustomerTracker.txt")))
            {
                Console.WriteLine("Customer Directory is currently empty.");
            }
            else if (File.Exists("CustomerTracker.txt"))
            {
                Console.WriteLine(File.ReadAllText("CustomerTracker.txt"));
            }

            GoBackToMain();
        }

        private static void AddCustomer()
        {
            List<string> customerInfo = new List<string>();
            //var customerInfo = new List<string>();
            //List<string> customerInfo = new();

            if (File.Exists("CustomerTracker.txt"))
            {
                customerInfo = new List<string>(File.ReadAllLines("CustomerTracker.txt"));
            }

            CustomerModel newCustomer = new CustomerModel();

            GetCustomerInfo(newCustomer);
            customerInfo.Add($"{ newCustomer.Name }\n{ newCustomer }\n");
            File.WriteAllLines("CustomerTracker.txt", customerInfo);

            Console.WriteLine();
            Console.WriteLine($"Welcome, { newCustomer.Name }!");
            Console.WriteLine("Here is your information:");
            Console.WriteLine($"{ newCustomer.ToString() }");

            GoBackToMain();
        }

        private static void GetCustomerInfo(CustomerModel newCustomer)
        {
            Console.Write("Enter your name: ");
            newCustomer.Name = Console.ReadLine();

            Console.Write("Enter your phone number: ");
            newCustomer.Phone = Console.ReadLine();

            Console.Write("Enter your email: ");
            newCustomer.Email = Console.ReadLine();

            Console.Write("Enter your street address: ");
            newCustomer.CustomerAddress.StreetAddress = Console.ReadLine();

            Console.Write("Enter your city: ");
            newCustomer.CustomerAddress.City = Console.ReadLine();

            Console.Write("Enter your state: ");
            newCustomer.CustomerAddress.State = Console.ReadLine();

            Console.Write("Enter your zip code: ");
            newCustomer.CustomerAddress.ZipCode = Console.ReadLine();

        }

        private static void ReturningCustomer()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            bool isCustomer = false;

            List<string> customerInfo = new List<string>(File.ReadAllLines("CustomerTracker.txt"));

            CheckCustomer(customerInfo, isCustomer, name);

            GoBackToMain();
        }

        private static void CheckCustomer(List<string> customerInfo, bool isCustomer, string name)
        {
            int i = 0;
            string[] output = customerInfo.ToArray();
            foreach (var customer in customerInfo)
            {
                if (customer.ToLower().StartsWith(name.ToLower()))
                {
                    Console.WriteLine($"Welcome back, { customer }");
                    //code to display rest of customer info
                    for (int j = i + 1; j < i + 4; j++)
                    {
                        Console.WriteLine(output[j]);
                    }
                    isCustomer = true;
                    break;
                }
                i++;
            }

            // for loop with counter built-in
            //for (int k = 0; k < customerInfo.Count; k++)
            //{
            //    if (customerInfo[k].ToLower().StartsWith(name.ToLower()))
            //    {
            //        Console.WriteLine($"Welcome back, { customerInfo[k] }");
            //        //code to display rest of customer info
            //        for (int j = k + 1; j < k + 4; j++)
            //        {
            //            Console.WriteLine(output[j]);
            //        }
            //        isCustomer = true;
            //        break;
            //    }
            //}

            if (isCustomer == false)
            {
                Console.WriteLine("No such customer exists.");
            }
        }


        private static void RemoveCustomer()
        {
            Console.Write("What is the name of the customer you would like to remove: ");
            string name = Console.ReadLine();

            List<string> customerInfo = new List<string>(File.ReadAllLines("CustomerTracker.txt"));
            bool isValidName = false;

            int i = 0;
            string[] output = customerInfo.ToArray();
            foreach (var customer in customerInfo)
            {
                if (customer.ToLower().Contains(name.ToLower()))
                {
                    Console.WriteLine($"{ customer } was removed from the customer directory.");
                    isValidName = true;

                    //code to remove rest of customer information
                    for (int j = i + 4; j >= i; j--)
                    {
                        customerInfo.Remove(output[j]);
                    }

                    break;
                }
                i++;
            }

            if (isValidName == false)
            {
                Console.WriteLine("No such customer exists.");
            }

            File.WriteAllLines("CustomerTracker.txt", customerInfo);
            GoBackToMain();
        }

        private static void GoBackToMain()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
