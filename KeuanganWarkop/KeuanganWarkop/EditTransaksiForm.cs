using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KeuanganWarkop
{
    public partial class EditTransaksiForm : Form
    {
        private string idTransaksi;

        // Event callback untuk memberi tahu form Laporan
        public event Action OnTransaksiUpdated;

        public EditTransaksiForm(string id, string kategori, string nominal, string deskripsi)
        {
            InitializeComponent();
            idTransaksi = id;

            // Isi ComboBox hanya dengan 2 pilihan
            txtKategori.Items.Add("Pemasukan");
            txtKategori.Items.Add("Pengeluaran");

            // Set nilai awal
            txtKategori.SelectedItem = kategori;
            txtNominal.Text = nominal;
            txtDeskripsi.Text = deskripsi;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtKategori.SelectedItem == null || string.IsNullOrWhiteSpace(txtNominal.Text))
            {
                MessageBox.Show("Kategori dan nominal wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE transaksi SET kategori = @kategori, nominal = @nominal, deskripsi = @deskripsi WHERE id_transaksi = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kategori", txtKategori.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@nominal", Convert.ToDecimal(txtNominal.Text));
                        cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text);
                        cmd.Parameters.AddWithValue("@id", idTransaksi);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Data berhasil diperbarui.");

                            // Panggil event untuk refresh laporan
                            OnTransaksiUpdated?.Invoke();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Gagal memperbarui data.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
