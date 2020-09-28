using Clinic.Contracts.Winform;
using Clinic.Contracts.Winform.Models;

namespace Clinic.Managers
{
    public class LoginManager : BaseManager
    {
        public Login LoginData { get; set; }

        public LoginManager() : base()
        {
            LoginData = new Login();
        }

        public UserDetails GetLoginUserDetails(string Menu)
        {
            string message = string.Empty;

            //LoginData.UserDetails = _userRepository.GetLoginUserDetails(LoginData.UserName, LoginData.Password);
            ////return _userRepository.GetLoginUserDetails(LoginData.UserName, LoginData.Password);


            //if (LoginData.UserDetails == null)
            //{
            //    message = "Login Failed!";
            //    //LoginData.UserDetails.error = "Login Failed!";
            //    _logRepository.InsertUserLog(currentUserName, $"Failed Log in attempt for user - {LoginData.UserName}");
            //}
            //else
            //{
            //    // _userDetails = LoginData.UserDetails[0];
            //    _logRepository.InsertUserLog(currentUserName, $"Log in successful for user - {LoginData.UserName}", Menu, LoginData.UserDetails.pkPEToolUserId);
            //}
            return LoginData.UserDetails;
        }
    }
}
