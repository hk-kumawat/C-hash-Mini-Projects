using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IN
{
    public partial class ImgProcessing : Form
    {
        public ImgProcessing()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png|*.png|jpg|*.jpg|bmp|*.bmp";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {

                pictureBox1.Image = Bitmap.FromFile(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Bitmap bt = new Bitmap(pictureBox1.Image);
            for (int y = 0; y < bt.Height; y++)
            {
                for (int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);

                    int r = c.R;
                    int g = c.G;
                    int b = c.B;
                    int avg = (r + g + b) / 3;
                    Color cc = Color.FromArgb(avg, avg, avg);
                    bt.SetPixel(x, y, cc);
                }
            }
            pictureBox2.Image = bt; Cursor.Current = Cursors.Default;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Bitmap bt = new Bitmap(pictureBox1.Image);

            for (int y = 0; y < bt.Height; y++)

            {

                for (int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);

                    int r = c.R;
                    int g = c.G;
                    int b = c.B;
                    int avg = (r + g + b) / 3;
                    Color cc = Color.FromArgb(255, avg, avg);
                    bt.SetPixel(x, y, cc);
                }
            }
            pictureBox3.Image = bt;
            Cursor.Current = Cursors.Default;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Bitmap bt = new Bitmap(pictureBox1.Image);

            for (int y = 0; y < bt.Height; y++)

            {

                for (int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);

                    int r = c.R;
                    int g = c.G;
                    int b = c.B;
                    bt.SetPixel(bt.Width - 1 - x, y, c);
                }
            }
            pictureBox4.Image = bt;
            Cursor.Current = Cursors.Default;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Bitmap bt = new Bitmap(pictureBox1.Image);
            Bitmap bt2 = new Bitmap(bt.Width, bt.Height);


            for (int y = 0; y < bt.Height; y++)

            {

                for (int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);

                    int r = c.R;
                    int g = c.G;
                    int b = c.B;
                    bt2.SetPixel(bt.Width - 1 - x, y, c);
                }
            }
            pictureBox5.Image = bt2;
            Cursor.Current = Cursors.Default;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Bitmap bt = new Bitmap(pictureBox1.Image);

            int th = int.Parse(textBox1.Text);

            for (int y = 0; y < bt.Height; y++)
            {
                for (int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);

                    int r = c.R;
                    int g = c.G;
                    int b = c.B;
                    int avg = (r + g + b) / 3;

                    if (avg < th)

                    {
                        bt.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        bt.SetPixel(x, y, Color.White);
                    }
                }
            }
            pictureBox6.Image = bt;
            Cursor.Current = Cursors.Default;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Bitmap bt = new Bitmap(pictureBox1.Image);

            for (int y = 0; y < bt.Height; y++)

            {

                for (int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);

                    int r = c.R;
                    int g = c.G;
                    int b = c.B;
                    int avg = (r + g + b) / 3;
                    Color cc = Color.FromArgb(avg, 255, avg);
                    bt.SetPixel(x, y, cc);
                }
            }
            pictureBox8.Image = bt;
            Cursor.Current = Cursors.Default;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Bitmap bt = new Bitmap(pictureBox1.Image);

            for (int y = 0; y < bt.Height; y++)

            {

                for (int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);

                    int r = c.R;
                    int g = c.G;
                    int b = c.B;
                    int avg = (r + g + b) / 3;
                    Color cc = Color.FromArgb(avg, avg, 255);
                    bt.SetPixel(x, y, cc);
                }
            }
            pictureBox7.Image = bt;
            Cursor.Current = Cursors.Default;
        }
    }
}