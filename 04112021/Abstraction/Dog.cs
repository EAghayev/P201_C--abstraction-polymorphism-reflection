using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Dog : Animal
    {

        private string _gender;
        public override string Gender
        { 
            get => _gender;
            set => _gender=value;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Hav hav");
        }
    }

    class OwneredDog:Dog
    {
        public string OwnerFullName;
        public override void MakeSound()
        {
            Console.WriteLine("hau hau");
        }
    }
}
