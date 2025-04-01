using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== KALKULATOR SEDERHANA ===");
                Console.WriteLine("Pilih operasi yang diinginkan:");
                Console.WriteLine("1. Penjumlahan (+)");
                Console.WriteLine("2. Pengurangan (-)");
                Console.WriteLine("3. Perkalian (*)");
                Console.WriteLine("4. Pembagian (/)");
                Console.WriteLine("5. Keluar");
                Console.Write("Masukkan pilihan (1-5): ");

                int pilihan = int.Parse(Console.ReadLine());

                if (pilihan == 5)
                {
                    Console.WriteLine("Program dihentikan. Terima kasih telah menggunakan kalkulator ini!");
                    break;
                }

                Console.Write("Masukkan angka pertama: ");
                double angka1 = double.Parse(Console.ReadLine());

                Console.Write("Masukkan angka kedua: ");
                double angka2 = double.Parse(Console.ReadLine());

                double hasil = 0;

                switch (pilihan)
                {
                    case 1:
                        hasil = angka1 + angka2;
                        Console.WriteLine($"Hasil: {angka1} + {angka2} = {hasil}");
                        break;
                    case 2:
                        hasil = angka1 - angka2;
                        Console.WriteLine($"Hasil: {angka1} - {angka2} = {hasil}");
                        break;
                    case 3:
                        hasil = angka1 * angka2;
                        Console.WriteLine($"Hasil: {angka1} * {angka2} = {hasil}");
                        break;
                    case 4:
                        if (angka2 != 0)
                        {
                            hasil = angka1 / angka2;
                            Console.WriteLine($"Hasil: {angka1} / {angka2} = {hasil}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Pembagian dengan nol tidak diperbolehkan.");
                        }
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Silakan pilih antara 1-5.");
                        break;
                }

                Console.WriteLine("\nTekan tombol apa saja untuk melanjutkan...");
                Console.ReadKey();
            }
        }
    }
}
