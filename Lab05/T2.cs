using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Tuote
    {
        public string Nimi { get; set; }
        public string Sijainti { get; set; }

        public Tuote()
        {
        }
        public Tuote(string nimi, string sijainti)
        {
            Nimi = nimi;
            Sijainti = sijainti;
        }
        public override string ToString()
        {
            return Nimi + " löytyy paikasta " + Sijainti;
        }
    }
    class Jkaappi
    {
        public string Name { get; set; }
        public List<Tuote> tuote;
        
        public Jkaappi()
        {
            tuote = new List<Tuote>();

        }
        
        public override string ToString()
        {
            string retval = Name + ", tuotteet ja paikat.\n";
            foreach (Tuote item in tuote)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }
    }
}
