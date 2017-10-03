using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class T6
    {
        private readonly int Tila = 1;
        private readonly int Maxvolume = 9;
        private readonly int Minvolume = 0;

        private readonly double Maxtune = 26000.0;
        private readonly double Mintune = 2000.0;

        public double tune;
        public int volume;
        public int virta;

        public bool Käynnistys(int luku)
        {
            if (luku == Tila)
            {
                virta = luku;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Säädävolumea(int voimakkuus)
        {
            if (voimakkuus >= Minvolume && voimakkuus <= Maxvolume)
            {
                volume = voimakkuus;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Säädätaajuus(double taajuus)
        {
            if (taajuus >= Mintune && taajuus <= Maxtune)
            {
                tune = taajuus;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
