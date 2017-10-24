using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Card
    {
        public string Maa { get; set; }
        public int Luku { get; set; }

        public Card()
        {

        }
        public Card(string maa, int luku)
        {
            Maa = maa;
            Luku = luku;
        }
        public override string ToString()
        {
            return "Kortti on " + Maa + " " + Luku;
        }
    }
    class Cardpack : Card
    {
        public List<Card> Cards;

        public Cardpack()
        {
            Cards = new List<Card>();
        }

        public override string ToString()
        {
            int numero = 1;
            string retval = "";
            foreach (Card item in Cards)
            {
                retval += numero + ". " + item.ToString() + "\n";
                numero++;
            }
            return retval;
        }

    }
}
