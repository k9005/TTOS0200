using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab02
    {
        public class Kiuas
        {
            public bool paalla { get; set; }
            public int lampo { get; set; }
            public int kosteus { get; set; }
            public Kiuas(bool paalla, int Teho, int kosteus) : base()
            {
                this.paalla = paalla;
                this.lampo = Teho;
                this.kosteus = kosteus;
            }
            public Kiuas()
            {
            }
            public string warming()
            {
                string tiktik = "grrrrprrr\nprrrtiktitkitktiktiktik\n";

                return tiktik;
            }
            public string loyly()
            {
                string ssh = "pshshhsshhsssshhhh";

                return ssh;
            }
        }
        public class Kiuascontrol
        {
            public static void Controlpanel()
            {
                Kiuas harvia = new Kiuas();
                Console.WriteLine("Haluatko käynnistää kiukaan (y/n)?");
                while (true)
                {
                    string vastaus = Console.ReadLine();
                    if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y")
                    {
                        harvia.paalla = true;
                        break;
                    }
                    else if (vastaus.Substring(0, 1) == "n" || vastaus.Substring(0, 1) == "N")
                    {
                        harvia.paalla = false;
                        break;
                    }
                    Console.Write("Haluatko käynnistää kiukaan (y/n)?");
                }
                if (harvia.paalla == true)
                {
                    Console.Write("Mihin asteeseen haluat saunan lämmön? ");
                    harvia.lampo = int.Parse(Console.ReadLine());
                    Console.Write("Mihin prosenttiin haluat saunan kosteuden? ");
                    harvia.kosteus = int.Parse(Console.ReadLine());
                    Console.WriteLine(harvia.warming());
                    Console.WriteLine("Kiuas on nyt valmis käyttöön! lämpö on {0} celsiusta ja kosteus {1} prosenttia", harvia.lampo, harvia.kosteus);
                    while (harvia.paalla == true)
                    {

                        Console.Write("Haluatko heittää löylyä (y/n)?");
                        string vastaus = Console.ReadLine();
                        if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y")
                        {
                            Console.WriteLine(harvia.loyly());
                        }

                        Console.Write("Haluatko lopettaa saunomisen? (y/n)?");
                        vastaus = Console.ReadLine();
                        if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y") harvia.paalla = false;


                    }
                }


                Console.WriteLine("Kiuas on nyt sammutettu! harvia kiittää!!");

            }
        }
        public class Pesukone
        {
            public bool paalla { get; set; }
            public int lampo { get; set; }
            public int kovuus { get; set; }
            public bool linkous { get; set; }

            public Pesukone(bool paalla, int lampo, int kovuus, bool linkous) : base()
            {
                this.paalla = paalla;
                this.lampo = lampo;
                this.kovuus = kovuus;
                this.linkous = linkous;
            }
            public Pesukone()
            {
            }
            public string running()
            {
                return "hrrrhrrrhrrrhrr";
            }
            public string lingging()
            {
                return "viuhviuhviuhviuhviuhviuh";
            }
        }
        public class Pesukonecontrol
        {
            public static void Controlpanel()
            {
                Pesukone rosenlew = new Pesukone();
                Console.Write("Hei, haluatko pestä pyykkiä (y/n)?");
                string vastaus = Console.ReadLine();
                if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y") rosenlew.paalla = true;
                else rosenlew.paalla = false;
                if (rosenlew.paalla == false) { Console.WriteLine("Näkemiin!"); Environment.Exit(1); }
                Console.Write("Millä lämpötilalla haluat pestä pyykkisi? ");
                rosenlew.lampo = int.Parse(Console.ReadLine());
                Console.Write("Kuinka kovan pesun haluat pyykillesi 1-10 (hellävarainen - raju)? ");
                rosenlew.kovuus = int.Parse(Console.ReadLine());
                Console.Write("Haluatko linkouksen (y/n)? ");
                vastaus = Console.ReadLine();
                if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y") rosenlew.linkous = true;
                string linko = "";
                if (rosenlew.linkous == true) linko = "haluat linkouksen";
                else if (rosenlew.linkous == false) linko = "et halua linkousta";
                Console.WriteLine("Valitsit seuraavat vaihtoehdot: Lämpötila {0} celsius astetta, kovuus {1} ja {2}.", rosenlew.lampo, rosenlew.kovuus, linko);
                Console.Write("Aloitetaanko ohjelma (y/n)? ");
                vastaus = Console.ReadLine();
                if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y")
                {
                    Console.WriteLine(rosenlew.running());
                    if (rosenlew.linkous == true)
                    {
                        Console.WriteLine("Aloitetaan linkous!");
                        Console.WriteLine(rosenlew.lingging());
                    }
                    Console.WriteLine("Ohjelma on valmis!");
                }


                Console.WriteLine("Ohjelma on lopetettu. Kiitos!!");


            }
        }
        public class Tv
        {
            public bool paalla { get; set; }
            public int kanava { get; set; }
            public int volume { get; set; }
            public Tv(bool paalla, int kanava, int volume) : base()
            {
                this.paalla = paalla;
                this.kanava = kanava;
                this.volume = volume;
            }
            public Tv()
            {
            }
            public string startting()
            {
                return "Tsimm";
            }
            public string change()
            {
                return "Tsuim";
            }

        }
        public class Tvcontrol
        {
            public static void Controlpanel()
            {
                Tv lg = new Tv();
                Console.Write("Käynnistetäänkö televisio (y/n)? ");
                string vastaus = Console.ReadLine();
                if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y") lg.paalla = true;
                else lg.paalla = false;
                if (lg.paalla == true)
                {
                    Console.WriteLine(lg.startting());
                    do
                    {
                        Console.Write("Valitse joku kanava? ");
                        lg.kanava = int.Parse(Console.ReadLine());
                        Console.Write("Säädä äänenvoimakkuus kohdilleen? ");
                        lg.volume = int.Parse(Console.ReadLine());
                        Console.WriteLine(lg.change());
                        Console.Write("Valitsit kanavan {0} ja äänen voimakkuutesi on {1} astetta. Haluatko vaihtaa jotain (y/n)?", lg.kanava, lg.volume);
                        vastaus = Console.ReadLine();
                        if (vastaus.Substring(0, 1) == "N" || vastaus.Substring(0, 1) == "n")
                        {
                            Console.Write("Haluatko sammuttaa tvn (y/n)? ");
                            vastaus = Console.ReadLine();
                            if (vastaus.Substring(0, 1) == "Y" || vastaus.Substring(0, 1) == "y") lg.paalla = false;
                        }
                    } while (lg.paalla != false);
                    Console.WriteLine("Telvisio sammuu, heihei!");
                    Console.WriteLine(lg.startting());
                }

            }
        }
        public class Vehicle
        {
            public string name { get; set; }
            public int speed { get; set; }
            public int tyres { get; set; }
            public Vehicle(string name, int speed, int tyres) : base()
            {
                this.name = name;
                this.speed = speed;
                this.tyres = tyres;
            }
            public Vehicle()
            {
            }
            public string info()
            {
                return name + " max " + speed + "km/h " + tyres + ".";
            }
        }
        public class Vehicleinfo
        {
            public static void Autoinfo()
            {
                Vehicle theauto = new Vehicle();

                Console.Write("Mikä auto sinulla on? ");
                theauto.name = Console.ReadLine();
                Console.WriteLine("Kuinka nopea autosi on? ");
                theauto.speed = int.Parse(Console.ReadLine());
                Console.WriteLine("Minkä kokoiset renkaat autossasi on?");
                theauto.tyres = int.Parse(Console.ReadLine());



                Console.WriteLine("Tässä tietoja autostasi: ");

                Console.WriteLine(theauto.info());


            }
        }
        public class CD
        {
            public string[] soittolista = new string[] { "Stop", "Endless Forms Most Beautiful", "The Greatest Show on Earth", "Elan", "Weak Fantasy", "Alpenglow" };
            int soittaa_nyt = 0; // 0-mitään ei soita
            public void Play(int kappale)
            {
                this.soittaa_nyt = kappale;

                Console.WriteLine("Play! Nyt soittaa kappale: '" + this.soittolista[kappale] + "'");
            }
            public void Stop()
            {
                this.soittaa_nyt = 0;
                Console.WriteLine("Stop! Ei ole toistoa");
            }
            public override string ToString()
            {
                string soittotilanne;
                if (this.soittaa_nyt == 0) soittotilanne = "Now playing: " + this.soittolista[this.soittaa_nyt];
                else soittotilanne = "Stop";
                return soittotilanne;
            }
        }
        public class CDplayer
        {
            public static void CDlukija()
            {
                int valinta = 0;
                int kappale = 1;
                CD disk = new CD();
                do
                {
                    Console.WriteLine("CD levy on soitimissa. Sinun valinta:");
                    Console.WriteLine("1. Play");
                    Console.WriteLine("2. Stop");
                    Console.WriteLine("3. Change the song");
                    Console.WriteLine("4. Eject");
                    Console.WriteLine("5. Off");
                    valinta = Convert.ToInt32(Console.ReadLine());
                    switch (valinta)
                    {
                        case 1:
                            disk.Play(kappale);
                            break;
                        case 2:
                            disk.Stop();
                            break;
                        case 3:
                            Console.Write("Type the number of song (1-5) > ");
                            kappale = Convert.ToInt32(Console.ReadLine());
                            Console.Write("You choosed song #" + kappale + ": '" + disk.soittolista[kappale]);
                            disk.Play(kappale);
                            break;
                        case 4:
                            Console.Write("Eject. Good bye!");
                            System.Environment.Exit(1);
                            break;

                        default:
                            break;
                    }

                } while (valinta != 5);
                Console.WriteLine("CD soitin on pois päältä");
            }
        }
    }

}
}