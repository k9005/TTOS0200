using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMK
{
    class Opiskelija
    {
        public string Nimi { get; set; }
        public string Id { get; set; }
        public int Ika { get; set; }
       
        public Opiskelija(string nimi, string id, int ika) 
        {
            Nimi = nimi;
            Id = id;
            Ika = ika;
          

        }
        public override string ToString()
        {
            return "Oppilaan nimi: " + Nimi + " Id: " + Id + " ikä: " + Ika;
        }

    }
}
