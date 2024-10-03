using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    public class Vehicle
    {
        //fields
        //properties
        //contructors
        //destructors
        //methods
        //indexers

        //--> field

        //private
        string model;
        string make;
        int year;
        double fuelLevel;

        //contsructor
        //where to use this Keyword
        public Vehicle(string make,string model,int year)
        {
            this.model = model;
            this.make = make;
            this.year = year;
            fuelLevel = 100;
        }
        public void Drive(double distance)
        {
            double fuelconsumed = distance * 0.05;// consumes 5% per 100km
            if (fuelconsumed <= fuelLevel)
            {
                fuelLevel= fuelLevel-fuelconsumed;
                Console.WriteLine($"you drove {distance} km. Fuel level is now {fuelLevel}% .");
            }
            else
            {
                Console.WriteLine("not enough fuel to drive the distance");
            }

        }
        //Method : to refuel vechicle

        public void Refuel(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount to refuel must be greater than 0");
                return;
            }
            if (fuelLevel + amount > 100)
            {
                fuelLevel = 100;
                Console.WriteLine("Fuel tank is now full");
            }
            else
            {
                fuelLevel = fuelLevel + amount;
                Console.WriteLine($"Added {amount}% fueel. Fuel level is now {fuelLevel}% .");
            }
        }
        //Method : to display the information
        public void DisplayInfo()
        {
            Console.WriteLine($"Vehicle Info : {year} {make} {model} , Fuel Level: {fuelLevel}% ");
        }
    }
    internal class Class5
    {
        public static void Main5()
        {
            Vehicle car = new Vehicle("Toyoto","Inova",2020);
            car.DisplayInfo();
            car.Drive(100);
            car.Drive(500);
            car.Refuel(30);
            car.DisplayInfo();

        }
    }
}
