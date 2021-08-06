using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06._22
{
    class PersonModel
    {
        public static int InstanceCounter = 0;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public AddressModel HomeAddress { get; set; } = new AddressModel();

        //public AddressModel WorkAddress { get; set; }

        //public List<AddressModel> Addresses { get; set; }

        public PersonModel()
        {
            InstanceCounter += 1;
        }

        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            InstanceCounter += 1;
        }

        public PersonModel(string firstName, string lastName, AddressModel address)
        {
            FirstName = firstName;
            LastName = lastName;
            HomeAddress = address;
            InstanceCounter += 1;
        }

    }
}
