using BattleNet.Model;
using BattleNet.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BattleNet.Utils
{
    /// <summary>
    /// Interaction logic for Favorite.xaml
    /// </summary>
    public partial class Favorite : UserControl
    {
        FavoriteGamesViewModel viewModel;
        public Favorite()
        {
            InitializeComponent();
            viewModel = new FavoriteGamesViewModel();
            DataContext = viewModel;
        }

        private void OnSelecChange(object sender, SelectionChangedEventArgs e)
        {
            Game _selectedGame = (Game)Games.SelectedItem;
            if (_selectedGame != null)
            {
                viewModel.SelectedGame = _selectedGame;
            }
        }

        public ObservableCollection<Game> AllGames
        {
            get
            {
                return viewModel.AllGames;
            }
        }

        public ObservableCollection<Game> FavoriteGames
        {
            get
            {
                return viewModel.Favorites;
            }
        }
    }
}
