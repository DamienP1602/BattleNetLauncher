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
        public RelayCommand SwitchCommand => new RelayCommand(Switch);
        public RelayCommand HomeCommand => new RelayCommand(HomeDraw);
        public RelayCommand GameCommand => new RelayCommand(GameDraw);
        public RelayCommand AllGamesCommand => new RelayCommand(AllGamesDraw);
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

        void Switch(object? _sender)
        {
            //TextBlock _textBlox = (TextBlock)_sender;
            //string _name = _textBlox.Text;

            //foreach (string key in allGrids.Keys)
            //{
            //    if (key == _name)
            //    {
            //        foreach (Grid grid in allGrids[key])
            //        {
            //            grid.Visibility = Visibility.Visible;
            //        }
            //    }
            //    else
            //    {
            //        foreach (Grid grid in allGrids[key])
            //        {
            //            grid.Visibility = Visibility.Hidden;
            //        }
            //    }
            //}
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


        void ToggleVisibility(object? _sender)
        {
            Control _control = (Control)_sender;
            _control.Visibility = _control.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
        }
    }
}
