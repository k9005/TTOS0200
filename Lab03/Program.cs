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
            Testaapvm();
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
            Console.WriteLine(DateTime.MinValue);
        }
    }
}
