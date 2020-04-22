using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalniProjekatOOP
{
    class KontaktTelefon : RadnoVreme
    {
        public KontaktTelefon(string broj)
        {
            this.broj = broj;

        }
        public KontaktTelefon()
        {

        }

        public override void BrTel()
        {
            MessageBox.Show("066/157-2219");
        }
    }
}
