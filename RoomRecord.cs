using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelTakip_Me
{
    public class RoomRecord:BaseClass
    {
        public Customer customer { get; set; }
        public Room room { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string CustomerName
        {
            get
            {
                return customer.Name + " " + customer.Surname;
            }

        }
        public string RoomName
        {
            get
            {
                return string.Format("Floor:{0} Room num:{1}", room.Floor, room.RoomNo);
            }

        }
        public int DayCount
        {
            get
            {
                return EndDate.Day - StartDate.Day;
            }
        }


    }
}
