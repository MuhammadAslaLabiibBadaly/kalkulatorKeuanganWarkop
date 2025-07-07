using System;
using System.Data;
using System.Windows.Forms;
using KeuanganWarkop.Models;
using KeuanganWarkop.Controllers;
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
                var controller = new TransaksiController();

                // 1. Ambil ringkasan saldo
                var (pemasukan, pengeluaran) = controller.AmbilRingkasan();
                decimal saldo = pemasukan - pengeluaran;

                lblPemasukan.Text = $"Rp {pemasukan:N0}";
                lblPengeluaran.Text = $"Rp {pengeluaran:N0}";
                lblSaldo.Text = $"Rp {saldo:N0}";

                // 2. Ambil riwayat transaksi
                DataTable dt = controller.AmbilRiwayatTerakhir();
                dgvRiwayat.DataSource = dt;

                dgvRiwayat.Columns["tanggal"].HeaderText = "Tanggal";
                dgvRiwayat.Columns["kategori"].HeaderText = "Kategori";
                dgvRiwayat.Columns["nominal"].HeaderText = "Nominal";
                dgvRiwayat.Columns["deskripsi"].HeaderText = "Deskripsi";

                dgvRiwayat.Columns["tanggal"].Width = 120;
                dgvRiwayat.Columns["kategori"].Width = 100;
                dgvRiwayat.Columns["nominal"].Width = 100;
                dgvRiwayat.Columns["deskripsi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
