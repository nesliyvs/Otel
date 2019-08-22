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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void BtnPer_Click(object sender, EventArgs e)
        {
            PersonelForm frm = new PersonelForm();
            frm.Show();
        }

        private void BtnCus_Click(object sender, EventArgs e)
        {
            CustomerForm frm = new CustomerForm();
            frm.Show();
        }

        private void BtnRoom_Click(object sender, EventArgs e)
        {
            RoomForm frm = new RoomForm();
            frm.Show();
        }

        private void BtnRoomRecord_Click(object sender, EventArgs e)
        {
            RoomRecordsForm frm = new RoomRecordsForm();
            frm.Show();
        }
    }
}
