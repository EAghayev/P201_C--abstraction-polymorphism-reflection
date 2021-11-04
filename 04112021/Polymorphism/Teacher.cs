using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Teacher:Human,IPersonable
    {
        public Teacher(string name,string surname,byte age):base(name,surname,age)
        {
            ExperienceYear = 1;
        }
        public byte ExperienceYear;

        public override void ShowInfo()
        {
            Console.WriteLine($"FullName: {Name} {Surname} - Age: {Age} - Year: {ExperienceYear}");

        }

        public string GetData()
        {
            return $"FullName: {Name} {Surname} - Age: {Age} - Year: {ExperienceYear}";       
        }
    }
}
