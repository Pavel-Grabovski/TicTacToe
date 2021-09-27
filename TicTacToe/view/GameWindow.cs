using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TicTacToeCell;
using TicTacToePlayer;
using TicTacToeSettings;

namespace TicTacToeView
{

    public partial class GameWindow : Form
    {
        public event EventHandler SettingsGame;
        public event EventHandler NewGame;

        private string PlayerName1;
        private Color PlayerColor1;
        public Image PlayerSymbol1;

        private string PlayerName2;
        private Color PlayerColor2;
        public Image PlayerSymbol2;

        // Максимум клеток
        public int Rows { get; }
        public int Columns { get; }
        private int SizeCell;
        public Cell[,] _cells;

        public Color ButtonsColor;
        public Color FieldColor;

        Settings _settings;
        private int _InformationTableHeight { get; set; }

        public GameWindow(Settings settings)
        {
            InitializeComponent();
            this.Rows = settings.Rows;
            this.Columns = settings.Columns;
            this.SizeCell = settings.SizeCell;

            _cells = new Cell[Rows, Columns];

            this.BackColor = settings.BackColor;
            _settings = settings;

            this.PlayerName1 = settings.PlayerFirstName;
            this.PlayerColor1 = settings.PlayerFirstColor;
            this.PlayerSymbol1 = new Bitmap(settings.PlayerFirstImage, Math.Min(50, 2 * SizeCell), Math.Min(50, 2 * SizeCell));

            this.PlayerName2 = settings.PlayerSecondName;
            this.PlayerColor2 = settings.PlayerSecondColor;
            this.PlayerSymbol2 = new Bitmap(settings.PlayerSecondImage, Math.Min(50, 2* SizeCell), Math.Min(50, 2 * SizeCell)); 

            _InformationTableHeight = this.Columns < 34 ? 100 : 50;

            this._createButtons();
            this._createHeadingColumnAndRows();
            this._adaptationInformationTable();

            MenuNewGame.Click += _newGame_Click;
            _settingsItem.Click += _settingsGame_Click;
        }

        #region Проброс событий
        private void _newGame_Click(object sender, EventArgs e)
        {
            if (NewGame != null)
            {
                NewGame(this, EventArgs.Empty);
            }
        }

