using System;

using System.Windows.Forms;
using TicTacToeGame;
using TicTacToeField;
using TicTacToeSettings;

namespace TicTacToeView
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Settings settings = new Settings();

            GameWindow view = new GameWindow(settings);
            Field field = new Field(settings);
            Game game = new Game(settings, view, field, 0, 0);

            Application.Run(view);
        }
    }
}
