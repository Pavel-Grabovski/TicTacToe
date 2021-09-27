using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeSettings;
using TicTacToePlayer;


namespace TicTacToeView
{
    /*public interface IEndRoundWindow
    {
        event EventHandler EndGame;
        //event EventHandler NextRound;
    }*/



    public partial class EndRoundWindow : Form
    {
        public event EventHandler EndGame;
        public event EventHandler NextRound;
        public EndRoundWindow(Settings settings, Player player, int total)
        {
            InitializeComponent();
            _symbolVictory.Image = new Bitmap(player.Symbol, 150, 150);

            _nameVictory.Text = player.Name;
            _nameVictory.ForeColor = player.Colour;

            _score.Text = "+" + Convert.ToString(total);
            _score.ForeColor = player.Colour;

            this.BackColor = settings.BackColor;
            this._endGameButton.BackColor = settings.ButtonsColor;
            this._nextRoundButton.BackColor = settings.ButtonsColor;

            _endGameButton.Click += _endGameButton_Click;
            _nextRoundButton.Click += _nextGameButton_Click;
        }

        public EndRoundWindow(Settings settings)
        {
            InitializeComponent();
            _nameVictory.Text = "Дружба";
        }

        #region Проброс событий
        private void _endGameButton_Click(object sender, EventArgs e)
        {
            if (EndGame != null)
            {
                this.Close();
                EndGame(this, EventArgs.Empty);
            }
        }
        private void _nextGameButton_Click(object sender, EventArgs e)
        {
            if (NextRound != null)
            {
                this.Hide();
                this.Close();
                NextRound(this, EventArgs.Empty);
            }
        }
        #endregion 


    }
}
