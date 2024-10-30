using BattleNet.Utils;
using BattleNet.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BattleNet.ViewModel
{
    class ConnexionWindowViewModel : Utils.ViewBase
    {
        public RelayCommand LoginCommand => new RelayCommand(Connexion);


        public ConnexionWindowViewModel()
        {

        }


        public void Connexion(object _obj)
        {
            ConnexionWindow _window = _obj as ConnexionWindow;
            string _s = _window.Username.Text;

            if (_s.Contains('#'))
            {                
                MainWindow? _mainWindow = Window.GetWindow(App.Current.MainWindow) as MainWindow;
                ContactListViewModel _vm = _mainWindow.ContactList.DataContext as ContactListViewModel;
                _mainWindow.ContactList.LoginButton.Visibility = Visibility.Hidden;
                _mainWindow.ContactList.ContactList.Visibility = Visibility.Visible;
                _vm.CurrentUser.PseudoBattleTag = _s;

                _window.Close();
            }
            else
            {
                MessageBox.Show("Enter a # in your BattleTag");
            }
        }
    }
}
