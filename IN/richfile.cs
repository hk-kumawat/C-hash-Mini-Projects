using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace IN
{
    public partial class richfile : Form
    {
        public richfile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter("C:\\Users\\HARSHAL\\Desktop\\text.doc");
            file.Write(richTextBox1);
            MessageBox.Show("File saved to destined location...!");
            file.Close();
        }
    }
}
