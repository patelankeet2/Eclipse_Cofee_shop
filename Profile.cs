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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void profile1_Click(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show(this);
            this.Hide();
        }

        private void card_Click(object sender, EventArgs e)
        {
            cart cart = new cart();
            cart.Show(this);
            this.Hide();
        }

        private void viewCard_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show(this);
            this.Hide();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form1 LoginPage = new Form1();
            LoginPage.Show();
            this.Hide();
        }
    }
}
