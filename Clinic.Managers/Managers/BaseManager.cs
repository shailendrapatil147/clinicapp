using Clinic.Repositories.Factory;

namespace Clinic.Managers
{
    public class BaseManager
    {
        public RepositoryFactory RepositoryFactory { get; set;}
        protected static readonly string SystemUser = "";
        protected readonly int UserId = 0;

        public BaseManager()
        {
            RepositoryFactory = new RepositoryFactory();
        }
    }
}
