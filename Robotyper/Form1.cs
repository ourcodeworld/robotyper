using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;
using WindowsInput;
using System.Threading;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Robotyper
{
    public partial class Form1 : MaterialForm
    {
        SettingsForm settingsForm = null;

        RobotyperHelpers ThreadHelpers = null;

        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        public Form1()
        {
            InitializeComponent();
            InitializeMaterial(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void writeCodeWords(string code, int delay = 100, int startTypingDelay = 2000)
        {
            
        }
 

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (settingsForm != null)
            {
                settingsForm.BringToFront();
            }
            else
            {
                settingsForm = new SettingsForm();

                InitializeMaterial(settingsForm);

                settingsForm.Show();

                settingsForm.FormClosed += delegate {
                    settingsForm = null;

                    calculateEstimatedTime();
                };
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            ThreadHelpers = new RobotyperHelpers();

            ThreadHelpers.OnProgressChanged += updateProgressBar;
            ThreadHelpers.OnTypingEnd += handleOnEnd;

            materialRaisedButton1.Enabled = false;
            materialRaisedButton3.Enabled = true;

            string Text = textEditorControl1.Text;

            if (Properties.Settings.Default.typingMode == "characters")
            {
                ThreadHelpers.StartTypingCharacters(Text);
            }
            else if (Properties.Settings.Default.typingMode == "words")
            {
                ThreadHelpers.StartTypingWords(Text);
            }
        }

        private void handleOnEnd(object sender, ThreadResponse instance)
        {
            materialRaisedButton1.Enabled = true;
            materialRaisedButton3.Enabled = false;
            typingProgress.Value = 0;
        }

        private void updateProgressBar(object sender, ThreadResponse instance)
        {
            typingProgress.Value = instance.Progress;
        }

        private void textEditorControl1_TextChanged(object sender, EventArgs e)
        {
            calculateEstimatedTime();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            if(ThreadHelpers != null)
            {

                ThreadHelpers.Stop();
                ThreadHelpers = null;

                materialRaisedButton1.Enabled = true;
                materialRaisedButton3.Enabled = false;
            }
        }

        private void InitializeMaterial(MaterialForm frm)
        {
            materialSkinManager.AddFormToManage(frm);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.LightBlue500, Primary.LightBlue700,
                Primary.LightBlue100, Accent.Blue200,
                TextShade.WHITE
            );
        }

        private void calculateEstimatedTime()
        {
            int milliseconds = 0;
            string Text = textEditorControl1.Text;

            if (Properties.Settings.Default.typingMode == "characters")
            {
                int TextLength = Text.Length;

                milliseconds = Properties.Settings.Default.typingDelay * TextLength;
            }
            else if (Properties.Settings.Default.typingMode == "words")
            {
                string[] words = Regex.Split(Text, @"(?<=[\S\n])(?=\s)");

                milliseconds = Properties.Settings.Default.typingDelay * words.Length;
            }

            TimeSpan t = TimeSpan.FromMilliseconds(milliseconds);

            materialLabel2.Text = string.Format("{0:D2}H:{1:D2}M:{2:D2}S:{3:D3}MS",
                t.Hours,
                t.Minutes,
                t.Seconds,
                t.Milliseconds
            );
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        { 
            Process.Start(
                new ProcessStartInfo("https://github.com/ourcodeworld/robotyper")
            );
        }
    }
}
