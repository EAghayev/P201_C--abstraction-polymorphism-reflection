using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Student : Human, IPersonable
    {
        public Student(string name, string surname, byte age, string groupNo) : base(name, surname, age)
        {
            GroupNo = groupNo;
        }
        public string GroupNo;


        public override void ShowInfo()
        {
            Console.WriteLine($"FullName: {Name} {Surname} - Age: {Age} - GroupNo: {GroupNo}");
        }

        public string GetData()
        {
            return $"FullName: {Name} {Surname} - Age: {Age} - GroupNo: {GroupNo}";
        }
    }
}
