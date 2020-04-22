using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalniProjekatOOP
{
    abstract class RadnoVreme
    {
        public string broj;

        public abstract void BrTel();

        public void Vradnidan()
        {
           MessageBox.Show("Radni dan: od 8h-20h.");

        }
        public void Vvikend()
        {
           MessageBox.Show("Vikend: od 10h-16h.");
        }
    }
}
