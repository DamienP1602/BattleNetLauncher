using BattleNet.Utils;
using System.ComponentModel;
using System.Windows.Input;

namespace BattleNet
{
    public class AllGamesViewModel : INotifyPropertyChanged
    {
        // My Games properties
        private bool _isMyGamesChecked;
        private bool _isInstalledChecked;
        private bool _isFavoriteChecked;

        // All Games properties
        private bool _isAllGamesChecked;
        private bool _isBlizzardChecked;
        private bool _isActivisionChecked;

        // My Games properties
        public bool IsMyGamesChecked
        {
            get => _isMyGamesChecked;
            set
            {
                if (_isMyGamesChecked != value)
                {
                    _isMyGamesChecked = value;
                    OnPropertyChanged(nameof(IsMyGamesChecked));
                    if (value) UncheckOthers(nameof(IsMyGamesChecked));
                }
            }
        }

        public bool IsInstalledChecked
        {
            get => _isInstalledChecked;
            set
            {
                if (_isInstalledChecked != value)
                {
                    _isInstalledChecked = value;
                    OnPropertyChanged(nameof(IsInstalledChecked));
                    if (value) UncheckOthers(nameof(IsInstalledChecked));
                }
            }
        }

        public bool IsFavoriteChecked
        {
            get => _isFavoriteChecked;
            set
            {
                if (_isFavoriteChecked != value)
                {
                    _isFavoriteChecked = value;
                    OnPropertyChanged(nameof(IsFavoriteChecked));
                    if (value) UncheckOthers(nameof(IsFavoriteChecked));
                }
            }
        }

        // All Games properties
        public bool IsAllGamesChecked
        {
            get => _isAllGamesChecked;
            set
            {
                if (_isAllGamesChecked != value)
                {
                    _isAllGamesChecked = value;
                    OnPropertyChanged(nameof(IsAllGamesChecked));
                    if (value) UncheckOthers(nameof(IsAllGamesChecked));
                }
            }
        }

        public bool IsBlizzardChecked
        {
            get => _isBlizzardChecked;
            set
            {
                if (_isBlizzardChecked != value)
                {
                    _isBlizzardChecked = value;
                    OnPropertyChanged(nameof(IsBlizzardChecked));
                    if (value) UncheckOthers(nameof(IsBlizzardChecked));
                }
            }
        }

        public bool IsActivisionChecked
        {
            get => _isActivisionChecked;
            set
            {
                if (_isActivisionChecked != value)
                {
                    _isActivisionChecked = value;
                    OnPropertyChanged(nameof(IsActivisionChecked));
                    if (value) UncheckOthers(nameof(IsActivisionChecked));
                }
            }
        }

        private void UncheckOthers(string checkedButton)
        {
            // My Games unchecking logic
            if (checkedButton != nameof(IsMyGamesChecked)) IsMyGamesChecked = false;
            if (checkedButton != nameof(IsInstalledChecked)) IsInstalledChecked = false;
            if (checkedButton != nameof(IsFavoriteChecked)) IsFavoriteChecked = false;

            // All Games unchecking logic
            if (checkedButton != nameof(IsAllGamesChecked)) IsAllGamesChecked = false;
            if (checkedButton != nameof(IsBlizzardChecked)) IsBlizzardChecked = false;
            if (checkedButton != nameof(IsActivisionChecked)) IsActivisionChecked = false;
        }

        // Commands
        public ICommand MyGamesCommand { get; }
        public ICommand InstalledCommand { get; }
        public ICommand FavoriteCommand { get; }
        public ICommand AllGamesCommand { get; }
        public ICommand BlizzardCommand { get; }
        public ICommand ActivisionCommand { get; }

        public AllGamesViewModel()
        {
            MyGamesCommand = new RelayCommand(param => IsMyGamesChecked = true);
            InstalledCommand = new RelayCommand(param => IsInstalledChecked = true);
            FavoriteCommand = new RelayCommand(param => IsFavoriteChecked = true);
            AllGamesCommand = new RelayCommand(param => IsAllGamesChecked = true);
            BlizzardCommand = new RelayCommand(param => IsBlizzardChecked = true);
            ActivisionCommand = new RelayCommand(param => IsActivisionChecked = true);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
