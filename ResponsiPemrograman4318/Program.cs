using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("No Nik\t\t Nama\t\t Gaji Bulanan");
            Console.WriteLine("----------------------------------------------");
            Karyawan karyawan1 = new Karyawan("Kurniawan", "762535", 3000000);

            if(karyawan1.GajiBulanan < 0){
                Console.WriteLine("Gaji Bulanan tidak boleh kurang dari 0");
            }
            else{
                Console.WriteLine("1. {0} \t {1} \t {2}", karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan);
            }

            Karyawan karyawan2 = new Karyawan("Kurniadi", "231223", 2500000);

            if(karyawan2.GajiBulanan < 0){
                Console.WriteLine("Gaji Bulanan tidak boleh kurang dari 0");
            }
            else{
                Console.WriteLine("2. {0} \t {1} \t {2}", karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan);
            }

            Console.WriteLine();
            Console.WriteLine("Asyiiikkkk kenaikan gaji 10%");
            Console.WriteLine();
            Console.WriteLine("No Nik\t\t Nama\t\t Gaji Bulanan");
            Console.WriteLine("----------------------------------------------");

            karyawan1.GajiBulanan = karyawan1.GajiBulanan + (karyawan1.GajiBulanan / 10);
            karyawan2.GajiBulanan = karyawan2.GajiBulanan + (karyawan2.GajiBulanan / 10);

            Console.WriteLine("1. {0} \t {1} \t {2}", karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2. {0} \t {1} \t {2}", karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan);

            Console.ReadKey();
        }
    }
}