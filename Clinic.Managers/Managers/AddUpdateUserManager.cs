using Clinic.Common.StaticMethods;
using Clinic.Contracts.Models;
using Clinic.Contracts.Winform;
using Clinic.Managers;
using Clinic.Repositories.Factory;

namespace Clinic.BusinessLogic.Managers
{
    public class AddUpdateUserManager : BaseManager
    {
        public AddUpdateUser AddUpdateUser { get; set; }

        public AddUpdateUserManager(User user) : base()
        {
            AddUpdateUser = new AddUpdateUser();
            AddUpdateUser.User = user;
        }

        public string AddNewUser()
        {
            string message = string.Empty;
            if (!string.IsNullOrEmpty(AddUpdateUser.User.FirstName) && !string.IsNullOrEmpty(AddUpdateUser.User.LastName))
            {
                message = ExecuteUsingTryCatch.UserTryCatchAndReturnErrorMessage(() =>
                {
                    int recordsAffected = RepositoryFactory.UserRepository.AddUser(AddUpdateUser.User);
                    return "User addedd successfully...!";
                });
            }
            else
            {
                message = "Invalid User Details";
            }
            return message;
        }

        public string UpdateUser()
        {
            string message = string.Empty;
            if (AddUpdateUser.User.UserId != 0 && !string.IsNullOrEmpty(AddUpdateUser.User.FirstName) && !string.IsNullOrEmpty(AddUpdateUser.User.LastName))
            {
                message = ExecuteUsingTryCatch.UserTryCatchAndReturnErrorMessage(() =>
                {
                    int recordsAffected = RepositoryFactory.UserRepository.UpdateUser(AddUpdateUser.User);
                    return "User updated successfully...!";
                });
            }
            else
            {
                message = "Invalid User Details";
            }
            return message;
        }

        public string AddOrUpdateUser()
        {
            if (AddUpdateUser.User.UserId != 0)
            {
                return UpdateUser();
            }
            else
            {
                return AddNewUser();
            }
        }
    }
}
