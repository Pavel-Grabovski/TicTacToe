using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeField;
using TicTacToeView;
using TicTacToeSettings;
using TicTacToeCell;
using TicTacToePlayer;
using System.Diagnostics;
using TicTacToeSetting;
using TicTacToe;

namespace TicTacToeGame
{
    class Game
    {
        static Settings _settings;
        private Field _field;
        public GameWindow _view;

        static public Player Player_1;
        static public Player Player_2;

        int _moveCount;

        public Game(Settings settings, GameWindow gameWindow, Field field, int totalPlayer1, int totalPlayer2)
        {
            _settings = settings;
            _view = gameWindow;
            _field = field;
            Player_1 = new Player("Анатолий", global::TicTacToe.Properties.Resources.Blue_ball, System.Drawing.Color.Blue);
            Player_2 = new Player("Алексей", global::TicTacToe.Properties.Resources.Red_ball, System.Drawing.Color.Red);
            _moveCount = _settings.Rows * _settings.Columns;

            Player_1.Total += totalPlayer1;
            Player_2.Total += totalPlayer2;

            _viewInitialize();
        }

        private void _viewInitialize()
        {
            _view.SetMoveCounter(_moveCount);
            _view.SetTotalPlayer1(Player_1.Total);
            _view.SetTotalPlayer2(Player_2.Total);
            foreach (Cell cell in _view._cells)
            {
                cell.CellClick += new EventHandler(_mouse_button_down);
            }
            _view.NewGame += _nextGame;
            _view.SettingsGame += _settingsGame;
        }

        private void _mouse_button_down(object sender, EventArgs e) /// Потом метод надо будет переменовать
        {
            Cell cell = (Cell)sender;
            if(!cell.IsChecked)
            {
                Player AktivеPlayer = null;
                int Marker = 0;
                if (_moveCount % 2 == 0)
                {
                    AktivеPlayer = Player_1;
                    Marker = 1;
                }
                else if(_moveCount % 2 == 1)
                {
                    AktivеPlayer = Player_2;
                    Marker = -1;
                }
                _moveCount--;
                cell.IsChecked = true;
                _view.SetMoveCounter(_moveCount);

                cell.SetImage(AktivеPlayer.Symbol);
                _field.SetMarker(cell.Y, cell.X, Marker);


                List<Cell> _cellsPaint = new List<Cell>();
                int _countIdenticalCells = 0;
                if (_checkVictoryHorizontalMarkers(AktivеPlayer, Marker, cell, _cellsPaint))
                {
                    _countIdenticalCells++;
                }
                if(_checkVictoryTopLeftToDownRightMarkers(AktivеPlayer, Marker, cell, _cellsPaint))
                {
                    _countIdenticalCells++;
                }
                if (_checkVictoryVerticalMarkers(AktivеPlayer, Marker, cell, _cellsPaint))
                {
                    _countIdenticalCells++;
                }
                if (_checkVictoryTopRightToDownLeftMarkers(AktivеPlayer, Marker, cell, _cellsPaint))
                {
                    _countIdenticalCells++;
                }


                if(_countIdenticalCells > 0)
                {
                    _awardVictory(AktivеPlayer, _countIdenticalCells, _cellsPaint);
                    EndRoundWindow _endRoundView = new EndRoundWindow(_settings, AktivеPlayer, _countIdenticalCells);
                    _endRoundView.EndGame += new EventHandler(_endGame);
                    _endRoundView.NextRound += new EventHandler(_nextGame);
                    _endRoundView.ShowDialog();
                }
            }
            if (_moveCount == 0)
            {
                EndRoundWindow _endRoundView = new EndRoundWindow(_settings);
                _endRoundView.EndGame += new EventHandler(_endGame);
                _endRoundView.NextRound += new EventHandler(_nextGame);
                _endRoundView.ShowDialog();
            }
        }

