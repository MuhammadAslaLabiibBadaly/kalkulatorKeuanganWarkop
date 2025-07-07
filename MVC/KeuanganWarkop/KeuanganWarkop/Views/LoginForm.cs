using System;
using System.Windows.Forms;
using KeuanganWarkop.Models;
using KeuanganWarkop.Controllers;
using MySql.Data.MySqlClient;

namespace KeuanganWarkop
{
    public partial class LoginForm : Form
    {
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

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Silakan isi Username dan Password.");
                return;
            }

            try
            {
                var controller = new UserController();
                bool loginBerhasil = controller.LoginUser(username, password);

                if (loginBerhasil)
                {
                    MessageBox.Show("Login berhasil!");
                    this.Hide();
                    new Home().Show();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah!");
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
