using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace IN
{
    public partial class splash : From1
    {
        int ticks;
        public splash()
        {
            InitializeComponent();
            time.Start(); 
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            ticks++;
            if(ticks==3)
            {
                From1 obj = new From1();
                obj.Show();
                Hide();
                time.Stop();
                Form1 hj = new Form1();
                hj.Show();
                SoundPlayer sp = new SoundPlayer("C:\\Users\\HARSHAL\\Downloads\\clock-tick-101150.mp3");
                sp.Stop();

            }
        }

        private void splash_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("C:\\Users\\HARSHAL\\Downloads\\clock-tick-101150.mp3");
            sp.Play();
        }

       
    }
}
