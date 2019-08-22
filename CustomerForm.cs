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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            dataGridViewCustomer.DataSource = HotelRepository.customers;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddCustomer frm = new AddCustomer();
            frm.ShowDialog();

            dataGridViewCustomer.DataSource = null;
            dataGridViewCustomer.DataSource = HotelRepository.customers;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomer.SelectedRows.Count==0)
            {
                MessageBox.Show("Silenecek satırı seçein!");
                return;
            }

            Customer c = (Customer)dataGridViewCustomer.SelectedRows[0].DataBoundItem;
            HotelRepository.customers.Remove(c);

            dataGridViewCustomer.DataSource = null;
            dataGridViewCustomer.DataSource = HotelRepository.customers;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomer.SelectedRows.Count==0)
            {
                MessageBox.Show("Editlenecek satırı seçin!");
                return;
            }
            Customer c = (Customer)dataGridViewCustomer.SelectedRows[0].DataBoundItem;
            AddCustomer frm = new AddCustomer(c);
            frm.ShowDialog();

            dataGridViewCustomer.DataSource = null;
            dataGridViewCustomer.DataSource = HotelRepository.customers;
        }
    }
}
