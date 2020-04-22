using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalniProjekatOOP
{
    class PremiumSoba : StandardnaSoba
    {
        public PremiumSoba()
        {
            cena = 10.000;
            sadrzaj = " LCD Televizod, Kablovska, Klima uredjaj, Besplatan wi-fi, Mini bar, Radni sto";
            brKreveta = 2;
        }
        public override void PorukaOSobi()
        {
           MessageBox.Show("Informacije o premium sobi: ");
        }
    }
}
