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
    public class FavoriteGamesViewModel : ViewBase
    {
        public ObservableCollection<Game> AllGames { get; set; }
        public ObservableCollection<Game> Favorites { get; set; }

        Game selectedGame = null;

        public RelayCommand AddGameToFavoritesCommand => new RelayCommand(_callback => AddGameToFavorites());

        public FavoriteGamesViewModel()
        {

            AllGames = new ObservableCollection<Game>()
            {
                new Game("Bo6","/Utils/Bo6Icon.png","/Utils/BO6BG.png", "/Utils/BO6Logo.png", "Action Shooter"),
                new Game("Overwatch2","/Utils/OverIcon.png","/Utils/OWBG.png", "/Utils/OWLogo.png", "Shooter"),
                new Game("DiabloIV","/Utils/Diablo4Icon.png","/Utils/DiabloBG.png", "/Utils/DiabloLogo.png", "RPG"),
                new Game("Hearthstone","/Utils/HTIcon.png","/Utils/HTBG.png", "/Utils/HTLogo.png", "RPG"),
                new Game("Wow","/Utils/WowIcon.png", "/Utils/WowBG.png", "/Utils/WowLogo.png", "MMORPG"),
            };
            Favorites = new ObservableCollection<Game>();
        }

        public Game SelectedGame
        {
            get
            {
                return selectedGame;
            }
            set
            {
                selectedGame = value;
                OnPropertyChanged();
            }
        }

        void AddGameToFavorites()
        {
            if (!Favorites.Contains(selectedGame))
            {
                Favorites.Add((selectedGame));
                MessageBox.Show(SelectedGame.Name);
            }
        }
    }
}
