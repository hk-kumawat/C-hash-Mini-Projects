using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IN
{
    public partial class Form1 : Form
    {
        String password_pattern = "(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$";
       
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            From1 lg = new From1();
            lg.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Username can't be Empty");
            }
            if (textBox2.Text.Trim().Contains('@') == false || textBox2.Text.Trim().Contains('.') == false)
            {
                MessageBox.Show("Invalid Email");
                return;
            }
            if (textBox3.TextLength != 10)
            {
                MessageBox.Show("Invalid Phone No.");
                return;
            }
            Regex reg = new Regex(password_pattern);
            if (!reg.IsMatch(textBox4.Text))
            {
                MessageBox.Show("Enter Strong Password");
                return;
            }
            if (!reg.IsMatch(textBox5.Text))
            {
                MessageBox.Show("Enter Strong Re-Write Password");
                return;
            }
            if (textBox4.Text != textBox5.Text)
            {
                MessageBox.Show("Password Doesn't Match");
                return;
            }
            else
            {
                MessageBox.Show("Sign up successful");
                this.Hide();
                From1 lg = new From1();
                lg.Show();
                Hide();
            }
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.PasswordChar = '\0';
                textBox5.PasswordChar = '\0';
            }
            else
            {
                textBox4.PasswordChar = '*';
                textBox5.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
