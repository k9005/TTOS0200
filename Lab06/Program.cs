using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            //T2();
            //T3();
            //T4();
            
        }
        static void T2()
        {
            CD NIN = new CD();
            NIN.Name = "Year Zero";
            NIN.Artisti = "Nine Inch Nails";
            NIN.Kappaleet.Add(new Kappale("HYPERPOWER!", "1:42"));
            NIN.Kappaleet.Add(new Kappale("The Beginning of the end", "2:47"));
            NIN.Kappaleet.Add(new Kappale("Survivalism", "4:23"));
            NIN.Kappaleet.Add(new Kappale("The Good Soldier", "3:23"));
            NIN.Kappaleet.Add(new Kappale("Vessel", "4:52"));
            NIN.Kappaleet.Add(new Kappale("Me, I'm Not", "4:51"));
            NIN.Kappaleet.Add(new Kappale("Capital G", "3:50"));
            Console.WriteLine(NIN.ToString());

        }
        static void T3()
        {
            Cardpack Pakka = new Cardpack();

            for (int i = 1; i < 14; i++)
            {
                Pakka.Cards.Add(new Card("Risti", i));
            }
            for (int i = 1; i < 14; i++)
            {
                Pakka.Cards.Add(new Card("Pata", i));
            }
            for (int i = 1; i < 14; i++)
            {
                Pakka.Cards.Add(new Card("Hertta", i));
            }
            for (int i = 1; i < 14; i++)
            {
                Pakka.Cards.Add(new Card("Ruutu", i));
            }

            Console.WriteLine(Pakka.ToString());
        }
        static void T4()
        {
            Joukkue JYP = new Joukkue("JYP,", "Jyväskylä.\nEtunimi, Sukunimi, Kätisyys, Pelinumero:");
            Console.WriteLine(JYP.ToString());
            List<Pelaaja> pelaajat = new List<Pelaaja>();
            pelaajat.Insert(0, new Pelaaja() { Etunimi = "Pelaaja1", Sukunimi = "Sukunimi", Kätisyys = "Vasen", Numero = 1 });
            pelaajat.Insert(1, new Pelaaja() { Etunimi = "Pelaaja2", Sukunimi = "Sukunimi", Kätisyys = "Vasen", Numero = 2 });
            pelaajat.Insert(2, new Pelaaja() { Etunimi = "Pelaaja3", Sukunimi = "Sukunimi", Kätisyys = "Vasen", Numero = 3 });
            pelaajat.Insert(3, new Pelaaja() { Etunimi = "Pelaaja4", Sukunimi = "Sukunimi", Kätisyys = "Vasen", Numero = 4 });
            pelaajat.Insert(4, new Pelaaja() { Etunimi = "Pelaaja5", Sukunimi = "Sukunimi", Kätisyys = "Vasen", Numero = 5 });
            pelaajat.Insert(5, new Pelaaja() { Etunimi = "Pelaaja6", Sukunimi = "Sukunimi", Kätisyys = "Vasen", Numero = 6 });
            foreach (Pelaaja p in pelaajat)
            {
                Console.WriteLine(p);
            }
            pelaajat.Insert(6, new Pelaaja() { Etunimi = "Pelaaja7", Sukunimi = "Sukunimi", Kätisyys = "Vasen", Numero = 7 });
            Console.WriteLine("\nLisätty pelaaja nro 7.\n");
            foreach (Pelaaja p in pelaajat)
            {
                Console.WriteLine(p);
            }
            
            pelaajat.RemoveAt(3);
            Console.WriteLine("\nPoistettu pelaaja nro 4.\n");
            foreach (Pelaaja p in pelaajat)
            {
                Console.WriteLine(p);
            }
        }

    
        
    }


}
