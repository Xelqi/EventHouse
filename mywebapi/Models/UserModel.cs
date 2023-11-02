using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using MySqlConnector;

namespace mywebapi.Models
{
    public class User
    {
        public int userID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }

        internal Database Db { get; set; }

        public User()
        {
        }

        internal User(Database db)
        {
            Db = db;
        }

        public async Task<List<User>> GetAllAsync()
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM User;";
            using var reader = await cmd.ExecuteReaderAsync();
            return await ReturnAllAsync(reader);
        }

        public async Task<User> FindOneAsync(int userID)
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM User WHERE userID = @userID";
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@userID",
                DbType = DbType.Int32,
                Value = userID,
            });
            using var reader = await cmd.ExecuteReaderAsync();
            return await ReturnOneAsync(reader);
        }

        public async Task<User> FindByUsername(string username)
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM User WHERE username = @username";
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@username",
                DbType = DbType.String,
                Value = username,
            });
            using var reader = await cmd.ExecuteReaderAsync();
            return await ReturnOneAsync(reader);
        }

        public async Task DeleteAllAsync()
        {
            using var txn = await Db.Connection.BeginTransactionAsync();
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"DELETE FROM User";
            await cmd.ExecuteNonQueryAsync();
            await txn.CommitAsync();
        }

        public async Task<int> InsertAsync()
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"INSERT INTO user (username, password, fname, lname) VALUES (@username, @password, @fname, @lname);";
            BindParams(cmd);
            try
            {
                await cmd.ExecuteNonQueryAsync();
                int userID = (int)cmd.LastInsertedId;
                return userID;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
        }

        public async Task UpdateAsync()
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"UPDATE User SET username = @username, password = @password, fname = @fname, lname = @lname WHERE userID = @userID;";
            BindParams(cmd);
            BindId(cmd);
            await cmd.ExecuteNonQueryAsync();
        }

        public async Task DeleteAsync()
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"DELETE FROM User WHERE username = @username;";
            BindId(cmd);
            await cmd.ExecuteNonQueryAsync();
        }

        private async Task<List<User>> ReturnAllAsync(DbDataReader reader)
        {
            var users = new List<User>();
            using (reader)
            {
                while (await reader.ReadAsync())
                {
                    var user = new User(Db)
                    {
                        userID = reader.GetInt32(0),
                        username = reader.GetString(1),
                        password = reader.GetString(2),
                        fname = reader.GetString(3),
                        lname = reader.GetString(4)
                    };
                    users.Add(user);
                }
            }
            return users;
        }

        private async Task<User> ReturnOneAsync(DbDataReader reader)
        {
            User user = null;
            using (reader)
            {
                if (await reader.ReadAsync())
                {
                    user = new User(Db)
                    {
                        userID = reader.GetInt32(0),
                        username = reader.GetString(1),
                        password = reader.GetString(2),
                        fname = reader.GetString(3),
                        lname = reader.GetString(4),
                    };
                }
            }
            return user;
        }

        private void BindId(MySqlCommand cmd)
        {
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@userID",
                DbType = DbType.Int32,
                Value = userID,
            });
        }

        private void BindParams(MySqlCommand cmd)
        {
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@username",
                DbType = DbType.String,
                Value = username,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@password",
                DbType = DbType.String,
                Value = password,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@fname",
                DbType = DbType.String,
                Value = fname,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@lname",
                DbType = DbType.String,
                Value = lname,
            });
        }
    }
}
