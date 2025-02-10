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
    public partial class AIO : Form
    {
        public AIO()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AIO_Load(object sender, EventArgs e)
        {
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void OpenFormInPanel(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel.Controls.Clear();
            panel.Controls.Add(form);

            form.Show();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            OpenFormInPanel(f1, panel4);
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            From1 f2 = new From1();
            OpenFormInPanel(f2, panel4);
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            splash f3 = new splash();
            OpenFormInPanel(f3, panel4);
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            font f4 = new font();
            OpenFormInPanel(f4, panel4);
        }

        private void LinkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IM f5 = new IM();
            OpenFormInPanel(f5, panel4);
        }

        private void LinkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tooltip f6 = new Tooltip();
            OpenFormInPanel(f6, panel4);
        }

        private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            context f7 = new context();
            OpenFormInPanel(f7, panel4);
        }

        private void LinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            combox f8 = new combox();
            OpenFormInPanel(f8, panel4);
        }

        private void LinkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sug f9 = new sug();
            OpenFormInPanel(f9, panel4);
        }

        private void LinkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richfile f10 = new richfile();
            OpenFormInPanel(f10, panel4);
        }

        private void LinkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Beep f11 = new Beep();
            OpenFormInPanel(f11, panel4);
        }

        private void LinkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            buttonhover f12 = new buttonhover();
            OpenFormInPanel(f12, panel4);
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
