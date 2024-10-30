using BattleNet.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BattleNet
{
    /// <summary>
    /// Interaction logic for US_UserControl.xaml
    /// </summary>
    public partial class US_AllGames : UserControl
    {
        public US_AllGames()
        {
            InitializeComponent();
            AllGamesViewModel allGamesViewModel = new AllGamesViewModel();
            DataContext = allGamesViewModel;
        }
    }

}
