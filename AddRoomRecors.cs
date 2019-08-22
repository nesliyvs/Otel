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
    public partial class AddRoomRecors : Form
    {
        public AddRoomRecors()
        {
            InitializeComponent();
            comboBoxCustomer.DataSource = HotelRepository.customers;
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;
            List<Room> avaliableRooms = HotelRepository.rooms.ToList();

            foreach (var item in HotelRepository.roomRecords)
            {
                if (item.StartDate < startDate && item.EndDate > startDate)
                    avaliableRooms.Remove(item.room);

                if (item.EndDate > endDate && item.StartDate < endDate)
                    avaliableRooms.Remove(item.room);

                //if (item.StartDate < startDate && item.EndDate > endDate)
                //    avaliableRooms.Remove(item.room);
            }
            dataGridViewAddRoomRecords.DataSource = null;
            dataGridViewAddRoomRecords.DataSource = avaliableRooms;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            RoomRecord rr = new RoomRecord();
            rr.customer = (Customer)comboBoxCustomer.SelectedItem;
            rr.EndDate = dateTimePickerEnd.Value;
            rr.StartDate = dateTimePickerStart.Value;
            rr.room = (Room)dataGridViewAddRoomRecords.SelectedRows[0].DataBoundItem;
            rr.TotalPrice = int.Parse(txtPrice.Text);

            HotelRepository.roomRecords.Add(rr);
            Close();
        }
    }
}
