namespace ChessApp.View.Game
{
    using ChessApp.Model;
    using ChessApp.Utilities;

    public partial class Space : UserControl
    {
        #region Constructors

        public Space()
            : this(Color.White, (0,0))
        {}

        public Space(Color backColor, (int x, int y) coordinates)
        {
            InitializeComponent();

            BackColor = backColor;
            Coordinates = coordinates;

            Disposed += OnDispose;
            Click += OnClick;
        }

        #endregion

        #region Public Properties

        public (int x, int y) Coordinates { get; set; }

        #endregion

        #region Public Events

        public event Action<(int x, int y)> Clicked;

        #endregion

        #region Public Methods

        public void SetPiece(PieceType? piece, bool isWhite)
        {
            _pieceTypeLabel.Text = ChessPieceIcon.GetIcon(piece, isWhite);
        }

        #endregion

        #region Event Handlers

        private void OnClick(object? sender, EventArgs e)
        {
            Clicked?.Invoke(Coordinates);
        }

        private void OnDispose(object? sender, EventArgs e)
        {
            Disposed -= OnDispose;
            Click -= OnClick;
        }

        #endregion
    }
}