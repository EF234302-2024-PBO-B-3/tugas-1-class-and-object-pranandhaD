using System;
using ClassAndObject.Perpustakaan;
using ClassAndObject.Kendaraan;
using ClassAndObject.TokoLaptop;
using ClassAndObject.TokoSepeda;
using ClassAndObject.OperasiMatematika;

namespace ClassAndObject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Buku
            Buku buku = new Buku("Laskar Pelangi", "Andrea Hirata", 2005);
            buku.TampilkanInfo();

            Console.WriteLine();

            // Kendaraan
            Mobil mobil = new Mobil("Toyota", "Corolla", 2020);
            mobil.TampilkanSpesifikasi();

            Console.WriteLine();

            // Laptop
            Laptop laptop = new Laptop("Dell", "Intel Core i7", 16, 512);
            laptop.TampilkanSpesifikasi();

            Console.WriteLine();

            // Sepeda
            Sepeda sepeda = new Sepeda("Polygon", "Mountain Bike", 14.5);
            sepeda.TampilkanInformasi();

            Console.WriteLine();

            // Kalkulator
            Kalkulator kalkulator = new Kalkulator();
            double a = 10;
            double b = 5;
            Console.WriteLine($"Penjumlahan: {a} + {b} = {kalkulator.Tambah(a, b)}");
            Console.WriteLine($"Pengurangan: {a} - {b} = {kalkulator.Kurang(a, b)}");
            Console.WriteLine($"Perkalian: {a} * {b} = {kalkulator.Kali(a, b)}");
            Console.WriteLine($"Pembagian: {a} / {b} = {kalkulator.Bagi(a, b)}");
            Console.WriteLine($"Pembagian dengan nol: {a} / 0 = {kalkulator.Bagi(a, 0)}");
        }
    }
}