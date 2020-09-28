namespace Clinic.Repositories
{
    public class LogRepository: BaseRepository, ILogRepository
    {

        public LogRepository(string connectionString) : base(connectionString)
        {
        }

        public string InsertLog(string OldValue, string NewValue, string SolvedBy, string description = "", string error = "")
        {
            string message = string.Empty;
            //try
            //{
            //    int result = -1;
            //    using (var connection = new SqlConnection(_connectionString))
            //    {
            //        var param = new DynamicParameters();
            //        param.Add("@TicketId", TicketId, dbType: DbType.String);
            //        param.Add("@ZendeskTicketType", TicketType, dbType: DbType.Int32);
            //        param.Add("@FkUserActivityLog", fkUserActivityLog, dbType: DbType.Int32);
            //        param.Add("@OldValue", OldValue, dbType: DbType.String);
            //        param.Add("@NewValue", NewValue, dbType: DbType.String);
            //        param.Add("@SolvedBy", SolvedBy, dbType: DbType.String);
            //        param.Add("@Description", description, dbType: DbType.String);
            //        param.Add("@Error", error, dbType: DbType.String);

            //        using (var multi = connection.QueryMultiple("pe_udp_AddLogTicket", param, commandType: CommandType.StoredProcedure))
            //        {
            //            result = multi.Read<int>().FirstOrDefault();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    message = "Error while inserting ticket log.";
            //}
            return message;
        }
    }
}
