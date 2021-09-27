using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToePlayer
{
    public class Player
    {
        public string Name;
        public Image Symbol;
        public Color Colour;

        public int Total;

        public Player(string name, Image symbol, Color colour)
        {
            Name = name;
            Symbol = symbol;
            Colour = colour;
        }
        public void AddTotal(int total)
        {
            Total += total;
        }
    }
}
