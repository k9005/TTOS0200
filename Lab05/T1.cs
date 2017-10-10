using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Tyres
    {
        string Merkki { get; set; }
        string Tyyppi { get; set; }
        int Koko { get; set; }

        public Tyres()
        {

        }
        public Tyres(string merkki, string tyyppi, int koko)
        {
            Merkki = merkki;
            Tyyppi = tyyppi;
            Koko = koko;
        }
        public override string ToString()
        {
            return "Merkki: " + Merkki + " Tyyppi: " + Tyyppi + " Koko: " + Koko;
        }

    }
    class Type
    {
        public string Name { get; set; }
        public List<Tyres> renkaat;
        
        public Type()
        {
            renkaat = new List<Tyres>();

        }
        
        public override string ToString()
        {
            string retval = Name + "renkaat\n";
            foreach (Tyres item in renkaat)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }
    }
    class Vehicle : Tyres
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }


        public Vehicle()
        {
        }
        public Vehicle(string nimi, string malli)
        {
            Nimi = nimi;
            Malli = malli;
        }
        public override string ToString()
        {
            return "Nimi: " + Nimi + " Malli: " + Malli;
        }
    }
}
