using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelTakip_Me
{
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            id = -1;
            InitializeComponent();
            comboBoxResp.DataSource = HotelRepository.personels;
        }
        public AddRoom(Room room)
        {
            id = room.Id;
            InitializeComponent();
            txtRoomNo.Text = room.RoomNo;
            txtCapacity.Text = room.Capacity.ToString();
            txtFloor.Text = room.Floor.ToString();
            comboBoxResp.DataSource = HotelRepository.personels;
            comboBoxResp.SelectedItem = room.Responsible;
        }

        private int id;

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string roomNo = txtRoomNo.Text;
            int capacity = Convert.ToInt32(txtCapacity.Text);
            int floor = Convert.ToInt32(txtFloor.Text);
            Personel resp = (Personel)comboBoxResp.SelectedItem;
            decimal price = Convert.ToDecimal(txtPrice.Text);

            if (id==-1)
            {
                Room r = new Room(roomNo, capacity, floor, resp, price);
                HotelRepository.rooms.Add(r);
            }
            else
            {
                Room r = HotelRepository.rooms.Where(c => c.Id == id).FirstOrDefault();
                r.Floor = floor;
                r.Capacity = capacity;
                r.Price = price;
                r.Responsible = resp;
                r.RoomNo = roomNo;
            }
            Close();
        }
    }
}
