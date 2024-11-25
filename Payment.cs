﻿using System;
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
    public partial class Payment : Form
    {
        public Payment()
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


        private void buttonSubmitPayment_Click(object sender, EventArgs e)
        {

        }
    }
}
