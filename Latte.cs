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
                return;
            }
            total = price * quantity;

            dbItem db = new dbItem();
            db.data.Item = item;
            db.data.Quantity = Convert.ToInt32(quantity.ToString());
            db.data.Price = Convert.ToDouble(price.ToString());
            db.data.Total = Convert.ToDouble(total.ToString());

            string recordID = "4"; // Unique record ID for Latte
            if (db.Update(recordID))
            {
                MessageBox.Show("Order saved successfully!");
            }
            else
            {
                MessageBox.Show($"Failed to save the order. Error: {db.LastError}");
            }

            menu menu = new menu();
            menu.Show(this);
            this.Hide();
        }
    }
}
