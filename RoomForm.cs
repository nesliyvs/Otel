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
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
            dataGridViewRoom.DataSource = HotelRepository.rooms;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddRoom frm = new AddRoom();
            frm.ShowDialog();
            dataGridViewRoom.DataSource = null;
            dataGridViewRoom.DataSource = HotelRepository.rooms;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoom.SelectedRows.Count==0)
            {
                MessageBox.Show("Silenecek satırıseçin!");
                return;
            }

            Room p = (Room)dataGridViewRoom.SelectedRows[0].DataBoundItem;
            HotelRepository.rooms.Remove(p);

            dataGridViewRoom.DataSource = null;
            dataGridViewRoom.DataSource = HotelRepository.rooms;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoom.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silenecek satırıseçin!");
                return;
            }

            Room p = (Room)dataGridViewRoom.SelectedRows[0].DataBoundItem;
            AddRoom frm = new AddRoom(p);
            frm.ShowDialog();
            dataGridViewRoom.DataSource = null;
            dataGridViewRoom.DataSource = HotelRepository.rooms;
        }
    }
}
