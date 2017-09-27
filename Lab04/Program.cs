using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {            
            Employee employee = new Employee();
            employee.FirstName = "Esa";
            employee.LastName = "Nahka";
            employee.Salary = 1200;            
            Console.WriteLine(employee.ToString());
                       
            Boss boss = new Boss();
            boss.FirstName = "Tero";
            boss.LastName = "Nuppi";
            boss.Salary = 10000;
            boss.Car = "Mercedes-Benz";
            boss.Bonus = 1000000;            
            Console.WriteLine(boss.ToString());

            
            
            
            
        }
    }
}
