using BattleNet.Model;
using BattleNet.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BattleNet.ViewModel
{
    internal class ShopPanelViewModel : Utils.ViewBase
    {
        public RelayCommand ShowFavoriteCommand => new RelayCommand(execute => DisplayFavoriteGames());
        public RelayCommand ShowAllGamesCommand => new RelayCommand(execute => DisplayAllGame());

        ObservableCollection<Game> games = null;
        public ObservableCollection<Game> DisplayedGames
        {
            get => games;
            set
            {
                games = value;
                OnPropertyChanged();
            }
        }
        public ShopPanelViewModel()
        {
            DisplayAllGame();
        }

        void DisplayFavoriteGames()
        {
            MainWindow _mainWindow = Window.GetWindow(App.Current.MainWindow) as MainWindow;

            FavoriteGamesViewModel _favoriteDataContext = _mainWindow.FavoritesGame.DataContext as FavoriteGamesViewModel;

            DisplayedGames = _favoriteDataContext.Favorites;
        }

        void DisplayAllGame()
        {
            DisplayedGames = GameManager.games;
        }
    }
}
