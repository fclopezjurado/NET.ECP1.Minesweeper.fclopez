namespace Minesweeper.Models
{
    class Cell
    {
        private bool hidden;
        private bool isBomb;
        private int value;

        public const string BOMB = "B";
        public const string HIDDEN = "X";

        public Cell()
        {
            this.hidden = true;
            this.isBomb = false;
            this.value  = 0;
        }

        public override string ToString()
        {
            if (hidden)
                return HIDDEN;
            else if (this.isBomb)
                return BOMB;
            else
                return this.value.ToString();
        }

        public void Upturn()
        {
            this.hidden = false;
        }

        public void SetBomb()
        {
            this.isBomb = true;
        }

        public void AddOne()
        {
            this.value++;
        }

        internal bool IsBomb()
        {
            return this.isBomb;
        }

        internal bool IsEmpty()
        {
            return (this.value == 0);
        }

        internal bool IsHidden()
        {
            return (this.hidden == true);
        }
    }
}
