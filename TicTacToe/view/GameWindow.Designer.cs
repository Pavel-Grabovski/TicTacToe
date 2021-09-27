
namespace TicTacToeView
{
    partial class GameWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.InformationTable = new System.Windows.Forms.Panel();
            this._namePlayer1 = new System.Windows.Forms.Label();
            this._namePlayer2 = new System.Windows.Forms.Label();
            this._totalPlayer2 = new System.Windows.Forms.Label();
            this._totalPlayer1 = new System.Windows.Forms.Label();
            this._timerPlayer1 = new System.Windows.Forms.Label();
            this._symbolPlayer1 = new System.Windows.Forms.Label();
            this._symbolPlayer2 = new System.Windows.Forms.Label();
            this._timerPlayer2 = new System.Windows.Forms.Label();
            this._gameMoves = new System.Windows.Forms.Label();
            this._vs = new System.Windows.Forms.Label();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this._fileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this._settingsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.InformationTable.SuspendLayout();
            this._menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // InformationTable
            // 
            this.InformationTable.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.InformationTable.Controls.Add(this._namePlayer1);
            this.InformationTable.Controls.Add(this._namePlayer2);
            this.InformationTable.Controls.Add(this._totalPlayer2);
            this.InformationTable.Controls.Add(this._totalPlayer1);
            this.InformationTable.Controls.Add(this._timerPlayer1);
            this.InformationTable.Controls.Add(this._symbolPlayer1);
            this.InformationTable.Controls.Add(this._symbolPlayer2);
            this.InformationTable.Controls.Add(this._timerPlayer2);
            this.InformationTable.Controls.Add(this._gameMoves);
            this.InformationTable.Controls.Add(this._vs);
            this.InformationTable.Controls.Add(this._menuStrip);
            this.InformationTable.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.InformationTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.InformationTable.Location = new System.Drawing.Point(0, 0);
            this.InformationTable.Name = "InformationTable";
            this.InformationTable.Size = new System.Drawing.Size(800, 124);
            this.InformationTable.TabIndex = 0;
            // 
            // _namePlayer1
            // 
            this._namePlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._namePlayer1.Cursor = System.Windows.Forms.Cursors.No;
            this._namePlayer1.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._namePlayer1.Location = new System.Drawing.Point(132, 24);
            this._namePlayer1.Name = "_namePlayer1";
            this._namePlayer1.Size = new System.Drawing.Size(231, 50);
            this._namePlayer1.TabIndex = 4;
            this._namePlayer1.Text = "ИмяИгрока1";
            this._namePlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _namePlayer2
            // 
            this._namePlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._namePlayer2.Cursor = System.Windows.Forms.Cursors.No;
            this._namePlayer2.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._namePlayer2.ForeColor = System.Drawing.SystemColors.ControlText;
            this._namePlayer2.Location = new System.Drawing.Point(425, 24);
            this._namePlayer2.Name = "_namePlayer2";
            this._namePlayer2.Size = new System.Drawing.Size(231, 50);
            this._namePlayer2.TabIndex = 4;
            this._namePlayer2.Text = "ИмяИгрока2";
            this._namePlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _totalPlayer2
            // 
            this._totalPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._totalPlayer2.Cursor = System.Windows.Forms.Cursors.No;
            this._totalPlayer2.Font = new System.Drawing.Font("Arial Narrow", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._totalPlayer2.Location = new System.Drawing.Point(425, 74);
            this._totalPlayer2.Name = "_totalPlayer2";
            this._totalPlayer2.Size = new System.Drawing.Size(50, 50);
            this._totalPlayer2.TabIndex = 4;
            this._totalPlayer2.Text = "0";
            this._totalPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _totalPlayer1
            // 
            this._totalPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._totalPlayer1.Cursor = System.Windows.Forms.Cursors.No;
            this._totalPlayer1.Font = new System.Drawing.Font("Arial Narrow", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._totalPlayer1.Location = new System.Drawing.Point(313, 74);
            this._totalPlayer1.Name = "_totalPlayer1";
            this._totalPlayer1.Size = new System.Drawing.Size(50, 50);
            this._totalPlayer1.TabIndex = 3;
            this._totalPlayer1.Text = "0";
            this._totalPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _timerPlayer1
            // 
            this._timerPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._timerPlayer1.Cursor = System.Windows.Forms.Cursors.No;
            this._timerPlayer1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._timerPlayer1.Location = new System.Drawing.Point(257, 74);
            this._timerPlayer1.Name = "_timerPlayer1";
            this._timerPlayer1.Size = new System.Drawing.Size(50, 50);
            this._timerPlayer1.TabIndex = 2;
            this._timerPlayer1.Text = "111";
            this._timerPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _symbolPlayer1
            // 
            this._symbolPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._symbolPlayer1.Cursor = System.Windows.Forms.Cursors.No;
            this._symbolPlayer1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._symbolPlayer1.Image = global::TicTacToe.Properties.Resources.Blue_ball;
            this._symbolPlayer1.Location = new System.Drawing.Point(201, 74);
            this._symbolPlayer1.Name = "_symbolPlayer1";
            this._symbolPlayer1.Size = new System.Drawing.Size(50, 50);
            this._symbolPlayer1.TabIndex = 2;
            this._symbolPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _symbolPlayer2
            // 
            this._symbolPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._symbolPlayer2.Cursor = System.Windows.Forms.Cursors.No;
            this._symbolPlayer2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._symbolPlayer2.Image = global::TicTacToe.Properties.Resources.Red_ball;
            this._symbolPlayer2.Location = new System.Drawing.Point(537, 74);
            this._symbolPlayer2.Name = "_symbolPlayer2";
            this._symbolPlayer2.Size = new System.Drawing.Size(50, 50);
            this._symbolPlayer2.TabIndex = 2;
            this._symbolPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _timerPlayer2
            // 
            this._timerPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._timerPlayer2.Cursor = System.Windows.Forms.Cursors.No;
            this._timerPlayer2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._timerPlayer2.Location = new System.Drawing.Point(481, 74);
            this._timerPlayer2.Name = "_timerPlayer2";
            this._timerPlayer2.Size = new System.Drawing.Size(50, 50);
            this._timerPlayer2.TabIndex = 2;
            this._timerPlayer2.Text = "222";
            this._timerPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _gameMoves
            // 
            this._gameMoves.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._gameMoves.Cursor = System.Windows.Forms.Cursors.No;
            this._gameMoves.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._gameMoves.Location = new System.Drawing.Point(369, 74);
            this._gameMoves.Name = "_gameMoves";
            this._gameMoves.Size = new System.Drawing.Size(50, 50);
            this._gameMoves.TabIndex = 2;
            this._gameMoves.Text = "0";
            this._gameMoves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _vs
            // 
            this._vs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._vs.Cursor = System.Windows.Forms.Cursors.No;
            this._vs.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._vs.Location = new System.Drawing.Point(369, 24);
            this._vs.Name = "_vs";
            this._vs.Size = new System.Drawing.Size(50, 50);
            this._vs.TabIndex = 1;
            this._vs.Text = "VS";
            this._vs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _menuStrip
            // 
            this._menuStrip.BackColor = System.Drawing.SystemColors.Highlight;
            this._menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileItem,
            this._settingsItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(800, 24);
            this._menuStrip.TabIndex = 0;
            this._menuStrip.Text = "menuStrip1";
            // 
            // _fileItem
            // 
            this._fileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNewGame,
            this.Exit});
            this._fileItem.Image = global::TicTacToe.Properties.Resources.File_logo;
            this._fileItem.Name = "_fileItem";
            this._fileItem.Size = new System.Drawing.Size(64, 20);
            this._fileItem.Text = "Файл";
            // 
            // MenuNewGame
            // 
            this.MenuNewGame.Image = global::TicTacToe.Properties.Resources.New_game_logo;
            this.MenuNewGame.Name = "MenuNewGame";
            this.MenuNewGame.Size = new System.Drawing.Size(136, 22);
            this.MenuNewGame.Text = "Новая игра";
            // 
            // Exit
            // 
            this.Exit.Image = global::TicTacToe.Properties.Resources.Exit_logo;
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(136, 22);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // _settingsItem
            // 
            this._settingsItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._settingsItem.Image = global::TicTacToe.Properties.Resources.Settings_logo;
            this._settingsItem.Name = "_settingsItem";
            this._settingsItem.Size = new System.Drawing.Size(95, 20);
            this._settingsItem.Text = "Настройки";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InformationTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameWindow";
            this.Text = "Крестики-нолики 5 в ряд";
            this.InformationTable.ResumeLayout(false);
            this.InformationTable.PerformLayout();
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InformationTable;
        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem _fileItem;
        private System.Windows.Forms.ToolStripMenuItem _settingsItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label _vs;
        private System.Windows.Forms.Label _gameMoves;
        private System.Windows.Forms.Label _totalPlayer2;
        private System.Windows.Forms.Label _totalPlayer1;
        private System.Windows.Forms.Label _timerPlayer1;
        private System.Windows.Forms.Label _timerPlayer2;
        private System.Windows.Forms.Label _symbolPlayer2;
        private System.Windows.Forms.Label _symbolPlayer1;
        private System.Windows.Forms.Label _namePlayer1;
        private System.Windows.Forms.Label _namePlayer2;
        private System.Windows.Forms.ToolStripMenuItem MenuNewGame;
        private System.Windows.Forms.ToolStripMenuItem Exit;
    }
}

