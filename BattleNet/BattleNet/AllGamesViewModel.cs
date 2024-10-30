using BattleNet.Model;
using BattleNet.Utils;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace BattleNet
{
    public class AllGamesViewModel : ViewBase
    {
        // Games
        private ObservableCollection<Game> games = new ObservableCollection<Game>();
        public ObservableCollection<Game> Games => games;

        // Button states
        public bool IsAllGamesChecked { get; set; }
        public bool IsBlizzardChecked { get; set; }
        public bool IsActivisionChecked { get; set; }
        public bool IsMyGamesChecked { get; set; }
        public bool IsInstalledChecked { get; set; }
        public bool IsFavoriteChecked { get; set; }

        // Commands
        public RelayCommand AllGamesCommand { get; }
        public RelayCommand BlizzardCommand { get; }
        public RelayCommand ActivisionCommand { get; }
        public RelayCommand MyGamesCommand { get; }
        public RelayCommand InstalledCommand { get; }
        public RelayCommand FavoriteCommand { get; }

        public AllGamesViewModel()
        {
            AllGamesCommand = new RelayCommand(_ => ExecuteAllGamesCommand());
            BlizzardCommand = new RelayCommand(_ => ExecuteBlizzardCommand());
            ActivisionCommand = new RelayCommand(_ => ExecuteActivisionCommand());
            MyGamesCommand = new RelayCommand(_ => ExecuteMyGamesCommand());
            InstalledCommand = new RelayCommand(_ => ExecuteInstalledCommand());
            FavoriteCommand = new RelayCommand(_ => ExecuteFavoriteCommand());

            games = GameManager.games;
        }

        private void ExecuteAllGamesCommand()
        {
            UncheckOthers(nameof(IsAllGamesChecked));
            IsAllGamesChecked = true;
        }

        private void ExecuteBlizzardCommand()
        {
            UncheckOthers(nameof(IsBlizzardChecked));
            IsBlizzardChecked = true;
        }

        private void ExecuteActivisionCommand()
        {
            UncheckOthers(nameof(IsActivisionChecked));
            IsActivisionChecked = true;
        }

        private void ExecuteMyGamesCommand()
        {
            UncheckOthers(nameof(IsMyGamesChecked));
            IsMyGamesChecked = true;
        }

        private void ExecuteInstalledCommand()
        {
            UncheckOthers(nameof(IsInstalledChecked));
            IsInstalledChecked = true;
        }

        private void ExecuteFavoriteCommand()
        {
            UncheckOthers(nameof(IsFavoriteChecked));
            IsFavoriteChecked = true;
        }

        private void UncheckOthers(string checkedButton)
        {
            IsAllGamesChecked = checkedButton == nameof(IsAllGamesChecked);
            IsBlizzardChecked = checkedButton == nameof(IsBlizzardChecked);
            IsActivisionChecked = checkedButton == nameof(IsActivisionChecked);
            IsMyGamesChecked = checkedButton == nameof(IsMyGamesChecked);
            IsInstalledChecked = checkedButton == nameof(IsInstalledChecked);
            IsFavoriteChecked = checkedButton == nameof(IsFavoriteChecked);
        }
    }
}
