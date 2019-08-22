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
    public partial class AddPersonel : Form
    {
        public AddPersonel()
        {
            id = -1;
            InitializeComponent();
        }

        public AddPersonel(Personel personel)
        {
            id = personel.Id;
            InitializeComponent();
            txtPerName.Text = personel.Name;
            txtPerSurname.Text = personel.Surname;
        }

        private int id;

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (id==-1)
            {
                Personel p = new Personel(txtPerName.Text, txtPerSurname.Text);
                HotelRepository.personels.Add(p);                    
            }
            else
            {
                Personel p = HotelRepository.personels.Where(c => c.Id == id).FirstOrDefault();
                p.Name = txtPerName.Text;
                p.Surname = txtPerSurname.Text;
            }
            Close();
        }
    }
}
