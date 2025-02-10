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
    public partial class context : Form
    {
        public context()
        {
            InitializeComponent();
        }

        private void context_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button1, 0,button1.Height);
            
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show(e.ClickedItem.Text);
        }
    }
}
