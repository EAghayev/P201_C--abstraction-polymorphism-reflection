using System;
using System.Reflection;

namespace _04112021
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var humanType = typeof(Human);

            Human human1 = new Human("12345678")
            {
                Name = "Akif"
            };

            foreach (var type in assembly.GetTypes())
            {
                Console.WriteLine(type.Name);

                if(type == humanType)
                {
                    Console.WriteLine("properties:");
                    foreach (var prop in type.GetProperties())
                    {
                        Console.WriteLine($"\t {prop.Name} - {prop.GetValue(human1)}");
                    }

                    Console.WriteLine("fields:");
                    foreach (var field in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public))
                    {
                        if(field.Name == "_PIN")  field.SetValue(human1, "12345ABC");

                        Console.WriteLine($"\t {field.Name} - {field.GetValue(human1)}");
                    }
                }
            }
        }
    }
}
