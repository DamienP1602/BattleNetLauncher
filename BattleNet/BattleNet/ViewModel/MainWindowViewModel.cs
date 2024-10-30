﻿using BattleNet.Model;
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
            GameManager.games = new ObservableCollection<Game>()
            {
                new Game("Bo6","/Utils/Bo6Icon.png","/Utils/BO6BG.png", "/Utils/BO6Logo.png", "Action Shooter"),
                new Game("Overwatch2","/Utils/OverIcon.png","/Utils/OWBG.png", "/Utils/OWLogo.png", "Shooter"),
                new Game("DiabloIV","/Utils/Diablo4Icon.png","/Utils/DiabloBG.png", "/Utils/DiabloLogo.png", "RPG"),
                new Game("Hearthstone","/Utils/HTIcon.png","/Utils/HTBG.png", "/Utils/HTLogo.png", "RPG"),
                new Game("Wow","/Utils/WowIcon.png", "/Utils/WowBG.png", "/Utils/WowLogo.png", "MMORPG"),
            };
            
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
