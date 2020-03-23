using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zer_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random number = new Random();
        int toplam1 = 0;
        int toplam2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            int a = number.Next(1, 7);
            int b = number.Next(1, 7);

            label3.Text = a.ToString();
            label4.Text = b.ToString();

            toplam1 = toplam1 + a + b;
            label10.Text = toplam1.ToString();

            button1.Enabled = false;
            button2.Enabled = true;

            if (a == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\1.gif";
            }
            if (a == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\2.gif";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\3.gif";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\4.jpg";
            }
            if (a == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\5.gif";
            }
            if (a == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\6.jpg";
            }
            if (b == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\1.gif";
            }
            if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\2.gif";
            }
            if (b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\3.gif";
            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\4.jpg";
            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\5.gif";
            }
            if (b == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\6.jpg";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int c = number.Next(1, 7);
            int d = number.Next(1, 7);

            label5.Text = c.ToString();
            label6.Text = d.ToString();

            toplam2 = toplam2 + c + d;
            label9.Text = toplam1.ToString();

            button1.Enabled = true;
            button2.Enabled = false;

            if (c == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\1.gif";
            }
            if (c == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\2.gif";
            }
            if (c == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\3.gif";
            }
            if (c == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\4.jpg";
            }
            if (c == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\5.gif";
            }
            if (c == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\6.jpg";
            }
            if (d == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\1.gif";
            }
            if (d == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\2.gif";
            }
            if (d == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\3.gif";
            }
            if (d == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\4.jpg";
            }
            if (d == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\5.gif";
            }
            if (d == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ASUS\\Desktop\\zerler\\6.jpg";
            }


            if (toplam1>toplam2)
            {
                label13.Text = "1-ci oyuncu  qalibdir.";
            }
            if (toplam2>toplam1)
            {
                label13.Text = "2-ci oyuncu qalibdir.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
