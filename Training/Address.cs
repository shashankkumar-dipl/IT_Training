using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class Address
    {
        public string addressline, city, state;

        public Address(string addressline, string city, string state)
        {
            this.addressline = addressline;
            this.city = city;
            this.state = state;
        }


    }
}
