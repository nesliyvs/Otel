using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelTakip_Me
{
    public class Customer:BaseClass
    {
        public Customer(string n, string sn, string phoneNumber)
        {
            Name = n;
            Surname = sn;
            Phone = phoneNumber;            
        }

        public string Phone { get; set; }


    }
}
