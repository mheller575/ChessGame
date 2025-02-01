namespace ChessApp.View
{
    public partial class PauseMenu : UserControl
    {
        #region Private Fields

        private uint? _selectedOption = null;

        #endregion

        #region Constructor

        public PauseMenu()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Events

        public event Action QuitSelected;

        public event Action ResumeSelected;

        public event Action SaveSelected;

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

                _resumeLabel.ForeColor = Color.White;
                _saveLabel.ForeColor = Color.White;
                _settingsLabel.ForeColor = Color.White;
                _quitLabel.ForeColor = Color.White;

                if (_selectedOption == 0)
                {
                    _resumeLabel.ForeColor = Color.SkyBlue;
                }
                else if (_selectedOption == 1)
                {
                    _saveLabel.ForeColor = Color.SkyBlue;
                }
                else if (_selectedOption == 2)
                {
                    _settingsLabel.ForeColor = Color.SkyBlue;
                }
                else if (_selectedOption == 3)
                {
                    _quitLabel.ForeColor = Color.SkyBlue;
                }
            }
        }

        #endregion

        #region Event Handlers

        private void ResumeLabel_Click(object sender, EventArgs e)
        {
            ResumeSelected?.Invoke();
        }

        private void ResumeLabel_MouseEnter(object sender, EventArgs e)
        {
            SelectedOption = 0;
        }

        private void ResumeLabel_MouseLeave(object sender, EventArgs e)
        {
            SelectedOption = null;
        }

        private void SaveLabel_Click(object sender, EventArgs e)
        {
            SaveSelected?.Invoke();
        }

        private void SaveLabel_MouseEnter(object sender, EventArgs e)
        {
            SelectedOption = 1;
        }

        private void SaveLabel_MouseLeave(object sender, EventArgs e)
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

        private void QuitLabel_Click(object sender, EventArgs e)
        {
            QuitSelected?.Invoke();
        }

        private void QuitLabel_MouseEnter(object sender, EventArgs e)
        {
            SelectedOption = 3;
        }

        private void QuitLabel_MouseLeave(object sender, EventArgs e)
        {
            SelectedOption = null;
        }

        private void PauseMenu_KeyPress(object sender, KeyPressEventArgs e)
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
                            ResumeSelected?.Invoke();
                            break;
                        case 1:
                            SaveSelected?.Invoke();
                            break;
                        case 2:
                            SettingsSelected?.Invoke();
                            break;
                        case 3:
                            QuitSelected?.Invoke();
                            break;
                        default:
                            // Do nothing.
                            return;
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