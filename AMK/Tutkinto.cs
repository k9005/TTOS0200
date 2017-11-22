using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMK
{
    class Tutkinto
    {
        public string Nimi { get; set; }
        public List<Opintojakso> Jakso;

        public Tutkinto(string nimi)
        {
            Nimi = nimi;
            Jakso = new List<Opintojakso>();
        }
        public override string ToString()
        {

            string retval = Nimi + " opintojaksot:\n";
            foreach (Opintojakso item in Jakso)
            {
                retval += item.ToString() + "\n";
            }
            
            return retval;
        }

    }
}
