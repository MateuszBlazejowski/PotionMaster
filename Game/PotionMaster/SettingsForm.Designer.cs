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
            difficultyComboBox.Location = new Point(168, 39);
            difficultyComboBox.Margin = new Padding(4, 4, 4, 4);
            difficultyComboBox.Name = "difficultyComboBox";
            difficultyComboBox.Size = new Size(289, 29);
            difficultyComboBox.TabIndex = 0;
            // 
            // segmentsNumUpDown
            // 
            segmentsNumUpDown.Location = new Point(168, 102);
            segmentsNumUpDown.Margin = new Padding(4, 4, 4, 4);
            segmentsNumUpDown.Name = "segmentsNumUpDown";
            segmentsNumUpDown.Size = new Size(291, 29);
            segmentsNumUpDown.TabIndex = 1;
            segmentsNumUpDown.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // vialsNumUpDown
            // 
            vialsNumUpDown.Location = new Point(168, 161);
            vialsNumUpDown.Margin = new Padding(4, 4, 4, 4);
            vialsNumUpDown.Name = "vialsNumUpDown";
            vialsNumUpDown.Size = new Size(291, 29);
            vialsNumUpDown.TabIndex = 2;
            vialsNumUpDown.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // lightModeButton
            // 
            lightModeButton.AutoSize = true;
            lightModeButton.Location = new Point(183, 238);
            lightModeButton.Margin = new Padding(4, 4, 4, 4);
            lightModeButton.Name = "lightModeButton";
            lightModeButton.Size = new Size(66, 25);
            lightModeButton.TabIndex = 3;
            lightModeButton.TabStop = true;
            lightModeButton.Text = "Light";
            lightModeButton.UseVisualStyleBackColor = true;
            // 
            // darkModeButton
            // 
            darkModeButton.AutoSize = true;
            darkModeButton.Location = new Point(374, 238);
            darkModeButton.Margin = new Padding(4, 4, 4, 4);
            darkModeButton.Name = "darkModeButton";
            darkModeButton.Size = new Size(64, 25);
            darkModeButton.TabIndex = 4;
            darkModeButton.TabStop = true;
            darkModeButton.Text = "Dark";
            darkModeButton.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(168, 316);
            buttonCancel.Margin = new Padding(4, 4, 4, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(96, 32);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // difficultyLabel
            // 
            difficultyLabel.AutoSize = true;
            difficultyLabel.Location = new Point(60, 43);
            difficultyLabel.Margin = new Padding(4, 0, 4, 0);
            difficultyLabel.Name = "difficultyLabel";
            difficultyLabel.Size = new Size(79, 21);
            difficultyLabel.TabIndex = 7;
            difficultyLabel.Text = "Difficulty: ";
            // 
            // segmentsLabel
            // 
            segmentsLabel.AutoSize = true;
            segmentsLabel.Location = new Point(15, 105);
            segmentsLabel.Margin = new Padding(4, 0, 4, 0);
            segmentsLabel.Name = "segmentsLabel";
            segmentsLabel.Size = new Size(129, 21);
            segmentsLabel.TabIndex = 8;
            segmentsLabel.Text = "Segments: (2-10)";
            // 
            // vialsCountLabel
            // 
            vialsCountLabel.AutoSize = true;
            vialsCountLabel.Location = new Point(51, 164);
            vialsCountLabel.Margin = new Padding(4, 0, 4, 0);
            vialsCountLabel.Name = "vialsCountLabel";
            vialsCountLabel.Size = new Size(93, 21);
            vialsCountLabel.TabIndex = 9;
            vialsCountLabel.Text = "Vials: (5-25)";
            // 
            // colorThemeLabel
            // 
            colorThemeLabel.AutoSize = true;
            colorThemeLabel.Location = new Point(39, 241);
            colorThemeLabel.Margin = new Padding(4, 0, 4, 0);
            colorThemeLabel.Name = "colorThemeLabel";
            colorThemeLabel.Size = new Size(102, 21);
            colorThemeLabel.TabIndex = 10;
            colorThemeLabel.Text = "Color Theme:";
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(363, 316);
            buttonOK.Margin = new Padding(4, 4, 4, 4);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(96, 32);
            buttonOK.TabIndex = 11;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 354);
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
            Margin = new Padding(4, 4, 4, 4);
            MaximumSize = new Size(509, 401);
            MinimumSize = new Size(509, 401);
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