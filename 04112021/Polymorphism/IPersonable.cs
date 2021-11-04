using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    interface IPersonable
    {
        string GetData();
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }
}
