namespace ChessApp.View
{
    public partial class StartMenu : UserControl
    {
        #region Private Fields

        private uint? _selectedOption = null;

        #endregion

        #region Constructor

        public StartMenu()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Events

        public event Action ExitSelected;

        public event Action LoadGameSelected;

        public event Action NewGameSelected;

        public event Action SettingsSelected;

        #endregion

        #region Private Properties

        private uint? SelectedOption
        {
            get
            {
                return _selectedOption;
            }
            set
            {
                _selectedOption = value;

                _newGameLabel.ForeColor = Color.White;
                _loadGameLabel.ForeColor = Color.White;
                _settingsLabel.ForeColor = Color.White;
                _exitLabel.ForeColor = Color.White;

                if (_selectedOption == 0)
                {
                    _newGameLabel.ForeColor = Color.SkyBlue;
                }
                else if (_selectedOption == 1)
                {
                    _loadGameLabel.ForeColor = Color.SkyBlue;
                }
                else if (_selectedOption == 2)
                {
                    _settingsLabel.ForeColor = Color.SkyBlue;
                }
                else if (_selectedOption == 3)
                {
                    _exitLabel.ForeColor = Color.SkyBlue;
                }
            }
        }

        #endregion

        #region Event Handlers

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            ExitSelected?.Invoke();
        }

        private void ExitLabel_MouseEnter(object sender, EventArgs e)
        {
            SelectedOption = 3;
        }

        private void ExitLabel_MouseLeave(object sender, EventArgs e)
        {
            SelectedOption = null;
        }

        private void LoadGameLabel_Click(object sender, EventArgs e)
        {
            LoadGameSelected?.Invoke();
        }

        private void LoadGameLabel_MouseEnter(object sender, EventArgs e)
        {
            SelectedOption = 1;
        }

        private void LoadGameLabel_MouseLeave(object sender, EventArgs e)
        {
            SelectedOption = null;
        }

        private void NewGameLabel_Click(object sender, EventArgs e)
        {
            NewGameSelected?.Invoke();
        }

        private void NewGameLabel_MouseEnter(object sender, EventArgs e)
        {
            SelectedOption = 0;
        }

        private void NewGameLabel_MouseLeave(object sender, EventArgs e)
        {
            SelectedOption = null;
        }

        private void SettingsLabel_Click(object sender, EventArgs e)
        {
            SettingsSelected?.Invoke();
        }

        private void SettingsLabel_MouseEnter(object sender, EventArgs e)
        {
            SelectedOption = 2;
        }

        private void SettingsLabel_MouseLeave(object sender, EventArgs e)
        {
            SelectedOption = null;
        }

        private void StartMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Down:
                    SelectedOption = SelectedOption == null && SelectedOption == 3 ? 0 : ++SelectedOption;
                    break;
                case (char)Keys.Up:
                    SelectedOption = SelectedOption == null && SelectedOption == 0 ? 3 : --SelectedOption;
                    break;
                case (char)Keys.Enter:
                    switch (SelectedOption)
                    {
                        case 0:
                            NewGameSelected?.Invoke();
                            break;
                        case 1:
                            LoadGameSelected?.Invoke();
                            break;
                        case 2:
                            SettingsSelected?.Invoke();
                            break;
                        case 3:
                            ExitSelected?.Invoke();
                            break;
                        default:
                            // Do nothing.
                            break;
                    }                    
                    break;
                default:
                    // Do nothing.
                    return;
            }
        }

        #endregion
    }
}