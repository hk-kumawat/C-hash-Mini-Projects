using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;


namespace IN
{
    public partial class SpeechToText : Form
    {
        public SpeechToText()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine s = new SpeechRecognitionEngine();
            Grammar words = new DictationGrammar();
            s.LoadGrammar(words);

            try
            {
                richTextBox1.Text = "Listening Now...";
                s.SetInputToDefaultAudioDevice();
                RecognitionResult result = s.Recognize();
                richTextBox1.Clear();
                richTextBox1.Text = result.Text;
            }
            catch
            { 
                richTextBox1.Text = "";
                MessageBox.Show("Mic Not Found...!");
            }
            finally
            {
                s.UnloadAllGrammars();
            }

        }

        private void SpeechToText_Load(object sender, EventArgs e)
        {

        }
    }
}
