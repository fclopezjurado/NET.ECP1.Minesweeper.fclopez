using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper.Views
{
    public partial class ShowScores : Form
    {
        public ShowScores()
        {
            InitializeComponent();
        }

        private void ShowScores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'minesweeperDataSet.Score' Puede moverla o quitarla según sea necesario.
            this.scoreTableAdapter.Fill(this.minesweeperDataSet.Score);

        }
    }
}
