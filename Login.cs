using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rcmndr
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int verify = 0;
            if (unamein.Text == string.Empty)
            {
                MessageBox.Show("Please enter your username!");
                return;
            }
            if (pwdin.Text == string.Empty)
            {
                MessageBox.Show("Please enter your Password!");
                return;
            }

            if (unamein.Text == "tushar")
            {
                verify = verify + 1;
            }
            if (pwdin.Text == "tushar")
            {
                verify = verify + 1;
            }

            if (verify == 2)
            {
                MessageBox.Show("Logged in");
                return;
            }

            else
            {
                MessageBox.Show("Invalid Username or Password");
                return;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://help.netflix.com/");
        }
    }
}
