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
    public partial class Form1 : Form
    {
        dbCustomer customer = new dbCustomer();


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string customerID = textBoxUsername.Text.Trim();
            Boolean signedIn = false;

            if (customerID != "")
            {
                if (customer.Read(customerID))
                {
                    if (textBoxPassword.Text.Trim() == customer.data.CustomerPassword)
                    {
                        signedIn = true;
                    }
                }
            }

            if (signedIn)
            {
                MessageBox.Show("Signed in. Press Enter to continue.", "Sign In");
                
                Form3 Dashboard = new Form3();
                Dashboard.Show();
                this.Hide();

               

            }
            else
            {
                MessageBox.Show("Not signed in. Please reenter your information correctly", "Sign In");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form2 RegisterPage = new Form2();
            RegisterPage.Show();
            this.Hide();
        }
    }
}
