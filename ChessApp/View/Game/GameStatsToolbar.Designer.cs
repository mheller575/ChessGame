namespace ChessApp.View.Game
{
    partial class GameStatsToolbar
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
            _turnLabel = new Label();
            _playerLabel = new Label();
            _graveyardLabel = new Label();
            _graveyardPiecesLabel = new Label();
            _turnsLabel = new Label();
            _turnNumberLabel = new Label();
            _menuButton = new Button();
            SuspendLayout();
            // 
            // _turnLabel
            // 
            _turnLabel.AutoSize = true;
            _turnLabel.BackColor = Color.Black;
            _turnLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _turnLabel.ForeColor = Color.White;
            _turnLabel.Location = new Point(13, 12);
            _turnLabel.Name = "_turnLabel";
            _turnLabel.Size = new Size(97, 45);
            _turnLabel.TabIndex = 0;
            _turnLabel.Text = "Turn:";
            // 
            // _playerLabel
            // 
            _playerLabel.AutoSize = true;
            _playerLabel.BackColor = Color.Black;
            _playerLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _playerLabel.ForeColor = Color.White;
            _playerLabel.Location = new Point(48, 57);
            _playerLabel.Name = "_playerLabel";
            _playerLabel.Size = new Size(109, 45);
            _playerLabel.TabIndex = 1;
            _playerLabel.Text = "White";
            // 
            // _graveyardLabel
            // 
            _graveyardLabel.AutoSize = true;
            _graveyardLabel.BackColor = Color.Black;
            _graveyardLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _graveyardLabel.ForeColor = Color.White;
            _graveyardLabel.Location = new Point(13, 125);
            _graveyardLabel.Name = "_graveyardLabel";
            _graveyardLabel.Size = new Size(183, 45);
            _graveyardLabel.TabIndex = 2;
            _graveyardLabel.Text = "Graveyard:";
            // 
            // _graveyardPiecesLabel
            // 
            _graveyardPiecesLabel.AutoSize = true;
            _graveyardPiecesLabel.BackColor = Color.Black;
            _graveyardPiecesLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _graveyardPiecesLabel.ForeColor = Color.White;
            _graveyardPiecesLabel.Location = new Point(48, 182);
            _graveyardPiecesLabel.Name = "_graveyardPiecesLabel";
            _graveyardPiecesLabel.Size = new Size(0, 45);
            _graveyardPiecesLabel.TabIndex = 3;
            // 
            // _turnsLabel
            // 
            _turnsLabel.AutoSize = true;
            _turnsLabel.BackColor = Color.Black;
            _turnsLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _turnsLabel.ForeColor = Color.White;
            _turnsLabel.Location = new Point(9, 602);
            _turnsLabel.Name = "_turnsLabel";
            _turnsLabel.Size = new Size(97, 45);
            _turnsLabel.TabIndex = 4;
            _turnsLabel.Text = "Turn:";
            // 
            // _turnNumberLabel
            // 
            _turnNumberLabel.AutoSize = true;
            _turnNumberLabel.BackColor = Color.Black;
            _turnNumberLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _turnNumberLabel.ForeColor = Color.White;
            _turnNumberLabel.Location = new Point(37, 647);
            _turnNumberLabel.Name = "_turnNumberLabel";
            _turnNumberLabel.Size = new Size(74, 45);
            _turnNumberLabel.TabIndex = 5;
            _turnNumberLabel.Text = "125";
            // 
            // _menuButton
            // 
            _menuButton.Location = new Point(3, 1211);
            _menuButton.Name = "_menuButton";
            _menuButton.Size = new Size(194, 34);
            _menuButton.TabIndex = 6;
            _menuButton.Text = "Menu";
            _menuButton.UseVisualStyleBackColor = true;
            // 
            // GameStatsToolbar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(_menuButton);
            Controls.Add(_turnNumberLabel);
            Controls.Add(_turnsLabel);
            Controls.Add(_graveyardPiecesLabel);
            Controls.Add(_graveyardLabel);
            Controls.Add(_playerLabel);
            Controls.Add(_turnLabel);
            Name = "GameStatsToolbar";
            Size = new Size(200, 1248);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _turnLabel;
        private Label _playerLabel;
        private Label _graveyardLabel;
        private Label _graveyardPiecesLabel;
        private Label _turnsLabel;
        private Label _turnNumberLabel;
        private Button _menuButton;
    }
}