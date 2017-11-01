using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            T1();
            T2();
            T3();
            T4();
        }
        static void T1()
        {
            string nimi;
            string mydocpath = @"D:\K9005\Visualstudio\Texts\";
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(mydocpath + @"\testi.txt");
            do
            {
                Console.WriteLine("Anna tallennettavat nimet: ");
                nimi = Console.ReadLine();
                outputFile.WriteLine(nimi);
            } while (nimi.Length != 0);
            outputFile.Close();

            try
            {
                string text = System.IO.File.ReadAllText(mydocpath + @"\testi.txt");
                System.Console.WriteLine("testi.txt filun tiedot:\n" + text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
        static void T2()
        {
            try
            {
                int a = 0;
                string polku = @"C:\Users\Olympos\Documents\Olio\names.txt";
                if (!File.Exists(polku))
                {

                    var nameCount = new SortedDictionary<string, int>();

                    foreach (String s in File.ReadAllLines(@"C:\Users\Olympos\Documents\Olio\names.txt"))
                    {
                        if (nameCount.ContainsKey(s))
                        {
                            nameCount[s] = nameCount[s] + 1;
                            a++;
                        }
                        else
                        {
                            nameCount.Add(s, 1);
                            a++;
                        }
                    }

                    // and printing
                    Console.WriteLine("Sisälsi {0} riviä ja {1} nimeä.", a, nameCount.Count);
                    foreach (var pair in nameCount)
                    {
                        Console.WriteLine("{0} count:{1}", pair.Key, pair.Value);
                    }
                }
                else
                {
                    Console.WriteLine("Tiedosto on jo olemassa");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }

        }
        static void T3()
        {
            try
            {
                string numero;
                string mydocpath = @"C:\Users\Olympos\Documents\Olio";
                System.IO.StreamWriter outputFile = new System.IO.StreamWriter(mydocpath + @"\integers.txt");
                System.IO.StreamWriter outputFile2 = new System.IO.StreamWriter(mydocpath + @"\doubles.txt");
                do
                {
                    int integer;
                    double duble;
                    Console.WriteLine("Anna tallennettavia numeroita(lopetus nollalla): ");
                    numero = Console.ReadLine();
                    if (int.TryParse(numero, out integer))
                    {
                        outputFile.WriteLine(numero);
                    }
                    else if (double.TryParse(numero, out duble))
                    {
                        outputFile2.WriteLine(numero);
                    }
                    else
                    {
                        Console.WriteLine("Syötä numeroita.");
                    }

                } while (numero.Length != 0);
                outputFile.Close();
                outputFile2.Close();
                string text = System.IO.File.ReadAllText(mydocpath + @"\integers.txt");
                System.Console.WriteLine("Integers:\n" + text);
                string text2 = System.IO.File.ReadAllText(mydocpath + @"\doubles.txt");
                System.Console.WriteLine("Doubles:\n" + text2);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
        static void T4()
        {
            string mydocpath = @"C:\Users\Olympos\Documents\Olio";
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(mydocpath + @"\series.txt");

            outputFile.WriteLine(new Tvshows("Midsomerin murhat", "Tv2", "Tiistai klo 19.15", "Kertoo murhatutkijan tutkimuksista"));
            outputFile.WriteLine(new Tvshows("Posse", "Mtv3", "Lauantai 20.00", "Perheen hupiohjelma"));
            outputFile.WriteLine(new Tvshows("Kymppiuutiset", "Mtv3", "Joka päivä 22.00", "Uutisia"));
            outputFile.WriteLine(new Tvshows("Napakymppi", "Mtv3", "- klo 20.00", "Parin etsintä ohjelma"));
            outputFile.Close();

            string text = System.IO.File.ReadAllText(mydocpath + @"\series.txt");
            System.Console.WriteLine("Tv ohjelmien luettelo:\n" + text);
        }
    }
}
