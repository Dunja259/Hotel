using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalniProjekatOOP
{
    public partial class Rezervacija : Form
    {
        public Rezervacija()
        {
            InitializeComponent();
        }
        private void Pozdrav_Click(object sender, EventArgs e)
        {
            Hotel hotel = new Hotel();
            Hotel.Pozdrav();
        }
        private void Informacije_Click(object sender, EventArgs e)
        {
            Hotel hotel = new Hotel("Novi sad", 4, true);
            hotel.Ispis();
        }
        private void OdabirSobeTextChanged(object sender, EventArgs e)
        {
            if (OdabirSobe.Text == "premium")
            {
                MessageBox.Show("Uspesno izabrana soba - premium.");
            }
            else if (OdabirSobe.Text == "standard")
            {
                MessageBox.Show("Uspesno izabrana soba - standardna.");
            }
        }
        private void ssoba_CheckedChanged(object sender, EventArgs e)
        {
            StandardnaSoba soba = new StandardnaSoba();
            soba.PorukaOSobi();
            soba.Ispis();
        }
        private void psoba_CheckedChanged(object sender, EventArgs e)
        {
            PremiumSoba soba = new PremiumSoba();
            soba.PorukaOSobi();
            soba.Ispis();
        }
        private void DSobaClick_1(object sender, EventArgs e)
        {
            Hotel.Soba soba = new Hotel.Soba(1);
            MessageBox.Show("Trenutno na raspolaganju imamo " + soba.brSoba + " slobodnu sobu.");
        }
        private void Odjava_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Dodjite nam opet!");
            Application.Exit();
        }
        private void radnovreme_Click(object sender, EventArgs e)
        {
            KontaktTelefon vreme = new KontaktTelefon("broj");
            vreme.BrTel();
            vreme.Vradnidan();
            vreme.Vvikend();
        }

        private void OdabirDatumaTextChanged(object sender, EventArgs e)
        {

            if (OdabirDatuma.Text == "ponedeljak")
            {
                MessageBox.Show("Uspesno sacuvan dan.");
            }
            else if (OdabirDatuma.Text == "utorak")
            {
                MessageBox.Show("Uspesno sacuvan dan.");
            }
            else if (OdabirDatuma.Text == "sreda")
            {
                MessageBox.Show("Uspesno sacuvan dan.");
            }
            else if (OdabirDatuma.Text == "cetvrtak")
            {
                MessageBox.Show("Uspesno sacuvan dan.");
            }
            else if (OdabirDatuma.Text == "petak")
            {
                MessageBox.Show("Uspesno sacuvan dan.");
            }
            else if (OdabirDatuma.Text == "subota")
            {
                MessageBox.Show("Uspesno sacuvan dan.");
            }
            else if (OdabirDatuma.Text == "nedelja")
            {
                MessageBox.Show("Uspesno sacuvan dan.");
            }
        }

        private void Dodatnikrevet_Click(object sender, EventArgs e)
        {
            StandardnaSoba soba = new StandardnaSoba();
            soba.DodatniKrevet();
            MessageBox.Show("Uspesno dodat krevet.");
        }
    }
}
