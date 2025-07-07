using KeuanganWarkop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeuanganWarkop.Controllers
{
    public class TransaksiController
    {
        public DataTable AmbilLaporan(int tahun, int bulan)
        {
            return TransaksiModel.GetByMonthYear(tahun, bulan);
        }

        public void SimpanTransaksi(string tanggal, string kategori, decimal nominal, string deskripsi)
        {
            TransaksiModel.Insert(tanggal, kategori, nominal, deskripsi);
        }

        public void EditTransaksi(string id, string kategori, decimal nominal, string deskripsi)
        {
            TransaksiModel.Update(id, kategori, nominal, deskripsi);
        }

        public void HapusTransaksi(string id)
        {
            TransaksiModel.Delete(id);
        }

        public (decimal pemasukan, decimal pengeluaran) AmbilRingkasan()
        {
            return TransaksiModel.GetSummary();
        }

        public DataTable AmbilRiwayatTerakhir(int jumlah = 10)
        {
            return TransaksiModel.GetLatestTransaksi(jumlah);
        }

    }
}
