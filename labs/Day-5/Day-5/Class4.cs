using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }

    }
    public class Mamal : Animal
    {
        public void Run()
        {
            Console.WriteLine("Mammel is running");
        }

    }
    internal class Class4
    {
        public static void Main4()
        {
            Dog dog=new Dog();
            dog.Eat();
            dog.Bark();

            Mamal m=new Mamal();
            m.Eat();
            m.Run();
        }
    }
}
