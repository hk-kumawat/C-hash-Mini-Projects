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
    public partial class From1 : Form
    {
        String password_pattern = "(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeft,
               int nTop,
               int nRight,
               int nBottom,
               int nWidthEllipse,
               int nHeightEllipse
           );
        public From1()
        {
            InitializeComponent();
        }
        public async void DataFromCloud()
        {
            Cursor.Current = Cursors.WaitCursor;
            var fb = new FirebaseClient(FBConfig.url);
            RegisterData obj = new RegisterData();

            obj.Username = textBox1.Text;
            obj.Password = textBox2.Text;
            var fbdata = await fb.Child("RegisterInfo").OnceAsync<RegisterData>();
            int id = 0;
            foreach(var data in fbdata)
            {
                RegisterData rd = new RegisterData();
                rd.Username = data.Object.Username;
                rd.Password = data.Object.Password;

                if(rd.Username == textBox1.Text && rd.Password == textBox2.Text)
                {
                    id = 1;
                    MessageBox.Show("Login Done Successfully");
                    Notepadcs form = new Notepadcs();
                    form.Show();
                    this.Hide();
                    return;
                }
            }
            if (id == 0)
            {
                MessageBox.Show("Invalid User");
            }
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 gh = new Form1();
            gh.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Username can't be Empty");
                return;
            }
            Regex reg = new Regex(password_pattern);
            if (!reg.IsMatch(textBox2.Text))
            {
                MessageBox.Show("Enter Correct Password");
                return;
            }
            else
            {
                DataFromCloud();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
