using BattleNet.ViewModel;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for US_ContactList.xaml
    /// </summary>
    public partial class US_ContactList : UserControl
    {

        public US_ContactList()
        {
            InitializeComponent();
            ContactListViewModel _contactListVM = new ContactListViewModel();
            DataContext = _contactListVM;
        }
    }
}
