using Clinic.Contracts.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace Clinic.Contracts.Winform
{
    public class SearchUsers : Base, INotifyPropertyChanged
    {
        private List<User> _users;

        public List<User> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(Users)));
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool IsValid
        {
            get { return !string.IsNullOrEmpty(Name) && (Errors.Count == 0); }
        }

        public bool IsUsersPopulated
        {
            get { return Users != null && Users.Count > 0; }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
