using System.Diagnostics.Metrics;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AddressBookApplication
{
    public partial class Form1 : Form
    {
        private List<Person> addressBook = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(phone))
            {
                Person newPerson = new Person
                {
                    Name = name,
                    Email = email,
                    PhoneNumber = phone
                };

                addressBook.Add(newPerson);
                ClearTextBoxes();
                UpdateContactList();
                MessageBox.Show("Contact saved successfully!");
            }
            else
            {
                MessageBox.Show("Please fill in all the fields.");
            }
        }

        private void ClearTextBoxes()
        {
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }

        private void UpdateContactList()
        {
            listContacts.Items.Clear();
            foreach (var person in addressBook)
            {
                listContacts.Items.Add($"{person.Name} - {person.Email} - {person.PhoneNumber}");
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}

