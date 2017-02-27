using System;
using System.Windows.Forms;
using Minesweeper.Views;

namespace Minesweeper.Main
{
    static class Minesweeper
    {
        private const int BOARD_X           = 5;
        private const int BOARD_Y           = 5;
        private const int BOMBS_PERCENTAGE  = 33;
        private const int FORM_WIDTH        = 640;
        private const int FORM_HEIGHT       = 679;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InitBoard());
        }
    }
}
