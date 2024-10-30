using BattleNet.Model;
using BattleNet.ViewModel;
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

namespace BattleNet.Utils
{
    /// <summary>
    /// Interaction logic for GameContent.xaml
    /// </summary>
    public partial class GameContent : UserControl
    {
        GameContentViewModel viewModel;
        public GameContent()
        {
            InitializeComponent();
            viewModel = new GameContentViewModel();
            viewModel.StartTimer();
            DataContext = viewModel;
        }
    }
}
