using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void work(string[] args)
        {            
            Employee employee = new Employee();
            employee.FirstName = "Esa";
            employee.LastName = "Nahka";
            employee.Profession = "Sweeper";
            employee.Salary = 1200;            
            Console.WriteLine(employee.ToString());
                       
            Boss boss = new Boss();
            boss.FirstName = "Tero";
            boss.LastName = "Nuppi";
            boss.Profession = "Yeller";
            boss.Salary = 10000;
            boss.Car = "Mercedes-Benz";
            boss.Bonus = 1000000;            
            Console.WriteLine(boss.ToString());     
          
        }

        static void Mmain(string[] args)
        {
            Bike bike = new Bike();
            bike.Name = "Harley Davidson";
            bike.Model = "Roamer";
            bike.Modelyear = 1999;
            bike.Color = "Grey";
            bike.Gears = true;
            bike.Gearname = "Matslock";
            Console.WriteLine(bike.ToString());

            Bike bike2 = new Bike("Kawasaki", "Ninja",2001,"Green");
            Console.WriteLine(bike2.ToString());

            Boat boat = new Boat();
            boat.Name = "";
            boat.Model = "";
            boat.Modelyear = 1988;
            boat.Color = "";
            boat.Seats = 3;
            boat.BoatType = "";
            Console.WriteLine(boat.ToString());

           

        }

        static void Msain(string[] args)
        {
            
            T6 radio = new T6();

            while (true)
            {
                Console.Write("Aseta Radio päälle antamalla 1 : ");
                if (radio.Käynnistys(int.Parse(Console.ReadLine())))
                {
                    Console.WriteLine("Radio on päällä");
                    Console.Write("Säädä volumea väliltä (0-9): ");
                    if (radio.Säädävolumea(int.Parse(Console.ReadLine())))
                    {
                        Console.WriteLine("Volume on: " + radio.volume);
                    }
                    else
                    {
                        Console.WriteLine("Arvo ei kelvannut..");
                        Console.WriteLine("Volume: " + radio.volume);
                    }
                    Console.Write("Anna taajuus väliltä 2000.0-26000.0: ");
                    if (radio.Säädätaajuus(Convert.ToDouble(Console.ReadLine())))
                    {
                        Console.WriteLine("Taajuus on nyt: " + radio.tune);
                    }
                    else
                    {
                        Console.WriteLine("Taajuus ei ole valittavissa.");
                        Console.WriteLine("Taajuus: " + radio.tune);
                    }
                }
                else
                {
                    Console.WriteLine("Radio on sammutettu.");
                }
            }
        }

        static void Masin(string[] args)
        {
            
            DVD levy = new DVD("Dokumentti", "Ihmeellinen maailma", 129, "Jack Black");
            Book kirja = new Book("Kauhu", "Harri potteri", 787, "Wk. Rowling");

           

            Console.WriteLine(levy.ToString());
            Console.WriteLine(kirja.ToString());
        }

        static void Main(string[] args)
        {

            NHL capitals = new NHL("Washington Capitals",6, 3, 3, 9);
            Liiga saipa = new Liiga("Saipa", 8, 2, 6, 6);



            Console.WriteLine(capitals.ToString());
            Console.WriteLine(saipa.ToString());
        }
    }

}
