using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class DVD
    {
        public string Genre { get; set; }
        public string Nimi { get; set; }
        public int Pituus { get; set; }
        public string Ohjaaja { get; set; }

            public DVD()
            {

            }
            public DVD(string genre, string nimi, int pituus, string ohjaaja)
            {

                Genre = genre;
                Nimi = nimi;
                Pituus = pituus;
                Ohjaaja = ohjaaja;
            }
            public override string ToString()
            {
                return "Genre: " + Genre + "\nNimi: "+ Nimi + "\n" + "\nPituus: " + Pituus + "min" + "\nOhjaaja: " + Ohjaaja + "\n";
            }
        
    }
    class Book : DVD
    {
        
        

        public Book()
        {

        }
        public Book(string genre, string nimi, int pituus, string kirjoittaja)
        {
            Genre = genre;
            Nimi = nimi;
            Pituus = pituus;
            Ohjaaja = kirjoittaja;
        }
        public override string ToString()
        {
            return "Genre: " + Genre + "\nNimi: " + Nimi + "\n" + "\nPituus: " + Pituus + "sivua" + "\nKirjoittaja: " + Ohjaaja + "\n";
        }
    }
}
