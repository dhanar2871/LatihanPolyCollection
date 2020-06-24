using System;
using Collection.induk;
using Collection.anak;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) -- Polymorphism, Abstraction & Collection ";
        
            KaryawanTetap karyawantetap = new KaryawanTetap();
            karyawantetap.Nik = "19-11-2871";
            karyawantetap.Nama = "dhanar.r.k";
            karyawantetap.GajiBulanan = 10000000;

            KaryawanHarian karyawanharian = new KaryawanHarian();
            karyawanharian.Nik = "19-11-1234";
            karyawanharian.Nama = "d.rizky.k";
            karyawanharian.JumlahJamKerja = 8;
            karyawanharian.UpahPerJam = 50000;

            Sales sales = new Sales();
            sales.Nik = "19-11-4321";
            sales.Nama = "d.r.krisnadhy";
            sales.JumlahPenjualan = 20;
            sales.Komisi = 35000;
            // objek class collection
            List<Karyawan> listkaryawan = new List<Karyawan>();

            listkaryawan.Add(karyawantetap);
            listkaryawan.Add(karyawanharian);
            listkaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine("{0}. Nik: {1} Nama: {2} Gaji: {3:N0}",
                    noUrut,
                    karyawan.Nik,
                    karyawan.Nama,
                    karyawan.TotalGaji());

                noUrut++;
            }
            
            Console.ReadKey();
        }
    }
}