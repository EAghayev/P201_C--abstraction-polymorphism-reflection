using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Age = 45;
            Cat cat = new Cat();
            OwneredDog owneredDog = new OwneredDog();

            Ak47 ak47 = new Ak47();

            dog.MakeSound();
            cat.MakeSound();
            owneredDog.MakeSound();
        }
    }
}
