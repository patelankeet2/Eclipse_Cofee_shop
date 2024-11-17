using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eclipse_Cofee_shop
{
    public partial class Latte : Form
    {
        string item;
        int quantity;
        double price;
        double total;
        public Latte()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show(this);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            quantity = int.Parse(numericUpDown1.Value.ToString());
            if (quantity > 0)
            {
                item = "Latte";
            }

            if (radioButton1.Checked)
            {
                price = 5.90;
            }

            else if (radioButton2.Checked)
            {
                price = 5.30;
            }

            else if (radioButton3.Checked)
            {
                price = 4.50;
            }

            else
            {
                MessageBox.Show("please choose cup size to proceed your order");
                quantity = 0;
            }
            total = price * quantity;

            menu menu = new menu();
            menu.Show(this);
            this.Hide();
        }
    }
}
