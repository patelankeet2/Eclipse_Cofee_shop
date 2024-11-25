using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eclipse_Cofee_shop
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            SetPlaceholders();
            AddInputRestrictions();
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

        private void logOut_Click(object sender, EventArgs e)
        {
            Form1 LoginPage = new Form1();
            LoginPage.Show();
            this.Hide();
        }

        // Method to set initial placeholders
        private void SetPlaceholders()
        {
            SetPlaceholder(textBoxaccnum, "NNNN-NNNN-NNNN-NNNN");
            SetPlaceholder(textBoxnamecard, "Enter Name on Card");
            SetPlaceholder(textBoxExpDate, "MM/YY");
            SetPlaceholder(textBoxSecCode, "Enter Security Code");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void AddInputRestrictions()
        {
            // Format Account Number as NNNN-NNNN-NNNN-NNNN
            textBoxaccnum.KeyPress += (sender, e) =>
            {
                // Allow only digits and backspace
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                    return;
                }

                if (e.KeyChar == (char)Keys.Back) // Allow backspace
                {
                    return;
                }

                string rawInput = textBoxaccnum.Text.Replace("-", ""); // Remove dashes to count digits

                if (rawInput.Length >= 16) // Limit to 16 digits
                {
                    e.Handled = true;
                    return;
                }

                // Add dashes after every 4 digits
                if (rawInput.Length % 4 == 0 && rawInput.Length > 0)
                {
                    textBoxaccnum.Text += "-";
                    textBoxaccnum.SelectionStart = textBoxaccnum.Text.Length; // Set cursor position
                }
            };

            // Restrict CVC Code to 3 digits
            textBoxSecCode.KeyPress += (sender, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) // Allow digits and backspace
                {
                    e.Handled = true;
                }

                if (textBoxSecCode.Text.Length >= 3 && e.KeyChar != (char)Keys.Back) // Limit to 3 digits
                {
                    e.Handled = true;
                }
            };

            // Validate Expiry Date format as MM/YY
            textBoxExpDate.TextChanged += (sender, e) =>
            {
                if (textBoxExpDate.Text.Length == 5) // Check for "MM/YY" length
                {
                    if (!DateTime.TryParseExact(textBoxExpDate.Text, "MM/yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                    {
                        textBoxExpDate.ForeColor = Color.Red; // Indicate invalid format
                    }
                    else
                    {
                        textBoxExpDate.ForeColor = Color.Black; // Valid format
                    }
                }
                else
                {
                    textBoxExpDate.ForeColor = Color.Gray; // Placeholder or incomplete
                }
            };
        }



        private void buttonSubmitPayment_Click(object sender, EventArgs e)
        {
            // Validate account number format
            string accountNumber = textBoxaccnum.Text.Replace("-", ""); // Remove dashes for validation
            if (accountNumber.Length != 16 || textBoxaccnum.ForeColor == Color.Gray)
            {
                MessageBox.Show("Please enter a valid account number in the format NNNN-NNNN-NNNN-NNNN.");
                return;
            }

            // Validate expiry date format
            if (textBoxExpDate.ForeColor == Color.Red || textBoxExpDate.Text.Length != 5)
            {
                MessageBox.Show("Please enter a valid expiry date in MM/YY format.");
                return;
            }

            // Validate CVC code
            if (textBoxSecCode.Text.Length != 3 || textBoxSecCode.ForeColor == Color.Gray)
            {
                MessageBox.Show("Please enter a valid 3-digit security code.");
                return;
            }

            // Validate name on card
            if (textBoxnamecard.Text == "Enter Name on Card" || string.IsNullOrWhiteSpace(textBoxnamecard.Text))
            {
                MessageBox.Show("Please enter the name on the card.");
                return;
            }

            // If all validations pass
            MessageBox.Show("Payment submitted successfully!");

        }
    }
}
