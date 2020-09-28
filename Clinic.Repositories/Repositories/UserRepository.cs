using Clinic.Common.Constants.Database;
using Clinic.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using Dapper;
using System.Data;
using System.Linq;

namespace Clinic.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(string connectionString, string filePath) : base(connectionString, filePath)
        {
            if (!File.Exists(FilePath))
            {
                CreateFile(FilePath);
                CreateUserTable(FilePath);
            }
        }

        public List<User> SearchUsers(string Name)
        {
            List<User> result = new List<User>();
            using (var connection = new OleDbConnection(ConnectionString))
            {
                using var multi = connection.QueryMultiple($@"SELECT * FROM USERS WHERE FirstName like '%{Name}%' OR LastName like '%{Name}%' OR Email like '%{Name}%' OR Address like '%{Name}%'",
                    commandType: CommandType.Text);
                result = multi.Read<User>().ToList();
            }
            return result;
        }

        public void CreateFile(string FilePath)
        {
            //File.Create(FilePath);
            using (StreamWriter sw = new StreamWriter(FilePath, true))
            {
            }
        }

        public void CreateUserTable(string FilePath)
        {
            OleDbConnection myConnection = new OleDbConnection();
            myConnection.ConnectionString = ConnectionString;
            OleDbCommand myCommand = new OleDbCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = Queries.CREATEUSER;
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
        }

        public int AddUser(User User)
        {
            using (var connection = new OleDbConnection(ConnectionString))
            {
                return connection.Execute($@"INSERT INTO USERS (FirstName, LastName, Email, Address, Mobile) VALUES('{User.FirstName}','{User.LastName}','{User.Email}','{User.Address}','{User.Mobile}')",
                    commandType: CommandType.Text);
            }
        }

        public int UpdateUser(User User)
        {
            using (var connection = new OleDbConnection(ConnectionString))
            {
                return connection.Execute($@"UPDATE USERS SET FirstName = '{User.FirstName}', LastName = '{User.LastName}', Email = '{User.Email}', Address = '{User.Address}', Mobile = '{User.Mobile}' WHERE UserId = {User.UserId}",
                    commandType: CommandType.Text);
            }
        }
    }
}