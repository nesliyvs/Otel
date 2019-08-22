using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelTakip_Me
{
    public class Personel:BaseClass
    {
        public Personel(string n,string sn)
        {         
            Name = n;
            Surname = sn;
        }
       
        public string PersonelInfo
        {
            get
            {
                return string.Format("({0}) {1} {2}", Id, Name, Surname);
            }
        }

    }
}

