using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeSettings;

namespace TicTacToeField
{
    class Field
    {
        private int _rows;
        private int _columns;
        public int[,] Markers;
        public Field(Settings _settings)
        {
            _rows = _settings.Rows;
            _columns = _settings.Columns;
            Markers = new int[_rows, _columns];
        }
        public int[,] GetMarkers()
        {
            return Markers;
        }
        public void SetMarker(int y, int x, int marker)
        {
            Markers[y, x] = marker;
        }
    }
}
