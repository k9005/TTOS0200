using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Ihminen : Nisakas
    {
        public string Nimi { get; set; }
        public int Paino { get; set; }
        public int Pituus { get; set; }

        public override void Liiku()
        {
            Console.WriteLine("Liikettä");
        }
        public void Kasvu()
        {
            Ikä++;
        }
        public override string ToString()
        {
            return "Nimi:" + Nimi + " Paino:" + Paino + " Pituus:" + Pituus;
        }
    }
    class Lapsi : Ihminen
    {
        public string Vaippa { get; set; }

        public override void Liiku()
        {
            Console.WriteLine("Konttaan");
        }
        public override string ToString()
        {
            return "Lapsi: " + Nimi + " Ikä:" + Ikä + " Pituus: " + Pituus + " Paino:" + Paino + " Vaippa(?)" + Vaippa;
        }
    }
    abstract class Nisakas
    {
        public int Ikä { get; set; }

        public Nisakas()
        {

        }

        public abstract void Liiku();
    }
}
