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
            labelPemasukan = new Label();
            label2 = new Label();
            panel3 = new Panel();
            labelPengeluaran = new Label();
            label3 = new Label();
            panel4 = new Panel();
            labelSisa = new Label();
            label4 = new Label();
            label5 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tabControl1.SuspendLayout();
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
            panel2.Controls.Add(labelPemasukan);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(182, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(181, 108);
            panel2.TabIndex = 2;
            // 
            // labelPemasukan
            // 
            labelPemasukan.AutoSize = true;
            labelPemasukan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPemasukan.Location = new Point(12, 72);
            labelPemasukan.Name = "labelPemasukan";
            labelPemasukan.Size = new Size(48, 25);
            labelPemasukan.TabIndex = 1;
            labelPemasukan.Text = "Rp.0";
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
            panel3.Controls.Add(labelPengeluaran);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(390, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(181, 108);
            panel3.TabIndex = 3;
            // 
            // labelPengeluaran
            // 
            labelPengeluaran.AutoSize = true;
            labelPengeluaran.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPengeluaran.Location = new Point(16, 72);
            labelPengeluaran.Name = "labelPengeluaran";
            labelPengeluaran.Size = new Size(48, 25);
            labelPengeluaran.TabIndex = 1;
            labelPengeluaran.Text = "Rp.0";
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
            panel4.Controls.Add(labelSisa);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(597, 54);
            panel4.Name = "panel4";
            panel4.Size = new Size(181, 108);
            panel4.TabIndex = 3;
            // 
            // labelSisa
            // 
            labelSisa.AutoSize = true;
            labelSisa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSisa.Location = new Point(19, 72);
            labelSisa.Name = "labelSisa";
            labelSisa.Size = new Size(48, 25);
            labelSisa.TabIndex = 1;
            labelSisa.Text = "Rp.0";
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(182, 233);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(596, 205);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(588, 172);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(588, 172);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
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
            tabControl1.ResumeLayout(false);
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
        private Label labelPemasukan;
        private Label labelPengeluaran;
        private Label labelSisa;
        private Label label5;
        private Button btnExit;
        private Button btnLaporan;
        private Button btnTransaksi;
        private Button btnHome;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}