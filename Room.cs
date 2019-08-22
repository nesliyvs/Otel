using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelTakip_Me
{
    public class Room:BaseClass
    {
        public Room(string rn,int c, int f, Personel resp,decimal p )
        {
           
            RoomNo = rn;
            Capacity = c;
            Floor = f;
            Responsible = resp;
            Price = p;
        }
        public string RoomNo { get; set; }
        public int Capacity { get; set; }
        public int Floor { get; set; }
        public Personel Responsible { get; set; }

        public string ResponsibleName
        {
            get
            {
                return Responsible.Name + " " + Responsible.Surname;
            }
        }
        public decimal Price { get; set; }
    }
}
