using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTracker
{
    class CustomerModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public AddressModel CustomerAddress { get; set; } = new AddressModel();

        public CustomerModel()
        {

        }

        public override string ToString()
        {
            string output = $"\t{ Phone }\n\t{ Email }\n\t{CustomerAddress.StreetAddress }, { CustomerAddress.City }, " +
                $"{ CustomerAddress.State } { CustomerAddress.ZipCode }";
            return output;
        }
    }

    

}
