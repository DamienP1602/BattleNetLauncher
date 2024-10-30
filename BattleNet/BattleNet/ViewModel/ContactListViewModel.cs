using BattleNet.Model;
using BattleNet.Utils;
using System.Collections.ObjectModel;
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

        public ObservableCollection<Contact> allContacts = new ObservableCollection<Contact>();
        public ObservableCollection<Contact> AllContacts
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


        string allFriendListText = "Amis - 0/0";
        public string AllFriendListText
        {
            get => allFriendListText;
            set
            {
                allFriendListText = value;
                OnPropertyChanged();
            }
        }

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
