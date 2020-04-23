using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalniProjekatOOP
{
    class StandardnaSoba
    {
        public double cena;
        public string sadrzaj;
        public int brKreveta;

        public virtual void PorukaOSobi()
        {
           MessageBox.Show("Informacije o standardnoj sobi: ");
        }

        public StandardnaSoba()
        {
            cena = 5000;
            sadrzaj = "Televizod, Klima uredjaj, Besplatan wi-fi";
            brKreveta = 2;
        }
        public void Ispis()
        {
            MessageBox.Show("Cena sobe je: " + cena);
            MessageBox.Show("Sadrzaj sobe: " + sadrzaj);
            MessageBox.Show("Broj kreveta: " + brKreveta + "\n\n");
        }
        public int DodatniKrevet()
        {
            return brKreveta++;
        }


    }
}

