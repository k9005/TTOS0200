using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opiskelija
{
    class Classopiskelija
    {
        public string Nimi { get; set; }
        public string id { get; set; }
        public int ika { get; set; }
        public string sposti { get; set; }
        public string osoite { get; set; }
        public Classopiskelija(string Nimi, string opiskelijatunn, int ikä, string sposti, string osoite) : base()
        {
            this.Nimi = Nimi;
            this.id = id;
            this.ika = ika;
            this.sposti = sposti;
            this.osoite = osoite;

        }
        public Classopiskelija()
        {
        }
        public string tiedot()
        {
            return Nimi + ", " + ika + ", " + id + ", " + sposti + ", " + osoite;
        }
    }
}