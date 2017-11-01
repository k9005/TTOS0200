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
        static void Main(string[] args)
        {
            try
            {
                LueOhjastajatVer2();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
        
    }
}

