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
    public partial class Transaksi : Form
    {
        // Di dalam Transaksi.cs, dalam class Transaksi : Form
        string currentInput = "";
        string operatorSimbol = "";
        decimal firstValue = 0;
        bool isOperatorPressed = false;
        private string connectionString = "server=127.0.0.1; user=root; database=keuanganwarkop; password=";



        public Transaksi()
        {
            InitializeComponent();

            // Binding tombol angka
            btn0.Click += Angka_Click;
            btn1.Click += Angka_Click;
            btn2.Click += Angka_Click;
            btn3.Click += Angka_Click;
            btn4.Click += Angka_Click;
            btn5.Click += Angka_Click;
            btn6.Click += Angka_Click;
            btn7.Click += Angka_Click;
            btn8.Click += Angka_Click;
            btn9.Click += Angka_Click;

            // Binding operator
            btnPlus.Click += Operator_Click;
            btnMines.Click += Operator_Click;
            btnKali.Click += Operator_Click;
            btnBagi.Click += Operator_Click;

            // Binding tombol khusus
            btnSamdeng.Click += btnSamdeng_Click;
            btnBackspace.Click += btnBackspace_Click;

            // Binding Tombol Clear dan Submit
            btnClear.Click += btnClear_Click;
            btnSubmit.Click += btnSubmit_Click;
            this.Load += new System.EventHandler(this.Transaksi_Load);


        }

        private void LoadKategoriGabungan()
        {
            // Menampilkan hanya dua pilihan kategori tetap
            txtKategori.Items.Clear();
            txtKategori.Items.Add("Pemasukan");
            txtKategori.Items.Add("Pengeluaran");
            txtKategori.SelectedIndex = 0; // Memilih "Pemasukan" sebagai default
        }


        private void Transaksi_Load(object sender, EventArgs e)
        {
            LoadKategoriGabungan();

            // ... (kode kalkulator dan event lainnya)
        }


        private string ToTitleCase(string text)
        {
            if (string.IsNullOrEmpty(text)) return text;
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            return culture.TextInfo.ToTitleCase(text.ToLower());
        }


        // Fungsi untuk tombol angka
        private void Angka_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            currentInput += btn.Text;
            txtNominal.Text = currentInput;
        }

        // Fungsi untuk tombol operator (+, -, ×, ÷)
        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (decimal.TryParse(currentInput, out firstValue))
            {
                operatorSimbol = btn.Text;
                isOperatorPressed = true;
                currentInput = "";
            }
        }

        // Fungsi untuk tombol sama dengan (=)
        private void btnSamdeng_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(currentInput, out decimal secondValue))
                return;

            decimal result = 0;
            switch (operatorSimbol)
            {
                case "+": result = firstValue + secondValue; break;
                case "-": result = firstValue - secondValue; break;
                case "×": result = firstValue * secondValue; break;
                case "÷":
                    if (secondValue != 0)
                        result = firstValue / secondValue;
                    else
                    {
                        MessageBox.Show("Tidak bisa dibagi 0!");
                        return;
                    }
                    break;
            }

            txtNominal.Text = result.ToString();
            currentInput = result.ToString();
            isOperatorPressed = false;
        }

        // Fungsi untuk tombol backspace
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (currentInput.Length > 0)
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
                txtNominal.Text = currentInput;
            }
        }

        //Side Bar

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home HomeForm = new Home();
            HomeForm.Show();
            this.Close();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            //form transaksi
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            Laporan LaporanForm = new Laporan();
            LaporanForm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDate.Value = DateTime.Now;
            if (txtKategori.Items.Count > 0)
                txtKategori.SelectedIndex = 0;
            txtNominal.Text = "";
            txtDeskripsi.Text = "";
            currentInput = "";
            firstValue = 0;
            operatorSimbol = "";
            isOperatorPressed = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string tanggal = txtDate.Value.ToString("yyyy-MM-dd");
            string kategori = txtKategori.Text.Trim().ToLower(); // Memastikan kategori dalam format lowercase
            string nominal = txtNominal.Text.Trim();
            string deskripsi = txtDeskripsi.Text.Trim();

            // Validasi kategori hanya Pemasukan atau Pengeluaran
            if (kategori != "pemasukan" && kategori != "pengeluaran")
            {
                MessageBox.Show("Kategori harus Pemasukan atau Pengeluaran.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(kategori) || string.IsNullOrWhiteSpace(nominal))
            {
                //MessageBox.Show("Kategori dan Nominal harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO transaksi (tanggal, kategori, nominal, deskripsi) VALUES (@tanggal, @kategori, @nominal, @deskripsi)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tanggal", tanggal);
                        cmd.Parameters.AddWithValue("@kategori", kategori); // Simpan lowercase
                        cmd.Parameters.AddWithValue("@nominal", Convert.ToDecimal(nominal));
                        cmd.Parameters.AddWithValue("@deskripsi", deskripsi);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Transaksi berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan transaksi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
