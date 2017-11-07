using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    public struct Ohjastaja
    {
        public string Nimi;
        public int Startit;
        public int Voitot;
        public float VoittoPros;
    }
    class Program
    {
        static void LueOhjastajatVer1()
        {
            try
            {
                int counter = 0;
                string line;
                System.IO.StreamReader stream = new System.IO.StreamReader(@"D:\tilasto2017.txt");
                while ((line = stream.ReadLine()) != null)
                {
                    Console.WriteLine(counter + ":" + line);
                    counter++;
                }
                stream.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        static void LueOhjastajatVer2()
        {
            try
            {
                string erotin = ";";
                string[] rivit = System.IO.File.ReadAllLines(@"D:\tilasto2017.csv");
                Ohjastaja kuski;
                int lkm = rivit.Length;
                Console.WriteLine("Ohjastajia yhteensä {0}", lkm - 1);
                for (int i = 1; i < lkm; i++)
                {
                    string[] sanat = rivit[i].Split(erotin.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    if (int.TryParse(sanat[2], out int apu))
                    {                    
                    kuski.Nimi = sanat[0] + " " + sanat[1];
                    kuski.Startit = int.Parse(sanat[2]);
                    kuski.Voitot = int.Parse(sanat[3]);
                    kuski.VoittoPros = (100F * kuski.Voitot / kuski.Startit);
                    
                    }
                    else
                    {
                        kuski.Nimi = sanat[0] + " " + sanat[1] + " " + sanat[2];
                        kuski.Startit = int.Parse(sanat[3]);
                        kuski.Voitot = int.Parse(sanat[4]);
                        kuski.VoittoPros = (100F * kuski.Voitot / kuski.Startit);
                        
                    }
                    Console.WriteLine("{0}: {1} Startit:{2} Voitot:{3} Voittoprosentti:{4}", i, kuski.Nimi, kuski.Startit, kuski.Voitot, kuski.VoittoPros);
                }
                Console.WriteLine("Siinäpä kaikki pojat!");
            }
            catch (Exception)
            {

                throw;
            }
        }
        static void Dice()
        {
            Dice noppa = new Dice();
            Console.Write("Monesti haluat heittää? ");
            int amount = int.Parse(Console.ReadLine());
            noppa.Throw(amount);
            Console.WriteLine("Noppa heitettiin {0} kertaa. ", amount);
            Console.WriteLine("Lukujen keskiarvo: " + noppa.Throws.Average());
            for (int x = 1; x < 7; x++)
            {
                int count = 0;
                foreach (int i in noppa.Throws)
                {
                    if (i == x)
                    {
                        count++;
                    }
                }
                Console.WriteLine("{0} numero tuli: {1} kertaa.", x, count);
            }
        }
        static void ShoppingCart()
        {
            List<Shoppingcart> Shoppingcart = new List<Shoppingcart>();
            Shoppingcart.Add(new Shoppingcart("Maito", 1.4));
            Shoppingcart.Add(new Shoppingcart("Kalja", 0.8));
            Shoppingcart.Add(new Shoppingcart("Viina", 2.5));
            Console.WriteLine("Kaikki tuotteet kasattuna: ");
            foreach (Shoppingcart p in Shoppingcart)
            {
                Console.WriteLine("-tuote: {0} {1}e", p.Name, p.Price);
            }
        }
        static void Fish()
        {         
                List<Fisher> Registry = new List<Fisher>();
                Registry.Add(new Fisher("Kali Killi", "0700123123"));
                Registry.Add(new Fisher("Manu Valla", "0700123123"));
                Registry[0].Catch.Add(new Fish("Ahven", 200, 50, "Jyväsjärvi"));
                Registry[0].Catch.Add(new Fish("Siika", 1000, 5000, "Perävesi"));
                Registry[1].Catch.Add(new Fish("Monni", 100, 5, "Lampi"));
                Registry[1].Catch.Add(new Fish("Saapas", 1000, 500, "Puro"));
                foreach (Fisher f in Registry)
                {
                    Console.WriteLine("Kalastaja: {0} Puhelinnumero: {1}", f.Name, f.PhoneNumber);
                    f.Catch.Sort((x, y) => y.Weight.CompareTo(x.Weight));
                    foreach (Fish r in f.Catch)
                    {
                        Console.WriteLine("-Laji: {0}\n-Pituus(cm): {1}\n-Paino(kg): {2}\n-Sijainti: {3}", r.Species, r.Length, r.Weight, r.Location);
                    }
                }
            
         

        }
        static void Shapes()
        {
           
            
                List<Shapes> shape = new List<Shapes>();
                shape.Add(new Circle(1));
                shape.Add(new Circle(2));
                shape.Add(new Circle(3));
                shape.Add(new Rectangle(10, 20));
                shape.Add(new Rectangle(20, 30));
                shape.Add(new Rectangle(40, 50));
                foreach (var t in shape)
                {
                    Console.WriteLine(t);
                }
            
            

        }
        static void Arraycalcs()
        {
            try
            {
                double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
                Console.WriteLine("Sum = {0:00.00}", ArrayCalcs.Sum(array));
                Console.WriteLine("Avg = {0:00.00}", ArrayCalcs.Average(array));
                Console.WriteLine("Min = {0:00.00}", ArrayCalcs.Min(array));
                Console.WriteLine("Max = {0:00.00}", ArrayCalcs.Max(array));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Main(string[] args)
        {
            //Dice();
            //ShoppingCart();
            //Fish();
            //Shapes();
            Arraycalcs();
        }
        
    }
}

