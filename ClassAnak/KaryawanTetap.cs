using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OPPdanCollection2723.ClassInduk;

namespace OPPdanCollection2723.ClassAnak
{
    class KaryawanTetap : Karyawan
    {
        public int GajiBulanan {get; set;}

        public override int Gaji() => GajiBulanan;
        
    }
}
