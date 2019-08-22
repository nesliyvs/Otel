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
    public partial class RoomRecordsForm : Form
    {
        public RoomRecordsForm()
        {
            InitializeComponent();
            dataGridViewRoomRecords.DataSource = HotelRepository.roomRecords;
        }

        private void BtnAddRoomRecord_Click(object sender, EventArgs e)
        {
            AddRoomRecors frm = new AddRoomRecors();
            frm.ShowDialog();
            dataGridViewRoomRecords.DataSource = null;
            dataGridViewRoomRecords.DataSource = HotelRepository.roomRecords;
        }
    }
}
