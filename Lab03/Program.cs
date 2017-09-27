using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testaaluku();
            //Testaapvm();
            //Hissiconsole();
            Volumeconsole();
        }
        static void Testaaluku()
        {
            Console.Write("Anna joku luku: ");
            string luku = Console.ReadLine();
            T1.Onkoluku(luku);
            Console.WriteLine(T1.Onkoluku(luku));
           
        }
        static void Testaapvm()
        {
            Console.Write("Anna paivamaara: ");
            string luku = Console.ReadLine();
            T1.Onkopvm(luku);
            Console.WriteLine(T1.Onkopvm(luku));
            
        }
        static void Hissiconsole()
       {
            T2 hissi = new T2();

            while (true)
            {
                Console.Write("Mihin kerrokseen haluat mennä? ");
                hissi.Kerros = int.Parse(Console.ReadLine());
                Console.WriteLine("olet kerroksessa: " + hissi.Kerros);
            }
        }
        static void Volumeconsole()
        {
            T3 kajari = new T3();

            while (true)
            {
                Console.Write("Säädä volume haluaamasi kovuudelle: ");
                kajari.Volume = int.Parse(Console.ReadLine());
                Console.WriteLine("Volume on nyt: " + kajari.Volume);
            }
        }
    }
    
}
