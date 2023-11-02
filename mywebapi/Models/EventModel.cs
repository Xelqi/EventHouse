using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using MySqlConnector;

namespace mywebapi.Models
{
    public class Event
    {
        public int eventID { get; set; }
        public string artist { get; set; }
        public string location { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }

        internal Database Db { get; set; }

        public Event()
        {
        }

        internal Event(Database db)
        {
            Db = db;
        }

        public async Task<List<Event>> GetAllAsync()
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM  Event ;";
            return await ReturnAllAsync(await cmd.ExecuteReaderAsync());
        }

        public async Task<Event> FindOneAsync(int eventID)
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM  Event  WHERE  eventID  = @eventID";
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
            cmd.CommandText = @"INSERT INTO  Event  ( artist ,  location ,  description ,  date ) VALUES (@artist, @location, @description,@date);";
            BindParams(cmd);
            try
            {
                await cmd.ExecuteNonQueryAsync();
                int id_user = (int)cmd.LastInsertedId;
                return id_user;
            }
            catch (System.Exception)
            {
                return 0;
            }
        }

        public async Task UpdateAsync()
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"UPDATE  Event  SET  artist  = @artist,  location  = @location,  description  = @description,  date = @date  WHERE  eventID  = @eventID;";
            BindParams(cmd);
            BindId(cmd);
            await cmd.ExecuteNonQueryAsync();
        }

        public async Task DeleteAsync()
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"DELETE FROM  Event  WHERE  eventID  = @eventID;";
            BindId(cmd);
            await cmd.ExecuteNonQueryAsync();
        }

        private async Task<List<Event>> ReturnAllAsync(DbDataReader reader)
        {
            var posts = new List<Event>();
            using (reader)
            {
                while (await reader.ReadAsync())
                {
                    var post = new Event(Db)
                    {
                        eventID = reader.GetInt32(0),
                        artist = reader.GetString(1),
                        location = reader.GetString(2),
                        description = reader.GetString(3),
                        date = reader.GetDateTime(4)
                    };
                    posts.Add(post);
                }
            }
            return posts;
        }

        private void BindId(MySqlCommand cmd)
        {
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@eventID",
                DbType = DbType.Int32,
                Value = eventID,
            });
        }

        private void BindParams(MySqlCommand cmd)
        {
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@artist",
                DbType = DbType.String,
                Value = artist,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@location",
                DbType = DbType.String,
                Value = location,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@description",
                DbType = DbType.String,
                Value = description,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@date",
                DbType = DbType.DateTime,
                Value = date,
            });
        }
    }
}