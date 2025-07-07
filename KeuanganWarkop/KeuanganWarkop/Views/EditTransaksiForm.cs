using System;
using System.Windows.Forms;
using KeuanganWarkop.Models;
using KeuanganWarkop.Controllers;
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
                var controller = new TransaksiController();
                controller.EditTransaksi(
                    idTransaksi,
                    txtKategori.SelectedItem.ToString(),
                    Convert.ToDecimal(txtNominal.Text),
                    txtDeskripsi.Text
                );

                MessageBox.Show("Data berhasil diperbarui.");
                OnTransaksiUpdated?.Invoke();
                this.Close();
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
