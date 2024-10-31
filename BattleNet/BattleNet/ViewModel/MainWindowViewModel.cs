using BattleNet.Model;
using BattleNet.Utils;
using BattleNet.View;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace BattleNet.ViewModel
{
    public class MainWindowViewModel : Utils.ViewBase
    {
        public RelayCommand HomeCommand => new RelayCommand(HomeDraw);
        public RelayCommand GameCommand => new RelayCommand(GameDraw);
        public RelayCommand AllGamesCommand => new RelayCommand(AllGamesDraw);
        public RelayCommand ShopCommand => new RelayCommand(ShopDraw);
        public RelayCommand ToggleVisibilityCommand => new RelayCommand(ToggleVisibility);

        ObservableCollection<Game> displayedGames = new ObservableCollection<Game>();

        public ObservableCollection<Game> DisplayedGames
        {
            get
            {
                return displayedGames;
            }
            set
            {
                displayedGames = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {

            
        }

        void HomeDraw(object _obj)
        {
            PanelManager? _panel = _obj as PanelManager;

            if (_panel == null)
                return;

            _panel.GameContent.Visibility = Visibility.Visible;
            _panel.ShopPanel.Visibility = Visibility.Hidden;
            _panel.AllGames.Visibility = Visibility.Hidden;
        }

        void GameDraw(object _obj)
        {

        }

        void AllGamesDraw(object _obj)
        {
            PanelManager? _panel = _obj as PanelManager;

            if (_panel == null)
                return;

            _panel.GameContent.Visibility = Visibility.Hidden;
            _panel.ShopPanel.Visibility = Visibility.Hidden;
            _panel.AllGames.Visibility = Visibility.Visible;
        }

        void ShopDraw(object _obj)
        {
            PanelManager? _panel = _obj as PanelManager;

            if (_panel == null)
                return;

            _panel.GameContent.Visibility = Visibility.Hidden;
            _panel.ShopPanel.Visibility = Visibility.Visible;
            _panel.AllGames.Visibility = Visibility.Hidden;
        }


        void ToggleVisibility(object? _sender)
        {
            Control _control = (Control)_sender;
            _control.Visibility = _control.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
        }
    }
}
