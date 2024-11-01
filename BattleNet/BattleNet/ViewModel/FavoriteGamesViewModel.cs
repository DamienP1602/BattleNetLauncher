﻿using BattleNet.Model;
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
            AllGames = GameManager.games;
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
