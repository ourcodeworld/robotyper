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

namespace Robotyper
{
    public partial class SettingsForm : MaterialForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            loadDefaultSettings();
        }

        private void loadDefaultSettings()
        {
            if(Properties.Settings.Default.typingMode == "characters")
            {
                btnSimulationCharacters.Checked = true;
            }
            else if(Properties.Settings.Default.typingMode == "words")
            {
                btnSimulationWords.Checked = true;
            }

            txtboxTypingDelay.Text = Properties.Settings.Default.typingDelay.ToString();

            txtboxStartTypingDelay.Text = Properties.Settings.Default.typingStartDelay.ToString();

            checkboxAllowBeep.Checked = Properties.Settings.Default.enableBeep;
        }

        private void btnSimulationCharacters_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.typingMode = "characters";
            Properties.Settings.Default.Save();
        }

        private void btnSimulationWords_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.typingMode = "words";
            Properties.Settings.Default.Save();
        }

        private void txtboxTypingDelay_TextChanged(object sender, EventArgs e)
        {
            string value = txtboxTypingDelay.Text;

            if (String.IsNullOrEmpty(value))
            {
                value = "0";
            }

            try
            {
                Properties.Settings.Default.typingDelay = Int32.Parse(value);
            }
            catch (Exception err)
            {
                MessageBox.Show("There was an error processing this value, default value 100 will be used");
                txtboxTypingDelay.Text = "100";
            }

            Properties.Settings.Default.Save();
        }

        private void txtboxTypingDelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void checkboxAllowBeep_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.enableBeep = checkboxAllowBeep.Checked;
            Properties.Settings.Default.Save();
        }

        private void txtboxStartTypingDelay_TextChanged(object sender, EventArgs e)
        {
            string value = txtboxStartTypingDelay.Text;

            if (String.IsNullOrEmpty(value))
            {
                value = "0";
            }

            try
            {
                Properties.Settings.Default.typingStartDelay = Int32.Parse(value);
            }
            catch (Exception err)
            {
                MessageBox.Show("There was an error processing this value, default value 2000 will be used");
                txtboxTypingDelay.Text = "2000";
            }

            Properties.Settings.Default.Save();
        }
    }
}
