using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
     abstract class Animal
     {
        public byte Age;
        public abstract string Gender { get; set; }
        public abstract void MakeSound();
     }
}
