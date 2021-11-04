using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Akif","Ismayilov",45);
            human.ShowInfo();

            Student student = new Student("Israfil", "Memmedov", 40, "P201");
            student.ShowInfo();

            Human human1 = student;
            human1.ShowInfo();

            Teacher teacher = new Teacher("Tukezban", "Memmedova", 52);
            teacher.ExperienceYear = 5;

            teacher.ShowInfo();

            Human human2 = teacher;
            human2.ShowInfo();

            //IPersonable person = new Student("Huseyn", "Ahmedov", 19, "P201");
            IPersonable person= teacher;
            person.SayHello();
            Console.WriteLine(person.GetData());


        }
    }
}
