using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BattleNet.Utils
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        Action<object?>? executeAction { get; set; }
        Func<object?, bool>? canExecuteFunc { get; set; }

        public RelayCommand(Action<object?> _executeAction, Func<object?, bool>? _canExecuteFunc = null)
        {
            executeAction = _executeAction;
            canExecuteFunc = _canExecuteFunc;
        }

        public bool CanExecute(object? parameter)
        {
            return canExecuteFunc == null || canExecuteFunc(parameter);
        }
        public void Execute(object? parameter)
        {
            executeAction?.Invoke(parameter);
        }
    }
}
