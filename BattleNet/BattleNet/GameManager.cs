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
        public static ObservableCollection<Game> games = new ObservableCollection<Game>();
    }
}
