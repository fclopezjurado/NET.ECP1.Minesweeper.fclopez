using System.Windows.Forms;

namespace Minesweeper.Views
{
    class MyButton : Button
    {
        public int row;
        public int column;

        public MyButton(int row, int column) : base() 
        {
            this.row    = row;
            this.column = column;
        }
    }
}
