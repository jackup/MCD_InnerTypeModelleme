using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_InnerTypeModelleme
{
    class MusteriIletisimBilgisi
    {
        public int iletisimTip { get; set; } //717770001 : Mobil - 71777002 : Sabit Hat
        public string alanKodu { get; set; }
        public string numara { get; set; }
        public bool aktifPasif { get; set; }

        public void MusteriIletisimBilgisiTestMetod()
        {
            Console.WriteLine("MusteriIletisimTestMetod");
        }
    }
}
