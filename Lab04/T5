using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Modelyear { get; set; }
        public String Color { get; set; }
                
        public Vehicle()
        {
        }

        
        public Vehicle(string name, string model, int modelyear, String color)
        {
            Name = name;
            Model = model;
            Modelyear = modelyear;
            Color = color;
        }
        
        public override string ToString()
        {
            return "Name: "+ Name + " Model: " + Model + " Model year: " + Modelyear + " Color: " + Color;
        }
    }
    
    class Bike : Vehicle
    {
        public bool Gears { get; set; }
        public string Gearname { get; set; }
               
        public Bike()
        {
        }
                
        public Bike(string name, string model, int modelyear, string color, bool gears, string gearname)
            : base(name, model, modelyear, color)
        {
            Gears = gears;
            Gearname = gearname;
        }                 
                       
        public override string ToString()
        {
            return base.ToString() + " Gears: " + Gears + "Gear name: " + Gearname;
        }
    }
    
     class Boat : Vehicle
    {
        public int Seats { get; set; }
        public string BoatType { get; set; }
               
        public Boat()
        {
        }
                
        public Boat(string name, string model, int modelyear, string color, int seats, string boatType)
            : base(name, model, modelyear, color)
        {
            Seats = seats;
            BoatType = boatType;
        }                 
                       
        public override string ToString()
        {
            return base.ToString() + " Seats: " + Seats + " BoatType: " + BoatType;
        }
    }
}
