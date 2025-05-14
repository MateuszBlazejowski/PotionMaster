using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PotionMaster.Common;

namespace PotionMaster
{
    public partial class SettingsForm : Form
    {
        public string Difficulty { get; set; }
        public int MaxSegments { get; set; }
        public int VialCount { get; set; }
        public string ColorTheme { get; set; }
        public bool settingsChanged { get; set; }

        private string initialDifficulty;
        private int initialMaxSegments;
        private int initialVialCount;
        private string initialColorTheme;
        public SettingsForm()
        {
            InitializeComponent();
            LoadSettings();
            ApplyColorTheme();
        }
        private void LoadSettings()
        {
            // These values could come from settings file or a database
            initialDifficulty = Properties.Settings.Default.Difficulty ?? "Medium"; // Default to "Medium" if not set
            initialMaxSegments = Properties.Settings.Default.MaxSegments == 0 ? 5 : Properties.Settings.Default.MaxSegments; // Default to 5 if not set
            initialVialCount = Properties.Settings.Default.VialCount == 0 ? 10 : Properties.Settings.Default.VialCount; // Default to 10 if not set
            initialColorTheme = Properties.Settings.Default.ColorTheme ?? "Light"; // Default to "Light" if not set

            // Set the initial values in the controls
            difficultyComboBox.SelectedItem = initialDifficulty;
            segmentsNumUpDown.Value = initialMaxSegments;
            vialsNumUpDown.Value = initialVialCount;
            lightModeButton.Checked = initialColorTheme == "Light";
            darkModeButton.Checked = initialColorTheme == "Dark";
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (segmentsNumUpDown.Value < 2)
            {
                segmentsNumUpDown.Value = 2; 
                return; 
            }
            if (segmentsNumUpDown.Value > 10)
            {
                segmentsNumUpDown.Value = 10;
                return;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (vialsNumUpDown.Value < 5)
            {
                vialsNumUpDown.Value = 5;
                return;
            }
            if (vialsNumUpDown.Value > 25)
            {
                vialsNumUpDown.Value = 25;
                return;
            }
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (HasSettingsChanged())
            {
                Difficulty = difficultyComboBox.SelectedItem.ToString();
                MaxSegments = (int)segmentsNumUpDown.Value;
                VialCount = (int)vialsNumUpDown.Value;
                ColorTheme = lightModeButton.Checked ? "Light" : "Dark";

                SaveSettings();
            }

            // Close the settings window
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private bool HasSettingsChanged()
        {
            // Compare current values in the controls with the initial values
            bool settingsChanged = difficultyComboBox.SelectedItem.ToString() != initialDifficulty ||
                                   (int)segmentsNumUpDown.Value != initialMaxSegments ||
                                   (int)vialsNumUpDown.Value != initialVialCount ||
                                   (lightModeButton.Checked ? "Light" : "Dark") != initialColorTheme;

            this.settingsChanged = settingsChanged;
            return settingsChanged;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            settingsChanged = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.Difficulty = Difficulty;
            Properties.Settings.Default.MaxSegments = MaxSegments;
            Properties.Settings.Default.VialCount = VialCount;
            Properties.Settings.Default.ColorTheme = ColorTheme;
            Properties.Settings.Default.Save();
        }
        private void ApplyColorTheme()
        {
            if (initialColorTheme == "Light")
                ApplyTheme(Light);
            else
                ApplyTheme(Dark);
        }
        private void ApplyTheme(ColorPreset theme)
        {
            this.BackColor = theme.Background;

            // Apply background and text color to all controls
            foreach (Control ctrl in this.Controls)
            {
                ctrl.BackColor = theme.Background;
                ctrl.ForeColor = theme.TextColor;

                if (ctrl is Button)
                {
                    ctrl.BackColor = theme.ButtonBackground;
                }
            }


            this.buttonCancel.BackColor = theme.ButtonBackground;
            this.buttonOK.BackColor = theme.ButtonBackground;
        }
    }
}
