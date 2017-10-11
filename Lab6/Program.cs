using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.MiniASIO
{
    class TestaaMiniASIO
    {
        static void Testaa()
        {
            List<Opiskelija> opiskelijat = new List<Opiskelija>();
            Opiskelija masa = new Opiskelija("Masa", "Niemi");
            opiskelijat.Add(masa);
            opiskelijat.Add(new Opiskelija("Muammar", "Bombom", "He123"));
            //3 vaihtoehto
            opiskelijat.Add(new Opiskelija { Etunimi = "Lucifer", Sukunimi = "Satan", AsioID = "B666" });
            opiskelijat.Add(new Opiskelija { Etunimi = "Hurri", Sukunimi = "Ruotsalainen", AsioID = "F6969", Ryhma = "Kysymysmerkkimiehet" });
            Opiskelija kalle = new Opiskelija();
            kalle.Etunimi = "Kalle";
            kalle.Sukunimi = "Pikku";
            kalle.AsioID = "T5498";
            opiskelijat.Add(kalle);

            //yhdenopiskelijan näyttäminen
            Console.Write("Anna numero 1-5 väliltä: ");
            int i = int.Parse(Console.ReadLine());
            
            if (i-1 > -1 && i-1 < opiskelijat.Count)
                Console.WriteLine("MiniASIOn {0} opiskelija on {1}", i, opiskelijat[i-1].ToString());
            else
                Console.WriteLine("MiniAsiossa on vain {0} opiskelijaa!!!", opiskelijat.Count);
            //Kaikki opiskelijat
            Console.WriteLine("MiniASIOn kaikki opiskelijat: ");
            foreach (var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }
            //Kaikki opiskelijat aakkosjärjestyksessä
            opiskelijat.Sort((x, y) => x.Sukunimi.CompareTo(y.Sukunimi));
            Console.WriteLine("MiniASIOn kaikki opiskelijat aakkosjärjestyksessä: ");
            foreach (var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }
            //Uuden opiskelijan lisääminen, samalla tarkastetaan ettei asioID ole jo olemassa
            Console.Write("Anna uuden Opiskelijan asioID: ");
            string asioid = Console.ReadLine();
            //Id check
            bool lippu = false;
            foreach (Opiskelija o in opiskelijat)
            {
                if (asioid == o.AsioID)
                {
                    lippu = true;
                    break;
                }
            }
            if (lippu)
            {
                Console.WriteLine("AsioID {0} on jo käytössä", asioid);
            }
            else
            {
                Console.Write("Anna uuden opiskelija etunimi: ");
                string etunimi = Console.ReadLine();
                Console.Write("Anna uuden opiskelija sukunimi: ");
                string sukunimi = Console.ReadLine();
                Console.Write("Anna uuden opiskelija ryhmä: ");
                string ryhma = Console.ReadLine();
                //Luodaan uusi opiskelija olio
                Opiskelija uusi = new Opiskelija(etunimi, sukunimi, ryhma);
                opiskelijat.Add(uusi);
                Console.WriteLine("MiniASIOn kaikki opiskelijat: ");
                foreach (var o in opiskelijat)
                {
                    Console.WriteLine(o.ToString());
                }
            }
        }


        static void Main(string[] args)
        {
            Testaa();
        }
    }
}
