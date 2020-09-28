namespace Clinic.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        public string ConnectionString { get; set; }
        public string FilePath { get; set; }

        public BaseRepository(string connectionString, string filePath = "")
        {
            ConnectionString = connectionString;
            FilePath = filePath;
        }

    }
}
