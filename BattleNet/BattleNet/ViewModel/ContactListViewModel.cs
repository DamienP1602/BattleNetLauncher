using BattleNet.Model;
using BattleNet.Utils;
using System.Windows;
using System.Windows.Controls;

namespace BattleNet.ViewModel
{
    public class ContactListViewModel : BattleNet.Utils.ViewBase
    {
        public RelayCommand ChangeVisibilityCommand => new RelayCommand(OnChangeVisibilityLB);
        public RelayCommand AddContactCommand => new RelayCommand(execute => AddContact());

        public Contact CurrentUser { get; set; } = null;
        public Constant Constant { get; } = new Constant();

        public List<Contact> allContacts = new List<Contact>();
        public List<Contact> AllContacts
        {
            get { return allContacts; }
            set
            {
                allContacts = value;
                OnPropertyChanged();
                UpdateNumberFriend();
            }
        }
        public List<Contact> favContacts = new List<Contact>();

        public string AllFriendListText { get; set; } = "Amis - 0/0";

        public ContactListViewModel()
        {
            InitCurrentUser();
            AllContacts.Add(new Contact());
            AllContacts.Add(new Contact("FuegoDavid", "#97458", EStateVisibility.OCCUPIED));
            AllContacts.Add(new Contact("Autretest", "#44775"));
            UpdateNumberFriend();
        }

        void UpdateNumberFriend()
        {
            int _totalConnected = 0;
            foreach (Contact _contact in allContacts)
                if (_contact.State != EStateVisibility.OFFLINE) _totalConnected++;

            AllFriendListText = $"Amis - {_totalConnected}/{AllContacts.Count}";
            OnPropertyChanged();
        }

        public void OnChangeVisibilityLB(object _sender)
        {
            ListBox _list = (ListBox)_sender;
            bool _vis = _list.IsVisible;
            _list.Visibility = _vis ? Visibility.Hidden : Visibility.Visible;
        }

        // Init Current User For debug and test
        void InitCurrentUser()
        {
            CurrentUser = new Contact("Zarilax", "#12121", EStateVisibility.ONLINE);
        }

        void AddContact() // param besoin ?
        {
            AddContactWindow _addWindow = new AddContactWindow(this);
            _addWindow.Show();
        }

        public void CreateNewContact(Contact _contact)
        {
            AllContacts.Add(_contact);
            UpdateNumberFriend();
        }
    }
}
