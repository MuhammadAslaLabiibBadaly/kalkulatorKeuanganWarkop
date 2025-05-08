namespace KeuanganWarkop
{
    partial class EditTransaksiForm
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
            txtNominal = new TextBox();
            txtKategori = new ComboBox();
            txtDeskripsi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSimpan = new Button();
            btnBatal = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtNominal
            // 
            txtNominal.Location = new Point(336, 200);
            txtNominal.Name = "txtNominal";
            txtNominal.Size = new Size(195, 27);
            txtNominal.TabIndex = 0;
            // 
            // txtKategori
            // 
            txtKategori.FormattingEnabled = true;
            txtKategori.Location = new Point(336, 154);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(195, 28);
            txtKategori.TabIndex = 1;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(336, 244);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(195, 27);
            txtDeskripsi.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 161);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 3;
            label1.Text = "Kategori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 203);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Nominal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 247);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 3;
            label3.Text = "Deskripsi";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(279, 310);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 4;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(426, 310);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 29);
            btnBatal.TabIndex = 5;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(257, 81);
            label4.Name = "label4";
            label4.Size = new Size(174, 31);
            label4.TabIndex = 6;
            label4.Text = "Form Edit Data";
            // 
            // EditTransaksiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDeskripsi);
            Controls.Add(txtKategori);
            Controls.Add(txtNominal);
            Name = "EditTransaksiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditTransaksiForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNominal;
        private ComboBox txtKategori;
        private TextBox txtDeskripsi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSimpan;
        private Button btnBatal;
        private Label label4;
    }
}