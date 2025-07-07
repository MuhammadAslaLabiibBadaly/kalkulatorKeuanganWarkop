using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeuanganWarkop.Models
{
    public class TransaksiModel
    {
        public static DataTable GetByMonthYear(int tahun, int bulan)
        {
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT id_transaksi, tanggal, kategori, nominal, deskripsi FROM transaksi WHERE YEAR(tanggal) = @tahun AND MONTH(tanggal) = @bulan";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tahun", tahun);
                cmd.Parameters.AddWithValue("@bulan", bulan);

                var adapter = new MySqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static void Insert(string tanggal, string kategori, decimal nominal, string deskripsi)
        {
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO transaksi (tanggal, kategori, nominal, deskripsi) VALUES (@tanggal, @kategori, @nominal, @deskripsi)";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tanggal", tanggal);
                cmd.Parameters.AddWithValue("@kategori", kategori);
                cmd.Parameters.AddWithValue("@nominal", nominal);
                cmd.Parameters.AddWithValue("@deskripsi", deskripsi);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Update(string id, string kategori, decimal nominal, string deskripsi)
        {
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "UPDATE transaksi SET kategori = @kategori, nominal = @nominal, deskripsi = @deskripsi WHERE id_transaksi = @id";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@kategori", kategori);
                cmd.Parameters.AddWithValue("@nominal", nominal);
                cmd.Parameters.AddWithValue("@deskripsi", deskripsi);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Delete(string id)
        {
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM transaksi WHERE id_transaksi = @id";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static (decimal pemasukan, decimal pengeluaran) GetSummary()
        {
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT 
                SUM(CASE WHEN kategori = 'Pemasukan' THEN nominal ELSE 0 END) AS total_pemasukan,
                SUM(CASE WHEN kategori = 'Pengeluaran' THEN nominal ELSE 0 END) AS total_pengeluaran
            FROM transaksi";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    decimal pemasukan = 0, pengeluaran = 0;
                    if (reader.Read())
                    {
                        pemasukan = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                        pengeluaran = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                    }
                    return (pemasukan, pengeluaran);
                }
            }
        }

        public static DataTable GetLatestTransaksi(int limit = 10)
        {
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = $"SELECT tanggal, kategori, nominal, deskripsi FROM transaksi ORDER BY tanggal DESC LIMIT {limit}";
                var adapter = new MySqlDataAdapter(query, conn);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}