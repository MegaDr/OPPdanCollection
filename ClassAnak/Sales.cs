using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPPdanCollection2723.ClassInduk;
namespace OPPdanCollection2723.ClassAnak
{
    class Sales : Karyawan
    {
        public int JumlahPenjualan { get; set; }
        public int Komisi { get; set; }

        public override int Gaji() => JumlahPenjualan * Komisi;
      
    }
}
