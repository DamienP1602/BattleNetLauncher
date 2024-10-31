using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BattleNet.Model
{
    public enum EStateVisibility
    {
        ONLINE,
        ABSENT,
        OCCUPIED,
        OFFLINE,
    }

    public class Contact : Utils.ViewBase
    {
        public string Pseudo {  get; set; }
        public string BattleTag { get; set; }

        string pseudoBattleTag;
        public string PseudoBattleTag
        {
            get => pseudoBattleTag;
            set
            {
                pseudoBattleTag = value;
                OnPropertyChanged();
            }
        }
        public EStateVisibility State { get; set; } 
        public string Region { get; set; } // Europe, Asie etc...

        private string FullName { get; set; } // uniquement accessible via la page principale battle.net et meme la c'est crypté
        private string Email { get; set; } // uniquement accessible via la page principale battle.net et meme la c'est crypté
        private string PhoneNumber { get; set; } // uniquement accessible via la page principale battle.net et meme la c'est crypté

        public bool IsFavorite { get; set; } = false;

        public Contact()
        {
            Pseudo = "Toto";
            BattleTag = "#12345";
            PseudoBattleTag = Pseudo + BattleTag;
            State = EStateVisibility.ABSENT;
        }

        public Contact(string _pseudoBattleTag)
        {
            PseudoBattleTag = _pseudoBattleTag;
            State = EStateVisibility.ABSENT;
        }

        public Contact(string _pseudo, string _bTag, EStateVisibility _state = EStateVisibility.OFFLINE)
        {
            Pseudo = _pseudo;
            BattleTag = _bTag;
            PseudoBattleTag = Pseudo + BattleTag;
            State = _state;
        }


        public override string ToString() => $"{PseudoBattleTag}";
    }
}
