using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Kappale
    {
        string Nimi { get; set; }
        string Pituus { get; set; }

        public Kappale()
        {

        }
        public Kappale(string nimi, string pituus)
        {
            Nimi = nimi;
            Pituus = pituus;
        }

        public override string ToString()
        {
            return Nimi + ", " + Pituus;
        }
    }
    class CD :Kappale
    {
        public string Name { get; set; }
        public string Artisti { get; set; }
        public List<Kappale> Kappaleet;

        public CD()
        {
            Kappaleet = new List<Kappale>();
        }
        public override string ToString()
        {
            string retval = " Nimi: " + Name + "\n Artisti: " + Artisti + "\n Kappaleet: \n";
            int i = 1;
            foreach (Kappale item in Kappaleet)
            {
                
                retval += i+"." + item.ToString() + "\n";
                i++;
            }
            return retval;
        }
    }
}
