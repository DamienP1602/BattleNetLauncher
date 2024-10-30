using BattleNet.Model;
using BattleNet.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace BattleNet.ViewModel
{
    public class GameContentViewModel : ViewBase
    {
        public ObservableCollection<Game> AllGames { get; set; }

        public RelayCommand OpenLinkCommand => new RelayCommand(_execute => OpenLink());

        DispatcherTimer switchTimer = new DispatcherTimer();
        int timeBetweenSwitches = 3;
        int currentGameIndex = 0;

        Game currentGame;

        public Game CurrentGame
        {
            get
            {
                return currentGame;
            }
            set
            {
                currentGame = value;
                OnPropertyChanged();
            }
        }

        public GameContentViewModel()
        {
            AllGames = new ObservableCollection<Game>()
            {
                new Game("Bo6","/Utils/Bo6Icon.png","/Utils/BO6BG.png","Bo6 now available!","https://www.callofduty.com/blog/2024/10/call-of-duty-black-ops-6-launch-comms-intel"),
                new Game("Overwatch2","/Utils/OverIcon.png","/Utils/OWBG.png","MHA collab","https://overwatch.blizzard.com/en-us/news/24142481/overwatch-2-x-my-hero-academia-collaboration/"),
                new Game("DiabloIV","/Utils/Diablo4Icon.png","/Utils/DiabloBG.png","Vessel of hatred now live","https://diablo4.blizzard.com/fr-fr/vessel-of-hatred"),
                new Game("Hearthstone","/Utils/HTIcon.png","/Utils/HTBG.png","Expansion pre-purchase","https://hearthstone.blizzard.com/en-us/news/24146090/the-great-dark-beyond-community-events"),
            };
            CurrentGame = AllGames[0];
        }

        public void StartTimer()
        {
            switchTimer.Interval = TimeSpan.FromSeconds(timeBetweenSwitches);
            switchTimer.Tick += (s,e) => Switch();
            switchTimer.Start();
        }

        void Switch()
        {
            currentGameIndex++;
            if (currentGameIndex >= AllGames.Count)
            {
                currentGameIndex = 0;
            }
            CurrentGame = AllGames[currentGameIndex];
        }

        void OpenLink()
        {
            Process.Start(new ProcessStartInfo(CurrentGame.Link) { UseShellExecute = true });
        }
        
    }
}
