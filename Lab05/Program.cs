using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Program
    {
         static void Main(string[] args)
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
         }
         static void Main(string[] args)
         {
             Team Joukkue1 = new Team();
             Joukkue1.Name = "Joukkue 1 ";
             Joukkue1.pelaajat.Add(new Player("Joku", "Paikka", "Kätisyys"));
             Joukkue1.pelaajat.Add(new Player("Joku", "Paikka", "Kätisyys"));
             Joukkue1.pelaajat.Add(new Player("Joku", "Paikka", "Kätisyys"));

             Team Joukkue2 = new Team();
             Joukkue2.Name = "Joukkue 2 ";
             Joukkue2.pelaajat.Add(new Player("Joku", "Paikka", "Kätisyys"));
             Joukkue2.pelaajat.Add(new Player("Joku", "Paikka", "Kätisyys"));
             Joukkue2.pelaajat.Add(new Player("Joku", "Paikka", "Kätisyys"));

             Team Joukkue3 = new Team();
             Joukkue3.Name = "Joukkue 3";
             Joukkue3.pelaajat.Add(new Player("Joku", "Paikka", "Kätisyys"));
             Joukkue3.pelaajat.Add(new Player("Joku", "Paikka", "Kätisyys"));
             Joukkue3.pelaajat.Add(new Player("Joku", "Paikka", "Kätisyys"));

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
         static void Main4(string[] args)
         {
             Human Man = new Human();
             Man.Nimi = "Matt";
             Man.Age = 55;
             Man.Pituus = 150;
             Man.Paino = 120;
             
             Console.WriteLine(Mies.ToString());
             Mies.Ageing();
             Mies.Move();
             Mies.Ageing();
             Mies.Move();
             Console.WriteLine("Miehen ikä:" + Mies.Age);

             Kid Baby = new Kid();
             Baby.Nimi = "Erkka";
             Baby.Age = 1;
             Baby.Pituus = 43;
             Baby.Paino = 12;
            
             Console.WriteLine(Vauva.ToString());
             Baby.Ageing();
             Baby.Ageing();
             Baby.Move();
             Baby.Move();
             Console.WriteLine("Vauvan ikä:" + Vauva.Age);

     

         }
         static void Main(string[] args)
         {
             Hyllyt Kauppa = new Hyllyt();
             Kauppa.Name = "Hedelmä hylly";
             Kauppa.sisältö.Add(new Fruit("Cacao", "hylly 5B", "Popoa"));
             Kauppa.sisältö.Add(new Fruit("Banaani", "hylly 2A", "Pirkka"));
             Kauppa.sisältö.Add(new Fruit("Appelsiini", "hylly 3A", "Jaffa"));
             Kauppa.sisältö.Add(new Fruit("Mango", "Hylly 6C", "Tuntematon"));
             

             Console.Write("Haluatko tulostaa tuotteet ja niiden sijainnit vai lisätä tuotteita? \n1. Tulostaa tuotteet \n2. Lisätä tuotteita \nValinta: ");
             int valinta = int.Parse(Console.ReadLine());
             if (valinta == 1)
             {
                 Console.WriteLine(Kauppa.ToString());
             }
             else if (valinta == 2)
             {
                 Fruit fruit = new Fruit();
                 Console.WriteLine("Kerro tuote: ");
                 fruit.Nimi = Console.ReadLine();
                 Console.WriteLine("Kerro säilytys paikka: ");
                 fruit.Sijainti = Console.ReadLine();
                 Console.WriteLine("Kerro merkki: ");
                 fruit.Merkki = Console.ReadLine();
                 Kauppa.sisältö.Add(fruit);

                Console.WriteLine(Kauppa.ToString());
            }
         }

    }
}

