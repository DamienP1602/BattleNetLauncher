using BattleNet.Model;
using BattleNet.Utils;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace BattleNet.ViewModel
{
    public class MainWindowViewModel : Utils.ViewBase
    {
        Dictionary<string, List<Grid>> allGrids = new Dictionary<string, List<Grid>>();

        public RelayCommand SwitchCommand => new RelayCommand(Switch);
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

        public MainWindowViewModel(List<Grid> _home, List<Grid> _shop, List<Grid> _games)
        {
            allGrids["Home"] = _home;
            allGrids["Shop"] = _shop;
            allGrids["Games"] = _games;
        }

        void Switch(object? _sender)
        {
            TextBlock _textBlox = (TextBlock)_sender;
            string _name = _textBlox.Text;

            foreach (string key in allGrids.Keys)
            {
                if (key == _name)
                {
                    foreach (Grid grid in allGrids[key])
                    {
                        grid.Visibility = Visibility.Visible;
                    }
                }
                else
                {
                    foreach (Grid grid in allGrids[key])
                    {
                        grid.Visibility = Visibility.Hidden;
                    }
                }
            }
        }


        void ToggleVisibility(object? _sender)
        {
            Control _control = (Control)_sender;
            _control.Visibility = _control.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
        }
    }
}
