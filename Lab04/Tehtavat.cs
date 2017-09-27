using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }
                
        public Employee()
        {
        }

        
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        
        public override string ToString()
        {
            return "Name: "+ FirstName + " " + LastName + " Profession: " + Profession + " Salary: " + Salary+ "$" ;
        }
    }
    class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }
               
        public Boss()
        {
        }
                
        public Boss(string firstName, string lastName, string car)
            : base(firstName, lastName)
        {
            Car = car;
        }                 
                       
        public override string ToString()
        {
            return base.ToString() + " Car: " + Car + "Bonus: " + Bonus+ "$";
        }
    }
}
