using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelTakip_Me
{
    public class HotelRepository
    {
        public static List<Personel> personels;
        public static List<Customer> customers;
        public static List<Room> rooms;
        public static List<RoomRecord> roomRecords;

        public static void Populate()
        {
            personels = new List<Personel>();
            customers = new List<Customer>();
            rooms = new List<Room>();
            roomRecords = new List<RoomRecord>();


            Personel p1 = new Personel("Ali", "Demir");
            personels.Add(p1);

            Personel p2 = new Personel("Ahmet", "Yılmaz");
            personels.Add(p2);

            Room r1 = new Room("oda1",1,1,p1,200);
            rooms.Add(r1);

            Room r2 = new Room("oda2", 2, 2, p1, 200);
            rooms.Add(r2);

            Room r3 = new Room("oda4", 2, 1, p2, 200);
            rooms.Add(r3);

            Room r4 = new Room("oda5", 3, 2, p2, 300);
            rooms.Add(r4);

            Room r5 = new Room("oda6", 4, 2, p2, 350);
            rooms.Add(r5);

            Room r6 = new Room("oda7", 2, 2, p2, 200);
            rooms.Add(r6);

            Room r7 = new Room("oda8", 2, 2, p2, 200);
            rooms.Add(r7);

            Customer c = new Customer("Büşra", "Kömürcü", "123456789");
            customers.Add(c);

        }
    }

   
}
