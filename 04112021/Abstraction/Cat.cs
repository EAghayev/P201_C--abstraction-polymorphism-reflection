using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Cat:Animal
    {
        private string _gender;
        public override string Gender
        {
            get => _gender;
            set => _gender = value;
        }
        public override void MakeSound()
        {
            Console.WriteLine("meow meow");
        }
    }
}
