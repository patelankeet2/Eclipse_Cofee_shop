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
    public partial class cart : Form
    {
        public cart()
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

        private void button2_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show(this);
            this.Hide();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form1 LoginPage = new Form1();
            LoginPage.Show();
            this.Hide();
        }

        private void LoadCartData()
        {
            try
            {
                dbItem db = new dbItem();
                string[] itemIds = { "1", "2", "3", "4" }; 

                dataGridView1.Rows.Clear();
                double totalPurchaseAmount = 0;

                foreach (var itemId in itemIds)
                {
                    if (db.ReadItem(itemId))
                    {
                        double itemTotal = db.data.Total;
                        totalPurchaseAmount += itemTotal;

                        dataGridView1.Rows.Add(
                            db.data.Item,
                            db.data.Quantity,
                            db.data.Price.ToString("C"),
                            db.data.Total.ToString("C"),
                            "Edit",
                            "Delete"
                        );
                    }
                }
                TotalPurchase.Text = $"Total Purchase: {totalPurchaseAmount:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the cart: {ex.Message}");
            }
        }

        private void cart_Load(object sender, EventArgs e)
        {
            LoadCartData();
        }

        private void TotalPurchase_Click(object sender, EventArgs e)
        {
            double totalPurchaseAmount = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Total"]?.Value != null)
                {
                    double itemTotal;
                    if (double.TryParse(row.Cells["Total"].Value.ToString(), out itemTotal))
                    {
                        totalPurchaseAmount += itemTotal;
                    }
                }
            }

            TotalPurchase.Text = $"Total Purchase: {totalPurchaseAmount:C}";
        }
    }
}
