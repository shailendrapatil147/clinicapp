using Clinic.Contracts.Models;
using System.ComponentModel;

namespace Clinic.Contracts.Winform
{
    public class AddUpdateUser : Base, INotifyPropertyChanged
    {
        private User _user;

        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(User)));
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