        #region Проверка победы
        /*
        Проверка экземпляра _field, свойство Markers (цифровой массив значений маркеров игроков)
        идет по 4-м направлениям и в ответ получаем true - приносит победу или false - не приносит победу:
        1) _checkVictoryHorizontalMarkers - проверяем маркеры в горизонтальном направление.
        2) _checkVictoryTopLeftToDownRightMarkers - проверяем маркеры в диагональном направление СверхуСлева в ВнизВправо.
        3) _checkVictoryVerticalMarkers - проверяем маркеры в вертикальном направление.
        4) _checkVictoryTopRightToDownLeftMarkers - проверяем маркеры в диагональном направление СправаСверху в ВнизВлево.
        */
        private bool _checkVictoryHorizontalMarkers(Player aktivеPlayer, int marker, Cell cell, List<Cell> cellsPaint)
        {/*
         * Данный метод проверяет, есть ли 5 одинаковых клеток подряд в горизонтальном ряду,
         * сначал осмотрит на лево, ищет одинаковые клетки, и оттуда начинает отсчет на право, если набирается 5 и
         * более одинаковых маркеров, то метод выдает true.
         */
            int LengthIdenticalCells = 1;
            int _x = cell.X;
            int _y = cell.Y;
            List<Cell> _cellsIdentical = new List<Cell>();
            while ( !_isLeftBorder(_x, _y) && _IsMoveOn(_x - 1, _y, marker))
            {
                _x--;
            }
            cellsPaint.Add(_view._cells[_y, _x]);
            while ( !_isRightBorder(_x, _y) && _IsMoveOn(_x + 1, _y, marker))
            {
                _x++;
                _cellsIdentical.Add(_view._cells[_y, _x]);
                LengthIdenticalCells++ ;
            }
            if(LengthIdenticalCells >= 5)
            {
                additionList(cellsPaint, _cellsIdentical);
                return true;
            }
            else
            {
                _listClear(_cellsIdentical);
                return false;
            }
        }
        private bool _checkVictoryTopLeftToDownRightMarkers(Player aktivеPlayer, int marker, Cell cell, List<Cell> cellsPaint)
        {
         /* 
         * Данный метод проверяет, есть ли 5 одинаковых клеток подряд в диагональном ряду,
         * сначал осмотрит в верх и влево, ищет одинаковые клетки, и оттуда начинает отсчет вниз и вправо, если набирается 5 и
         * более одинаковых маркеров, то метод выдает true.
         */
            int LengthIdenticalCells = 1;
            int _x = cell.X;
            int _y = cell.Y;
            List<Cell> _cellsIdentical = new List<Cell>();
            while (!_isLeftBorder(_x, _y) && !_isUpBorder(_x, _y) && _IsMoveOn(_x - 1 , _y - 1, marker))
            {
                _x--;
                _y--;
            }
            cellsPaint.Add(_view._cells[_y, _x]);
            while (!_isRightBorder(_x, _y) && !_isLowerBorder(_x, _y) && _IsMoveOn(_x + 1, _y + 1, marker))
            {
                _x++;
                _y++;
                cellsPaint.Add(_view._cells[_y, _x]);
                LengthIdenticalCells++;
            }
            if (LengthIdenticalCells >= 5)
            {
                additionList(cellsPaint, _cellsIdentical);
                return true;
            }
            else
            {
                _listClear(_cellsIdentical);
                return false;
            }
        }
        private bool _checkVictoryVerticalMarkers(Player aktivеPlayer, int marker, Cell cell, List<Cell> cellsPaint)
        {
         /*
         * Данный метод проверяет, есть ли 5 одинаковых клеток подряд в вертикальном ряду,
         * сначал осмотрит в верх, ищет одинаковые клетки, и оттуда начинает отсчет вниз, если набирается 5 и
         * более одинаковых маркеров, то метод выдает true.
         */
            int LengthIdenticalCells = 1;
            int _x = cell.X;
            int _y = cell.Y;
            List<Cell> _cellsIdentical = new List<Cell>();
            while (!_isUpBorder(_x, _y) && _IsMoveOn(_x, _y - 1, marker))
            {
                _y--;
            }
            cellsPaint.Add(_view._cells[_y, _x]);
            while (!_isLowerBorder(_x, _y) && _IsMoveOn(_x, _y + 1, marker))
            {
                _y++;
                cellsPaint.Add(_view._cells[_y, _x]);
                LengthIdenticalCells++;
            }
            if (LengthIdenticalCells >= 5)
            {
                additionList(cellsPaint, _cellsIdentical);
                return true;
            }
            else
            {
                _listClear(_cellsIdentical);
                return false;
            }
        }
        private bool _checkVictoryTopRightToDownLeftMarkers(Player aktivеPlayer, int marker, Cell cell, List<Cell> cellsPaint)
        {
            /* 
            * Данный метод проверяет, есть ли 5 одинаковых клеток подряд в диагональном ряду,
            * сначал осмотрит в верх и вправо, ищет одинаковые клетки, и оттуда начинает отсчет вниз и влево, если набирается 5 и
            * более одинаковых маркеров, то метод выдает true.
            */
            int LengthIdenticalCells = 1;
            int _x = cell.X;
            int _y = cell.Y;
            List<Cell> _cellsIdentical = new List<Cell>();
            while (!_isRightBorder(_x, _y) && !_isUpBorder(_x, _y) && _IsMoveOn(_x + 1, _y - 1, marker))
            {
                _x++;
                _y--;
            }
            cellsPaint.Add(_view._cells[_y, _x]);
            while (!_isLeftBorder(_x, _y) && !_isLowerBorder(_x, _y) && _IsMoveOn(_x - 1, _y + 1, marker))
            {
                _x--;
                _y++;
                cellsPaint.Add(_view._cells[_y, _x]);
                LengthIdenticalCells++;
            }
            if (LengthIdenticalCells >= 5)
            {
                additionList(cellsPaint, _cellsIdentical);
                return true;
            }
            else
            {
                _listClear(_cellsIdentical);
                return false;
            }
        }
        #endregion
        private void _awardVictory(Player aktivеPlayer, int total, List<Cell> _cellsPaint)
        {
            _cellsPaintColorVictory(aktivеPlayer, _cellsPaint);
            foreach (Cell cell in _view._cells)
            {
                cell.IsChecked = true;
            }
            aktivеPlayer.AddTotal(total);
            if(aktivеPlayer == Player_1)
            {
                _view.SetTotalPlayer1(aktivеPlayer.Total);
            }
            else if(aktivеPlayer == Player_2)
            {
                _view.SetTotalPlayer2(aktivеPlayer.Total);
            }
        }

