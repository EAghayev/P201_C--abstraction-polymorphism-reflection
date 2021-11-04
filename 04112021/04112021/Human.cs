using System;
using System.Collections.Generic;
using System.Text;

namespace _04112021
{
    class Human
    {
        public Human(string pin)
        {
            _PIN = pin;
        }
        private string _PIN;
        private string _name;
        public string Gender;
        public string Name {
            get => _name;
            set
            {
                if (value != null) _name = value;
            }
        }
        public string Surname { get; set; }
        public byte Age { get; set; }
    }
}
