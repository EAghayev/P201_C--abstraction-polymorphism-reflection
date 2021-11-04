using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Makarov : Gun, IWeapon,IGun
    {
        public int Capacity { get; set; }

        public void Fire()
        {
            if (Capacity > 0) Capacity -= 1;
        }

        public override string GetInfo()
        {
            return $"{this.Country}";
        }

        public void Use()
        {
            if (UseageLimit > 0)
            {
                Fire();
                UseageLimit -= 1;
            }
        }
    }
}
