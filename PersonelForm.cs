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
    public partial class PersonelForm : Form
    {
        public PersonelForm()
        {
            InitializeComponent();
            dataGridViewPersonel.DataSource = HotelRepository.personels;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddPersonel frm = new AddPersonel();
            frm.ShowDialog();

            dataGridViewPersonel.DataSource = null;
            dataGridViewPersonel.DataSource = HotelRepository.personels;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPersonel.SelectedRows.Count==0)
            {
                MessageBox.Show("Silinecek satırı seçiniz!");
                return;
            }

            Personel p = (Personel)dataGridViewPersonel.SelectedRows[0].DataBoundItem;
            HotelRepository.personels.Remove(p);

            dataGridViewPersonel.DataSource = null;
            dataGridViewPersonel.DataSource = HotelRepository.personels;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewPersonel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek satırı seçiniz!");
                return;
            }

            Personel p = (Personel)dataGridViewPersonel.SelectedRows[0].DataBoundItem;

            AddPersonel frm = new AddPersonel(p);
            frm.ShowDialog();

            dataGridViewPersonel.DataSource = null;
            dataGridViewPersonel.DataSource = HotelRepository.personels;
        }
    }
}
