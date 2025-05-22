using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KeuanganWarkop
{
    public partial class Transaksi : Form
    {
        string currentInput = "";
        string operatorSimbol = "";
        decimal firstValue = 0;
        bool isOperatorPressed = false;

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

            // Tombol Clear dan Submit
            btnClear.Click += btnClear_Click;
            btnSubmit.Click += btnSubmit_Click;
            this.Load += Transaksi_Load;
        }

        private void LoadKategoriGabungan()
        {
            txtKategori.Items.Clear();
            txtKategori.Items.Add("Pemasukan");
            txtKategori.Items.Add("Pengeluaran");
            txtKategori.SelectedIndex = 0;
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            LoadKategoriGabungan();
        }

        private string ToTitleCase(string text)
        {
            if (string.IsNullOrEmpty(text)) return text;
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
        }

        private void Angka_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            currentInput += btn.Text;
            txtNominal.Text = currentInput;
        }

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

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (currentInput.Length > 0)
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
                txtNominal.Text = currentInput;
            }
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
            string kategori = txtKategori.Text.Trim().ToLower();
            string nominal = txtNominal.Text.Trim();
            string deskripsi = txtDeskripsi.Text.Trim();

            if (kategori != "pemasukan" && kategori != "pengeluaran")
            {
                MessageBox.Show("Kategori harus Pemasukan atau Pengeluaran.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(kategori) || string.IsNullOrWhiteSpace(nominal))
            {
                return;
            }

            try
            {
                using (MySqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO transaksi (tanggal, kategori, nominal, deskripsi) VALUES (@tanggal, @kategori, @nominal, @deskripsi)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tanggal", tanggal);
                        cmd.Parameters.AddWithValue("@kategori", kategori);
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home HomeForm = new Home();
            HomeForm.Show();
            this.Close();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
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
    }
}
