using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program{
    class Karyawan{
        // Properties
        public string Nama { get; set; }
        public string Nik { get; set; }
        public int GajiBulanan { get; set; }

        // Constructor
        public Karyawan(string nama, string nik, int gaji){
            this.Nama = nama;
            this.Nik = nik;
            this.GajiBulanan = gaji;
        }
    }
}