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
using Firebase.Database;
using Firebase.Database.Query;

namespace IN
{
    public partial class Form1 : Form
    {
        String password_pattern = "(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        

        public Form1()
        {
            InitializeComponent();


        }
        public async void RegisterData()
        {
            Cursor.Current = Cursors.WaitCursor;
            FirebaseClient fb = new FirebaseClient(FBConfig.url);
            RegisterData obj = new RegisterData();
            obj.Username = textBox1.Text;
            obj.Email = textBox2.Text;
            obj.Contact = textBox3.Text;
            obj.Password = textBox4.Text;

            try
            {
                await fb.Child("RegisterInfo").PostAsync(obj);
                MessageBox.Show("Registration Done Successfully");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            Cursor.Current = Cursors.Default;

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
            RegisterData();
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
