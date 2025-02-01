namespace ChessApp.View
{
    public partial class MainForm : Form
    {
        private readonly Services.IGameService _gameService = new Services.GameService();
        private readonly PauseMenu _pauseMenu = new PauseMenu();
        private readonly StartMenu _startMenu = new StartMenu();
        private readonly Game.Game _game = new Game.Game();

        public MainForm()
        {
            InitializeComponent();

            _startMenu.Location = new Point(0, 0);

            Controls.Add(_pauseMenu);
            Controls.Add(_startMenu);
            Controls.Add(_game);

            _pauseMenu.Hide();
            _game.Hide();
        }
    }
}