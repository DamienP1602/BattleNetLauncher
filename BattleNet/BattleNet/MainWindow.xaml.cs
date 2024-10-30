using BattleNet.Model;
using BattleNet.ViewModel;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BattleNet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel mainWindow;
        public MainWindow()
        {
            InitializeComponent();
            List<Grid> _home = new List<Grid> { HomeContent };
            List<Grid> _shop = new List<Grid> { ShopContent };
            List<Grid> _games = new List<Grid> { GamesContent };
            mainWindow = new MainWindowViewModel(_home, _shop, _games);
            DataContext = mainWindow;
            mainWindow.DisplayedGames = FavoritesGame.AllGames;
        }

        private void DisplayAll(object sender, RoutedEventArgs e)
        {
            mainWindow.DisplayedGames = FavoritesGame.AllGames;
        }

        private void DisplayFav(object sender, RoutedEventArgs e)
        {
            mainWindow.DisplayedGames = FavoritesGame.FavoriteGames;
        }
    }
}