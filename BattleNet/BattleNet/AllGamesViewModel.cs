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
        private ObservableCollection<Game> games =  new ObservableCollection<Game>();

        public ObservableCollection<Game> Games => games;
        private static void ExecuteAllGamesCommand()
        {
            MessageBox.Show("All Games");
        }

        //// My Games properties
        //private bool isMyGamesChecked;
        //private bool isInstalledChecked;
        //private bool isFavoriteChecked;

        //// All Games properties
        //private bool isAllGamesChecked;
        //private bool isBlizzardChecked;
        //private bool isActivisionChecked;



        private void UncheckOthers(string checkedButton)
        {
            //// My Games unchecking logic
            //if (checkedButton != nameof(IsMyGamesChecked)) IsMyGamesChecked = false;
            //if (checkedButton != nameof(IsInstalledChecked)) IsInstalledChecked = false;
            //if (checkedButton != nameof(IsFavoriteChecked)) IsFavoriteChecked = false;

            //// All Games unchecking logic
            //if (checkedButton != nameof(IsAllGamesChecked)) IsAllGamesChecked = false;
            //if (checkedButton != nameof(IsBlizzardChecked)) IsBlizzardChecked = false;
            //if (checkedButton != nameof(IsActivisionChecked)) IsActivisionChecked = false;
        }

        // Commands
        public RelayCommand AllGamesCommand = new RelayCommand(execute => ExecuteAllGamesCommand());


        public AllGamesViewModel()
        {
            games = GameManager.games;
        }
    }
}
