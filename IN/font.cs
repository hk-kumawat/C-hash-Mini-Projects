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
    public partial class font : Form
    {
        public font()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog.Font;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog foregroundColorDialog = new ColorDialog();
            if (foregroundColorDialog.ShowDialog() == DialogResult.OK)
            {
                label1.ForeColor = foregroundColorDialog.Color;
            }

            ColorDialog backgroundColorDialog = new ColorDialog();
            if (backgroundColorDialog.ShowDialog() == DialogResult.OK)
            {
                label1.BackColor = backgroundColorDialog.Color;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
