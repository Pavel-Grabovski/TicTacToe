using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToePlayer;
using TicTacToeSetting;

namespace TicTacToeSettings
{
    public class Settings
    {
        // Общие настройки
        public Color ButtonsColor;
        public Color FieldColor;
        public Color BackColor;

        // Параметры поля
        public bool MaxSizeField;
        public int Rows;
        public int Columns;
        public int SizeCell;

        // Параметры времени
        public bool TimeDescending;
        public int CountSeconds;

        // Параметры игроков
        // Игрок 1
        public string PlayerFirstName;
        public Color PlayerFirstColor;
        public Image PlayerFirstImage;

        // Игрок 2
        public string PlayerSecondName;
        public Color PlayerSecondColor;
        public Image PlayerSecondImage;

        SettingsModel settingsModel = new SettingsModel();

        public Settings()
        {
            // Общие настройки
            BackColor = System.Drawing.Color.Violet;
            FieldColor = System.Drawing.Color.SkyBlue;
            ButtonsColor = System.Drawing.Color.Aqua;

            // Параметры поля
            MaxSizeField = true;
            Rows = settingsModel.Rows;
            Columns = settingsModel.Columns;
            SizeCell = 40;


            // Параметры времени
            TimeDescending = true;
            CountSeconds = 500;


            // Параметры игроков
            // Игрок 1
            PlayerFirstName = "Анатолий";
            PlayerFirstImage = global::TicTacToe.Properties.Resources.Blue_ball;
            PlayerFirstColor = System.Drawing.Color.Blue;

            // Игрок 2
            PlayerSecondName = "Алексей";
            PlayerSecondImage = global::TicTacToe.Properties.Resources.Red_ball;
            PlayerSecondColor = System.Drawing.Color.Red;
        }
        public void ColorBackgroundNewValueHandler()
        {
            settingsModel.Rows = 11;
            settingsModel.Save();
            MessageBox.Show("Hello Rows.");
        }
        public void ColorFieldNewValueHandler()
        {
            MessageBox.Show("Hello, world.");
        }
        public void ColorButtonsNewValueHandler()
        {
            MessageBox.Show("Hello, world.");
        }
    }
}
