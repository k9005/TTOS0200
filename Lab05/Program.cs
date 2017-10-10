using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Program
    {
       /* static void Main(string[] args)
        {
            Vehicle auto = new Vehicle();
            auto.Nimi = "Merkki";
            auto.Malli = "Malli";


            Console.WriteLine(auto.ToString());
            Type Audi = new Type();
            Audi.Name = "Merkin";
            Audi.renkaat.Add(new Tyres("Merkki", "Malli", 20));
            Audi.renkaat.Add(new Tyres("Merkki", "Malli", 20));
            Audi.renkaat.Add(new Tyres("Merkki", "Malli", 20));
            Audi.renkaat.Add(new Tyres("Merkki", "Malli", 20));
            Console.WriteLine(Audi.ToString());

            Vehicle mopo = new Vehicle();
            mopo.Nimi = "Merkki";
            mopo.Malli = "Malli";

            Console.WriteLine(mopo.ToString());
            Type PV = new Type();
            PV.Name = "Merkin";
            PV.renkaat.Add(new Tyres("Merkki", "Malli", 0));
            PV.renkaat.Add(new Tyres("Merkki", "Malli", 0));
            Console.WriteLine(PV.ToString());
        }
        static void Main(string[] args)
        {
            Jkaappi upo = new Jkaappi();
            upo.Name = "Upo jääkaappi";
            upo.tuote.Add(new Tuote("Maito", "Ovi."));
            upo.tuote.Add(new Tuote("Ketsuppi", "Ovi."));
            upo.tuote.Add(new Tuote("Margariini", "Ylähylly."));
            upo.tuote.Add(new Tuote("Vihannekset", "Alahylly."));
            upo.tuote.Add(new Tuote("Juusto", "Keskitaso."));
            Console.WriteLine(upo.ToString());
        }*/
        static void Main(string[] args)
        {
            Team Joukkue1 = new Team();
            Joukkue1.Name = "Joukkue 1 ";
            Joukkue1.pelaajat.Add(new Player("Teppo Numminen", "Hyökkääjä", "Right"));
            Joukkue1.pelaajat.Add(new Player("Sami Joku", "Puolustaja", "Right"));
            Joukkue1.pelaajat.Add(new Player("Esko Aho", "Hyökkääjä", "Right"));

            Team Joukkue2 = new Team();
            Joukkue2.Name = "Joukkue 2 ";
            Joukkue2.pelaajat.Add(new Player("Sami Salin", "Hyökkääjä", "Right"));
            Joukkue2.pelaajat.Add(new Player("Jou hou", "Hyökkääjä", "Right"));
            Joukkue2.pelaajat.Add(new Player("Mika Häkkinen", "Hyökkääjä", "Left"));

            Team Joukkue3 = new Team();
            Joukkue3.Name = "Joukkue 3";
            Joukkue3.pelaajat.Add(new Player("Antti Anttonen", "Hyökkääjä", "Right"));
            Joukkue3.pelaajat.Add(new Player("Antti Mikkonen", "Hyökkääjä", "Right"));
            Joukkue3.pelaajat.Add(new Player("Antti Kaikkonen", "Puolustaja", "Right"));

            Console.Write("Minkä seuran pelaajatiedot haluat näkyville (nro)? \n 1.Joukkue 1 \n 2.Joukkue 2 \n 3.Joukkue 3  \n Valinta: ");
            int valinta = int.Parse(Console.ReadLine());
            if (valinta == 1)
            {
                Console.WriteLine(Joukkue1.ToString());
            }
            else if (valinta == 2)
            {
                Console.WriteLine(Joukkue2.ToString());
            }
            else if (valinta == 3)
            {
                Console.WriteLine(Joukkue3.ToString());
            }
            else
            {
                Console.WriteLine("Luuseri");
            }

        }
       /* static void Main4(string[] args)
        {
            Aikuinen Mies = new Aikuinen();
            Mies.Nimi = "Mikko";
            Mies.Ikä = 24;
            Mies.Pituus = 197;
            Mies.Paino = 120;
            Mies.Auto = "Audi";
            Console.WriteLine(Mies.ToString());
            Mies.Kasvu();
            Mies.Liiku();
            Mies.Kasvu();
            Mies.Liiku();
            Console.WriteLine("Miehen ikä:" + Mies.Ikä);

            Lapsi Vauva = new Lapsi();
            Vauva.Nimi = "Esa";
            Vauva.Ikä = 2;
            Vauva.Pituus = 60;
            Vauva.Paino = 15;
            Vauva.Vaippa = "LÖytyyy";
            Console.WriteLine(Vauva.ToString());
            Vauva.Kasvu();
            Vauva.Kasvu();
            Vauva.Liiku();
            Vauva.Liiku();
            Console.WriteLine("Vauvan ikä:" + Vauva.Ikä);

            Ihminen Joku = new Ihminen();
            Joku.Nimi = "Unknown";
            Joku.Ikä = 27;
            Joku.Pituus = 180;
            Joku.Paino = 75;
            Console.WriteLine(Joku.ToString());
            Joku.Liiku();
            Joku.Liiku();


        }
        static void Main5(string[] args)
        {
            Vaatekaappi IsännänJaEmännän = new Vaatekaappi();
            IsännänJaEmännän.Name = "Isännän ja Emännän vaatekaappi";
            IsännänJaEmännän.sisältö.Add(new Vaate("Toppi", "ylähylly", "emännän"));
            IsännänJaEmännän.sisältö.Add(new Vaate("Farkut", "Alahylly", "Isännän"));
            IsännänJaEmännän.sisältö.Add(new Vaate("Nahkahousut", "Vasenkaappi", "emännän"));
            IsännänJaEmännän.sisältö.Add(new Vaate("Leviksen paita", "ylähylly", "emännän"));
            IsännänJaEmännän.sisältö.Add(new Vaate("Champion huppari", "keskitaso", "isäntä"));

            Console.WriteLine("Haluatko 1.Tulostaa vaatekaapin sisällön 2. Lisätä vaatteen?");
            int valinta = int.Parse(Console.ReadLine());
            if (valinta == 1)
            {
                Console.WriteLine(IsännänJaEmännän.ToString());
            }
            else if (valinta == 2)
            {
                Vaate kappale = new Vaate();
                Console.WriteLine("Anna nimi.");
                kappale.Nimi = Console.ReadLine();
                Console.WriteLine("Anna sijainti");
                kappale.Sijainti = Console.ReadLine();
                Console.WriteLine("Kenen");
                kappale.Kenen = Console.ReadLine();
                IsännänJaEmännän.sisältö.Add(kappale);
            }
        }*/
        
    }
}

