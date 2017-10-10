using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Fruit
    {
        public string Nimi { get; set; }
        public string Sijainti { get; set; }
        public string Merkki { get; set; }

        public Fruit()
        {
        }
        public Fruit(string nimi, string sijainti, string merkki)
        {
            Nimi = nimi;
            Sijainti = sijainti;
            Merkki = merkki;
        }
        public override string ToString()
        {
            return Nimi + " löytyy kohdasta " + Sijainti + " ja on merkiltään " + Merkki +".";
        }
    }
    class Hyllyt
    {
        public string Name { get; set; }
        public List<Fruit> sisältö;
        
        public Hyllyt()
        {
            sisältö = new List<Fruit>();

        }
        
        public override string ToString()
        {
            string retval = Name + " sisältö\n";
            foreach (Fruit item in sisältö)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }
    }
}
