using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Player
    {
        public string Nimi { get; set; }
        public string Pelipaikka { get; set; }
        public string Kätisyys { get; set; }

        public Player()
        {
        }
        public Player(string nimi, string pelipaikka, string kätisyys)
        {
            Nimi = nimi;
            Pelipaikka = pelipaikka;
            Kätisyys = kätisyys;
        }
        public override string ToString()
        {
            return Nimi + " position: " + Pelipaikka + " Shoots: " + Kätisyys;
        }
    }
    class Team
    {
        public string Name { get; set; }
        public List<Player> pelaajat;
        
        public Team()
        {
            pelaajat = new List<Player>();

        }
        
        public override string ToString()
        {
            string retval = Name + " sisältö\n";
            foreach (Player item in pelaajat)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }
    }
}
