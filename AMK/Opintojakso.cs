using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMK
{
    class Opintojakso
    {
        public string Nimi { get; set; }
        public List<Opiskelija> Oppilas;
        public List<Opettaja> Opettaja;

        public Opintojakso(string nimi)
        {
            Nimi = nimi;
            Oppilas = new List<Opiskelija>();
            Opettaja = new List<Opettaja>();
        }
        public override string ToString()
        {
            int määrä = 0;
            string retval = Nimi + " Oppilaat:\n";
            
            foreach (Opiskelija item in Oppilas)
            {
                retval += item.ToString() + "\n";
                määrä++;
            }
            retval += "\nOppilaita: " + määrä.ToString();
            retval += "\nOpettaja: \n";
            foreach (Opettaja item in Opettaja)
            {
                retval += item.ToString() + "\n";
            }            

            return retval;
        }

    }
}
