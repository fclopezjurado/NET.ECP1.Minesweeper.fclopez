using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Minesweeper.Models;

namespace Minesweeper.Views
{
    public partial class MainForm : Form
    {
        private Board board;
        private Button[,] buttons;
        private List<Image> buttonsImages;
        private int buttonRows;
        private int buttonColumns;
        private int bombsPercentage;
        private int clicks;
        public minesweeperEntities databaseConnection;
        private string playerName;
        private System.Diagnostics.Stopwatch watch;

        private const string GAME_OVER      = "GAME OVER";
        private const string PLAYER_WINS    = "PLAYER WINS";

        public MainForm(string playerName, int buttonRows, int buttonColumns, int bombsPercentage, int formWidth, 
            int formHeight)
        {
            InitializeComponent();

            this.buttonRows                     = buttonRows;
            this.buttonColumns                  = buttonColumns;
            this.bombsPercentage                = bombsPercentage;
            this.board                          = new Board(buttonRows, buttonColumns, bombsPercentage);
            this.tableLayoutPanel1.RowCount     = buttonRows;
            this.tableLayoutPanel1.ColumnCount  = buttonColumns;
            this.buttons                        = new Button[buttonRows, buttonColumns];
            this.buttonsImages                  = new List<Image>();
            this.databaseConnection             = new minesweeperEntities();
            this.playerName                     = playerName;
            this.watch                          = System.Diagnostics.Stopwatch.StartNew();
            this.clicks                         = 0;

            for (int row = 0; row < this.buttonRows; row++)
                for (int column = 0; column < this.buttonColumns; column++)
                {
                    this.buttons[row, column]           = new MyButton(row, column);
                    this.buttons[row, column].AutoSize  = true;
                    this.buttons[row, column].Click     += new EventHandler(this.CellOnClick);

                    this.tableLayoutPanel1.Controls.Add(this.buttons[row, column]);
                }

            this.Location   = new System.Drawing.Point(10, 10);
            this.ClientSize = new System.Drawing.Size(formWidth, formHeight);

            SetButtonsImages();
            UpdateUI();
        }

        private void SetButtonsImages()
        {
            this.buttonsImages.Add(Minesweeper.Properties.Resources._0);
            this.buttonsImages.Add(Minesweeper.Properties.Resources._1);
            this.buttonsImages.Add(Minesweeper.Properties.Resources._2);
            this.buttonsImages.Add(Minesweeper.Properties.Resources._3);
            this.buttonsImages.Add(Minesweeper.Properties.Resources._4);
            this.buttonsImages.Add(Minesweeper.Properties.Resources._5);
            this.buttonsImages.Add(Minesweeper.Properties.Resources._6);
            this.buttonsImages.Add(Minesweeper.Properties.Resources._7);
            this.buttonsImages.Add(Minesweeper.Properties.Resources._8);
            this.buttonsImages.Add(Minesweeper.Properties.Resources._9);
        }

        private void CellOnClick(object sender, EventArgs e)
        {
            this.clicks++;

            bool cellWasUpturned = this.board.UpturnCell(((MyButton)sender).row + 1, ((MyButton)sender).column + 1);

            if (cellWasUpturned)
                this.UpdateUI();

            if (!cellWasUpturned || (cellWasUpturned && this.board.AllBombsAreFound()))
            {
                this.board.UpturnAllCells();
                this.UpdateUI();
                this.DisableAllButtons();

                if (!cellWasUpturned)
                    this.GameOver();
                else
                    this.PlayerWins();
            }
        }

        private void UpdateUI()
        {
            for (int row = 1; row <= this.buttonRows; row++)
                for (int column = 1; column <= this.buttonColumns; column++)
                {
                    string cellValue = this.board.CellValue(row, column);

                    if (cellValue == Cell.HIDDEN)
                        this.buttons[row - 1, column - 1].Image = Minesweeper.Properties.Resources.hidden;
                    else if (cellValue == Cell.BOMB)
                        this.buttons[row - 1, column - 1].Image = Minesweeper.Properties.Resources.bomb;
                    else
                    {
                        int cellNumber                              = Int16.Parse(cellValue);
                        this.buttons[row - 1, column - 1].Image     = this.buttonsImages[cellNumber];
                        this.buttons[row - 1, column - 1].Enabled   = false;
                    }
                }
        }

        private void DisableAllButtons()
        {
            for (int row = 0; row < this.buttonRows; row++)
                for (int column = 0; column < this.buttonColumns; column++)
                    if (this.buttons[row, column].Enabled)
                        this.buttons[row, column].Enabled = false;
        }

        private void GameOver()
        {
            MessageBox.Show(GAME_OVER);
        }

        private void PlayerWins()
        {
            this.watch.Stop();
            MessageBox.Show(PLAYER_WINS);
            
            TimeSpan timeSpan       = TimeSpan.FromMilliseconds(this.watch.ElapsedMilliseconds);
            Score score             = new Score();
            score.player            = this.playerName;
            score.rows              = this.buttonRows;
            score.columns           = this.buttonColumns;
            score.bombs_percentage  = this.bombsPercentage;
            score.seconds           = Int16.Parse(string.Format("{0:D2}", timeSpan.Seconds));
            score.clicks            = this.clicks;

            this.databaseConnection.Scores.Add(score);
            this.databaseConnection.SaveChanges();
        }
    }
}
