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

        static void Main(string[] args)
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
    }
}
