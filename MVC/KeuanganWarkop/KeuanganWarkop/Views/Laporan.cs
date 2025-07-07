using KeuanganWarkop.Controllers;
using KeuanganWarkop.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;


namespace KeuanganWarkop
{
    public partial class Laporan : Form
    {
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
                int tahun = Convert.ToInt32(cboTahun.SelectedItem);
                int bulan = dtBulan.Value.Month;

                TransaksiController controller = new TransaksiController();
                DataTable dt = controller.AmbilLaporan(tahun, bulan);

                dgvLaporan.DataSource = dt;
                HitungSaldo(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan laporan: " + ex.Message);
            }
        }


        private void dgvLaporan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dgvLaporan.Columns.Contains("aksi"))
            {
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.Name = "aksi";
                btnEdit.HeaderText = "Aksi";
                btnEdit.Text = "Edit/Hapus";
                btnEdit.UseColumnTextForButtonValue = true;
                dgvLaporan.Columns.Add(btnEdit);
            }

            if (e.ColumnIndex == dgvLaporan.Columns["aksi"].Index)
            {
                DataGridViewRow row = dgvLaporan.Rows[e.RowIndex];
                if (row == null || row.Cells["id_transaksi"].Value == null)
                    return;

                string idTransaksi = row.Cells["id_transaksi"].Value?.ToString() ?? "";
                string kategori = row.Cells["kategori"].Value?.ToString() ?? "";
                string nominal = row.Cells["nominal"].Value?.ToString() ?? "";
                string deskripsi = row.Cells["deskripsi"].Value?.ToString() ?? "";

                DialogResult result = MessageBox.Show("Pilih aksi: Edit (Yes) atau Hapus (No)?", "Pilih Aksi", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    EditTransaksi(idTransaksi, kategori, nominal, deskripsi);
                }
                else if (result == DialogResult.No)
                {
                    HapusTransaksi(idTransaksi);
                }
            }
        }


        private void EditTransaksi(string idTransaksi, string kategori, string nominal, string deskripsi)
        {
            EditTransaksiForm editForm = new EditTransaksiForm(idTransaksi, kategori, nominal, deskripsi);
            editForm.OnTransaksiUpdated += () =>
            {
                TampilkanLaporan();
            };
            editForm.Show();
        }

        private void HapusTransaksi(string idTransaksi)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Apakah Anda yakin ingin menghapus transaksi ini?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    TransaksiController controller = new TransaksiController();
                    controller.HapusTransaksi(idTransaksi);

                    MessageBox.Show("Transaksi berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TampilkanLaporan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus transaksi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
            TampilkanLaporan();
        }

        private void Laporan_Load(object sender, EventArgs e)
        {
            for (int i = 2023; i <= DateTime.Now.Year; i++)
            {
                cboTahun.Items.Add(i);
            }
            cboTahun.SelectedItem = DateTime.Now.Year;

            dtBulan.CustomFormat = "MM";
            dtBulan.Format = DateTimePickerFormat.Custom;
            dtBulan.Value = DateTime.Now;

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

        private void btnLaporan_Click(object sender, EventArgs e) { }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPageHandler);
            previewDialog.Document = printDocument;
            previewDialog.ShowDialog();
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgvLaporan.Width, this.dgvLaporan.Height);
            dgvLaporan.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvLaporan.Width, this.dgvLaporan.Height));
            e.Graphics.DrawImage(bm, 20, 20);
        }
    }
}
