namespace Clinic.Repositories
{
    public interface ILogRepository
    {
        public string InsertLog(string OldValue, string NewValue, string SolvedBy, string description = "", string error = "");
    }
}
