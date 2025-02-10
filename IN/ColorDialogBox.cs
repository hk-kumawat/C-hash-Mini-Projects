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
    public partial class ColorDialogBox : Form
    {
        public ColorDialogBox()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                label1.ForeColor = colorDialog1.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                label1.BackColor = colorDialog1.Color;
            }
        }

        private void ColorDialogBox_Load(object sender, EventArgs e)
        {

        }
    }
}
