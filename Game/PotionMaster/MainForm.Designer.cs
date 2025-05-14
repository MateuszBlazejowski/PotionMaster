namespace PotionMaster
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            EndGameToolStripMenuItem = new ToolStripMenuItem();
            exitGameToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            openSettingsToolStripMenuItem = new ToolStripMenuItem();
            vialsLayoutPanel = new TableLayoutPanel();
            backgroundTable = new TableLayoutPanel();
            controlPanel = new Panel();
            leftUndosLabel = new Label();
            currentScoreLabel = new Label();
            bestScoreLabel = new Label();
            congratulationsLabel = new Label();
            nextPuzzleButton = new Button();
            undoButton = new Button();
            menuStrip1.SuspendLayout();
            backgroundTable.SuspendLayout();
            controlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1008, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, EndGameToolStripMenuItem, exitGameToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(65, 25);
            fileToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(171, 26);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // EndGameToolStripMenuItem
            // 
            EndGameToolStripMenuItem.Name = "EndGameToolStripMenuItem";
            EndGameToolStripMenuItem.Size = new Size(171, 26);
            EndGameToolStripMenuItem.Text = "End Game";
            EndGameToolStripMenuItem.Click += EndGameToolStripMenuItem_Click;
            // 
            // exitGameToolStripMenuItem
            // 
            exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            exitGameToolStripMenuItem.Size = new Size(171, 26);
            exitGameToolStripMenuItem.Text = "Exit ";
            exitGameToolStripMenuItem.Click += exitGameToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openSettingsToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(80, 25);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // openSettingsToolStripMenuItem
            // 
            openSettingsToolStripMenuItem.Name = "openSettingsToolStripMenuItem";
            openSettingsToolStripMenuItem.Size = new Size(192, 26);
            openSettingsToolStripMenuItem.Text = "Open Settings";
            openSettingsToolStripMenuItem.Click += openSettingsToolStripMenuItem_Click;
            // 
            // vialsLayoutPanel
            // 
            vialsLayoutPanel.CausesValidation = false;
            vialsLayoutPanel.ColumnCount = 4;
            vialsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            vialsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            vialsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            vialsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            vialsLayoutPanel.Dock = DockStyle.Fill;
            vialsLayoutPanel.Location = new Point(0, 0);
            vialsLayoutPanel.Margin = new Padding(0);
            vialsLayoutPanel.Name = "vialsLayoutPanel";
            vialsLayoutPanel.RowCount = 1;
            vialsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            vialsLayoutPanel.Size = new Size(1008, 514);
            vialsLayoutPanel.TabIndex = 1;
            // 
            // backgroundTable
            // 
            backgroundTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            backgroundTable.ColumnCount = 1;
            backgroundTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            backgroundTable.Controls.Add(vialsLayoutPanel, 0, 0);
            backgroundTable.Controls.Add(controlPanel, 0, 1);
            backgroundTable.Location = new Point(0, 34);
            backgroundTable.Margin = new Padding(3, 4, 3, 4);
            backgroundTable.Name = "backgroundTable";
            backgroundTable.RowCount = 2;
            backgroundTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100.000008F));
            backgroundTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            backgroundTable.Size = new Size(1008, 612);
            backgroundTable.TabIndex = 2;
            backgroundTable.Paint += backgroundTable_Paint;
            // 
            // controlPanel
            // 
            controlPanel.Controls.Add(leftUndosLabel);
            controlPanel.Controls.Add(currentScoreLabel);
            controlPanel.Controls.Add(bestScoreLabel);
            controlPanel.Controls.Add(congratulationsLabel);
            controlPanel.Controls.Add(nextPuzzleButton);
            controlPanel.Controls.Add(undoButton);
            controlPanel.Dock = DockStyle.Fill;
            controlPanel.Location = new Point(3, 518);
            controlPanel.Margin = new Padding(3, 4, 3, 4);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(1002, 90);
            controlPanel.TabIndex = 2;
            // 
            // leftUndosLabel
            // 
            leftUndosLabel.AutoSize = true;
            leftUndosLabel.BackColor = Color.Transparent;
            leftUndosLabel.Location = new Point(39, 50);
            leftUndosLabel.Name = "leftUndosLabel";
            leftUndosLabel.Size = new Size(52, 21);
            leftUndosLabel.TabIndex = 5;
            leftUndosLabel.Text = "Left: 3";
            leftUndosLabel.Click += label4_Click;
            // 
            // currentScoreLabel
            // 
            currentScoreLabel.AutoSize = true;
            currentScoreLabel.BackColor = Color.Transparent;
            currentScoreLabel.Location = new Point(180, 50);
            currentScoreLabel.Name = "currentScoreLabel";
            currentScoreLabel.Size = new Size(113, 21);
            currentScoreLabel.TabIndex = 4;
            currentScoreLabel.Text = "Current Score: ";
            // 
            // bestScoreLabel
            // 
            bestScoreLabel.AutoSize = true;
            bestScoreLabel.BackColor = Color.Transparent;
            bestScoreLabel.Location = new Point(180, 16);
            bestScoreLabel.Name = "bestScoreLabel";
            bestScoreLabel.Size = new Size(85, 21);
            bestScoreLabel.TabIndex = 3;
            bestScoreLabel.Text = "Best Score:";
            bestScoreLabel.Click += label2_Click;
            // 
            // congratulationsLabel
            // 
            congratulationsLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            congratulationsLabel.AutoSize = true;
            congratulationsLabel.BackColor = Color.Transparent;
            congratulationsLabel.Location = new Point(712, 17);
            congratulationsLabel.Name = "congratulationsLabel";
            congratulationsLabel.Size = new Size(126, 21);
            congratulationsLabel.TabIndex = 2;
            congratulationsLabel.Text = "Congratulations!";
            congratulationsLabel.Click += congratulationsLabel_Click;
            // 
            // nextPuzzleButton
            // 
            nextPuzzleButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nextPuzzleButton.Location = new Point(874, 4);
            nextPuzzleButton.Margin = new Padding(3, 4, 3, 4);
            nextPuzzleButton.Name = "nextPuzzleButton";
            nextPuzzleButton.Size = new Size(128, 42);
            nextPuzzleButton.TabIndex = 1;
            nextPuzzleButton.Text = "Next Puzzle";
            nextPuzzleButton.UseVisualStyleBackColor = true;
            nextPuzzleButton.Click += nextPuzzleButton_Click;
            nextPuzzleButton.Paint += nextPuzzleButton_Paint;
            // 
            // undoButton
            // 
            undoButton.Location = new Point(3, 4);
            undoButton.Margin = new Padding(3, 4, 3, 4);
            undoButton.Name = "undoButton";
            undoButton.Size = new Size(128, 42);
            undoButton.TabIndex = 0;
            undoButton.Text = "Undo";
            undoButton.UseVisualStyleBackColor = true;
            undoButton.Click += undoButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 646);
            Controls.Add(backgroundTable);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(638, 401);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Potion Master";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            backgroundTable.ResumeLayout(false);
            controlPanel.ResumeLayout(false);
            controlPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem EndGameToolStripMenuItem;
        private ToolStripMenuItem exitGameToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem openSettingsToolStripMenuItem;
        private TableLayoutPanel vialsLayoutPanel;
        private Vial userControl11;
        private Vial userControl14;
        private Vial userControl13;
        private Vial userControl12;
        private TableLayoutPanel backgroundTable;
        private Panel controlPanel;
        private Button nextPuzzleButton;
        private Button undoButton;
        private Label leftUndosLabel;
        private Label currentScoreLabel;
        private Label bestScoreLabel;
        private Label congratulationsLabel;
    }
}
