using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleNet.Model
{
    public class Game
    {
        public string Name { get; set; }
        public string IconPath { get; set; }
        public string DisplayPath { get; set; }

        public string LogoPath { get; set; }

        public string Description { get; set; }
        public string Genre { get; set; }

        public string Link { get; set; }

        public Game(string _name, string _iconPath, string _displayPath = "", string _logoPath = "", string _genre = "", string description = null, string link = null)
        {
            Name = _name;
            IconPath = _iconPath;
            DisplayPath = _displayPath;
            Description = description;
            Link = link;
        }
    }
}
