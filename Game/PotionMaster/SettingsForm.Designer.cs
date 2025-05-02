namespace PotionMaster
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            difficultyComboBox = new ComboBox();
            segmentsNumUpDown = new NumericUpDown();
            vialsNumUpDown = new NumericUpDown();
            lightModeButton = new RadioButton();
            darkModeButton = new RadioButton();
            buttonCancel = new Button();
            difficultyLabel = new Label();
            segmentsLabel = new Label();
            vialsCountLabel = new Label();
            colorThemeLabel = new Label();
            buttonOK = new Button();
            ((System.ComponentModel.ISupportInitialize)segmentsNumUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vialsNumUpDown).BeginInit();
            SuspendLayout();
            // 
            // difficultyComboBox
            // 
            difficultyComboBox.FormattingEnabled = true;
            difficultyComboBox.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            difficultyComboBox.Location = new Point(131, 28);
            difficultyComboBox.Name = "difficultyComboBox";
            difficultyComboBox.Size = new Size(226, 23);
            difficultyComboBox.TabIndex = 0;
            // 
            // segmentsNumUpDown
            // 
            segmentsNumUpDown.Location = new Point(131, 73);
            segmentsNumUpDown.Name = "segmentsNumUpDown";
            segmentsNumUpDown.Size = new Size(226, 23);
            segmentsNumUpDown.TabIndex = 1;
            segmentsNumUpDown.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // vialsNumUpDown
            // 
            vialsNumUpDown.Location = new Point(131, 115);
            vialsNumUpDown.Name = "vialsNumUpDown";
            vialsNumUpDown.Size = new Size(226, 23);
            vialsNumUpDown.TabIndex = 2;
            vialsNumUpDown.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // lightModeButton
            // 
            lightModeButton.AutoSize = true;
            lightModeButton.Location = new Point(142, 170);
            lightModeButton.Name = "lightModeButton";
            lightModeButton.Size = new Size(52, 19);
            lightModeButton.TabIndex = 3;
            lightModeButton.TabStop = true;
            lightModeButton.Text = "Light";
            lightModeButton.UseVisualStyleBackColor = true;
            // 
            // darkModeButton
            // 
            darkModeButton.AutoSize = true;
            darkModeButton.Location = new Point(291, 170);
            darkModeButton.Name = "darkModeButton";
            darkModeButton.Size = new Size(49, 19);
            darkModeButton.TabIndex = 4;
            darkModeButton.TabStop = true;
            darkModeButton.Text = "Dark";
            darkModeButton.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(131, 226);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // difficultyLabel
            // 
            difficultyLabel.AutoSize = true;
            difficultyLabel.Location = new Point(47, 31);
            difficultyLabel.Name = "difficultyLabel";
            difficultyLabel.Size = new Size(61, 15);
            difficultyLabel.TabIndex = 7;
            difficultyLabel.Text = "Difficulty: ";
            // 
            // segmentsLabel
            // 
            segmentsLabel.AutoSize = true;
            segmentsLabel.Location = new Point(12, 75);
            segmentsLabel.Name = "segmentsLabel";
            segmentsLabel.Size = new Size(96, 15);
            segmentsLabel.TabIndex = 8;
            segmentsLabel.Text = "Segments: (2-10)";
            // 
            // vialsCountLabel
            // 
            vialsCountLabel.AutoSize = true;
            vialsCountLabel.Location = new Point(40, 117);
            vialsCountLabel.Name = "vialsCountLabel";
            vialsCountLabel.Size = new Size(68, 15);
            vialsCountLabel.TabIndex = 9;
            vialsCountLabel.Text = "Vials: (4-25)";
            // 
            // colorThemeLabel
            // 
            colorThemeLabel.AutoSize = true;
            colorThemeLabel.Location = new Point(30, 172);
            colorThemeLabel.Name = "colorThemeLabel";
            colorThemeLabel.Size = new Size(78, 15);
            colorThemeLabel.TabIndex = 10;
            colorThemeLabel.Text = "Color Theme:";
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(282, 226);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 11;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(buttonOK);
            Controls.Add(colorThemeLabel);
            Controls.Add(vialsCountLabel);
            Controls.Add(segmentsLabel);
            Controls.Add(difficultyLabel);
            Controls.Add(buttonCancel);
            Controls.Add(darkModeButton);
            Controls.Add(lightModeButton);
            Controls.Add(vialsNumUpDown);
            Controls.Add(segmentsNumUpDown);
            Controls.Add(difficultyComboBox);
            MaximumSize = new Size(400, 300);
            MinimumSize = new Size(400, 300);
            Name = "SettingsForm";
            Text = "Potions Master - Settings";
            ((System.ComponentModel.ISupportInitialize)segmentsNumUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)vialsNumUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox difficultyComboBox;
        private NumericUpDown segmentsNumUpDown;
        private NumericUpDown vialsNumUpDown;
        private RadioButton lightModeButton;
        private RadioButton darkModeButton;
        private Button buttonCancel;
        private Label difficultyLabel;
        private Label segmentsLabel;
        private Label vialsCountLabel;
        private Label colorThemeLabel;
        private Button buttonOK;
    }
}