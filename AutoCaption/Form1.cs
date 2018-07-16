using System;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using System.Threading;
using System.IO;
using System.ComponentModel;
using System.Threading.Tasks;

namespace AutoCaption
{
    public partial class AutoCaption : Form
    {
        string OutputPath = "";
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        bool HasSpoken = false;

        public AutoCaption()
        {
            InitializeComponent();
        }

        

        private void ToggleStartStop()
        {
            StopButton.Enabled = !StopButton.Enabled;
            StartButton.Enabled = !StartButton.Enabled;

            if (StopButton.Enabled)
            {
                //we are working
                StatusLabel.Text = "Working";
                StatusLabel.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                //we are stopped
                StatusLabel.Text = "Stopped";
                StatusLabel.BackColor = System.Drawing.Color.Red;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (OutputPath == "" || !File.Exists(OutputPath))
            {
                MessageBox.Show("Please select a valid file to output to");

            }
            else
            {
                ToggleStartStop();
                DoRecognise();
            }

        }



        private void StopButton_Click(object sender, EventArgs e)
        {
            ToggleStartStop();
            sre.Dispose();
        }


        private void ChooseOutputButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.InitialDirectory = @"E:\memes\Voice";
            saveFileDialog1.ShowDialog();
            OutputPath = saveFileDialog1.FileName;
            FilePathLabel.Text = OutputPath;
 
        }

        private void DoRecognise()
        {
            var sre = InitiliseSRE();
            sre.RecognizeAsync(RecognizeMode.Multiple);
        }

        public  SpeechRecognitionEngine InitiliseSRE()
        {

             sre = new SpeechRecognitionEngine(
          new System.Globalization.CultureInfo("en-EN"));
            //Use the microphone
            sre.SetInputToDefaultAudioDevice();
            Choices Words = new Choices();
            //use these words 
            Words.Add(new string[] { "Test", "Coffee", "blue", "Stream", "Siege","game","do anything","Chicken Nuggets" });
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(Words);
            gb.Culture = Thread.CurrentThread.CurrentCulture;
            Grammar g = new Grammar(gb);
            sre.LoadGrammar(g);
            sre.SpeechRecognized += Sre_SpeechRecognized;
            return sre;
        }

       
        
       

        private void Sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //MessageBox.Show("We heard a word "+e.Result.Text);
            StreamWriter sw = new StreamWriter(OutputPath,true);
            string output = e.Result.Text;

            OutputTextBox.Text += " " + output;
 
            sw.Write(output + " ");
            sw.Close();
            HasSpoken = true;
            SpeakTimer.Stop();
            SpeakTimer.Start();
        }

       

        private void ChooseMicButton_Click(object sender, EventArgs e)
        {

        }

        private void OutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!StartButton.Enabled && HasSpoken)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(OutputPath, false);
                    sw.Write("");
                    sw.Close();
                    OutputTextBox.Text += "------";
                    OutputTextBox.Text += Environment.NewLine;
                }
                catch { }
                HasSpoken = false;
            }
        }

        private void lengthTimer_Tick(object sender, EventArgs e)
        {
            
            if (!StartButton.Enabled)
            {
                try
                {
                    StreamReader sr = new StreamReader(OutputPath);
                    string contents = sr.ReadToEnd();
                    if (contents.Length > 500)
                    {
                        StreamWriter sw = new StreamWriter(OutputPath, false);
                        sw.Write("");
                        sw.Close();
                        OutputTextBox.Text += "------";
                        OutputTextBox.Text += Environment.NewLine;
                    }
                    sr.Close();
                }
                catch { }
                
            }
        }
    }
}
