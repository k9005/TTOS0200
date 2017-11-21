using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._2
{
    public static class Joukkueet
    {
        public static List<Pelaaja> HaePelaajat()
        {
            List<Pelaaja> pelaajat = new List<Pelaaja>();
            Pelaaja a = new Pelaaja()
            { Etunimi = "Eetu", Sukunimi = "Laurikainen", Katisyys = "Left", Numero = 41 };
            pelaajat.Add(a);
            Pelaaja b = new Pelaaja()
            { Etunimi = "Juho", Sukunimi = "Olkinuora", Katisyys = "Left", Numero = 45 };
            pelaajat.Add(b);
            Pelaaja c = new Pelaaja()
            { Etunimi = "Anttoni", Sukunimi = "Honka", Katisyys = "Right", Numero = 3 };
            pelaajat.Add(c);
            Pelaaja d = new Pelaaja()
            { Etunimi = "", Sukunimi = "", Katisyys = "", Numero = 0 };
            pelaajat.Add(d);
            Pelaaja e = new Pelaaja()            
            { Etunimi = "", Sukunimi = "", Katisyys = "", Numero = 0 };
            pelaajat.Add(e);
            Pelaaja f = new Pelaaja()
            { Etunimi = "", Sukunimi = "", Katisyys = "", Numero = 0 };
            pelaajat.Add(f);
            Pelaaja g = new Pelaaja()
            { Etunimi = "", Sukunimi = "", Katisyys = "", Numero = 0 };
            pelaajat.Add(g);
            Pelaaja h = new Pelaaja()
            { Etunimi = "", Sukunimi = "", Katisyys = "", Numero = 0 };
            pelaajat.Add(h);
            Pelaaja i = new Pelaaja()
            { Etunimi = "", Sukunimi = "", Katisyys = "", Numero = 0 };
            pelaajat.Add(i);
            return pelaajat;
        }
    }
    public class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Katisyys { get; set; }
        public int Numero { get; set; }
    }

}
