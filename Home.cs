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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Home";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewMovieReport NewMovie = new NewMovieReport();
            this.Hide();
            NewMovie.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movies movieForm= new Movies();
            this.Hide();
            movieForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 tvForm = new Form1();
            this.Hide();
            tvForm.ShowDialog();
        }
    }
}
