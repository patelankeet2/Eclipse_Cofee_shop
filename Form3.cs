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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show(this);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
