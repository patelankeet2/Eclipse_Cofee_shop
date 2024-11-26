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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show(this);
            this.Hide();
        }

        private void card_Click(object sender, EventArgs e)
        {
            cart cart = new cart();
            cart.Show(this);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flatWhite fw = new flatWhite();
            fw.Show(this);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cappuccino cap = new cappuccino();
            cap.Show(this);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mochacino mocha = new Mochacino();
            mocha.Show(this);
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Latte latte = new Latte();
            latte.Show(this);
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hotChoc hc = new hotChoc();
            hc.Show(this);
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chaiLatte cl = new chaiLatte();
            cl.Show(this);
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            matchaLatte matcha = new matchaLatte();
            matcha.Show(this);
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            longBlack longBlack = new longBlack();
            longBlack.Show(this);
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            fluppy fluppy = new fluppy();
            fluppy.Show();
            this.Hide();
        }

        private void viewCard_Click(object sender, EventArgs e)
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
    }
}
