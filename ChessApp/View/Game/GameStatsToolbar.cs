namespace ChessApp.View.Game
{
    using ChessApp.Model;
    using ChessApp.Utilities;

    public partial class GameStatsToolbar : UserControl
    {
        #region Constructor

        public GameStatsToolbar()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Events

        public event Action MenuClicked;

        #endregion

        #region Public Methods

        public void SetPlayerTurn(bool isWhitePlayersTurn)
        {
            _playerLabel.Text = isWhitePlayersTurn ? "White" : "Black";
        }

        public void SetGraveyard(Dictionary<PieceType, int> deadPieces, bool isWhite)
        {
            var graveyardText = string.Empty;
            foreach (var piece in deadPieces)
            {
                graveyardText += $"{ChessPieceIcon.GetIcon(piece.Key, isWhite)}: {piece.Value}{Environment.NewLine}";
            }

            _graveyardPiecesLabel.Text = graveyardText;
        }

        public void SetTurnCount(int turnCount)
        {
            _turnsLabel.Text = turnCount.ToString();
        }

        #endregion

        #region Event Handlers

        private void MenuButton_Click(object sender, EventArgs e)
        {
            MenuClicked?.Invoke();
        }

        #endregion
    }
}