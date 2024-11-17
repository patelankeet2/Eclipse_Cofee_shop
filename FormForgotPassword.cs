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
    public partial class FormForgotPassword : Form
    {
        dbCustomer customer = new dbCustomer();
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void FormForgotPassword_Load(object sender, EventArgs e)
        {
            textBoxForgotUsername.Text = "";
            textBoxNewPassword.Text = "";
        }

        private void buttonResetPassword_Click(object sender, EventArgs e)
        {
            string username = textBoxForgotUsername.Text.Trim();
            string newPassword = textBoxNewPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please fill in both fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the user exists
            if (customer.Read(username))
            {
                // Update the password in the database
                customer.data.CustomerPassword = newPassword;

                if (customer.Update(username))
                {
                    MessageBox.Show("Password reset successfully.", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Redirect to the login form
                    Form1 loginForm = new Form1();
                    loginForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to reset password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username not found. Please check your information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }
    }
}
