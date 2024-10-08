using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    //Interface Demo

    /// <summary>
    /// Interface declartion
    /// </summary>
    interface IVehicle
    {
        void changeGear(int a);
        void speedUp(int a);
        void applyBrakes(int a);
    }
    class Bicycle : IVehicle
    {
        int speed;
        int gear;
        public void applyBrakes(int decrement)
        {
            speed = speed - decrement;
        }

        public void changeGear(int newGear)
        {
            gear = newGear;
        }

        public void speedUp(int increment)
        {
            speed = speed + increment;
        }
        public void printStates()
        {
            Console.WriteLine($"Speed : {speed} Gear: {gear}");
        }
    }
    class Bike : IVehicle
    {
        int speed;
        int gear;
        public void applyBrakes(int decrement)
        {
            speed = speed - decrement;
        }

        public void changeGear(int newGear)
        {
            gear = newGear;
        }

        public void speedUp(int increment)
        {
            speed = speed + increment;
        }
        public void printStates()
        {
            Console.WriteLine($"Speed : {speed} Gear: {gear}");
        }
    }
    internal class Class1
    {
        public static void Main1()
        {

            Bicycle bicycle = new Bicycle();
            bicycle.changeGear(2);
            bicycle.speedUp(3);
            bicycle.applyBrakes(1);
            Console.WriteLine("Bicycle present state :");
            bicycle.printStates();


            Bike bike = new Bike();
            bike.changeGear(1);
            bike.speedUp(4);
            bike.applyBrakes(3);
            Console.WriteLine("Bike present state :");
            bike.printStates();
        }
    }
}
