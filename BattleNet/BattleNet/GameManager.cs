using BattleNet.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleNet
{
    public class GameManager
    {
        public static ObservableCollection<Game> games = new ObservableCollection<Game>()
        {
            new Game("Bo6","/Utils/Bo6Icon.png","/Utils/BO6BG.png", "/Utils/BO6Logo.png", "Action Shooter"),
            new Game("Overwatch2","/Utils/OverIcon.png","/Utils/OWBG.png", "/Utils/OWLogo.png", "Shooter"),
            new Game("DiabloIV","/Utils/Diablo4Icon.png","/Utils/DiabloBG.png", "/Utils/DiabloLogo.png", "RPG"),
            new Game("Hearthstone","/Utils/HTIcon.png","/Utils/HTBG.png", "/Utils/HTLogo.png", "RPG"),
            new Game("Wow","/Utils/WowIcon.png", "/Utils/WowBG.png", "/Utils/WowLogo.png", "MMORPG"),
        };
    }
}
