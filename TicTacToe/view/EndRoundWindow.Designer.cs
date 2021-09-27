
namespace TicTacToeView
{
    partial class EndRoundWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndRoundWindow));
            this._headingLabel = new System.Windows.Forms.Label();
            this._nextRoundButton = new System.Windows.Forms.Button();
            this._endGameButton = new System.Windows.Forms.Button();
            this._symbolVictory = new System.Windows.Forms.Label();
            this._nameVictory = new System.Windows.Forms.Label();
            this._score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _headingLabel
            // 
            this._headingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._headingLabel.Cursor = System.Windows.Forms.Cursors.No;
            this._headingLabel.Font = new System.Drawing.Font("Algerian", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._headingLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._headingLabel.Location = new System.Drawing.Point(0, 0);
            this._headingLabel.Name = "_headingLabel";
            this._headingLabel.Size = new System.Drawing.Size(448, 100);
            this._headingLabel.TabIndex = 0;
            this._headingLabel.Text = "В этом раунде победу одержал игрок:";
            this._headingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _nextRoundButton
            // 
            this._nextRoundButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._nextRoundButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this._nextRoundButton.Location = new System.Drawing.Point(300, 250);
            this._nextRoundButton.Name = "_nextRoundButton";
            this._nextRoundButton.Size = new System.Drawing.Size(150, 50);
            this._nextRoundButton.TabIndex = 1;
            this._nextRoundButton.Text = "Следующий раунд";
            this._nextRoundButton.UseVisualStyleBackColor = true;
            // 
            // _endGameButton
            // 
            this._endGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._endGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this._endGameButton.Location = new System.Drawing.Point(0, 250);
            this._endGameButton.Name = "_endGameButton";
            this._endGameButton.Size = new System.Drawing.Size(150, 50);
            this._endGameButton.TabIndex = 2;
            this._endGameButton.Text = "Завершить игру";
            this._endGameButton.UseVisualStyleBackColor = true;
            // 
            // _symbolVictory
            // 
            this._symbolVictory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._symbolVictory.Cursor = System.Windows.Forms.Cursors.No;
            this._symbolVictory.Location = new System.Drawing.Point(0, 100);
            this._symbolVictory.Name = "_symbolVictory";
            this._symbolVictory.Size = new System.Drawing.Size(150, 150);
            this._symbolVictory.TabIndex = 3;
            // 
            // _nameVictory
            // 
            this._nameVictory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._nameVictory.Cursor = System.Windows.Forms.Cursors.No;
            this._nameVictory.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nameVictory.Location = new System.Drawing.Point(150, 100);
            this._nameVictory.Name = "_nameVictory";
            this._nameVictory.Size = new System.Drawing.Size(150, 150);
            this._nameVictory.TabIndex = 4;
            this._nameVictory.Text = "label3";
            this._nameVictory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _score
            // 
            this._score.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._score.Cursor = System.Windows.Forms.Cursors.No;
            this._score.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._score.Location = new System.Drawing.Point(300, 100);
            this._score.Name = "_score";
            this._score.Size = new System.Drawing.Size(150, 150);
            this._score.TabIndex = 5;
            this._score.Text = "label4";
            this._score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndRoundWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(450, 299);
            this.Controls.Add(this._score);
            this.Controls.Add(this._nameVictory);
            this.Controls.Add(this._symbolVictory);
            this.Controls.Add(this._endGameButton);
            this.Controls.Add(this._nextRoundButton);
            this.Controls.Add(this._headingLabel);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EndRoundWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конец раунда!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _headingLabel;
        private System.Windows.Forms.Button _nextRoundButton;
        private System.Windows.Forms.Button _endGameButton;
        private System.Windows.Forms.Label _symbolVictory;
        private System.Windows.Forms.Label _nameVictory;
        private System.Windows.Forms.Label _score;
    }
}