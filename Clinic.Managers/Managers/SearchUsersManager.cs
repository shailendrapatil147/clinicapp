using Clinic.Common.StaticMethods;
using Clinic.Contracts.Winform;
using Clinic.Managers;
using Clinic.Repositories.Factory;

namespace Clinic.BusinessLogic.Managers
{
    public class SearchUsersManager : BaseManager
    {
        public SearchUsers SearchUsers { get; set; }

        public SearchUsersManager() : base()
        {
            SearchUsers = new SearchUsers();
        }

        public string SearchUsersByName()
        {
            string message = string.Empty;
            if (!string.IsNullOrEmpty(SearchUsers.Name))
            {
                message = ExecuteUsingTryCatch.UserTryCatchAndReturnErrorMessage(() =>
                {
                    SearchUsers.Users = RepositoryFactory.UserRepository.SearchUsers(SearchUsers.Name);
                    return string.Empty;
                });
            }
            else
            {
                message = "Invalid User Details";
            }
            if (SearchUsers.Users != null)
            {
                if (SearchUsers.Users.Count <= 0)
                {
                    message = "No user found.";
                }
            }
            return message;
        }
    }
}
