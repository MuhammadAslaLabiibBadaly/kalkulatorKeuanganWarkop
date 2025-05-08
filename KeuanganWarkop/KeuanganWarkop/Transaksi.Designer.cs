namespace KeuanganWarkop
{
    partial class Transaksi
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtDate = new DateTimePicker();
            txtKategori = new ComboBox();
            txtNominal = new TextBox();
            txtDeskripsi = new TextBox();
            btnSubmit = new Button();
            btnClear = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnBagi = new Button();
            btnKali = new Button();
            btnPlus = new Button();
            btnMines = new Button();
            btnBackspace = new Button();
            btnSamdeng = new Button();
            panel1.SuspendLayout();
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
            panel1.TabIndex = 3;
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
            label1.Location = new Point(188, 19);
            label1.Name = "label1";
            label1.Size = new Size(191, 28);
            label1.TabIndex = 4;
            label1.Text = "Form Tambah Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 74);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 5;
            label2.Text = "Tanggal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 126);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 5;
            label3.Text = "Kategori";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(204, 174);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 5;
            label4.Text = "Nominal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(204, 219);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 5;
            label5.Text = "Deskripsi";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(300, 71);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(260, 27);
            txtDate.TabIndex = 6;
            // 
            // txtKategori
            // 
            txtKategori.FormattingEnabled = true;
            txtKategori.Location = new Point(300, 123);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(260, 28);
            txtKategori.TabIndex = 7;
            // 
            // txtNominal
            // 
            txtNominal.Location = new Point(300, 171);
            txtNominal.Name = "txtNominal";
            txtNominal.Size = new Size(260, 27);
            txtNominal.TabIndex = 8;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(300, 219);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(260, 144);
            txtDeskripsi.TabIndex = 8;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(300, 388);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(110, 38);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(450, 388);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 38);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Location = new Point(602, 66);
            btn1.Name = "btn1";
            btn1.Size = new Size(35, 35);
            btn1.TabIndex = 10;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Location = new Point(666, 66);
            btn2.Name = "btn2";
            btn2.Size = new Size(35, 35);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(730, 66);
            btn3.Name = "btn3";
            btn3.Size = new Size(35, 35);
            btn3.TabIndex = 10;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(602, 116);
            btn4.Name = "btn4";
            btn4.Size = new Size(35, 35);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(666, 116);
            btn5.Name = "btn5";
            btn5.Size = new Size(35, 35);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Location = new Point(730, 116);
            btn6.Name = "btn6";
            btn6.Size = new Size(35, 35);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Location = new Point(602, 167);
            btn7.Name = "btn7";
            btn7.Size = new Size(35, 35);
            btn7.TabIndex = 10;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Location = new Point(666, 167);
            btn8.Name = "btn8";
            btn8.Size = new Size(35, 35);
            btn8.TabIndex = 10;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Location = new Point(730, 167);
            btn9.Name = "btn9";
            btn9.Size = new Size(35, 35);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Location = new Point(602, 219);
            btn0.Name = "btn0";
            btn0.Size = new Size(35, 35);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnBagi
            // 
            btnBagi.Location = new Point(666, 219);
            btnBagi.Name = "btnBagi";
            btnBagi.Size = new Size(35, 35);
            btnBagi.TabIndex = 10;
            btnBagi.Text = "÷";
            btnBagi.UseVisualStyleBackColor = true;
            // 
            // btnKali
            // 
            btnKali.Location = new Point(730, 219);
            btnKali.Name = "btnKali";
            btnKali.Size = new Size(35, 35);
            btnKali.TabIndex = 10;
            btnKali.Text = "×";
            btnKali.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(602, 276);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(35, 35);
            btnPlus.TabIndex = 10;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnMines
            // 
            btnMines.Location = new Point(666, 276);
            btnMines.Name = "btnMines";
            btnMines.Size = new Size(35, 35);
            btnMines.TabIndex = 10;
            btnMines.Text = "-";
            btnMines.UseVisualStyleBackColor = true;
            // 
            // btnBackspace
            // 
            btnBackspace.Location = new Point(730, 276);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(35, 35);
            btnBackspace.TabIndex = 10;
            btnBackspace.Text = "⌫";
            btnBackspace.UseVisualStyleBackColor = true;
            // 
            // btnSamdeng
            // 
            btnSamdeng.Location = new Point(602, 328);
            btnSamdeng.Name = "btnSamdeng";
            btnSamdeng.Size = new Size(163, 35);
            btnSamdeng.TabIndex = 10;
            btnSamdeng.Text = "=";
            btnSamdeng.UseVisualStyleBackColor = true;
            // 
            // Transaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSamdeng);
            Controls.Add(btnBackspace);
            Controls.Add(btnKali);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btn3);
            Controls.Add(btnMines);
            Controls.Add(btnPlus);
            Controls.Add(btnBagi);
            Controls.Add(btn0);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(txtDeskripsi);
            Controls.Add(txtNominal);
            Controls.Add(txtKategori);
            Controls.Add(txtDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Transaksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transaksi";
            panel1.ResumeLayout(false);
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
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker txtDate;
        private ComboBox txtKategori;
        private TextBox txtNominal;
        private TextBox txtDeskripsi;
        private Button btnSubmit;
        private Button btnClear;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnBagi;
        private Button btnKali;
        private Button btnPlus;
        private Button btnMines;
        private Button btnBackspace;
        private Button btnSamdeng;
    }
}