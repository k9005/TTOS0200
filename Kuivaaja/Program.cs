using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuivaaja
{
    class program
    {
        public static void Controlpanel()
        {
            Hiustenkuivaaja kuivari = new Hiustenkuivaaja();
            Console.Write("Käynnistetäänkö hiustenkuivaaja (y/n)? ");
            string vastaus = Console.ReadLine();
            if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y") kuivari.paalla = true;
            else kuivari.paalla = false;
            if (kuivari.paalla == true)
            {
                Console.WriteLine(kuivari.startting());

                Console.Write("Valitse kuivauslämpö? ");
                kuivari.lampo = int.Parse(Console.ReadLine());
                Console.Write("Valitse puhaltimen kesto? ");
                kuivari.voima = int.Parse(Console.ReadLine());
                Console.Write("Valitsit lämmöksi {0} celsiusta ja kestoksi {1} sekuntia. \nPuhallin sammuttaa itsensä puhalluksen jälkeen. Paina enter jatkaaksesi. ", kuivari.lampo, kuivari.voima);
                Console.ReadLine();
                if (kuivari.voima > 0)
                {
                    for (int i = 0; i < kuivari.voima; i++)
                    {
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine(kuivari.strong());
                    }
                }

                Console.WriteLine("\nHiustenkuivaaja on nyt sammunut.\n ");

            }

        }
    }
}

