using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IN
{
    public partial class Splash2cs : Form
    {
        int ticks;
        public Splash2cs()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Splash2cs_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks == 3)
            {
                From1 obj = new From1();
                obj.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
