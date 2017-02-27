using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Minesweeper.Views
{
    public partial class InitBoard : Form
    {
        private List<int> formWidth;
        private List<int> formHeight;

        private const int widthForThreeRows     = 400;
        private const int widthForFourRows      = 510;
        private const int widthForFiveRows      = 640;
        private const int heightForThreeColumns = 439;
        private const int heightForFourColumns  = 559;
        private const int heightForFivesColumns = 679;

        private const string EMPTY_PLAYER_NAME = "Player name cannot be empty";

        public InitBoard()
        {
            InitializeComponent();

            this.formWidth          = new List<int>();
            this.formHeight         = new List<int>();
            this.button1.Click      += new EventHandler(this.ClickToPlay);

            this.formWidth.Add(widthForThreeRows);
            this.formWidth.Add(widthForFourRows);
            this.formWidth.Add(widthForFiveRows);
            this.formHeight.Add(heightForThreeColumns);
            this.formHeight.Add(heightForFourColumns);
            this.formHeight.Add(heightForFivesColumns);
        }

        private void ClickToPlay(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBox1.Text))
                MessageBox.Show(EMPTY_PLAYER_NAME);
            else
            {
                string playerName   = this.textBox1.Text;
                int formRows        = Decimal.ToInt16(this.numericUpDown1.Value);
                int formColumns     = Decimal.ToInt16(this.numericUpDown2.Value);
                int formWidth       = this.formWidth[formColumns - 3];
                int formHeight      = this.formHeight[formRows - 3];
                int bombsPercentage = Decimal.ToInt16(this.numericUpDown3.Value);
                Form mainForm       = new MainForm(playerName, formRows, formColumns, bombsPercentage, formWidth, 
                    formHeight);

                mainForm.Show();
            }
        }

        private void ClickToShowScores(object sender, EventArgs e)
        {
            ShowScores formToShowScores = new ShowScores();
            formToShowScores.Show();
        }
    }
}
