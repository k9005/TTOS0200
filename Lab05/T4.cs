using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Human : Mammal
    {
        public string Nimi { get; set; }
        public int Paino { get; set; }
        public int Pituus { get; set; }

        public override void Move()
        {
            Console.WriteLine("Kävelee");
        }
        public void Ageing()
        {
            Age++;
        }
        public override string ToString()
        {
            return "Nimi:" + Nimi + " Paino:" + Paino + " Pituus:" + Pituus;
        }
    }
    class Kid : Ihminen
    {
        public string Baby { get; set; }

        public override void Move()
        {
            Console.WriteLine("Ryömii");
        }
        public override string ToString()
        {
            return "Lapsi: " + Nimi + " Ikä:" + Ikä + " Pituus: " + Pituus + " Paino:" + Paino;
        }
    }
    abstract class Mammal
    {
        public int Age { get; set; }

        public Mammal()
        {

        }

        public abstract void Liiku();
    }
}
