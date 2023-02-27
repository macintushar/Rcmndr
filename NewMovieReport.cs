using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Rcmndr
{
    public partial class NewMovieReport : Form
    {
        public NewMovieReport()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void uname_Click(object sender, EventArgs e)
        {

        }

        private void unamein_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwd_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("C:/Users/tusha/OneDrive/Documents/Christ University/Semester - IV/Dot Net/movies.pdf", FileMode.Create));
            doc.Open();
            Paragraph p1 = new Paragraph(Movie.Text);
            Paragraph p2 = new Paragraph(Genre.Text);
            Paragraph p3 = new Paragraph(Director.Text);
            doc.Add(p1);
            doc.Add(p2);
            doc.Add(p3);
            doc.Close();
            MessageBox.Show("PDF Created");

        }

        private void pwdin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
