using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Kiuas
    {
        public static void harvia()
        {
            bool kiuaspaalla = false;

            Console.WriteLine("Harvia Kiuas control panel");

            Console.Write("Haluatko käynnistää kiukaan (y/n)?");
            while (true)
            {
                string vastaus = Console.ReadLine();
                if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y")
                {
                    kiuaspaalla = true;
                    break;
                }
                else if (vastaus.Substring(0, 1) == "n" || vastaus.Substring(0, 1) == "N")
                {
                    kiuaspaalla = false;
                    Console.WriteLine("Harvia Kiuas kiittää ja menee unille!");
                    Environment.Exit(1);
                }
                Console.Write("Haluatko käynnistää kiukaan (y/n)?");
            }

            int lampo = 0, kosteus = 0;
            Console.Write("Mihin asteeseen haluat saunan lämmön? ");
            lampo = int.Parse(Console.ReadLine());
            Console.Write("Mihin prosenttiin haluat saunan kosteuden? ");
            kosteus = int.Parse(Console.ReadLine());
            Console.WriteLine("Sauna aloittaa lämpenemisen {0} celsiusta asti ja kostuttaa saunan {1} prosenttiin!", lampo, kosteus);
            Console.WriteLine(".");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("..");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Sauna on nyt valmis!!");
            do
            {
                Console.Write("Haluatko että heitetään löylyä (y/n)?  ");
                string vastaus = Console.ReadLine();
                if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y") Console.WriteLine("Psshshshhhshsshhhh....");
                Console.Write("Haluatko lopettaa saunomisen (y/n)?  ");
                vastaus = Console.ReadLine();
                if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y") kiuaspaalla = false;
            } while (kiuaspaalla == true);
            Console.WriteLine("Sauna sammuuttaa itsensä! Harvia Kiuas kiittää!!");







        }

     
    }
    
    class Pesukone
    {
        public static void rosenlew()
        {
            bool pesukonepaalla = false;

            Console.WriteLine("Rosenlew pesukone control panel");

            Console.Write("Hei, haluat ilmeisesti pestä pyykkiä, pitääkö paikkansa (y/n)?");
            while (true)
            {
                string vastaus1 = Console.ReadLine();
                if (vastaus1.Substring(0, 1) == "y" || vastaus1.Substring(0, 1) == "Y")
                {
                    pesukonepaalla = true;
                    break;
                }
                else if (vastaus1.Substring(0, 1) == "n" || vastaus1.Substring(0, 1) == "N")
                {
                   
                    Console.WriteLine("Rosenlew pesukone kiittää ja menee unille!");
                    Environment.Exit(1);
                }
                Console.Write("Haluatko pestä pyykkiä (y/n)?");
            }

            int lampo, kovuus;
            string vastaus;
            bool linkous;
            do
            {
                
                Console.Write("Millä lämpö asteella haluat pestä pyykkisi? ");
                lampo = int.Parse(Console.ReadLine());
                Console.Write("Kuinka kovan pesun haluat pyykillesi 1-10 (hellävarainen - raju)? ");
                kovuus = int.Parse(Console.ReadLine());
                Console.WriteLine("Laita haluamasi määrä pesuainetta pesulokeroon. ");
                Console.Write("Haluatko linkouksen (y/n)? ");
                vastaus = Console.ReadLine();
                if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "y") linkous = true;
                else linkous = false;
                Console.WriteLine("Aloitetaanko pesuohjelma vai palataanko takaisin (aloita/palaa)?");
                vastaus = Console.ReadLine();
            } while (vastaus.Substring(0, 1) == "p" || vastaus.Substring(0, 1) == "P");
            Console.WriteLine("Pesukone aloittaa ohjelman...");
            Console.WriteLine(".");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("..");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            if (linkous == true)
            {
                Console.WriteLine("Linkous aloitetaan");
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("..");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("Pesu on nyt valmis!!");
                   
            Console.WriteLine("Kiitos kun valitsit Rosenlewin, nähdään uudestaan!!");
        }


    }
}
