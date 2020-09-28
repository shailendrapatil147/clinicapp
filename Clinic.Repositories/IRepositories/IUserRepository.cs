using Clinic.Contracts.Models;
using System.Collections.Generic;

namespace Clinic.Repositories
{
    public interface IUserRepository
    {
        List<User> SearchUsers(string Name);
        int UpdateUser(User User);
        int AddUser(User User);
    }
}
