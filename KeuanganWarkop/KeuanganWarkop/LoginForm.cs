using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KeuanganWarkop
{
    public partial class LoginForm : Form
    {
        private string connectionString = "server=127.0.0.1; user=root; database=keuanganwarkop; password=";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Bisa tambahkan kode inisialisasi di sini jika perlu
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Silakan isi Username dan Password.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM login WHERE username = @username AND password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Login berhasil!");
                            this.Hide();

                            Home homeForm = new Home();
                            homeForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Username atau Password salah!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide(); // Menyembunyikan form login dan membuka form register
        }
    }
}
