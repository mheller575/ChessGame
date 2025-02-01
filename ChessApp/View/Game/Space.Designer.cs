namespace ChessApp.View.Game
{
    partial class Space
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
            _pieceTypeLabel = new Label();
            SuspendLayout();
            // 
            // _pieceTypeLabel
            // 
            _pieceTypeLabel.AutoSize = true;
            _pieceTypeLabel.Font = new Font("Segoe UI", 48F);
            _pieceTypeLabel.Location = new Point(20, 11);
            _pieceTypeLabel.Margin = new Padding(0);
            _pieceTypeLabel.Name = "_pieceTypeLabel";
            _pieceTypeLabel.Size = new Size(0, 128);
            _pieceTypeLabel.TabIndex = 0;
            // 
            // Space
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(_pieceTypeLabel);
            Name = "Space";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _pieceTypeLabel;
    }
}
