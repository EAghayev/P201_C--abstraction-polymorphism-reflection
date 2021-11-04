using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    interface IGun
    {
        int Capacity { get; set; }
        void Fire();
    }
}
