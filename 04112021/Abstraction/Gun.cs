using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    abstract class Gun
    {
        public int UseageLimit;
        public string Country;
        public double Price;

        public abstract string GetInfo();
    }
}
