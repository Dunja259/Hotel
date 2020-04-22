using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalniProjekatOOP
{
    class Hotel
    {
        private string cenaPoNoci;
        private string lokacija;
        private int brojZvezdica;
        private bool bazen;

        public string CenaPoNoci
        {
            get { return cenaPoNoci; }
        }
        public string Lokacija
        {
            get { return lokacija; }
        }
        public int BrojZvezdica
        {
            get { return brojZvezdica; }
            set
            {
                if (value == 1 || value == 2 || value == 3 || value == 4 || value == 5)
                {
                    brojZvezdica = value;
                }
                else
                {
                    brojZvezdica = 0;
                }
            }
        }
        public bool Bazen
        {
            get { return bazen; }
        }

        public Hotel(string lokacija, int brojZvezdica, bool bazen)
        {
            cenaPoNoci = "Od 5000 do 10.000 din. (U zavisnosti od sobe)";
            this.lokacija = lokacija;
            this.BrojZvezdica = brojZvezdica;
            this.bazen = bazen;
        }
        public Hotel()
        {

        }
        public static void Pozdrav()
        {
            MessageBox.Show("Dobrodosli u nas Hotel!");   
        }
        public void Ispis()
        {
            MessageBox.Show("Cena po noci: " + CenaPoNoci);
            MessageBox.Show("Lokacija: " + Lokacija);
            MessageBox.Show("Broj zvezdica: " + BrojZvezdica);
            MessageBox.Show("Bazen: " + Bazen);
        }


        public class Soba
        {
            public int brSoba;

            public Soba(int brSoba)
            {
                this.brSoba = brSoba;
            }
           
        }

    }
}

