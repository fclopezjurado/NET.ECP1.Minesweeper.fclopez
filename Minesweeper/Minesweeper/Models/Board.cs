using System;

namespace Minesweeper.Models
{
    class Board
    {
        private Cell[,] cells;

        private int rows;
        private int columns;

        const int MAX_RANDOM_INT = 100;

        public Board(int rows, int columns, int bombsPercentage)
        {
            this.rows       = rows + 2;
            this.columns    = columns + 2;
            this.cells      = new Cell[this.rows, this.columns];

            for (int row = 0; row < this.rows; row++)
                for (int column = 0; column < this.columns; column++)
                    this.cells[row, column] = new Cell();

            InitBoard(bombsPercentage);
        }

        private void InitBoard(int bombsPercentage)
        {
            Random random = new Random();

            for (int row = 1; row < this.rows - 1; row++)
                for (int column = 1; column < this.columns - 1; column++)
                {                    
                    int value = random.Next(MAX_RANDOM_INT);

                    if (value < bombsPercentage)
                    {
                        this.cells[row, column].SetBomb();
                        AddOneAroundBomb(row, column);
                    }
                }

            SetBoardBorder();
        }

        private void AddOneAroundBomb(int bombRow, int bombColumn)
        {
            for (int row = (bombRow - 1); row <= (bombRow + 1); row++)
                for (int column = (bombColumn - 1); column <= (bombColumn + 1); column++)
                    this.cells[row, column].AddOne();
        }

        private void SetBoardBorder()
        {
            for (int row = 0; row < this.rows; row++)
            {
                this.cells[row, 0].AddOne();
                this.cells[row, this.columns - 1].AddOne();
            }

            for (int column = 0; column < this.columns; column++)
            {
                this.cells[0, column].AddOne();
                this.cells[this.rows - 1, column].AddOne();
            }
        }

        public void Print()
        {
            for (int row = 1; row < this.rows - 1; row++)
            {
                for (int column = 1; column < this.columns - 1; column++) 
                    Console.Write(this.cells[row, column]);

                Console.WriteLine();
            }
        }

        public bool UpturnCell(int cellRow, int cellColumn)
        {
            this.cells[cellRow, cellColumn].Upturn();

            if (this.cells[cellRow, cellColumn].IsBomb())
                return false;

            if (this.cells[cellRow, cellColumn].IsEmpty())
                for (int row = (cellRow - 1); row <= (cellRow + 1); row++)
                    for (int column = (cellColumn - 1); column <= (cellColumn + 1); column++)
                        if (this.cells[row, column].IsHidden())
                            this.UpturnCell(row, column);

            return true;
        }

        public void UpturnAllCells()
        {
            for (int row = 0; row < this.rows; row++)
                for (int column = 0; column < this.columns; column++)
                    if (this.cells[row, column].IsHidden())
                        this.UpturnCell(row, column);
        }

        internal string CellValue(int row, int column)
        {
            return this.cells[row, column].ToString();
        }

        public bool AllBombsAreFound()
        {
            for (int row = 1; row < this.rows - 1; row++)
                for (int column = 1; column < this.columns - 1; column++)
                    if (!this.cells[row, column].IsBomb() /*&& !this.cells[row, column].IsEmpty()*/
                        && this.cells[row, column].IsHidden())
                        return false;

            return true;
        }
    }
}
