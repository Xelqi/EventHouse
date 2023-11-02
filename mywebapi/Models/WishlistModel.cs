using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using MySqlConnector;

namespace mywebapi.Models
{
    public class Wishlist
    {
        public int userID { get; set; }
        public int eventID { get; set; }

        internal Database Db { get; set; }

        public Wishlist()
        {
        }

        internal Wishlist(Database db)
        {
            Db = db;
        }

        public async Task<List<Wishlist>> GetAllAsync()
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM Wishlist;";
            return await ReturnAllAsync(await cmd.ExecuteReaderAsync());
        }

        public async Task<Wishlist> FindOneAsync(int userID, int eventID)
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM Wishlist WHERE userID = @userID AND eventID = @eventID";
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@userID",
                DbType = DbType.Int32,
                Value = userID,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@eventID",
                DbType = DbType.Int32,
                Value = eventID,
            });
            var result = await ReturnAllAsync(await cmd.ExecuteReaderAsync());
            return result.Count > 0 ? result[0] : null;
        }

        public async Task<int> InsertAsync()
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"INSERT INTO Wishlist (userID, eventID) VALUES (@userID, @eventID);";
            BindParams(cmd);
            try
            {
                await cmd.ExecuteNonQueryAsync();
                return 1;
            }
            catch (System.Exception)
            {
                return 0;
            }
        }

        public async Task DeleteAsync()
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"DELETE FROM Wishlist WHERE userID = @userID AND eventID = @eventID;";
            BindParams(cmd);
            await cmd.ExecuteNonQueryAsync();
        }

        private async Task<List<Wishlist>> ReturnAllAsync(DbDataReader reader)
        {
            var wishlistItems = new List<Wishlist>();
            using (reader)
            {
                while (await reader.ReadAsync())
                {
                    var wishlistItem = new Wishlist(Db)
                    {
                        userID = reader.GetInt32(0),
                        eventID = reader.GetInt32(1)
                    };
                    wishlistItems.Add(wishlistItem);
                }
            }
            return wishlistItems;
        }

        private void BindParams(MySqlCommand cmd)
        {
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@userID",
                DbType = DbType.Int32,
                Value = userID,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@eventID",
                DbType = DbType.Int32,
                Value = eventID,
            });
        }
    }
}