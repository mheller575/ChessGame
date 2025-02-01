namespace ChessApp.View
{
    partial class StartMenu
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
            _chessLabel = new Label();
            _newGameLabel = new Label();
            _loadGameLabel = new Label();
            _settingsLabel = new Label();
            _exitLabel = new Label();
            SuspendLayout();
            // 
            // _chessLabel
            // 
            _chessLabel.AutoSize = true;
            _chessLabel.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _chessLabel.ForeColor = Color.White;
            _chessLabel.Location = new Point(500, 179);
            _chessLabel.Name = "_chessLabel";
            _chessLabel.Size = new Size(461, 191);
            _chessLabel.TabIndex = 0;
            _chessLabel.Text = "Chess";
            _chessLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _newGameLabel
            // 
            _newGameLabel.AutoSize = true;
            _newGameLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _newGameLabel.ForeColor = Color.White;
            _newGameLabel.Location = new Point(583, 416);
            _newGameLabel.Name = "_newGameLabel";
            _newGameLabel.Size = new Size(295, 70);
            _newGameLabel.TabIndex = 1;
            _newGameLabel.Text = "New Game";
            _newGameLabel.TextAlign = ContentAlignment.MiddleCenter;
            _newGameLabel.Click += NewGameLabel_Click;
            _newGameLabel.MouseEnter += NewGameLabel_MouseEnter;
            _newGameLabel.MouseLeave += NewGameLabel_MouseLeave;
            // 
            // _loadGameLabel
            // 
            _loadGameLabel.AutoSize = true;
            _loadGameLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _loadGameLabel.ForeColor = Color.White;
            _loadGameLabel.Location = new Point(580, 510);
            _loadGameLabel.Name = "_loadGameLabel";
            _loadGameLabel.Size = new Size(303, 70);
            _loadGameLabel.TabIndex = 2;
            _loadGameLabel.Text = "Load Game";
            _loadGameLabel.TextAlign = ContentAlignment.MiddleCenter;
            _loadGameLabel.Click += LoadGameLabel_Click;
            _loadGameLabel.MouseEnter += LoadGameLabel_MouseEnter;
            _loadGameLabel.MouseLeave += LoadGameLabel_MouseLeave;
            // 
            // _settingsLabel
            // 
            _settingsLabel.AutoSize = true;
            _settingsLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _settingsLabel.ForeColor = Color.White;
            _settingsLabel.Location = new Point(616, 595);
            _settingsLabel.Name = "_settingsLabel";
            _settingsLabel.Size = new Size(228, 70);
            _settingsLabel.TabIndex = 3;
            _settingsLabel.Text = "Settings";
            _settingsLabel.TextAlign = ContentAlignment.MiddleCenter;
            _settingsLabel.Click += SettingsLabel_Click;
            _settingsLabel.MouseEnter += SettingsLabel_MouseEnter;
            _settingsLabel.MouseLeave += SettingsLabel_MouseLeave;
            // 
            // _exitLabel
            // 
            _exitLabel.AutoSize = true;
            _exitLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _exitLabel.ForeColor = Color.White;
            _exitLabel.Location = new Point(669, 687);
            _exitLabel.Name = "_exitLabel";
            _exitLabel.Size = new Size(122, 70);
            _exitLabel.TabIndex = 4;
            _exitLabel.Text = "Exit";
            _exitLabel.TextAlign = ContentAlignment.MiddleCenter;
            _exitLabel.Click += ExitLabel_Click;
            _exitLabel.MouseEnter += ExitLabel_MouseEnter;
            _exitLabel.MouseLeave += ExitLabel_MouseLeave;
            // 
            // StartMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(_exitLabel);
            Controls.Add(_settingsLabel);
            Controls.Add(_loadGameLabel);
            Controls.Add(_newGameLabel);
            Controls.Add(_chessLabel);
            Name = "StartMenu";
            Size = new Size(1460, 1254);
            KeyPress += StartMenu_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _chessLabel;
        private Label _newGameLabel;
        private Label _loadGameLabel;
        private Label _settingsLabel;
        private Label _exitLabel;
    }
}
