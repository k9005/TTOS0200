using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Olio-ohjelmoinnin viikkotehtävät Labra 1
//Lauri Rämö
namespace Labrat
{
    class Lab01
    {
        public static void Tehtava01 ()
        {
            //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku". 
    
    Console.Write("Anna jokin luku: ");
    string luku = Console.ReadLine();
    
            
            if (luku == "1") luku = "yksi";
            if (luku == "2") luku = "kaksi";
            if (luku == "3") luku = "kolme";
           

    Console.WriteLine("Antamasi luku oli " + luku);
           Console.ReadLine();
    

        }

        public static void Tehtava02 ()
        {
            int luku;
            Console.Write("Kuinka paljon oppilas sai pisteitä? ");
            luku = int.Parse(Console.ReadLine());
            if (luku < 2) luku = 0;
            if (luku > 1 && luku < 4) luku = 1;
            if (luku > 3 && luku < 6) luku = 2;
            if (luku > 5 && luku < 8) luku = 3;
            if (luku > 6 && luku < 10) luku = 4;
            if (luku > 9) luku = 5;

            Console.WriteLine("Oppilas sai koulunumeroksi: " + luku);
            Console.ReadLine();


        }
    
        public static void Tehtava03 ()
        {
            int luku, sum = 0, r;
            Console.WriteLine ("Kerro kolme lukua: ");
            luku = int.Parse(Console.ReadLine());
           while (luku != 0){
                 r = luku % 10;
                 luku = luku / 10;
                 sum = sum + r;
                }
            Console.WriteLine("Summa on: " + sum);
            Console.ReadLine();

        }

        public static void Tehtava04 ()
        {   
           int luku;
            Console.WriteLine ("Kerro oma ikäsi: ");
            luku = int.Parse(Console.ReadLine());
            if (luku < 66)
            {
                if (luku < 18) Console.WriteLine("Pyh.. Olet tenava!");
                else Console.WriteLine("Hehe.. Olet aikuinen!");
            }
            else Console.WriteLine("Jäbä on Seniori JOU!");
            Console.ReadLine();

        }

        public static void Tehtava05 ()
        {   
           int secs;
            Console.WriteLine("Anna sekuntimäärä: ");
            secs = int.Parse(Console.ReadLine());
            TimeSpan aika = TimeSpan.FromSeconds(secs);
            string vastaus = aika .ToString(@"hh\h\:mm\m\:ss\s");
            Console.WriteLine("Antamasi aika kivemmassa muodossa: " + vastaus);
            Console.ReadLine();
             


        }

        public static void Tehtava06 ()
        {
            double matka, kulutus, raha;
            Console.WriteLine("Kuinka pitkän matkan ajoit/ ajattelit ajaa: ");
            matka = double.Parse(Console.ReadLine());
            kulutus = matka / 100;
            kulutus = kulutus * 7.02;
            raha = kulutus * 1.595;
            raha = Math.Round(raha, 2);
            Console.WriteLine("Bensaa sinulla menee {0} ja se kustantaa sinulle {1} euroa.",kulutus, raha);
            Console.ReadLine();

        }

        public static void Tehtava07 ()
        {   
            int vuosi, tarkastus, tarka;
            Console.WriteLine("Anna vuosi: ");
            vuosi = int.Parse(Console.ReadLine());
            tarkastus = vuosi % 10;
            if (tarkastus == 0) 
                {
                tarkastus = vuosi % 400;
                if (tarkastus == 0) Console.WriteLine("Vuosi {0} on karkausvuosi", vuosi);
                else Console.WriteLine("Vuosi {0} ei ole karvausvuosi", vuosi);

                }
            else 
                {
                tarkastus = vuosi % 4;
                if (tarkastus == 0) Console.WriteLine("Vuosi {0} on karkausvuosi", vuosi);
                else Console.WriteLine("Vuosi {0} ei ole karvausvuosi", vuosi);
                
                }
            
            Console.ReadLine();


        }

        public static void Tehtava08 ()
        {   
            int luku, bluku;
            bluku = 0;
            for (int i = 0; i < 3; i++)
			{
            Console.WriteLine("Anna luku: ");
            luku = int.Parse(Console.ReadLine());
            if (luku > bluku) bluku = luku;
            }

            Console.WriteLine("Isoin antamasi luku on: " +bluku);
            Console.ReadLine();


        }

        public static void Tehtava09 ()
        {
            int luku, kaikki;
            kaikki = 0;
        do
	        {
                Console.WriteLine("Anna luku: ");
                luku = int.Parse(Console.ReadLine());
                kaikki = kaikki + luku;
            } while (luku != 0);    

            Console.WriteLine("Lukujen summa yhteensä on: " +kaikki);
            Console.ReadLine();
        
        }

        public static void Tehtava10 ()
        {   

        }

        public static void Tehtava11 ()
        {   
            int luku;
            Console.WriteLine("Anna luku: ");
            luku = int.Parse(Console.ReadLine());

            for (int i = luku; i < 1; i--)
			 {
			 for (int j = 1; j < luku; j++)
			  {
                Console.Write("*");
			  }
             }
            Console.ReadLine();
        }

        public static void Tehtava12 ()
        {

        }

        public static void Tehtava13 ()
        {   

        }

        public static void Tehtava14 ()
        {   

        }
}

}
