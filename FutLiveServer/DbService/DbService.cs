using FutLiveServer.DbService.Interfaces;
using FutLiveServer.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace FutLiveServer.DbService
{
    public class DatabaseService : IDbService
    {
        private readonly SQLiteConnection _connection = new SQLiteConnection("Data Source=futlive.db;Version=3");
        public DatabaseService()
        {

        }
        public async Task<UserResponse> LoginAsync(string email, string password)
        {
            string query = "SELECT Name, Email FROM TBL_USER WHERE Email = @email AND Password = @password";
            var jsonResult = string.Empty;
            var userResponse = new List<UserResponse>();
            DataTable dt = new DataTable();
            SQLiteCommand cmd = new SQLiteCommand(query, _connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

            _connection.Open();
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("password", password);

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                jsonResult = JsonConvert.SerializeObject(dt);
                userResponse = JsonConvert.DeserializeObject<List<UserResponse>>(jsonResult);
            }
            
            _connection.Close();
            foreach (var item in userResponse)
            {
                return item;
            }
            return new UserResponse();
        }
        public Task<UserResponse> RegisterAsync(User user)
        {
            string query = "INSERT INTO TBL_USER (Name,Email,Password) VALUES (@name,@email,@password)";
            SQLiteCommand cmd = new SQLiteCommand(query, _connection);

            _connection.Open();

            cmd.Parameters.AddWithValue("email", user.Email);
            cmd.Parameters.AddWithValue("password", user.Password);
            cmd.Parameters.AddWithValue("name", user.Name);
            cmd.ExecuteNonQuery();

            _connection.Close();

            return LoginAsync(user.Email, user.Password);
        }

    }
    
}
