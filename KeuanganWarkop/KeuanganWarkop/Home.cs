using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KeuanganWarkop
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadHomeData(); // Menampilkan data saat form pertama kali dibuka
        }

        private void LoadHomeData()
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    // 1. Ambil total pemasukan dan pengeluaran
                    string summaryQuery = @"
                        SELECT 
                            SUM(CASE WHEN kategori = 'Pemasukan' THEN nominal ELSE 0 END) AS total_pemasukan,
                            SUM(CASE WHEN kategori = 'Pengeluaran' THEN nominal ELSE 0 END) AS total_pengeluaran
                        FROM transaksi";

                    using (MySqlCommand cmd = new MySqlCommand(summaryQuery, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                decimal pemasukan = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                                decimal pengeluaran = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                                decimal saldo = pemasukan - pengeluaran;

                                lblPemasukan.Text = $"Rp {pemasukan:N0}";
                                lblPengeluaran.Text = $"Rp {pengeluaran:N0}";
                                lblSaldo.Text = $"Rp {saldo:N0}";
                            }
                        }
                    }

                    // 2. Ambil 10 transaksi terakhir
                    string transaksiQuery = "SELECT tanggal, kategori, nominal, deskripsi FROM transaksi ORDER BY tanggal DESC LIMIT 10";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(transaksiQuery, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvRiwayat.DataSource = dt;

                    // Optional: atur lebar kolom dan header
                    dgvRiwayat.Columns["tanggal"].HeaderText = "Tanggal";
                    dgvRiwayat.Columns["kategori"].HeaderText = "Kategori";
                    dgvRiwayat.Columns["nominal"].HeaderText = "Nominal";
                    dgvRiwayat.Columns["deskripsi"].HeaderText = "Deskripsi";

                    dgvRiwayat.Columns["tanggal"].Width = 120;
                    dgvRiwayat.Columns["kategori"].Width = 100;
                    dgvRiwayat.Columns["nominal"].Width = 100;
                    dgvRiwayat.Columns["deskripsi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            Transaksi TransaksiForm = new Transaksi();
            TransaksiForm.Show();
            this.Hide();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            Laporan LaporanForm = new Laporan();
            LaporanForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
