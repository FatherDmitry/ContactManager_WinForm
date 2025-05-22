using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class Form1 : Form
    {
        private List<Contact> contacts = new List<Contact>();
        private int selectedIndex = -1;

        public Form1()
        {
            InitializeComponent();
            UpdateGrid();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPersonalPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInternalPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Contact c = new Contact
            {
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                MiddleName = txtMiddleName.Text,
                Company = txtCompany.Text,
                Email = txtInternalPhone.Text,
                Position = txtPosition.Text,
                PersonalPhone = txtPersonalPhone.Text,
                InternalPhone = txtInternalPhone.Text
            };

            contacts.Add(c);
            ClearInputs();
            UpdateGrid();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
