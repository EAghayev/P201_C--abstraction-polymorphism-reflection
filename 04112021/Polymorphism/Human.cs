using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Human
    {
        public Human(string name,string surname,byte age)
        {
            Age = age;
            Name = name;
            Surname = surname;
        }
        public byte Age;
        public string Name;
        public string Surname;

        public virtual void ShowInfo()
        {
            Console.WriteLine($"FullName: {Name} {Surname} - Age: {Age}");
        }
    }
}
