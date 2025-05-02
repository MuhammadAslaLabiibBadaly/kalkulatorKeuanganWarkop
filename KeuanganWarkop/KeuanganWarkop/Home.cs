using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeuanganWarkop
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home HomeForm = new Home();
            HomeForm.show();
            this.Hide();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kepencet");
            //Transaksi TransaksiForm = new Transaksi();
            //TransaksiForm.Show();
            //this.Hide();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            Laporan LaporanForm = new Laporan();
            LaporanForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
