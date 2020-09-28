using Clinic.Common.AppSettings;

namespace Clinic.Repositories.Factory
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public ILogRepository LogRepository { get; set; }
        public IUserRepository UserRepository { get; set; }

        public RepositoryFactory()
        {
            string userFilePath  = AppConfiguration.Configuration.GetSection("UserFilePath").Value;
            string connectionString = string.Format(AppConfiguration.Configuration.GetSection("BaseConnectionString").Value, userFilePath);
             
            LogRepository = new LogRepository(connectionString);
            UserRepository = new UserRepository(connectionString, userFilePath);
        }
    }
}
