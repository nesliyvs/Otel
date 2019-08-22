using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelTakip_Me
{
    public class BaseClass
    {
        public static int maxId = 0;
        public BaseClass()
        {

            maxId++;
            Id = maxId;
         
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
    }
}
