using BattleNet.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BattleNet.ViewModel
{
    class CustomTitleBarViewModel : BattleNet.Utils.ViewBase
    {
        bool isMaximize = false;
        public RelayCommand CloseCommand => new RelayCommand(CloseWindow);
        public RelayCommand MinimizeCommand => new RelayCommand(Minimize);
        public RelayCommand ChangeSizeCommand => new RelayCommand(ChangeSize);

        void CloseWindow(object _obj)
        {
           UserControl? _userControl = _obj as UserControl;

            if (_userControl == null)
                return;

           MainWindow.GetWindow(_userControl).Close();
        }

        void Minimize(object _obj)
        {
            UserControl? _userControl = _obj as UserControl;

            if (_userControl == null)
                return;

            MainWindow.GetWindow(_userControl).WindowState = WindowState.Minimized;
        }

        void ChangeSize(object _obj)
        {
            UserControl? _userControl = _obj as UserControl;

            if (_userControl == null)
                return;

            MainWindow.GetWindow(_userControl).WindowState = isMaximize ? WindowState.Normal : WindowState.Maximized;

            isMaximize = !isMaximize;
        }
    }


}
