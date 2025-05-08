using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KeuanganWarkop
{
    public partial class Laporan : Form
    {
        private string connectionString = "server=127.0.0.1; user=root; database=keuanganwarkop; password=";
        public Laporan()
        {
            InitializeComponent();
            this.dgvLaporan.CellContentClick += new DataGridViewCellEventHandler(this.dgvLaporan_CellContentClick);

        }

        // Fungsi untuk menampilkan laporan transaksi berdasarkan filter bulan dan tahun
        private void TampilkanLaporan()
        {
            try
            {
                // Ambil tahun dari ComboBox
                int tahun = Convert.ToInt32(cboTahun.SelectedItem);
                // Ambil bulan dan tahun dari DateTimePicker
                int bulan = dtBulan.Value.Month;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id_transaksi, tanggal, kategori, nominal, deskripsi FROM transaksi WHERE YEAR(tanggal) = @tahun AND MONTH(tanggal) = @bulan ORDER BY tanggal DESC";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tahun", tahun);
                        cmd.Parameters.AddWithValue("@bulan", bulan);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvLaporan.DataSource = dt;  // Menampilkan data transaksi ke DataGridView

                        // Menambahkan kolom aksi
                        if (!dgvLaporan.Columns.Contains("aksi"))
                        {
                            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                            btnEdit.Name = "aksi";
                            btnEdit.HeaderText = "Aksi";
                            btnEdit.Text = "Edit/Hapus";
                            btnEdit.UseColumnTextForButtonValue = true;
                            dgvLaporan.Columns.Add(btnEdit);
                        }

                        // Menyembunyikan kolom id_transaksi agar tidak ditampilkan
                        dgvLaporan.Columns["id_transaksi"].Visible = false;

                        HitungSaldo(dt);  // Menghitung saldo setelah data ditampilkan
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan laporan: " + ex.Message);
            }
        }

        private void dgvLaporan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mengecek apakah tombol "Aksi" diklik (kolom tombol berada di posisi "aksi")
            if (e.ColumnIndex == dgvLaporan.Columns["aksi"].Index && e.RowIndex >= 0)
            {
                // Mengambil data transaksi berdasarkan baris yang diklik
                DataGridViewRow row = dgvLaporan.Rows[e.RowIndex];
                string idTransaksi = row.Cells["id_transaksi"].Value.ToString(); // ID Transaksi hanya digunakan di sini
                string kategori = row.Cells["kategori"].Value.ToString();
                string nominal = row.Cells["nominal"].Value.ToString();
                string deskripsi = row.Cells["deskripsi"].Value.ToString();

                // Menampilkan dialog konfirmasi untuk memilih aksi
                DialogResult result = MessageBox.Show("Pilih aksi: Edit(Yes) atau Hapus(No) ?", "Pilih Aksi", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    // Tindakan Edit
                    EditTransaksi(idTransaksi, kategori, nominal, deskripsi);
                }
                else if (result == DialogResult.No)
                {
                    // Tindakan Hapus
                    HapusTransaksi(idTransaksi);
                }
            }
        }

        private void EditTransaksi(string idTransaksi, string kategori, string nominal, string deskripsi)
        {
            EditTransaksiForm editForm = new EditTransaksiForm(idTransaksi, kategori, nominal, deskripsi);

            // Tambahkan event handler untuk reload data saat update selesai
            editForm.OnTransaksiUpdated += () =>
            {
                TampilkanLaporan(); // Refresh DataGridView setelah edit
            };

            editForm.Show();
        }

        private void HapusTransaksi(string idTransaksi)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus transaksi ini?", "Konfirmasi", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM transaksi WHERE id_transaksi = @idTransaksi";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@idTransaksi", idTransaksi);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Transaksi berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TampilkanLaporan();  // Memuat ulang laporan setelah penghapusan
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus transaksi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Fungsi untuk menghitung saldo akhir berdasarkan transaksi
        private void HitungSaldo(DataTable dt)
        {
            decimal pemasukan = 0;
            decimal pengeluaran = 0;

            foreach (DataRow row in dt.Rows)
            {
                string kategori = row["kategori"].ToString().ToLower();
                decimal nominal = Convert.ToDecimal(row["nominal"]);

                if (kategori == "pemasukan")
                    pemasukan += nominal;
                else if (kategori == "pengeluaran")
                    pengeluaran += nominal;
            }

            decimal saldo = pemasukan - pengeluaran;
            lblSaldo.Text = $"Sisa Saldo: Rp {saldo:N0}";
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            TampilkanLaporan(); // Menampilkan laporan berdasarkan bulan dan tahun yang dipilih
        }

        // Form load event untuk mengisi comboBox Tahun dengan data yang ada
        private void Laporan_Load(object sender, EventArgs e)
        {
            // Mengisi comboBox Tahun dengan pilihan tahun tertentu
            for (int i = 2023; i <= DateTime.Now.Year; i++)
            {
                cboTahun.Items.Add(i);
            }
            cboTahun.SelectedItem = DateTime.Now.Year;

            // Set default bulan ke bulan sekarang
            dtBulan.CustomFormat = "MM";  // Set format hanya bulan
            dtBulan.Format = DateTimePickerFormat.Custom;
            dtBulan.Value = DateTime.Now;  // Set nilai default bulan sekarang

            // Tampilkan laporan saat form dimuat pertama kali
            TampilkanLaporan();
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            Home HomeForm = new Home();
            HomeForm.Show();
            this.Close();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            Transaksi TransaksiForm = new Transaksi();
            TransaksiForm.Show();
            this.Close();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
