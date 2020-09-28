namespace Clinic.Repositories.Factory
{
    public interface IRepositoryFactory
    {
        ILogRepository LogRepository { get; set; }
        public IUserRepository UserRepository { get; set; }
    }
}
