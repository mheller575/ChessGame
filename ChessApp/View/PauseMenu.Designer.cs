namespace ChessApp.View
{
    partial class PauseMenu
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
            _quitLabel = new Label();
            _settingsLabel = new Label();
            _saveLabel = new Label();
            _pausedLabel = new Label();
            _resumeLabel = new Label();
            SuspendLayout();
            // 
            // _quitLabel
            // 
            _quitLabel.AutoSize = true;
            _quitLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _quitLabel.ForeColor = Color.White;
            _quitLabel.Location = new Point(663, 833);
            _quitLabel.Name = "_quitLabel";
            _quitLabel.Size = new Size(135, 70);
            _quitLabel.TabIndex = 9;
            _quitLabel.Text = "Quit";
            _quitLabel.TextAlign = ContentAlignment.MiddleCenter;
            _quitLabel.Click += QuitLabel_Click;
            _quitLabel.MouseEnter += QuitLabel_MouseEnter;
            _quitLabel.MouseLeave += QuitLabel_MouseLeave;
            // 
            // _settingsLabel
            // 
            _settingsLabel.AutoSize = true;
            _settingsLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _settingsLabel.ForeColor = Color.White;
            _settingsLabel.Location = new Point(616, 745);
            _settingsLabel.Name = "_settingsLabel";
            _settingsLabel.Size = new Size(228, 70);
            _settingsLabel.TabIndex = 8;
            _settingsLabel.Text = "Settings";
            _settingsLabel.TextAlign = ContentAlignment.MiddleCenter;
            _settingsLabel.Click += SettingsLabel_Click;
            _settingsLabel.MouseEnter += SettingsLabel_MouseEnter;
            _settingsLabel.MouseLeave += SettingsLabel_MouseLeave;
            // 
            // _saveLabel
            // 
            _saveLabel.AutoSize = true;
            _saveLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _saveLabel.ForeColor = Color.White;
            _saveLabel.Location = new Point(659, 647);
            _saveLabel.Name = "_saveLabel";
            _saveLabel.Size = new Size(142, 70);
            _saveLabel.TabIndex = 6;
            _saveLabel.Text = "Save";
            _saveLabel.TextAlign = ContentAlignment.MiddleCenter;
            _saveLabel.Click += SaveLabel_Click;
            _saveLabel.MouseEnter += SaveLabel_MouseEnter;
            _saveLabel.MouseLeave += SaveLabel_MouseLeave;
            // 
            // _pausedLabel
            // 
            _pausedLabel.AutoSize = true;
            _pausedLabel.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _pausedLabel.ForeColor = Color.White;
            _pausedLabel.Location = new Point(451, 338);
            _pausedLabel.Name = "_pausedLabel";
            _pausedLabel.Size = new Size(558, 191);
            _pausedLabel.TabIndex = 5;
            _pausedLabel.Text = "Paused";
            _pausedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _resumeLabel
            // 
            _resumeLabel.AutoSize = true;
            _resumeLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _resumeLabel.ForeColor = Color.White;
            _resumeLabel.Location = new Point(620, 554);
            _resumeLabel.Name = "_resumeLabel";
            _resumeLabel.Size = new Size(221, 70);
            _resumeLabel.TabIndex = 10;
            _resumeLabel.Text = "Resume";
            _resumeLabel.TextAlign = ContentAlignment.MiddleCenter;
            _resumeLabel.Click += ResumeLabel_Click;
            _resumeLabel.MouseEnter += ResumeLabel_MouseEnter;
            _resumeLabel.MouseLeave += ResumeLabel_MouseLeave;
            // 
            // PauseMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(_resumeLabel);
            Controls.Add(_quitLabel);
            Controls.Add(_settingsLabel);
            Controls.Add(_saveLabel);
            Controls.Add(_pausedLabel);
            Name = "PauseMenu";
            Size = new Size(1460, 1254);
            KeyPress += PauseMenu_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _quitLabel;
        private Label _settingsLabel;
        private Label _saveLabel;
        private Label _pausedLabel;
        private Label _resumeLabel;
    }
}
