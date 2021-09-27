using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeCell
{
    public class Cell: Button
    {
        public int Y;
        public int X;
        public bool IsChecked = false;

        public Cell(int y, int x)
        {
            this.Y = y;
            this.X = x;
        }
        public void SetImage(Image image)
        {
            this.Image = new Bitmap(image, Size);
        }

        public void _butCell_CellClick(object sender, EventArgs e)
        {
            if (CellClick != null) CellClick(this, EventArgs.Empty);
        }

        public event EventHandler CellClick;


    }
}
