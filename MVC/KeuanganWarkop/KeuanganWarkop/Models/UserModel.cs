using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeuanganWarkop.Models
{
    public class UserModel
    {
        public static bool Register(string username, string password)
        {
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO login (username, password) VALUES (@username, @password)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // Tambahkan enkripsi jika perlu
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool Login(string username, string password)
        {
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM login WHERE username = @username AND password = @password";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

    }
}
