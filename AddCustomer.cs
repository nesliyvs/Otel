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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            id= - 1;
            InitializeComponent();
        }
        public AddCustomer(Customer customer)
        {
            id = customer.Id;
            InitializeComponent();
            txtCusName.Text = customer.Name;
            txtCusSurname.Text = customer.Surname;
            txtCusPhone.Text = customer.Phone;

        }
        private int id;

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (id==-1)
            {
                Customer c = new Customer(txtCusName.Text, txtCusSurname.Text, txtCusPhone.Text);
                HotelRepository.customers.Add(c);
            }

            else
            {
                Customer cst = HotelRepository.customers.Where(c => c.Id == id).FirstOrDefault();
                cst.Name = txtCusName.Text;
                cst.Surname = txtCusSurname.Text;
                cst.Phone = txtCusPhone.Text;
            }
            Close();
        }
    }
}
