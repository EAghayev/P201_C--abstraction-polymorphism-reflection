using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Scarel : IGun
    {
        public int Capacity { get; set; }

        public void Fire()
        {
            this.Capacity -= 2;
        }
    }
}
