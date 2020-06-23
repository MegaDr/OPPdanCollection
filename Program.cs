using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OPPdanCollection2723.ClassInduk;
using OPPdanCollection2723.ClassAnak;
namespace OPPdanCollection2723
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Abstraction & Collection";

            //membuat objek untuk semua karyawan

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "123-456-789";
            karyawanTetap.Nama = "Mega Dwirani Rodja";
            karyawanTetap.GajiBulanan = 5000000;

           KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "987-654-321";
            karyawanHarian.Nama = "Hanum Mega";
            karyawanHarian.JumlahJamKerja = 6;
            karyawanHarian.UpahPerJam = 150000;

            Sales sales = new Sales();
            sales.Nik = "111-222-333";
            sales.Nama = "Uli Novianty";
            sales.JumlahPenjualan = 50;
            sales.Komisi = 55000;

            //objek class collection
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());

                noUrut++;
            } 

            Console.ReadKey();
        }
    }
}
