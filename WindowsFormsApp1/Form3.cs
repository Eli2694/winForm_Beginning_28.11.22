using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rnd = random.Next(1, 4);
            if(rnd == 1)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\User\\Pictures\\Saved Pictures\\image1.jpg");
            }
            else if(rnd == 2)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\User\\Pictures\\Saved Pictures\\image2.jpg");
            }
            else if(rnd == 3)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\User\\Pictures\\Saved Pictures\\image3.jpg");
            }
            else
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\User\\Pictures\\photo1.jpg");
            }
        }
    }
}
