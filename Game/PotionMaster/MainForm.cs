namespace PotionMaster;

using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

using static PotionMaster.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using PotionMaster.Properties;


public partial class MainWindow : Form
{
    public int vialsCount = MinVialsCount;
    public int segmentsCount = MinSegmentsCount;
    public string colorTheme;
    public int vialTableRowsCount;
    public int vialTableColumnsCount;

    public int difficulty = 1; // should be from 1 to 3 
    public int startingEmptyVials = 1;
    public int startingUndos;
    public int undosLeft;

    public int bestScoreEver = 0;
    public int sessionScore = 0;
    public int puzzleScore = 0;

    List<Vial> vials = new List<Vial> { };

    Stack<PastPour> pastPours = new Stack<PastPour>();
    public MainWindow()
    {
        InitializeComponent();
        InitializeGame();
    }


    private void InitializeGame()
    {
        Random rand = new Random();
        LoadSettings();
        LoadBestScore();
        startingEmptyVials = 4 - difficulty;
        startingUndos = 4 - difficulty;
        undosLeft = 4 - difficulty;
        undoButton.Enabled = true;
        leftUndosLabel.Text = $"Left: {undosLeft}";
        ApplyColorTheme();
        RefreshNumberOfVials();
        CheckWinningCondition();
    }
    private void LoadBestScore()
    {
        bestScoreEver = Properties.Settings.Default.BestScore;
        if (bestScoreEver < 0)
        {
            Properties.Settings.Default.BestScore = 0;
            bestScoreEver = 0;
        }
        bestScoreLabel.Text = $"Best Score: {bestScoreEver}";
    }
    private void SaveBestScore()
    {
        if (sessionScore > bestScoreEver)
        {
            bestScoreEver = sessionScore;
            Properties.Settings.Default.BestScore = bestScoreEver;  // Save to Settings
            Properties.Settings.Default.Save();  // Persist the change
        }
    }
    private void LoadSettings()
    {
        vialsCount = Properties.Settings.Default.VialCount;
        if (vialsCount < 5)
        {
            vialsCount = 5;
            return;
        }
        if (vialsCount > 25)
        {
            vialsCount = 25;
            return;
        }
        segmentsCount = Properties.Settings.Default.MaxSegments;

        if (segmentsCount < 2)
        {
            segmentsCount = 2;
            return;
        }
        if (segmentsCount > 10)
        {
            segmentsCount = 10;
            return;
        }
        colorTheme = Properties.Settings.Default.ColorTheme;
        if (colorTheme != "Light" && colorTheme != "Dark")
        {
            colorTheme = "Light"; // Default to Light if invalid
        }

        this.difficulty = 1;
        string difficultySettings = Properties.Settings.Default.Difficulty;
        if (difficultySettings == "Easy")
            this.difficulty = 1;
        if (difficultySettings == "Medium")
            this.difficulty = 2;
        if (difficultySettings == "Hard")
            this.difficulty = 3;
        startingEmptyVials = 4 - difficulty;
        undosLeft = 4 - difficulty;
        undosLeft = 4 - difficulty;
    }

