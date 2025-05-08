namespace KeuanganWarkop
{
    partial class Home
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
            panel2 = new Panel();
            lblPemasukan = new Label();
            label2 = new Label();
            panel3 = new Panel();
            lblPengeluaran = new Label();
            label3 = new Label();
            panel4 = new Panel();
            lblSaldo = new Label();
            label4 = new Label();
            label5 = new Label();
            dgvRiwayat = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnLaporan);
            panel1.Controls.Add(btnTransaksi);
            panel1.Controls.Add(btnHome);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 452);
            panel1.TabIndex = 0;
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
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 9);
            label1.Name = "label1";
            label1.Size = new Size(268, 31);
            label1.TabIndex = 1;
            label1.Text = "Keuangan Warung Kopi";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Moccasin;
            panel2.Controls.Add(lblPemasukan);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(182, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(181, 108);
            panel2.TabIndex = 2;
            // 
            // lblPemasukan
            // 
            lblPemasukan.AutoSize = true;
            lblPemasukan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPemasukan.Location = new Point(12, 72);
            lblPemasukan.Name = "lblPemasukan";
            lblPemasukan.Size = new Size(48, 25);
            lblPemasukan.TabIndex = 1;
            lblPemasukan.Text = "Rp.0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 3);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 0;
            label2.Text = "Pemasukan";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Moccasin;
            panel3.Controls.Add(lblPengeluaran);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(390, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(181, 108);
            panel3.TabIndex = 3;
            // 
            // lblPengeluaran
            // 
            lblPengeluaran.AutoSize = true;
            lblPengeluaran.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPengeluaran.Location = new Point(16, 72);
            lblPengeluaran.Name = "lblPengeluaran";
            lblPengeluaran.Size = new Size(48, 25);
            lblPengeluaran.TabIndex = 1;
            lblPengeluaran.Text = "Rp.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 3);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 0;
            label3.Text = "Pengeluaran";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Moccasin;
            panel4.Controls.Add(lblSaldo);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(597, 54);
            panel4.Name = "panel4";
            panel4.Size = new Size(181, 108);
            panel4.TabIndex = 3;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSaldo.Location = new Point(19, 72);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(48, 25);
            lblSaldo.TabIndex = 1;
            lblSaldo.Text = "Rp.0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(63, 3);
            label4.Name = "label4";
            label4.Size = new Size(49, 28);
            label4.TabIndex = 0;
            label4.Text = "Sisa";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(173, 189);
            label5.Name = "label5";
            label5.Size = new Size(203, 31);
            label5.TabIndex = 1;
            label5.Text = "Riwayat Transaksi";
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayat.Location = new Point(182, 246);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.RowHeadersWidth = 51;
            dgvRiwayat.Size = new Size(596, 188);
            dgvRiwayat.TabIndex = 4;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvRiwayat);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Keuangan Warung Kopi";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Label lblPemasukan;
        private Label lblPengeluaran;
        private Label lblSaldo;
        private Label label5;
        private Button btnExit;
        private Button btnLaporan;
        private Button btnTransaksi;
        private Button btnHome;
        private DataGridView dgvRiwayat;
    }
}