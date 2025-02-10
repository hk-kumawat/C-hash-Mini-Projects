using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace IN
{
    public partial class TextToSpeach : Form
    {
        SpeechSynthesizer reader = new SpeechSynthesizer();
        public TextToSpeach()
        {
            InitializeComponent();
        }

        private void TextToSpeach_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text!="")
            {
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(richTextBox1.Text);
                //reader.Dispose();
            }
            else
            {
                MessageBox.Show("Enter Some Text...!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Speaking)
                {
                    reader.Pause();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Paused)
                {
                    reader.Resume();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                reader.Dispose();
            }

        }
    }
}
