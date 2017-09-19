using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opiskelija
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] opiskelijat = new string[2];

            for (int i = 0; i < opiskelijat.Length; i++)
            {
                Classopiskelija uusiop = new Classopiskelija();
                Console.WriteLine("Lisää Opiskelija!");

                Console.Write("Nimi: ");
                uusiop.Nimi = Console.ReadLine();

                Console.Write("Ikä: ");
                uusiop.ika = int.Parse(Console.ReadLine());

                Console.Write("Opiskelijatunnus: ");
                uusiop.id = Console.ReadLine();

                Console.Write("Sähköposti: ");
                uusiop.sposti = Console.ReadLine();

                Console.Write("Kotiosoite: ");
                uusiop.osoite = Console.ReadLine();

                opiskelijat[i] = uusiop.Nimi + ", " + uusiop.ika + ", " + uusiop.id + ", " + uusiop.sposti + ", " + uusiop.osoite;

                
            }
            Console.WriteLine("\n\nOpiskelijat ja tiedot!\n ");
            
            for (int i = 0; i < opiskelijat.Length; i++)
            {
                Console.WriteLine(opiskelijat[i]);
                Console.WriteLine(".....................");
            }

        }
    }
}