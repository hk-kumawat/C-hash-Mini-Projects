using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace IN
{
    public partial class Notepadcs : Form
    {
        public Notepadcs()
        {
            InitializeComponent();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt|*.txt";
            DialogResult dr = ofd.ShowDialog();
            if(dr == DialogResult.OK)
            {
                string filepath = ofd.FileName;
                richTextBox1.Text = File.ReadAllText(filepath);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "*txt|*.txt";
            DialogResult dr = sfd.ShowDialog();
            if(dr==DialogResult.OK)
            {
                string s = richTextBox1.Text;
                File.WriteAllText(sfd.FileName, s);

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = System.DateTime.Now.ToString();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://support.microsoft.com/en-us/windows/help-in-notepad-4d68c388-2ff2-0e7f-b706-35fb2ab88a8c");
        }

        private void fontDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            richTextBox1.Font = fd.Font;
        }

        private void colorDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            richTextBox1.SelectionColor = cd.Color;
        }
    }
}