        #region Проверка границ
        private bool _isLeftBorder(int x, int y)
        {
            if(x < 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool _isRightBorder(int x, int y)
        {
            if(x == _settings.Columns - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool _isUpBorder(int x, int y)
        {
            if (y == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool _isLowerBorder(int x, int y)
        {
            if (y == _settings.Rows - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion


        private bool _IsMoveOn(int x, int y, int marker)
        {
            if(_field.Markers[y, x] == marker)
            {
                return true;
            }
            return false;
        }
        private void _listClear(List<Cell> cellsDetete)
        {
            while(cellsDetete.Count > 0)
            {
                cellsDetete.RemoveAt(cellsDetete.Count - 1);
            }
        }
        private void _cellsPaintColorVictory(Player aktivеPlayer, List<Cell> cellsPaint)
        {
            foreach (Cell cell in cellsPaint)
            {
                cell.BackColor = aktivеPlayer.Colour;
            }
        }
        private List<Cell> additionList(List<Cell> sourceListCell, List<Cell> addedListCell)
        {
            foreach(Cell cell in addedListCell)
            {
                sourceListCell.Add(cell);
            }
            return sourceListCell;
        }


        private void _endGame(object sender, EventArgs e)
        {
            _view.Close();
        }
        private void _nextGame(object sender, EventArgs e)
        {
            _view.Hide();
            Settings settings = new Settings();
            GameWindow newView = new GameWindow(settings);
            Field field = new Field(settings);
            Game game = new Game(settings, newView, field, Player_1.Total, Player_2.Total);
            newView.ShowDialog();
            _view.Close();
        }
        private void _settingsGame(object sender, EventArgs e)
        {
            // ЕСТЬ ОКНО НАСТРОЕК, ПОТОМ У НЕМУ СДЕЛАЮ model и presenter

            SettingWindow settingWindow = new SettingWindow(_settings, _view);
            settingWindow.ShowDialog();
        }
    }
}
