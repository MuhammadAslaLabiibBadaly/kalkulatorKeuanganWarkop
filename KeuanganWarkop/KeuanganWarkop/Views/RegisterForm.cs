using System;
using System.Windows.Forms;
using KeuanganWarkop.Models;
using KeuanganWarkop.Controllers;
using MySql.Data.MySqlClient;

namespace KeuanganWarkop
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Semua field harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password dan Konfirmasi Password tidak cocok.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var userController = new UserController();
                bool success = userController.RegisterUser(username, password);

                if (success)
                {
                    MessageBox.Show("Pendaftaran berhasil. Silakan login.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    new LoginForm().Show();
                }
                else
                {
                    MessageBox.Show("Gagal mendaftar. Coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }


        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
