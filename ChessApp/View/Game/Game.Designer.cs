namespace ChessApp.View.Game
{
    partial class Game
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chessGameBoard1 = new ChessGameBoard();
            gameStatsToolbar1 = new GameStatsToolbar();
            SuspendLayout();
            // 
            // chessGameBoard1
            // 
            chessGameBoard1.BackColor = Color.Black;
            chessGameBoard1.Location = new Point(3, 3);
            chessGameBoard1.Name = "chessGameBoard1";
            chessGameBoard1.Size = new Size(1248, 1248);
            chessGameBoard1.TabIndex = 0;
            // 
            // gameStatsToolbar1
            // 
            gameStatsToolbar1.BackColor = Color.Black;
            gameStatsToolbar1.Location = new Point(1257, 3);
            gameStatsToolbar1.Name = "gameStatsToolbar1";
            gameStatsToolbar1.Size = new Size(200, 1248);
            gameStatsToolbar1.TabIndex = 1;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(gameStatsToolbar1);
            Controls.Add(chessGameBoard1);
            Name = "Game";
            Size = new Size(1460, 1254);
            ResumeLayout(false);
        }

        #endregion

        private ChessGameBoard chessGameBoard1;
        private GameStatsToolbar gameStatsToolbar1;
    }
}
