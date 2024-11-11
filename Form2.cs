using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eclipse_Cofee_shop
{
    public partial class Form2 : Form
    {


        // Create the database object to handle the reading
        // and updating of customer data.
        dbCustomer customer = new dbCustomer();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxregUsername.Text.Trim();
            string password = textBoxregPassword.Text.Trim();
            // Basic input validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (customer.Read(username))
            {
                MessageBox.Show("Username already exists. Please choose a different one.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Set data fields for new customer
            customer.data.CustomerUsername = username;
            customer.data.CustomerPassword = password;

            // Attempt to save the new customer record
            bool isRegistered = customer.Update(username);

            if (isRegistered)
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Optionally, clear the form fields after successful registration
                textBoxregUsername.Clear();
                textBoxregPassword.Clear();
                Form1 LoginForm = new Form1();
                LoginForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Registration failed. " + customer.LastError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}