using BattleNet.Model;
using BattleNet.Utils;
using System.Threading.Channels;
using System.Windows;

namespace BattleNet.ViewModel
{
    public class AddContactWindowViewModel : BattleNet.Utils.ViewBase
    {
        public RelayCommand SendRequestCommand => new RelayCommand(execute => SendRequest());

        public Constant Constant { get; } = new Constant();
        public Window Window { get; set; }

        public string InputText { get; set; } = "BattleTag or e-mail";

        public ViewBase Caller { get; set; }

        public AddContactWindowViewModel(ViewBase _caller, Window _window)
        {
            Caller = _caller;
            Window = _window;
        }

        void SendRequest()
        {
            if (InputText.Contains('#'))
            {
                Contact _contact = new Contact(InputText); // directly via pseudoBattleTag
                ContactListViewModel _caller = (ContactListViewModel)Caller;
                _caller.CreateNewContact(_contact);
                Window.Close();
            }
        }
    }
}
