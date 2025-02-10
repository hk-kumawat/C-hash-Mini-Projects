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
    public partial class combox : Form
    {
        public combox()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            button1.Click += button1_Click;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedItem))
            {
               
                switch (selectedItem)
                {
                    case "Ronaldo":
                        MessageBox.Show("You've selected Ronaldo");
                        break;
                    case "Messi":
                        MessageBox.Show("You've selected Messi");
                        break;
                    case "Neymar":
                        MessageBox.Show("You've selected Neymar");
                        break;
                    
                }
            }
            else
            {
                MessageBox.Show("Please select an item...!");
            }
        }

        private void combox_Load(object sender, EventArgs e)
        {

        }
    }
}
