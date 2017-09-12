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
            Console.Write ("Kerro kolme lukua: ");
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
           int luku, r;
            luku = 555;
           luku = luku / 10;
            Console.WriteLine("summa: " + luku);


        }

        public static void Tehtava05 ()
        {   

        }

        public static void Tehtava06 ()
        {

        }

        public static void Tehtava07 ()
        {   

        }

        public static void Tehtava08 ()
        {   

        }

        public static void Tehtava09 ()
        {

        }

        public static void Tehtava10 ()
        {   

        }

        public static void Tehtava11 ()
        {   

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
