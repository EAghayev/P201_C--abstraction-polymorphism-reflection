using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Ak47 : Gun, IGun,IWeapon
    {
        public int Capacity { get; set; }

        public void Fire()
        {
            this.Capacity -= 1;
        }

        public void Use()
        {
            if (this.UseageLimit > 0)
            {
                this.UseageLimit -= 1;
                Fire();
            }
        }
        public override string GetInfo()
        {
            return $"{this.Country} {this.Capacity}";
        }

    }
}
