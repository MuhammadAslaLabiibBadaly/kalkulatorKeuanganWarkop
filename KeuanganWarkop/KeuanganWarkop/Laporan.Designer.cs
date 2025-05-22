namespace KeuanganWarkop
{
    partial class Laporan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnExit = new Button();
            btnLaporan = new Button();
            btnTransaksi = new Button();
            btnHome = new Button();
            label1 = new Label();
            label2 = new Label();
            dtBulan = new DateTimePicker();
            dgvLaporan = new DataGridView();
            cboTahun = new ComboBox();
            lblSaldo = new Label();
            btnTampilkan = new Button();
            btnCetak = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnLaporan);
            panel1.Controls.Add(btnTransaksi);
            panel1.Controls.Add(btnHome);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 452);
            panel1.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(22, 395);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(124, 40);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLaporan
            // 
            btnLaporan.Location = new Point(22, 200);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(124, 40);
            btnLaporan.TabIndex = 0;
            btnLaporan.Text = "Laporan";
            btnLaporan.UseVisualStyleBackColor = true;
            btnLaporan.Click += btnLaporan_Click;
            // 
            // btnTransaksi
            // 
            btnTransaksi.Location = new Point(22, 127);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(124, 40);
            btnTransaksi.TabIndex = 0;
            btnTransaksi.Text = "Transaksi";
            btnTransaksi.UseVisualStyleBackColor = true;
            btnTransaksi.Click += btnTransaksi_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(22, 55);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(124, 40);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(185, 12);
            label1.Name = "label1";
            label1.Size = new Size(188, 28);
            label1.TabIndex = 3;
            label1.Text = "Laporan Keuangan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 64);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "Bulan";
            // 
            // dtBulan
            // 
            dtBulan.CustomFormat = "MMMM";
            dtBulan.Location = new Point(282, 59);
            dtBulan.Name = "dtBulan";
            dtBulan.Size = new Size(108, 27);
            dtBulan.TabIndex = 5;
            // 
            // dgvLaporan
            // 
            dgvLaporan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaporan.Location = new Point(200, 126);
            dgvLaporan.Name = "dgvLaporan";
            dgvLaporan.RowHeadersWidth = 51;
            dgvLaporan.Size = new Size(553, 251);
            dgvLaporan.TabIndex = 6;
            // 
            // cboTahun
            // 
            cboTahun.FormattingEnabled = true;
            cboTahun.Location = new Point(420, 59);
            cboTahun.Name = "cboTahun";
            cboTahun.Size = new Size(95, 28);
            cboTahun.TabIndex = 7;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaldo.Location = new Point(200, 397);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(118, 28);
            lblSaldo.TabIndex = 8;
            lblSaldo.Text = "Sisa Saldo :";
            // 
            // btnTampilkan
            // 
            btnTampilkan.BackColor = Color.Lime;
            btnTampilkan.Location = new Point(546, 59);
            btnTampilkan.Name = "btnTampilkan";
            btnTampilkan.Size = new Size(122, 28);
            btnTampilkan.TabIndex = 9;
            btnTampilkan.Text = "Tampilkan";
            btnTampilkan.UseVisualStyleBackColor = false;
            btnTampilkan.Click += btnTampilkan_Click;
            // 
            // btnCetak
            // 
            btnCetak.BackColor = Color.Gold;
            btnCetak.Location = new Point(674, 58);
            btnCetak.Name = "btnCetak";
            btnCetak.Size = new Size(94, 29);
            btnCetak.TabIndex = 10;
            btnCetak.Text = "Cetak";
            btnCetak.UseVisualStyleBackColor = false;
            btnCetak.Click += btnCetak_Click;
            // 
            // Laporan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCetak);
            Controls.Add(btnTampilkan);
            Controls.Add(lblSaldo);
            Controls.Add(cboTahun);
            Controls.Add(dgvLaporan);
            Controls.Add(dtBulan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Laporan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laporan";
            Load += Laporan_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnLaporan;
        private Button btnTransaksi;
        private Button btnHome;
        private Label label1;
        private Label label2;
        private DateTimePicker dtBulan;
        private DataGridView dgvLaporan;
        private ComboBox cboTahun;
        private Label lblSaldo;
        private Button btnTampilkan;
        private Button btnCetak;
    }
}