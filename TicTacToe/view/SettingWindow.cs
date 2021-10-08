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
using TicTacToeView;

namespace TicTacToeSettings
{
    public partial class SettingWindow : Form
    {

        public event EventHandler NewColorBackground;
        public event EventHandler NewColorField;
        public event EventHandler NewColorButtons;


        public SettingWindow()
        {
            InitializeComponent();
            //_readActiveSettings();
        }

        /*private void _readActiveSettings()
        {
            // Общие настройки
            this.lblColorBackgroundValue.BackColor = _settings.BackColor;
            this.lblColorCellValue.BackColor = _settings.FieldColor;
            this.lblColorButtonValue.BackColor = _settings.ButtonsColor;

            // Параметры поля
            this.сheckBoxFullFieldValue.Checked = _settings.MaxSizeField;
            this.lblHeightFieldValue.Text = Convert.ToString(_settings.Rows);
            this.lblWidthFieldValue.Text = Convert.ToString(_settings.Columns);
            this.lblSizeCellValue.Text = Convert.ToString(_settings.SizeCell);

            // Параметры времени
            this.checkBoxTimeDescendingVavue.Checked = _settings.TimeDescending;
            this.lblCountSecondsValue.Text = Convert.ToString(_settings.CountSeconds);

            // Параметры игроков
            //Игрок 1
            this.lblNamePlayerFirstValue.Text = _settings.PlayerFirstName;
            this.lblColorPlayerFirstValue.BackColor = _settings.PlayerFirstColor;

            //Игрок 2
            this.lblNamePlayerSecondValue.Text = _settings.PlayerSecondName;
            this.lblColorPlayerSecondValue.BackColor = _settings.PlayerSecondColor;
        }*/

        private void _butColorBackgroundNewValue_Click(object sender, EventArgs e)
        {
            //_settings.ColorBackgroundNewValueHandler();
        }

        private void _butColorCellNewValue_Click(object sender, EventArgs e)
        {
           // _settings.ColorFieldNewValueHandler();
        }

        private void _butColorButtonsNewValue_Click(object sender, EventArgs e)
        {
            //_settings.ColorButtonsNewValueHandler();
        }

        private void butSaveGameSettings_Click(object sender, EventArgs e)
        {
            //_settings.MaxSizeField = this.сheckBoxFullFieldNewValue.Checked;
            //_settings.TimeDescending = this.checkBoxTimeDescendingNewVavue.Checked;
            
            //settingsModel.Save();
            MessageBox.Show("Hello Rows.");
        }
    }
}