        private void _settingsGame_Click(object sender, EventArgs e)
        {
            if (SettingsGame != null)
            {
                SettingsGame(this, EventArgs.Empty);
            }
        }
        #endregion
        private void _adaptationInformationTable()
        {
            this.ClientSize = new System.Drawing.Size((Columns + 1) * SizeCell, _InformationTableHeight + this._menuStrip.Size.Height + (Rows + 1) * SizeCell); // Корректировка размеров окна

            this._namePlayer1.Text = PlayerName1;
            this._namePlayer1.ForeColor = PlayerColor1;
            this._timerPlayer1.ForeColor = PlayerColor1;
            this._totalPlayer1.ForeColor = PlayerColor1;
            this._symbolPlayer1.Image = PlayerSymbol1;

            this._namePlayer2.Text = PlayerName2;
            this._namePlayer2.ForeColor = PlayerColor2;
            this._timerPlayer2.ForeColor = PlayerColor2;
            this._totalPlayer2.ForeColor = PlayerColor2;
            this._symbolPlayer2.Image = PlayerSymbol2;

            this.InformationTable.Size = new Size(Rows * SizeCell, this._InformationTableHeight + this._menuStrip.Size.Height);
            this.InformationTable.BackColor = this.FieldColor;
            this._menuStrip.BackColor = this.FieldColor;

            this._vs.Size = new Size((this.Columns + 1) % 2 == 0 ? 2 * SizeCell : 3 * SizeCell, _InformationTableHeight / 2);
            this._vs.Location = new Point((this.Columns + 1) * SizeCell / 2 - _vs.Size.Width / 2, this._menuStrip.Size.Height);

            this._gameMoves.Size = new Size((this.Columns + 1) % 2 == 0 ? 2 * SizeCell : 3 * SizeCell, this._InformationTableHeight / 2);
            this._gameMoves.Location = new Point((this.Columns + 1) * SizeCell / 2 - _vs.Size.Width / 2, this._vs.Size.Height + this._menuStrip.Size.Height);

            this._totalPlayer1.Size = new Size(SizeCell * 2, 50);
            this._totalPlayer1.Location = new Point((this.Columns + 1) * SizeCell / 2 - _vs.Size.Width / 2 - this._totalPlayer1.Size.Width,
                this.Columns < 34 ? this._InformationTableHeight / 2 + this._menuStrip.Size.Height : this._menuStrip.Size.Height);

            this._totalPlayer2.Size = new Size(SizeCell * 2, 50);
            this._totalPlayer2.Location = new Point((this.Columns + 1) * SizeCell / 2 - _vs.Size.Width / 2 + _vs.Size.Width,
                this.Columns < 34 ? this._InformationTableHeight / 2 + this._menuStrip.Size.Height : this._menuStrip.Size.Height);


            this._timerPlayer1.Size = new Size(SizeCell * 3, 50);
            this._timerPlayer1.Location = new Point(
                (this.Columns + 1) * SizeCell / 2 - _vs.Size.Width / 2 - this._totalPlayer1.Size.Width - this._timerPlayer1.Size.Width,
                this.Columns < 34 ? this._InformationTableHeight / 2 + this._menuStrip.Size.Height : this._menuStrip.Size.Height);

            this._timerPlayer2.Size = new Size(SizeCell * 3, 50);
            this._timerPlayer2.Location = new Point(
                (this.Columns + 1) * SizeCell / 2 - _vs.Size.Width / 2 + _vs.Size.Width + this._totalPlayer2.Size.Width,
                this.Columns < 34 ? this._InformationTableHeight / 2 + this._menuStrip.Size.Height : this._menuStrip.Size.Height);

            this._symbolPlayer1.Size = new Size(SizeCell * 3, 50);
            this._symbolPlayer1.Location = new Point(
                (this.Columns + 1) * SizeCell / 2 - _vs.Size.Width / 2 - this._totalPlayer1.Size.Width - this._timerPlayer1.Size.Width - this._symbolPlayer1.Size.Width,
                this.Columns < 34 ? this._InformationTableHeight / 2 + this._menuStrip.Size.Height : this._menuStrip.Size.Height);

            this._symbolPlayer2.Size = new Size(SizeCell * 3, 50);
            this._symbolPlayer2.Location = new Point(
                (this.Columns + 1) * SizeCell / 2 - _vs.Size.Width / 2 + _vs.Size.Width + this._totalPlayer2.Size.Width + this._timerPlayer2.Size.Width,
                this.Columns < 34 ? this._InformationTableHeight / 2 + this._menuStrip.Size.Height : this._menuStrip.Size.Height);

            this._namePlayer1.Size = new Size(SizeCell * 8, 50);

            if (_InformationTableHeight == 100)
            {
                this._namePlayer1.Location = new Point(
                    (this.Columns + 1) * SizeCell / 2 - _vs.Size.Width / 2 - this._namePlayer1.Size.Width,
                    this._menuStrip.Size.Height);
            }
            else
            {
                this._namePlayer1.Location = new Point(
                    (this.Columns + 1) * SizeCell / 2 - _vs.Size.Width / 2 - this._totalPlayer1.Size.Width - this._timerPlayer1.Size.Width - this._symbolPlayer1.Size.Width - this._namePlayer1.Size.Width,
                    this.Columns < 34 ? this._InformationTableHeight / 2 + this._menuStrip.Size.Height : this._menuStrip.Size.Height);
            }


            this._namePlayer2.Size = new Size(SizeCell * 8, 50);
            if (_InformationTableHeight == 100)
            {
                this._namePlayer2.Location = new Point(
                (this.Columns + 1) * SizeCell / 2 - _vs.Size.Width / 2 + _vs.Size.Width,
                this._menuStrip.Size.Height);
            }
            else
            {
                this._namePlayer2.Location = new Point(
                    (this.Columns + 1) * SizeCell / 2 - _vs.Size.Width / 2 + _vs.Size.Width + this._totalPlayer2.Size.Width + this._timerPlayer2.Size.Width + this._symbolPlayer2.Size.Width,
                    this.Columns < 34 ? this._InformationTableHeight / 2 + this._menuStrip.Size.Height : this._menuStrip.Size.Height);
            }
        }
        private void _createHeadingColumnAndRows()
        {
            _createCellHeader("", 0, _InformationTableHeight + this._menuStrip.Size.Height);
            for (int x = 1; x <= Columns; x++)
            {
                _createCellHeader(Convert.ToString(x), x * SizeCell, _InformationTableHeight + this._menuStrip.Size.Height);
            }
            for (int y = 1; y <= Rows; y++)
            {
                _createCellHeader(Convert.ToString(y), 0, _InformationTableHeight + this._menuStrip.Size.Height + y * SizeCell);
            }
        }
        private void _createCellHeader(string headerValue, int x, int y)
        {
            Label _frameWithNumber = new Label();
            _frameWithNumber.Size = new Size(SizeCell, SizeCell);
            _frameWithNumber.Font = new Font(_frameWithNumber.Font, FontStyle.Bold);
            _frameWithNumber.Text = headerValue;
            _frameWithNumber.Location = new Point(x, y);
            _frameWithNumber.BorderStyle = BorderStyle.FixedSingle;
            _frameWithNumber.TextAlign = ContentAlignment.MiddleCenter;
            _frameWithNumber.Cursor = System.Windows.Forms.Cursors.No;
            _frameWithNumber.BackColor = FieldColor;
            Controls.Add(_frameWithNumber);
        }
        private void _createButtons()
        {
            for (int y = 0; y < this.Rows; y++)
            {
                for (int x = 0; x < this.Columns; x++)
                {
                    Cell cell = new Cell(y, x);
                    cell.Size = new Size(SizeCell, SizeCell);
                    cell.Location = new Point(SizeCell + x * SizeCell, _InformationTableHeight + this._menuStrip.Size.Height + SizeCell + y * SizeCell);
                    cell.FlatStyle = FlatStyle.Popup;
                    cell.Cursor = System.Windows.Forms.Cursors.Hand;
                    cell.BackColor = _settings.FieldColor;
                    cell.Click += new EventHandler(cell._butCell_CellClick);
                    Controls.Add(cell);
                    _cells[y, x] = cell;
                }
            }
        }


        public void SetMoveCounter(int count)
        {
            this._gameMoves.Text = Convert.ToString(count);
        }
        public void SetTotalPlayer1(int count)
        {
            this._totalPlayer1.Text = Convert.ToString(count);
        }
        public void SetTotalPlayer2(int count)
        {
            this._totalPlayer2.Text = Convert.ToString(count);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
