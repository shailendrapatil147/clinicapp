using Clinic.Contracts.Winform.Models;
using System.ComponentModel;

namespace Clinic.Contracts.Winform
{
    public class Login : Base, INotifyPropertyChanged
    {
        //private List<UserDetails> _userDetails = new List<UserDetails>();
        private UserDetails _userDetails = new UserDetails();
        public UserDetails UserDetails
        {
            get { return _userDetails; }
            set
            {
                _userDetails = value;
                if (_userDetails == null)
                {
                    AddError(nameof(UserDetails), "No");
                }
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(UserDetails)));
            }
        }
        private string _userName = string.Empty;
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                if (string.IsNullOrEmpty(_userName))
                {
                    AddRequiredError(nameof(UserName));
                }
                else
                {
                    RemoveError(nameof(UserName));
                }
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(UserName)));
            }
        }

        private string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                if (string.IsNullOrEmpty(_password))
                {
                    AddRequiredError(nameof(Password));
                }
                else
                {
                    RemoveError(nameof(Password));
                }
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(Password)));
            }
        }

        public new bool IsValid
        {
            get { return (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
