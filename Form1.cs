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
    public partial class Form1 : Form
    {
        public Form1()
        {
            String mName =  Paths.Movies.Name[0];
            String mPath = Paths.Movies.Poster_Path[1];


            InitializeComponent();
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BackgroundImage = Image.FromFile(mPath);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
