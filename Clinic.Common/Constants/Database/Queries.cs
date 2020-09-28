namespace Clinic.Common.Constants.Database
{
    public static class Queries
    {
        public const string CREATEUSER ="CREATE TABLE Users (UserId int IDENTITY(1,1) PRIMARY KEY, FirstName string ,LastName string, Email string, Mobile string, Address string)";
    }
}
