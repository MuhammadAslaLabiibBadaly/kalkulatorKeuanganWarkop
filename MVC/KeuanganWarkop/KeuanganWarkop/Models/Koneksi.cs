using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KeuanganWarkop.Models
{
    internal class Koneksi
    {
        private static readonly string connectionString = "server=127.0.0.1; user=root; database=keuanganwarkop; password=";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
