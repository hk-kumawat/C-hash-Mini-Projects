using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace IN
{
    public partial class Tooltip : Form
    {
        public Tooltip()
        {
            InitializeComponent();
            AddTooltips();
        }

        private void Tooltip_Load(object sender, EventArgs e)
        {

        }
        private void AddTooltips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(label1, "Please Don't Click...!");
            toolTip.SetToolTip(button1, "Why");

            toolTip.AutoPopDelay = 5000; 
            toolTip.InitialDelay = 1000;  
            toolTip.ReshowDelay = 500;   
            toolTip.ShowAlways = true;    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string youtubeVideoUrl = "https://youtu.be/xwCDCI69Dvs";
            Process.Start(youtubeVideoUrl);
        }
    }
}