    public void RefreshNumberOfVials()
    {
        vials.Clear();
        ClearVialTable();
        vialTableRowsCount = (vialsCount - 1) / 7 + 1;
        if (vialTableRowsCount > 1)
        {
            vialTableColumnsCount = 7;
        }
        else
        {
            vialTableColumnsCount = vialsCount;
        }
        vialsLayoutPanel.RowCount = vialTableRowsCount;
        vialsLayoutPanel.ColumnCount = vialTableColumnsCount;

        for (int i = 0; i < vialTableRowsCount; i++)
        {
            vialsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / vialTableRowsCount));
        }

        for (int j = 0; j < vialTableColumnsCount; j++)
        {
            vialsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / vialTableColumnsCount));
        }


        List<Color> segments = GenerateSegments();
        GenerateTablePanels(segments);
    }
    public void ClearVialTable()
    {
        vialsLayoutPanel.Controls.Clear();
        vialsLayoutPanel.RowStyles.Clear();
        vialsLayoutPanel.ColumnStyles.Clear();
        vialsLayoutPanel.RowCount = 0;
        vialsLayoutPanel.ColumnCount = 0;
    }
    public void updateScore()
    {
        puzzleScore = difficulty * segmentsCount * (vials.Count - startingEmptyVials);
        sessionScore += puzzleScore;
        this.currentScoreLabel.Text = $"Current Score: {sessionScore}";
    }
    private List<Color> GenerateSegments()
    {
        int totalColors = vialsCount - startingEmptyVials;
        Random rand = new Random();
        List<Color> potionColors = GenerateDistinctColors(totalColors, segmentsCount);
        List<Color> segments = new List<Color>();
        // For each color, add it to the segments list 'm' times
        foreach (var color in potionColors)
        {
            for (int i = 0; i < segmentsCount; i++)
            {
                segments.Add(color);
            }
        }

        segments = segments.OrderBy(x => rand.Next()).ToList();
        return segments;
    }
    private void GenerateTablePanels(List<Color> segments)
    {
        int counter = 0;
        for (int row = 0; row < vialTableRowsCount; row++)
        {
            for (int col = 0; col < vialTableColumnsCount; col++)
            {
                if (counter >= vialsCount)
                    continue;

                counter++;
                Panel newPanel = new Panel();
                newPanel.Dock = DockStyle.Fill;
                newPanel.Padding = new Padding(0);
                newPanel.Margin = new Padding(0);
                newPanel.BackColor = Color.Transparent;

                List<Color> vialSegments = new List<Color>();
                if (segments.Count == 0)
                {
                    // Leave this vial empty
                    vialSegments = new List<Color>();
                }
                else
                {
                    // Add segments to the vial from the shuffled list
                    vialSegments.AddRange(segments.Take(segmentsCount));  // Only take the first 'm' segments
                    segments.RemoveRange(0, segmentsCount);  // Remove the added segments from the list
                }

                Vial newVial = new Vial(vialSegments, segmentsCount, this);

                newPanel.Controls.Add(newVial);
                vials.Add(newVial);
                newVial.Dock = DockStyle.Fill;
                newVial.AllowDrop = true;

                vialsLayoutPanel.Controls.Add(newPanel, col, row);
            }
        }
    }

    private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    public List<Color> GenerateDistinctColors(int totalColors, int maxSegments)
    {
        List<Color> colors = new List<Color>();
        Random rand = new Random();

        for (int i = 0; i < totalColors; i++)
        {
            // Calculate a distinct hue value (spread equally around the hue wheel)
            float hue = (i * 360f) / totalColors;  // Spread colors across the hue circle
            float saturation = 0.7f;  // Keep saturation high for vibrant colors
            float value = 0.9f;  // Keep value high for brighter colors

            Color color = ColorFromHSV(hue, saturation, value);
            colors.Add(color);
        }

        return colors;
    }

    public static Color ColorFromHSV(float hue, float saturation, float value)
    {
        int hi = (int)(hue / 60f) % 6;
        float f = hue / 60f - (int)(hue / 60f);
        float p = value * (1f - saturation);
        float q = value * (1f - f * saturation);
        float t = value * (1f - (1f - f) * saturation);

        float r = 0, g = 0, b = 0;

        switch (hi)
        {
            case 0: r = value; g = t; b = p; break;
            case 1: r = q; g = value; b = p; break;
            case 2: r = p; g = value; b = t; break;
            case 3: r = p; g = q; b = value; break;
            case 4: r = t; g = p; b = value; break;
            case 5: r = value; g = p; b = q; break;
        }

        return Color.FromArgb((int)(r * 255), (int)(g * 255), (int)(b * 255));
    }

    private void backgroundTable_Paint(object sender, PaintEventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void openSettingsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SettingsForm settingsForm = new SettingsForm();
        settingsForm.ShowDialog(this);
        if (settingsForm.settingsChanged)
        {
            StartNewGame();
        }
    }
    public void StartNewGame()
    {
        LoadSettings();
        puzzleScore = 0;
        sessionScore = 0;
        currentScoreLabel.Text = $"Current Score: {sessionScore}";
        leftUndosLabel.Text = $"Left: {undosLeft}";
        if (undosLeft <= 0)
        {
            undoButton.Enabled = false;
        }
        else
        {
            undoButton.Enabled = true;
        }
        LoadBestScore();
        ApplyColorTheme();
        RefreshNumberOfVials();
        CheckWinningCondition();
    }

    public void NextPuzzle()
    {
        leftUndosLabel.Text = $"Left: {undosLeft}";
        if (undosLeft <= 0)
        {
            undoButton.Enabled = false;
        }
        else
        {
            undoButton.Enabled = true;
        }
        updateScore();
        ApplyColorTheme();
        RefreshNumberOfVials();
        CheckWinningCondition();
    }

    private void ApplyColorTheme()
    {
        if (colorTheme == "Light")
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

        this.undoButton.BackColor = theme.ButtonBackground;
        this.nextPuzzleButton.BackColor = theme.ButtonBackground;

        // Apply to MenuStrip
        MenuColors customMenuColors = new MenuColors(theme);

        menuStrip1.Renderer = new ToolStripProfessionalRenderer(customMenuColors);

        menuStrip1.BackColor = theme.Background;
        menuStrip1.ForeColor = theme.TextColor;
        foreach (ToolStripMenuItem item in menuStrip1.Items)
        {
            ApplyToolStripMenuItemTheme(item, theme);
        }
    }
    private void ApplyToolStripMenuItemTheme(ToolStripMenuItem item, ColorPreset theme)
    {
        // Set the background and text color for each ToolStripMenuItem
        item.BackColor = theme.Background; // Background color of the menu item
        item.ForeColor = theme.TextColor;   // Text color of the menu item


        foreach (ToolStripMenuItem subItem in item.DropDownItems)
        {
            ApplyToolStripMenuItemTheme(subItem, theme); // Recursive call for submenus
        }

    }

    public void AddLastMoveToStack(Vial source, Vial sink, int pouredColorsNumber)
    {
        PastPour pastPour = new PastPour(source, sink, pouredColorsNumber);
        pastPours.Push(pastPour);
    }

    private void undoButton_Click(object sender, EventArgs e)
    {
        if (pastPours.Count > 0 && undosLeft > 0)
        {
            undosLeft--;
            leftUndosLabel.Text = $"Left: {undosLeft}";
            PastPour lastMove = pastPours.Pop();
            Vial sourceVial = lastMove.source;
            Vial sinkVial = lastMove.sink;
            int pouredColorsNumber = lastMove.pouredColorsNumber;

            for (int i = 0; i < pouredColorsNumber; i++)
            {
                if (sinkVial.segments.Count > 0)
                {
                    Color colorToMove = sinkVial.segments.Last();
                    sinkVial.segments.RemoveAt(sinkVial.segments.Count - 1);
                    sourceVial.segments.Add(colorToMove);
                }
            }
            sourceVial.Invalidate();
            sinkVial.Invalidate();

            if (undosLeft <= 0)
            {
                undoButton.Enabled = false;
            }
        }
    }

    public void CheckWinningCondition()
    {
        bool allVialsMatchColor = true;
        foreach (var vial in vials)
        {
            if (vial.segments.Count > 0)
            {
                Color firstColor = vial.segments[0];
                foreach (var segment in vial.segments)
                {
                    if (segment != firstColor) // If any segment doesn't match the first color, it's not a valid win
                    {
                        allVialsMatchColor = false;
                        break;
                    }
                }
            }
        }

        // Step 2: Check if the number of empty vials matches the starting empty vials count
        int emptyVialsCount = vials.Count(vial => vial.segments.Count == 0);
        bool correctEmptyVialsCount = emptyVialsCount == startingEmptyVials;


        if (allVialsMatchColor && correctEmptyVialsCount)
        {
            nextPuzzleButton.Enabled = true;
            congratulationsLabel.Visible = true;
            undoButton.Enabled = false;
        }
        else
        {
            undoButton.Enabled = true;
            nextPuzzleButton.Enabled = false;
            congratulationsLabel.Visible = false;
        }
    }

    private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
    {
        StartNewGame();
    }

    private void EndGameToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SaveBestScore();
        StartNewGame();
    }

    private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
    {
        // Ask the user to confirm if they want to exit
        DialogResult result = MessageBox.Show("Are you sure you want to exit the game?",
                                              "Exit Game",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

        // If the user clicks "Yes", exit the application
        if (result == DialogResult.Yes)
        {
            Application.Exit();  // Exits the application
        }
    }

    private void nextPuzzleButton_Click(object sender, EventArgs e)
    {
        NextPuzzle();
    }

    private void congratulationsLabel_Click(object sender, EventArgs e)
    {

    }

    private void nextPuzzleButton_Paint(object sender, PaintEventArgs e)
    {

    }
}
